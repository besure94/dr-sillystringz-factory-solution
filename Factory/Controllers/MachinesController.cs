using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Factory.Controllers
{
  public class MachinesController : Controller
  {
    private readonly FactoryContext _db;
    public MachinesController(FactoryContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Machine> model = _db.Machines.ToList();
      return View(model);
    }
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Machine machine)
    {
      if (!ModelState.IsValid)
      {
        return View(machine);
      }
      else
      {
        _db.Machines.Add(machine);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }
    }
    public ActionResult Details(int id)
    {
      Machine thisMachine = _db.Machines
      .Include(machine => machine.JoinEntities)
      .ThenInclude(machine => machine.Engineer)
      .FirstOrDefault(machine => machine.MachineId == id);
      return View(thisMachine);
    }
    public ActionResult AddEngineer(int id)
    {
      Machine thisMachine = _db.Machines.FirstOrDefault(machines => machines.MachineId == id);
      ViewBag.EngineerId = new SelectList(_db.Engineers, "EngineerId", "Name");
      return View(thisMachine);
    }

    [HttpPost]
    public ActionResult AddEngineer(Machine machine, int engineerId)
    {
      #nullable enable
      EngineerMachine? joinEntity = _db.EngineerMachines.FirstOrDefault(join => join.EngineerMachineId == engineerId && join.MachineId == machine.MachineId);
      #nullable disable
      if (joinEntity == null && engineerId != 0)
      {
        _db.EngineerMachines.Add(new EngineerMachine() { EngineerId = engineerId, MachineId = machine.MachineId });
        _db.SaveChanges();
      }
      return RedirectToAction("Details", new { id = machine.MachineId });
    }

    [HttpPost]
    public ActionResult DeleteJoin(int joinId)
    {
      EngineerMachine joinEntry = _db.EngineerMachines.FirstOrDefault(entry => entry.EngineerMachineId == joinId);
      _db.EngineerMachines.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

  }
}