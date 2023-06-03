﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BK.DataAccess.Repository.IRepository;
using BK.Models;
using BK.Models.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BangkokWheels.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class CarController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public CarController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            List<Car> objCarList = _unitOfWork.Car.GetAll(includeProperties: "CarSpecification").ToList();

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
                carVM.Car = _unitOfWork.Car.Get(u => u.Id == id);
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
                    string carPath = Path.Combine(wwwRootPath, @"images/cars");


                    using (var fileStream = new FileStream(Path.Combine(carPath, fileName), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }

                    carVM.Car.ImageUrl = @"/images/cars/" + fileName;

                }
                _unitOfWork.Car.Add(carVM.Car);
                _unitOfWork.Save();
                TempData["success"] = "Product created/updated successfully";
                return RedirectToAction("Index");
            }
            else
            {
                carVM.CarSpecificationList = _unitOfWork.CarSpecification.GetAll().Select(u => new SelectListItem
                {
                    Text = u.SpecificationName,
                    Value = u.Id.ToString()
                });
                return View(carVM);
            }
        }


        #region API CALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Car> objCarList = _unitOfWork.Car.GetAll(includeProperties: "CarSpecification").ToList();
            return Json(new { data = objCarList });
        }


        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var carToBeDeleted = _unitOfWork.Car.Get(u => u.Id == id);
            if (carToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }


            _unitOfWork.Car.Remove(carToBeDeleted);
            _unitOfWork.Save();

            return Json(new { success = true, message = "Delete Successful" });
        }

        #endregion
    }
}
