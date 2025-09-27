using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PruebaGD.Data;
using PruebaGD.Models;
using System.Collections.Immutable;

namespace PruebaGD.Controllers
{
    public class VentasController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

    public VentasController (ApplicationDbContext dbContext)
        {
                _dbContext = dbContext;
        }
        public async Task<IActionResult> Index(int CodigoCategoriaParm)
        {
            var categorias = await _dbContext.Categoria.ToListAsync();
            var productos = await _dbContext.Productos.ToListAsync();
            var ventas = await _dbContext.Ventas.ToListAsync();

            var ListCategoria = (from v in ventas
                             join p in productos on v.CodigoProducto equals p.CodigoProducto
                             join c in categorias on p.CodigoCategoria equals c.CodigoCategoria
                             where v.Fecha.Year == 2019
                             group c by new { c.CodigoCategoria, c.Nombre } into c
                               select new Categorium { 
                                   Nombre = c.Key.Nombre, 
                                   CodigoCategoria = c.Key.CodigoCategoria
                               } ).ToList();

            ViewBag.ListCategoria = new SelectList(ListCategoria, "CodigoCategoria", "Nombre");



            return View();
        }

        
    }
}
