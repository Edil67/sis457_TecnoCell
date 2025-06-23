using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTiendaCelulares.Models;

namespace WebTiendaCelulares.Controllers
{
    public class ClientesController : Controller
    {
        private readonly FinalTiendaCelularesContext _context;

        public ClientesController(FinalTiendaCelularesContext context)
        {
            _context = context;
        }

        // GET: Clientes
        public async Task<IActionResult> Index()
        {
            var clientes = _context.Clientes
            .Where(c => c.Estado != -1);
            return View(await clientes.ToListAsync());
        }

        // GET: Clientes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // GET: Clientes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CedulaIdentidad,Nombres,Apellidos,Direccion,Celular,CorreoElectronico,UsuarioRegistro,FechaRegistro,Estado")] Cliente cliente)
        {
            if (!String.IsNullOrEmpty(cliente.CedulaIdentidad) && 
                !String.IsNullOrEmpty(cliente.Nombres) && 
                !String.IsNullOrEmpty(cliente.Apellidos))
            {

                cliente.UsuarioRegistro = User.Identity.Name;
                cliente.FechaRegistro = DateTime.Now;
                cliente.Estado = 1;

                _context.Add(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }

        // GET: Clientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return View(cliente);
        }

        // POST: Clientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CedulaIdentidad,Nombres,Apellidos,Direccion,Celular,CorreoElectronico,UsuarioRegistro,FechaRegistro,Estado")] Cliente cliente)
        {
            if (id != cliente.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                try
                {
                    var clienteDb = await _context.Clientes.FindAsync(id);
                    if (clienteDb == null) return NotFound();

                    // Actualización directa sin condicionales
                    clienteDb.CedulaIdentidad= cliente.CedulaIdentidad;
                    clienteDb.Nombres = cliente.Nombres;
                    clienteDb.Apellidos = cliente.Apellidos;
                    clienteDb.Celular= cliente.Celular;
                    clienteDb.Direccion= cliente.Direccion;
                    clienteDb.CorreoElectronico= cliente.CorreoElectronico;

                    clienteDb.UsuarioRegistro = User.Identity.Name;
                    clienteDb.FechaRegistro = DateTime.Now;

                    clienteDb.Estado = 1; // o el estado que corresponde


                    _context.Update(clienteDb);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClienteExists(cliente.Id))
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
            return View(cliente);
        }

        // GET: Clientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // POST: Clientes/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente != null)
            {
                cliente.Estado = -1; // Eliminación lógica
                cliente.UsuarioRegistro = User.Identity.Name;
                cliente.FechaRegistro = DateTime.Now;

                _context.Clientes.Update(cliente);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClienteExists(int id)
        {
            return _context.Clientes.Any(e => e.Id == id);
        }
    }
}
