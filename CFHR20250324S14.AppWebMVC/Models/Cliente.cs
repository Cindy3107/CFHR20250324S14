using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CFHR20250324S14.AppWebMVC.Models;

public partial class Cliente
{
    public int Id { get; set; }

    [Required(ErrorMessage ="El nombre del cliente es obligatorio.")]

    public string Nombre { get; set; } = null!;

    [Display(Name = "dirección")]

    public string? Direccion { get; set; }
    [Display(Name = "teléfono")]

    public string? Telefono { get; set; }

    public string? Email { get; set; }
}
