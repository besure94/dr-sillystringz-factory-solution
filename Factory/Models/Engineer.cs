using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    // public int MachineId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    // public Machine Machine { get; set; }
    // public List<Machine> Machines { get; set; }
  }
}