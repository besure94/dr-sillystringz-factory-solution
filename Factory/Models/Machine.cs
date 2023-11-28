using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }

    [Required(ErrorMessage = "The Name field is required."),MaxLength(30)]
    [RegularExpression("^[A-Za-z-'0-9 ]+$", ErrorMessage = "The Name field contains invalid characters. You may enter only letters, numbers, spaces, apostrophes ('), and hyphens (-).")]
    public string Name { get; set; }

    [Required(ErrorMessage = "The Description field is required."), MaxLength(250)]
    public string Description { get; set; }
    public List<EngineerMachine> JoinEntities { get; }

  }
}