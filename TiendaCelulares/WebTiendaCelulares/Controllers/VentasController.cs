using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using WebTiendaCelulares.Models;
using System.ComponentModel.DataAnnotations.Schema;



namespace WebTiendaCelulares.Controllers
{
    public class VentasController : Controller
    {
        private readonly FinalTiendaCelularesContext _context;

        public VentasController(FinalTiendaCelularesContext context)
        {
            _context = context;
        }

        // GET: Ventas
        public async Task<IActionResult> Index()
        {
            var finalTiendaCelularesContext = _context.Venta
                .Where(v => v.Estado != -1)
                .Include(v => v.IdClienteNavigation)
                .Include(v => v.IdUsuarioNavigation);

            return View(await finalTiendaCelularesContext.ToListAsync());
        }

        // GET: Ventas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var venta = await _context.Venta
                .Include(v => v.IdClienteNavigation)
                .Include(v => v.IdUsuarioNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (venta == null)
            {
                return NotFound();
            }

            return View(venta);
        }

        // GET: Ventas/Create
        public IActionResult Create()
        {
            ViewData["Clientes"] = _context.Clientes
    .Where(c => c.Estado != -1)
    .Select(c => new SelectListItem
    {
        Value = c.Id.ToString(),
        Text = c.Nombres + " " + c.Apellidos
    })
    .ToList();



            ViewBag.Productos = _context.Productos
    .Where(p => p.Estado != -1 && p.Stock > 0)
    .Select(p => new {
        Id = (int)p.Id,
        Descripcion = p.Nombre + " | " + p.Marca + " " + p.Modelo +
                      " | Stock: " + p.Stock +
                      " | Precio: " + p.PrecioVenta.ToString("C", new CultureInfo("es-BO"))
    })
    .ToList();



            ViewData["IdUsuario"] = new SelectList(_context.Usuarios, "Id", "Id");
            return View();
        }

        // POST: Ventas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Venta venta, List<VentaDetalle> detalles)
        {
            Console.WriteLine("DETALLES RECIBIDOS: " + detalles.Count);
            Console.WriteLine("🚨 ENTRÓ AL MÉTODO CREATE POST");

            var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.nombreUsuario == User.Identity.Name);


            if (usuario == null)
            {
                ModelState.AddModelError("", "No se pudo determinar el usuario que registra la venta.");
                return View(venta);
            }

            venta.IdUsuario = usuario.Id;

            if (!detalles.Any())
                ModelState.AddModelError("", "Debe agregar al menos un producto a la venta.");

            if (!ModelState.IsValid)
            {
                var cliente = await _context.Clientes.FindAsync(venta.IdCliente);
                venta.DocumentoCliente = cliente?.CedulaIdentidad;

                _context.Venta.Add(venta);
                await _context.SaveChangesAsync(); // ahora venta.Id está generado
                decimal montoTotal = 0;

                foreach (var item in detalles)
                {
                    var producto = await _context.Productos.FindAsync(item.IdProducto);

                    if (producto == null || producto.Estado == -1 || producto.Stock < item.Cantidad)
                    {
                        ModelState.AddModelError("Cantidad", $"Stock insuficiente o producto inactivo: {item.IdProducto}");
                        return View(venta);
                    }

                    producto.Stock -= item.Cantidad;
                    item.PrecioUnitario = producto.PrecioVenta;
                    item.IdVenta = venta.Id; // esta línea es clave
                    _context.VentaDetalles.Add(item);
                    montoTotal += item.PrecioUnitario * item.Cantidad;

                }
                venta.MontoCambio = Math.Max(venta.MontoPago - montoTotal, 0);
                venta.UsuarioRegistro = User.Identity.Name;
                venta.FechaRegistro = DateTime.Now;
                venta.Estado = 1;
                Console.WriteLine("POST RECIBIDO");
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            // Repoblar combos si hay error
            ViewData["IdCliente"] = new SelectList(_context.Clientes.Where(c => c.Estado != -1), "Id", "Nombres", venta.IdCliente);
            ViewData["IdUsuario"] = new SelectList(_context.Usuarios, "Id", "Id", venta.IdUsuario);
            ViewData["Productos"] = new SelectList(_context.Productos.Where(p => p.Estado != -1), "Id", "Nombre");

            Console.WriteLine("DETALLES RECIBIDOS: " + detalles.Count);
            foreach (var kvp in ModelState)
            {
                foreach (var error in kvp.Value.Errors)
                {
                    Console.WriteLine($"❌ Campo '{kvp.Key}': {error.ErrorMessage}");
                }
            }

            return View(venta);
        }
        // GET: Ventas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            ViewData["Clientes"] = _context.Clientes
    .Where(c => c.Estado != -1)
    .Select(c => new SelectListItem
    {
        Value = c.Id.ToString(),
        Text = c.Nombres + " " + c.Apellidos
    })
    .ToList();



            ViewBag.Productos = _context.Productos
    .Where(p => p.Estado != -1 && p.Stock > 0)
    .Select(p => new {
        Id = (int)p.Id,
        Descripcion = p.Nombre + " | " + p.Marca + " " + p.Modelo +
                      " | Stock: " + p.Stock +
                      " | Precio: " + p.PrecioVenta.ToString("C", new CultureInfo("es-BO"))
    })
    .ToList();

            if (id == null)
            {
                return NotFound();
            }

            var venta = await _context.Venta
        .Include(v => v.VentaDetalles)
        .FirstOrDefaultAsync(v => v.Id == id);

            if (venta == null)
            {
                return NotFound();
            }



            ViewData["Clientes"] = _context.Clientes
                .Where(c => c.Estado != -1)
                .Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.Nombres + " " + c.Apellidos
                }).ToList();

            ViewBag.Productos = _context.Productos
                .Where(p => p.Estado != -1 && p.Stock > 0)
                .Select(p => new {
                    Id = (int)p.Id,
                    Descripcion = p.Nombre + " | " + p.Marca + " " + p.Modelo +
                                  " | Stock: " + p.Stock +
                                  " | Precio: " + p.PrecioVenta.ToString("C", new CultureInfo("es-BO"))
                }).ToList();

            return View(venta);
        }

        // POST: Ventas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdCliente,IdUsuario,DocumentoCliente,MontoPago,MontoCambio,MontoTotal,UsuarioRegistro,FechaRegistro,Estado")] Venta venta)
        {
            if (id != venta.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                try
                {

                    venta.UsuarioRegistro = User.Identity.Name;
                    venta.FechaRegistro = DateTime.Now;
                    venta.Estado = 1;
                    _context.Update(venta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VentaExists(venta.Id))
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
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "Id", "Id", venta.IdCliente);
            ViewData["IdUsuario"] = new SelectList(_context.Usuarios, "Id", "Id", venta.IdUsuario);

            return View(venta);
        }

        // GET: Ventas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var venta = await _context.Venta
                .Include(v => v.IdClienteNavigation)
                .Include(v => v.IdUsuarioNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (venta == null)
            {
                return NotFound();
            }

            return View(venta);
        }

        // POST: Ventas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var venta = await _context.Venta.FindAsync(id);
            if (venta != null)
            {

                venta.Estado = -1;
                venta.UsuarioRegistro = User.Identity.Name;
                venta.FechaRegistro = DateTime.Now;
                _context.Venta.Update(venta);

            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VentaExists(int id)
        {
            return _context.Venta.Any(e => e.Id == id);
        }
    }
}
