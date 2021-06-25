using lab2_BTVN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab2_BTVN.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult ListBookModel()
        {
            var books = new List<Book>();
            books.Add(new Book(1, "Nguyen Trung But", "Đời ngắn đừng ngủ dài", "Sách hay vc", "/Content/Images/1.jpg", 50000));
            books.Add(new Book(2, "Nguyen Trung Book", "Điểm bùng phát", "Sách hay vc", "/Content/Images/2.jpg", 20000));
            books.Add(new Book(3, "Nguyễn Trung Bút", "Đắc Nhân Tâm", "Sách hay vc", "/Content/Images/3.jpg", 70000));

            return View(books);
        }

        public ActionResult EditBook(int id)
        {
            var books = new List<Book>();
            books.Add(new Book(1, "Nguyen Trung But", "Đời ngắn đừng ngủ dài", "Sách hay vc", "/Content/Images/1.jpg", 50000));
            books.Add(new Book(2, "Nguyen Trung Book", "Điểm bùng phát", "Sách hay vc", "/Content/Images/2.jpg", 20000));
            books.Add(new Book(3, "Nguyễn Trung Bút", "Đắc Nhân Tâm", "Sách hay vc", "/Content/Images/3.jpg", 70000));
            Book book = new Book();
            foreach (Book b in books)
            {
                if (b.Id == id)
                {
                    book = b;
                    break;
                }
            }
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        [HttpPost, ActionName("EditBook")]
        [ValidateAntiForgeryToken]

        public ActionResult EditBook(int id, string Title, string Author, string ImageCover, string Description, int Price)
        {
            var books = new List<Book>();
            books.Add(new Book(1, "Nguyen Trung But", "Đời ngắn đừng ngủ dài", "Sách hay vc", "/Content/Images/1.jpg", 50000));
            books.Add(new Book(2, "Nguyen Trung Book", "Điểm bùng phát", "Sách hay vc", "/Content/Images/2.jpg", 20000));
            books.Add(new Book(3, "Nguyễn Trung Bút", "Đắc Nhân Tâm", "Sách hay vc", "/Content/Images/3.jpg", 70000));
            if (id == null)
            {
                return HttpNotFound();
            }
            foreach (Book b in books)
            {
                if (b.Id == id)
                {
                    b.Title = Title;
                    b.Author = Author;
                    b.ImageCover = ImageCover;
                    b.Description = Description;
                    b.Price = Price;
                    break;
                }
            }
            return View("ListBookModel", books);
        }
        public ActionResult CreateBook()
        {
            return View();
        }

        [HttpPost, ActionName("CreateBook")]
        [ValidateAntiForgeryToken]

        public ActionResult Contact([Bind(Include = "Id, Author, Title, Description, ImageCover, Price")] Book book)
        {
            
            var books = new List<Book>();
            books.Add(new Book(1, "Nguyen Trung But", "Đời ngắn đừng ngủ dài", "Sách hay vc", "/Content/Images/1.jpg", 50000));
            books.Add(new Book(2, "Nguyen Trung Book", "Điểm bùng phát", "Sách hay vc", "/Content/Images/2.jpg", 20000));
            books.Add(new Book(3, "Nguyễn Trung Bút", "Đắc Nhân Tâm", "Sách hay vc", "/Content/Images/3.jpg", 70000));
           try
            {
                if (ModelState.IsValid)
                {
                    books.Add(book);
                }
            }
            catch
            {
                ModelState.AddModelError("", "Error Save Data");
            }
            return View("ListBookModel", books);
        }

        public ActionResult DeleteBook(int id)
       {
           var books = new List<Book>();
           books.Add(new Book(1, "Nguyen Trung But", "Đời ngắn đừng ngủ dài", "Sách hay vc", "/Content/Images/1.jpg", 50000));
           books.Add(new Book(2, "Nguyen Trung Book", "Điểm bùng phát", "Sách hay vc", "/Content/Images/2.jpg", 20000));
           books.Add(new Book(3, "Nguyễn Trung Bút", "Đắc Nhân Tâm", "Sách hay vc", "/Content/Images/3.jpg", 70000));
           Book book = new Book();
           foreach (Book b in books)
           {
               if (b.Id == id)
               {
                   book = b;
                   break;
               }
           }
           if (book == null)
           {
              return HttpNotFound();
           }
           return View(book);
       }

        [HttpPost, ActionName("DeleteBook")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteBook(int id, string Title, string Author, string ImageCover, string Description, int? Price)
        {

            var books = new List<Book>();
            books.Add(new Book(1, "Nguyen Trung But", "Đời ngắn đừng ngủ dài", "Sách hay vc", "/Content/Images/1.jpg", 50000));
            books.Add(new Book(2, "Nguyen Trung Book", "Điểm bùng phát", "Sách hay vc", "/Content/Images/2.jpg", 20000));
            books.Add(new Book(3, "Nguyễn Trung Bút", "Đắc Nhân Tâm", "Sách hay vc", "/Content/Images/3.jpg", 70000));
            if (id == null)
            {
                return HttpNotFound();
            }
            foreach (Book b in books)
            {
                if (b.Id == id)
                {
                    books.Remove(b);
                    break;
                }
            }
            return View("ListBookModel", books);
        }
        
       
    }
}