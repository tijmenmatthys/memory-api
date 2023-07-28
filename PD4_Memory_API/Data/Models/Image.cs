using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PD4_Memory_API.Data.Models;

public partial class Image
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public byte[] Image1 { get; set; } = null!;

    public string? Theme { get; set; }

    public string? Extention { get; set; }

    public bool IsBack { get; set; }
}
