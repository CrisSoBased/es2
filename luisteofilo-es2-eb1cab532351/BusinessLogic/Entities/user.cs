﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Entities;


public partial class user
{
    
    [Key]
    public int id_user { get; set; }

    [Column(TypeName = "character varying")]
    public string username { get; set; } = null!;

    [Column(TypeName = "character varying")]
    public string password { get; set; } = null!;
}
