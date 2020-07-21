using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RealSurfLab.Models.DBModels
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        ///<summary>
        ///Текст
        ///</summary>
        [Display(Name = "Введите текст"), MaxLength(4095)]
        public string Text { get; set; }
        ///<summary>
        ///Дата публикации
        ///</summary>
        public DateTime PublishDate { get; set; }
        ///<summary>
        ///Изображение
        ///</summary>
        [Display(Name = "Прикрепить изображение")]
        public Guid Photo { get; set; }
        ///<summary>
        ///Фото
        ///</summary>
        public virtual User Author { get; set; }


    }
}