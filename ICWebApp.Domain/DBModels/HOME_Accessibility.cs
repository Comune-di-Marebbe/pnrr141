﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

public partial class HOME_Accessibility
{
    [Key]
    public Guid ID { get; set; }

    public Guid? AUTH_Municipality_ID { get; set; }

    [InverseProperty("HOME_Accessibility")]
    public virtual ICollection<HOME_Accessibility_Extended> HOME_Accessibility_Extended { get; set; } = new List<HOME_Accessibility_Extended>();
}