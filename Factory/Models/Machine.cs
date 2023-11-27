using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }

    [Required(ErrorMessage = "The Name field is required.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "The Description field is required.")]
    public string Description { get; set; }
    public List<Engineer> Engineers { get; set; }
    public List<EngineerMachine> JoinEntities { get; }

  }
}