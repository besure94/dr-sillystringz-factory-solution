using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }

    [Required(ErrorMessage = "The machine's name can't be empty!")]
    public string Name { get; set; }

    [Required(ErrorMessage = "The machine's description can't be empty!")]
    public string Description { get; set; }
    public List<Engineer> Engineers { get; set; }

  }
}