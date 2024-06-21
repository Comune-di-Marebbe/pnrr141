﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

public partial class HOME_Theme_Extended
{
    [Key]
    public Guid ID { get; set; }

    public Guid? LANG_Language_ID { get; set; }

    public Guid? HOME_Theme_ID { get; set; }

    public string Description { get; set; }

    public string Title { get; set; }

    [ForeignKey("HOME_Theme_ID")]
    [InverseProperty("HOME_Theme_Extended")]
    public virtual HOME_Theme HOME_Theme { get; set; }
}