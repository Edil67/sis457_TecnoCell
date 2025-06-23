using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using WebTiendaCelulares.Models;

namespace WebTiendaCelulares.Controllers
{
    public class ProductosController : Controller
    {
        private readonly FinalTiendaCelularesContext _context;

        public ProductosController(FinalTiendaCelularesContext context)
        {
            _context = context;
        }

        // GET: Productos
        public async Task<IActionResult> Index()
        {
            var productos = _context.Productos
    .Include(p => p.IdCategoriaNavigation)
    .Where(p => p.Estado != -1);

            return View(await productos.ToListAsync());

        }

        // GET: Productos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Productos
                .Include(p => p.IdCategoriaNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // GET: Productos/Create
        public IActionResult Create()
        {
            ViewData["IdCategoria"] = new SelectList(_context.Categoria, "Id", "Descripcion");
            return View();
        }

        // POST: Productos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCategoria,Nombre,Modelo,Marca,Color,Descripcion,PrecioVenta,Stock,UsuarioRegistro,FechaRegistro,Estado")] Producto producto)
        {
            // Validar que la categoría existe y está activa
            var categoriaValida = _context.Categoria.Any(c => c.Id == producto.IdCategoria && c.Estado != -1);
            if (!categoriaValida)
            {
                ModelState.AddModelError("IdCategoria", "La categoría seleccionada no existe o está dada de baja.");
            }

            if (!String.IsNullOrEmpty(producto.Modelo) && !String.IsNullOrEmpty(producto.Marca) && !String.IsNullOrEmpty(producto.Nombre) && categoriaValida)
            {
                producto.UsuarioRegistro = User.Identity.Name;
                producto.FechaRegistro = DateTime.Now;
                producto.Estado = 1;
                _context.Add(producto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            // Solo mostrar categorías activas
            ViewData["IdCategoria"] = new SelectList(_context.Categoria.Where(c => c.Estado != -1), "Id", "Descripcion", producto.IdCategoria);
            return View(producto);
        }

        // GET: Productos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var producto = await _context.Productos.FindAsync(id);
            if (producto == null) return NotFound();
            ViewData["IdCategoria"] = new SelectList(_context.Categoria, "Id", "Descripcion", producto.IdCategoria);
            return View(producto);
        }

        // POST: Productos/Edit/5
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdCategoria,Nombre,Modelo,Marca,Color,Descripcion,PrecioVenta,Stock")] Producto producto)
        {
            if (id != producto.Id) return NotFound();

            if (!ModelState.IsValid)
            {
                try
                {
                    var productoDb = await _context.Productos.FindAsync(id);
                    if (productoDb == null) return NotFound();

                    // Actualización directa sin condicionales
                    productoDb.Nombre = producto.Nombre;
                    productoDb.Modelo = producto.Modelo;
                    productoDb.Marca = producto.Marca;
                    productoDb.Color = producto.Color;
                    productoDb.Descripcion = producto.Descripcion;
                    productoDb.PrecioVenta = producto.PrecioVenta;
                    productoDb.Stock = producto.Stock;
                    productoDb.IdCategoria = producto.IdCategoria;
                    productoDb.UsuarioRegistro = User.Identity?.Name ?? productoDb.UsuarioRegistro;
                    productoDb.FechaRegistro = DateTime.Now;

                    productoDb.Estado = 1; // o el estado que corresponde


                    _context.Update(productoDb);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductoExists(producto.Id)) return NotFound();
                    else throw;
                }
            }
            // Si hay errores de validación, mostrar de nuevo la vista
            ViewData["IdCategoria"] = new SelectList(_context.Categoria.Where(c => c.Estado != -1), "Id", "Descripcion", producto.IdCategoria);
            return View(producto);
        }

        // GET: Productos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var producto = await _context.Productos
                .Include(p => p.IdCategoriaNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (producto == null) return NotFound();
            return View(producto);
        }

        // POST: Productos/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producto = await _context.Productos.FindAsync(id);
            if (producto != null)
            {   
                producto.UsuarioRegistro = User.Identity.Name ;//cambiar
                producto.Estado = -1;
                _context.Productos.Update(producto);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductoExists(int id)
        {
            return _context.Productos.Any(e => e.Id == id);
        }
    }
}
