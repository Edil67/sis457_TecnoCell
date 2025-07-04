﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebTiendaCelulares.Models;

namespace WebTiendaCelulares.Controllers
{
    public class VentaDetallesController : Controller
    {
        private readonly FinalTiendaCelularesContext _context;

        public VentaDetallesController(FinalTiendaCelularesContext context)
        {
            _context = context;
        }


        // GET: VentaDetalles
        public async Task<IActionResult> Index(int? id, string cedula)
{
            var detalles = _context.VentaDetalles
               .Include(v => v.IdProductoNavigation)
               .Include(v => v.IdVentaNavigation)
               .ThenInclude(v => v.IdClienteNavigation)
               .AsQueryable();

            if (id.HasValue)
            {
                detalles = detalles.Where(v => v.IdVenta == id.Value);
            }
            else if (!string.IsNullOrEmpty(cedula))
            {
                detalles = detalles.Where(v => v.IdVentaNavigation.DocumentoCliente == cedula);
            }

            ViewBag.Cedula = cedula;
            return View(await detalles.ToListAsync());
        }

        // GET: VentaDetalles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ventaDetalle = await _context.VentaDetalles
                .Include(v => v.IdProductoNavigation)
                .Include(v => v.IdVentaNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ventaDetalle == null)
            {
                return NotFound();
            }

            return View(ventaDetalle);
        }

        // GET: VentaDetalles/Create
        public IActionResult Create()
        {
            ViewData["IdProducto"] = new SelectList(_context.Productos, "Id", "Id");
            ViewData["IdVenta"] = new SelectList(_context.Venta, "Id", "Id");
            return View();
        }

        // POST: VentaDetalles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdVenta,IdProducto,Cantidad,PrecioUnitario,Subtotal,UsuarioRegistro,FechaRegistro,Estado")] VentaDetalle ventaDetalle)
        {
            if (ModelState.IsValid)
            {

                ventaDetalle.UsuarioRegistro = User.Identity.Name;
                ventaDetalle.FechaRegistro = DateTime.Now;
                ventaDetalle.Estado = 1;
                _context.Add(ventaDetalle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdProducto"] = new SelectList(_context.Productos, "Id", "Id", ventaDetalle.IdProducto);
            ViewData["IdVenta"] = new SelectList(_context.Venta, "Id", "Id", ventaDetalle.IdVenta);
            return View(ventaDetalle);
        }

        // GET: VentaDetalles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ventaDetalle = await _context.VentaDetalles.FindAsync(id);
            if (ventaDetalle == null)
            {
                return NotFound();
            }
            ViewData["IdProducto"] = new SelectList(_context.Productos, "Id", "Id", ventaDetalle.IdProducto);
            ViewData["IdVenta"] = new SelectList(_context.Venta, "Id", "Id", ventaDetalle.IdVenta);
            return View(ventaDetalle);
        }

        // POST: VentaDetalles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdVenta,IdProducto,Cantidad,PrecioUnitario,Subtotal,UsuarioRegistro,FechaRegistro,Estado")] VentaDetalle ventaDetalle)
        {
            if (id != ventaDetalle.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {

                    ventaDetalle.UsuarioRegistro = User.Identity.Name;
                    ventaDetalle.FechaRegistro = DateTime.Now;
                    ventaDetalle.Estado = 1;
                    _context.Update(ventaDetalle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VentaDetalleExists(ventaDetalle.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdProducto"] = new SelectList(_context.Productos, "Id", "Id", ventaDetalle.IdProducto);
            ViewData["IdVenta"] = new SelectList(_context.Venta, "Id", "Id", ventaDetalle.IdVenta);
            return View(ventaDetalle);
        }

        // GET: VentaDetalles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ventaDetalle = await _context.VentaDetalles
                .Include(v => v.IdProductoNavigation)
                .Include(v => v.IdVentaNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ventaDetalle == null)
            {
                return NotFound();
            }

            return View(ventaDetalle);
        }

        // POST: VentaDetalles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ventaDetalle = await _context.VentaDetalles.FindAsync(id);
            if (ventaDetalle != null)
            {
                ventaDetalle.UsuarioRegistro = User.Identity.Name;
                ventaDetalle.FechaRegistro = DateTime.Now;
                ventaDetalle.Estado = 1;
                _context.VentaDetalles.Remove(ventaDetalle);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VentaDetalleExists(int id)
        {
            return _context.VentaDetalles.Any(e => e.Id == id);
        }
    }
}
