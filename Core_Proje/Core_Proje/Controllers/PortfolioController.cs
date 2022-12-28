﻿using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using Core_Proje.Models;
using DataAccessLayer.EntityFramewoek;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index()
        {
            var values = portfolioManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddPortfolio()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPortfolio(Portfolio p)
        {
      
            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult results = validations.Validate(p);
            if(results.IsValid)
            {
                portfolioManager.TAdd(p);
                return RedirectToAction("Index");

            }
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult DeletePortfolio(int id)
        {
            var values = portfolioManager.TGetByID(id);
            portfolioManager.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditPortfolio(int id)
        {
            var values = portfolioManager.TGetByID(id);
            return View(values);

        }
     
        [HttpPost]
        public IActionResult EditPortfolio(Portfolio p)
        {
            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult results = validations.Validate(p);
        
            //if(p.Platform!=null)
            //{
               
              
            //        var resource = Directory.GetCurrentDirectory();
            //        var extension = Path.GetExtension(p.Platform.FileName);
            //        var imagename = Guid.NewGuid() + extension;
            //        var savelocation = resource + "/wwwroot/userimage/" + imagename;
            //        var stream = new FileStream(savelocation, FileMode.Create);
            //         p.Platform.CopyToAsync(stream);
            //        p.Platform = imagename;
            //    }
            //}
            if (results.IsValid)
            {
                portfolioManager.TUpdate(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }



    }
}
