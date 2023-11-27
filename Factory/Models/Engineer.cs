using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }

    [Required(ErrorMessage = "The Name field is required."), MaxLength(50)]
    public string Name { get; set; }

    [Required(ErrorMessage = "The Description field is required."), MaxLength(250)]
    public string Description { get; set; }
    public Machine Machine { get; set; }
    public List<EngineerMachine> JoinEntities { get; }
  }
}