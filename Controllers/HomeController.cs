using System.Numerics;
using DependencyInjection.Models;
using DependencyInjection.Repository;
using DependencyInjection.Repository.Impl;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers {
    public class HomeController : Controller {

        private IProductRepository _repository;
        private ProductTotalizer _totalizer;

        public HomeController(IProductRepository repository, ProductTotalizer totalizer){
            this._repository = repository;
            this._totalizer = totalizer;
        }

        public ViewResult Index(){
            ViewBag.HomeController = _repository.ToString(); 
            ViewBag.Totalizer = _totalizer.Repository.ToString();
            return View(_repository.Products);
        }
    }
}