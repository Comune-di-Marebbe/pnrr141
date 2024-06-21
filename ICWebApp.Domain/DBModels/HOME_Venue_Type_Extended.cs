﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

public partial class HOME_Venue_Type_Extended
{
    [Key]
    public Guid ID { get; set; }

    public Guid? HOME_Venue_Type_ID { get; set; }

    public Guid? LANG_Language_ID { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    [ForeignKey("HOME_Venue_Type_ID")]
    [InverseProperty("HOME_Venue_Type_Extended")]
    public virtual HOME_Venue_Type HOME_Venue_Type { get; set; }
}