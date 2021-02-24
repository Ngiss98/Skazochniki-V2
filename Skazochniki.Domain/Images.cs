using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Skazochniki.Models
{
    public class Images
    {
        // конструктор начало //
        protected Images()
        {

        }

        public Images(int imgId, string img_path)
        {
            Id = imgId;
            Img_path = img_path;
        }
        // конструктор конец //

        // Описание картинки начало //
        public int Id { get; protected set; }

        public string Img_path { get; protected set; }
        // Описание картинки конец //

        // Функционал класса начало //
        public void UpdateImages(string img_path)
        {
            Img_path = img_path;
        }
        // Функционал класса конец //

    }
}