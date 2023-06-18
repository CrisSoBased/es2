using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Entities;


[Table("detalhe")]
public partial class detalhe
{

    [Key]
    public int id_detalhe { get; set; }

    [Column(TypeName = "character varying")]
    public string titulo { get; set; } = null!;

    [Column(TypeName = "character varying")]
    public string empresa { get; set; } = null!;

    [Column(TypeName = "character varying")]
    public string ano_inicio { get; set; } = null!;

    [Column(TypeName = "character varying")]
    public string ano_fim { get; set; } = null!;

    public int id_skill { get; set; }

    public int id_perfil { get; set; }
}
