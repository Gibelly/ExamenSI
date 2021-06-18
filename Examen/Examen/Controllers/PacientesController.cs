using Examen.Data;
using Examen.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Examen.Controllers
{
    public class PacientesController: Controller
    {
       
           private readonly ApplicationDbContext db;

            public PacientesController(ApplicationDbContext db)
            {
                this.db = db;
            }

            public async Task<ActionResult> Index()
            {
                return View(await db.Pacientes.ToListAsync());
            }

            public async Task<IActionResult> Details(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var paciente = await db.Pacientes.FirstOrDefaultAsync(p => p.PacienteId == id);
                if (paciente == null)
                {
                    return NotFound();
                }

                return View(paciente);

            }

            //Crear por medio de vista
            public IActionResult Create()
            {

                return View();
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            
        public async Task<IActionResult> Create(Paciente paciente)
            {
                if (ModelState.IsValid)
                {
                    db.Add(paciente);
                    await db.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View(paciente);
            }

            public async Task<IActionResult> Edit(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var paciente = await db.Pacientes.FindAsync(id);

                if (paciente == null)
                {
                    return NotFound();
                }

                return View(paciente);
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Edit(int id, Paciente paciente)
            {
                if (id != paciente.PacienteId)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        db.Update(paciente);
                        await db.SaveChangesAsync();

                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        return NotFound();
                    }

                    return RedirectToAction(nameof(Index));
                }

                return View(paciente);

            }

            public async Task<IActionResult> Delete(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var paciente = await db.Pacientes.FirstOrDefaultAsync(p => p.PacienteId == id);
                if (paciente == null)
                {
                    return NotFound();
                }

                return View(paciente);
            }

            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Delete(int id)
            {
                var paciente = await db.Pacientes.FindAsync(id);
                db.Pacientes.Remove(paciente);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
        }
}
    
