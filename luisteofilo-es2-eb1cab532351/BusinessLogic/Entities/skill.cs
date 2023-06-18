using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Entities;


[Table("skill")]
public partial class skill
{
 
    [Key]
    public int id_skill { get; set; }

    [Column(TypeName = "character varying")]
    public string nome { get; set; } = null!;

    [Column(TypeName = "character varying")]
    public string area_profissional { get; set; } = null!;
}
