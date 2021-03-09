using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Skazochniki.Models
{
    public class Course
    {
        // конструктор начало //
        protected Course()
        {
        }

        public Course(int id, string name, int price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
        // конструктор конец //

        // Описание курса начало //
        public int Id { get; protected set; }

        public string Name { get; protected set; }
        
        public int Price { get; protected set; }
        // Описание курса конец //

        // Функционал класса начало //
        public void CreateCourse(int price, string name)
        {
            Price = price;
            Name = name;
        }

        public void UpdateCourse(int price, string name)
        {
            Price = price;
            Name = name;
        }
        // Функционал класса конец //
    }
}