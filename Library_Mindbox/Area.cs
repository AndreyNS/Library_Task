using System;
using System.Collections.Generic;

namespace Library_Mindbox
{
    public abstract class Figure
    {
        public abstract void Area();
    }

    public class Circle : Figure
    {
        public double Radius { get; set; }
        public Circle(double rad)
        {

            Radius = rad;
        }

        public override void Area() => Console.WriteLine(Math.PI * Radius);
    }

    public class Triangle : Figure
    {
        public double p { get; set; }
        public double S { get; set; }

        public string TriangleType { get; set; }

        public Triangle(double a, double b, double c)
        {
            double a2 = Math.Pow(a, 2);
            double b2 = Math.Pow(b, 2);
            double c2 = Math.Pow(c, 2);

            if ((a2 + b2) == c2 || (a2 + c2) == b2 || (b2 + c2) == a2)
            {
                TriangleType = "Прямоугольный";
            }
            else if (a == b && b == c)
            {
                TriangleType = "Равносторонний";
            }
            else if (a == b || a == c || b == c)
            {
                TriangleType = "Равнобедренный";
            }
            else TriangleType = "Обычный";

            p = (a + b + c) / 2;

            S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public override void Area() => Console.WriteLine($"{TriangleType} S={S}");
    }
}

//ОТВЕТ

//SELECT P.name_pro AS 'Имя продукта', C.name_cat AS 'Имя категории'
//FROM Product AS P
//LEFT JOIN Category_Product AS CP ON P.ID = CP.ID_pro
//LEFT JOIN Category AS C ON CP.ID_cat = C.ID



//Создание таблиц и данных, на которых проводилась проверка

//CREATE TABLE Category (
//    ID INT PRIMARY KEY IDENTITY(1,1),
//    name_cat NVARCHAR(255) NOT NULL
//);

//CREATE TABLE Product (
//    ID INT PRIMARY KEY IDENTITY(1,1),
//    name_pro NVARCHAR(255) NOT NULL
//);

//CREATE TABLE Category_Product (
//    ID INT PRIMARY KEY IDENTITY(1,1),
//    ID_pro INT,
//    ID_cat INT,
//    FOREIGN KEY (ID_pro) REFERENCES Product(ID),
//    FOREIGN KEY(ID_cat) REFERENCES Category(ID)
//);


//--INSERT INTO Category(name_cat) VALUES('Электроника');
//--INSERT INTO Category(name_cat) VALUES('Одежда');
//--INSERT INTO Category(name_cat) VALUES('Автомобили');
//--INSERT INTO Category(name_cat) VALUES('Краны');
//--INSERT INTO Category(name_cat) VALUES('Животные');


//--INSERT INTO Product(name_pro) VALUES('Смартфон');
//--INSERT INTO Product(name_pro) VALUES('Ноутбук');
//--INSERT INTO Product(name_pro) VALUES('Футболка');
//--INSERT INTO Product(name_pro) VALUES('Джинсы');
//--INSERT INTO Product(name_pro) VALUES('Седан');
//--INSERT INTO Product(name_pro) VALUES('Внедорожник');
//--INSERT INTO Product(name_pro) VALUES('Трубка');
//--INSERT INTO Product(name_pro) VALUES('Саквояж');


//--INSERT INTO Category_Product(ID_pro, ID_cat) VALUES(1, 1); 
//--INSERT INTO Category_Product (ID_pro, ID_cat) VALUES(2, 1); 
//--INSERT INTO Category_Product (ID_pro, ID_cat) VALUES(3, 2); 
//--INSERT INTO Category_Product (ID_pro, ID_cat) VALUES(4, 2); 
//--INSERT INTO Category_Product (ID_pro, ID_cat) VALUES(5, 3); 
//--INSERT INTO Category_Product (ID_pro, ID_cat) VALUES(6, 3); 
//--INSERT INTO Category_Product (ID_pro, ID_cat) VALUES(7, 3); 
//--INSERT INTO Category_Product (ID_pro, ID_cat) VALUES(7, 4); 
//--INSERT INTO Category_Product (ID_pro, ID_cat) VALUES(8, 5); 


