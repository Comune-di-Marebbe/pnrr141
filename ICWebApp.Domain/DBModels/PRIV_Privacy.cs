﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

public partial class PRIV_Privacy
{
    [Key]
    public Guid ID { get; set; }

    public Guid? AUTH_Municipality_ID { get; set; }

    [InverseProperty("FORM_Definition_Privacy")]
    public virtual ICollection<PRIV_Privacy_Extended> PRIV_Privacy_Extended { get; set; } = new List<PRIV_Privacy_Extended>();
}