using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BK.DataAccess.Repository.IRepository;
using BK.Models;
using BK.Models.ViewModels;
using BK.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BangkokWheels.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class SpecificationController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public SpecificationController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            List<Car> objCarList = _unitOfWork.Car.GetAll(includeProperties: "CarSpecification,Brand").ToList();

            return View(objCarList);
        }

        public IActionResult Upsert(int? id)
        {
            CarVM carVM = new()
            {
                CarSpecificationList = _unitOfWork.CarSpecification.GetAll().Select(u => new SelectListItem
                {
                    Text = u.SpecificationName,
                    Value = u.Id.ToString()
                }),
                BrandList = _unitOfWork.Brand.GetAll().Select(u => new SelectListItem
                {
                    Text = u.BrandName,
                    Value = u.Id.ToString()
                }),
                Car = new Car()
            };
            if (id == null || id == 0)
            {
                //create
                return View(carVM);
            }
            else
            {
                //update
                carVM.Car = _unitOfWork.Car.Get((System.Linq.Expressions.Expression<Func<Car, bool>>)(u => u.Id == id));
                return View(carVM);
            }

        }
        [HttpPost]
        public IActionResult Upsert(CarVM carVM, IFormFile? file)
        {
            if (ModelState.IsValid)
            {

                string wwwRootPath = _webHostEnvironment.WebRootPath;
                if (file != null)
                {
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string productPath = Path.Combine(wwwRootPath, @"images/cars");

                    if (!string.IsNullOrEmpty(carVM.Car.ImageUrl))
                    {
                        //delete the old image
                        var oldImagePath =
                            Path.Combine(wwwRootPath, carVM.Car.ImageUrl.TrimStart('/'));

                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }

                    using (var fileStream = new FileStream(Path.Combine(productPath, fileName), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }

                    carVM.Car.ImageUrl = @"/images/cars/" + fileName;
                }

                if (carVM.Car.Id == 0)
                {
                    _unitOfWork.Car.Add(carVM.Car);
                }
                else
                {
                    _unitOfWork.Car.Update(carVM.Car);
                }

                _unitOfWork.Save();
                TempData["success"] = "Car created successfully";
                return RedirectToAction("Index");

            }
            else
            {
                carVM.CarSpecificationList = _unitOfWork.CarSpecification.GetAll().Select(u => new SelectListItem
                {
                    Text = u.SpecificationName,
                    Value = u.Id.ToString()
                });
                carVM.BrandList = _unitOfWork.Brand.GetAll().Select(u => new SelectListItem
                {
                    Text = u.BrandName,
                    Value = u.Id.ToString()
                });
                return View(carVM);
            }
        }


        #region API CALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Car> objCarList = _unitOfWork.Car.GetAll(includeProperties: "CarSpecification,Brand").ToList();
            return Json(new { data = objCarList });
        }

        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var carToBeDeleted = _unitOfWork.Car.Get((System.Linq.Expressions.Expression<Func<Car, bool>>)(u => u.Id == id));
            if (carToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            var oldImagePath =
                           Path.Combine(_webHostEnvironment.WebRootPath,
                           carToBeDeleted.ImageUrl.TrimStart('/'));

            if (System.IO.File.Exists(oldImagePath))
            {
                System.IO.File.Delete(oldImagePath);
            }

            _unitOfWork.Car.Remove(carToBeDeleted);
            _unitOfWork.Save();

            return Json(new { success = true, message = "Delete Successful" });
        }


        #endregion
    }
}

