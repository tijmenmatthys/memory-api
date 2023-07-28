using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PD4_Memory_API.Data.Models;

public partial class CombinationFound
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public int ImageId { get; set; }
}
