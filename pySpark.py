from pyspark.sql import SparkSession
from pyspark.sql.functions import explode, collect_list

spark = SparkSession.builder.appName("ProductCategory").getOrCreate()

data = [("Продукт1", ["Категория1", "Категория2"]),
        ("Продукт2", ["Категория2", "Категория3"]),
        ("Продукт3", ["Категория1"]),
        ("Продукт4", []),
        ("Продукт5", ["Категория3"])]

schema = ["Продукт", "Категории"]

df = spark.createDataFrame(data, schema)

df = df.withColumn("Категория", explode(df["Категории"]))

result_df = df.groupBy("Продукт").agg(
    collect_list("Категория").alias("Категории"))

products_with_no_categories = df.filter(
    df["Категория"].isNull()).select("Продукт").distinct()
result_df = result_df.union(products_with_no_categories)

result_df.show()
