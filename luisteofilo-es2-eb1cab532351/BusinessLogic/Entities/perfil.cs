using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Entities;

[Keyless]
[Table("perfil")]
public partial class perfil
{
    public int id_perfil { get; set; }

    [Column(TypeName = "character varying")]
    public string nome { get; set; } = null!;

    [Column(TypeName = "character varying")]
    public string pais { get; set; } = null!;

    [Column(TypeName = "character varying")]
    public string mail { get; set; } = null!;

    public decimal preco_hora { get; set; }

    [Column(TypeName = "character varying")]
    public string visibilidade { get; set; } = null!;

    public int id_user { get; set; }
}
