using CrudBook.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using CrudBook.Models;
namespace CrudBook.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;
        public IActionResult Index()
        {
            var books = _bookRepository.GetAll();
            return View(books);
        }

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IActionResult Add()
        {
            return View(new Book());
        }

        public IActionResult Display(int Id)
        {
            var book = _bookRepository.GetbyId(Id);
            if (book == null)
            {
                return NotFound("Khong tim thay sach");
            }
            return View(book);
        }
        [HttpPost]
        public async Task<IActionResult> Add(Book book , IFormFile Image)
        {
            if (ModelState.IsValid)
            {
                if (Image != null)
                {
                    book.Image = await SaveImages(Image);
                }
                _bookRepository.Add(book);
                return RedirectToAction("Index");
            }
            return View(book);
        }
        public async Task<string> SaveImages(IFormFile image)
        {
            var savePath = Path.Combine("wwwroot/images", image.FileName);
            using (var fileStream = new FileStream(savePath, FileMode.Create))
            {
                await image.CopyToAsync(fileStream);
            }
            return "/images/" + image.FileName;
        }

        public IActionResult Update(int Id) 
        {
            var book = _bookRepository.GetbyId(Id);
            if (book == null)
            {
                return NotFound("Khong tim thay sach");
            }
            else
            {
                return View(book);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Update(Book book, IFormFile? Image)
        {
            if (ModelState.IsValid)
            {
                if (Image != null)
                {
                    book.Image = await SaveImages(Image);
                }
            
                _bookRepository.Update(book);
                return RedirectToAction("Index");
            }
            return View(book);
        }

        public IActionResult Delete(int Id)
        {
            var book = _bookRepository.GetbyId(Id);
            if (book == null)
            {
                return NotFound("Khong tim thay sach");
            }
            else
            {
                return View(book);
            }
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int Id)
        {
            if (ModelState.IsValid)
            {
                _bookRepository.Delete (Id);
                return RedirectToAction("Index");
            }
            return View("Index");
        }
    }
}
