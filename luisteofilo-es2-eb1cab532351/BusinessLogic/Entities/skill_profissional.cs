﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Entities;


[Table("skill_profissional")]
public partial class skill_profissional
{
    
    public int id_perfil { get; set; }
    [Key]
    public int id_skill { get; set; }
}
