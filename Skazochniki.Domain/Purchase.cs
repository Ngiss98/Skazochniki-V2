using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Skazochniki.Models
{
    public class Purchase
    {
        // конструктор начало //
        protected Purchase()
        {

        }

        public Purchase(int purchaseId, int courseId, string fio, string email, Boolean payed, DateTime dateTime)
        {
            Id = purchaseId;
            CourseId = courseId;
            FIO = fio;
            Email = email;
            Payed = payed;
            DateTime = dateTime;
        }
        // конструктор конец //

        // Описание покупки начало //
        public int Id { get; protected set; }

        public int CourseId { get; protected set; }

        public string FIO { get; protected set; }

        public string Email { get; protected set; }

        public Boolean Payed { get; protected set; }

        public DateTime DateTime { get; protected set; }
        // Описание покупки конец //

        // Функционал класса начало //
        public void UpdatePurchase(int courseId, string fio, string email, Boolean payed)
        {
            CourseId = courseId;
            FIO = fio;
            Email = email;
            Payed = payed;
        }
        // Функционал класса конец //
    }
}