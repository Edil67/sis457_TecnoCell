using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebTiendaCelulares.Models;

namespace WebTiendaCelulares.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly FinalTiendaCelularesContext _context;

        public CategoriasController(FinalTiendaCelularesContext context)
        {
            _context = context;
        }

        // GET: Categorias
        public async Task<IActionResult> Index()
        {
            var categorias = await _context.Categoria
                .Where(c => c.Estado != -1)
                .ToListAsync();
            return View(categorias);
        }

        // GET: Categorias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var categoria = await _context.Categoria
                .FirstOrDefaultAsync(c => c.Id == id);
            if (categoria == null) return NotFound();

            return View(categoria);
        }

        // GET: Categorias/Create
        public IActionResult Create()
        {

            return View();
        }

        // POST: Categorias/Create
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Descripcion")] Categorium categoria)
        {
            if (!String.IsNullOrEmpty(categoria.Descripcion))
            {
                categoria.UsuarioRegistro = User.Identity.Name;
                categoria.FechaRegistro = DateTime.Now;
                categoria.Estado = 1;

                _context.Add(categoria);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(categoria);
        }

        // GET: Categorias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var categoria = await _context.Categoria.FindAsync(id);
            if (categoria == null) return NotFound();

            return View(categoria);
        }

        // POST: Categorias/Edit/5
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Descripcion")] Categorium categoria)
        {
            if (id != categoria.Id) return NotFound();

            if (!ModelState.IsValid)
            {
                try
                {
                    var categoriaDb = await _context.Categoria.FindAsync(id);
                    if (categoriaDb == null) return NotFound();

                    categoriaDb.Descripcion = categoria.Descripcion;
                    categoriaDb.UsuarioRegistro = User.Identity?.Name ?? categoriaDb.UsuarioRegistro;
                    categoriaDb.FechaRegistro = DateTime.Now;
                    categoriaDb.Estado = 1;

                    _context.Update(categoriaDb);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoriaExists(categoria.Id)) return NotFound();
                    else throw;
                }
            }

            return View(categoria);
        }

        // GET: Categorias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var categoria = await _context.Categoria
                .FirstOrDefaultAsync(c => c.Id == id);
            if (categoria == null) return NotFound();

            return View(categoria);
        }

        // POST: Categorias/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var categoria = await _context.Categoria.FindAsync(id);
            if (categoria != null)
            {
                categoria.UsuarioRegistro = User.Identity.Name;
                categoria.Estado = -1; // Borrado lógico
                _context.Update(categoria);
                
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoriaExists(int id)
        {
            return _context.Categoria.Any(e => e.Id == id);
        }
    }
}
