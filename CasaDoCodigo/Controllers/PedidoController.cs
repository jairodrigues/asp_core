using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CasaDoCodigo.Models;
using CasaDoCodigo.Models.ViewModels;

namespace CasaDoCodigo.Controllers
{
    public class PedidoController : Controller
    {
       

        public IActionResult Carrossel()
        {
           
            return View(produtos);
        }

        public IActionResult Carrinho()
        {
            CarrinhoViewModel viewModel = GetCarrinhoViewModel();

            return View(viewModel);
        }

        private CarrinhoViewModel GetCarrinhoViewModel()
        {
            var itensCarrinho = new List<ItemPedido>
            {
                new ItemPedido(1, produtos[2], 1),
                new ItemPedido(2, produtos[3], 2),
                new ItemPedido(3, produtos[2], 3)
            };

            CarrinhoViewModel viewModel = new CarrinhoViewModel(itensCarrinho);
            return viewModel;
        }

        public IActionResult Resumo()
        {
            CarrinhoViewModel viewModel = GetCarrinhoViewModel();

            return View(viewModel);
        }
    }
}