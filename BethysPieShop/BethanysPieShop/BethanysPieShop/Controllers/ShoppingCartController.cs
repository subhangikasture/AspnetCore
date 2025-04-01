﻿using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IShoppingCart _shoppingCart;
        private readonly IPieRepository _pieRepository;
        public ShoppingCartController(IShoppingCart shoppingCart, IPieRepository pieRepository)
        {
            _shoppingCart = shoppingCart;
            _pieRepository = pieRepository;
        }
        public IActionResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;
            var shoppingCartViewModel = new ShoppingCartViewModel(_shoppingCart, _shoppingCart.GetShoppingCartTotal());
            return View(shoppingCartViewModel);
        }
        public RedirectToActionResult AddToShoppingCart(int pieId)
        {
            var selectedPie = _pieRepository.AllPies.FirstOrDefault(p => p.PieId == pieId);
            if (selectedPie != null)
            {
                _shoppingCart.AddToCart(selectedPie);
            }
            return RedirectToAction("Index");
        }

    }
}
