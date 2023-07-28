using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PD4_Memory_API.Data.Models;

public partial class Animal
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AnimalId { get; set; }

    public string Name { get; set; } = null!;

    public int? CutenessRating { get; set; }
}
