using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }

    [Required(ErrorMessage = "The engineer's name can't be empty!")]
    public string Name { get; set; }

    [Required(ErrorMessage = "The engineer's description can't be empty!")]
    public string Description { get; set; }
    // public Machine Machine { get; set; }
    public List<Machine> Machines { get; set; }
  }
}