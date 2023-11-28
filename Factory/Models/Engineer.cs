using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }

    [Required(ErrorMessage = "The Name field is required."), MaxLength(50)]
    [RegularExpression("^[A-Za-z-' ]+$", ErrorMessage = "The Name field contains invalid characters. You may enter only letters, spaces, apostrophes ('), and hyphens (-).")]
    public string Name { get; set; }

    [Required(ErrorMessage = "The Description field is required."), MaxLength(250)]
    public string Description { get; set; }
    public List<EngineerMachine> JoinEntities { get; }

  }
}