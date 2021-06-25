using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace lab2_BTVN.Models
{
    public class Book
    {
        private int id;
        private string title;
        private string author;
        private string image_cover;
        private string description;
        private int? price;

        public Book()
        {
        }

        public Book(int id, string author, string title, string description, string image_cover, int? price)
        {
            this.id = id;
            this.author = author;
            this.title = title;
            this.description = description;
            this.image_cover = image_cover;
            this.price = price;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        [Required(ErrorMessage = "Tiêu đề không được để trống")]
        [StringLength(100, ErrorMessage = "Tiêu đề không được vượt quá 100 ký tự")]
        //[Display(Name = "Tiêu đề")]
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        [Required(ErrorMessage = "Tên tác giả không được để trống")]
        [StringLength(30, ErrorMessage = "Tên tác giả không được vượt quá 30 ký tự")]
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        
        public string ImageCover
        {
            get { return image_cover; }
            set { image_cover = value; }
        }
        //[DataType(DataType.MultilineText)]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        [Required(ErrorMessage = "Giá không được để trống")]
        public int? Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}