﻿using System;
/*
Создать класс, представляющий учебный класс ClassRoom. 
Создайте класс ученик Pupil. В теле класса создайте методы void Study(), void Read(), void
Write(), void Relax(). 
Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от класса базового класса 
Pupil и переопределите каждый из методов, в зависимости от успеваемости ученика. 
Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников. 
Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента. 
Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать, 
писать, отдыхать.*/
namespace Les3OOPHW
{
    internal class Student
    {
        public virtual void Study()
        {
            Console.WriteLine();
        }
        public virtual void Read()
        {
            Console.WriteLine();
        }
        public virtual void Write()
        {
            Console.WriteLine();
        }
        public virtual void Relax()
        {
            Console.WriteLine();
        }


    }
}
