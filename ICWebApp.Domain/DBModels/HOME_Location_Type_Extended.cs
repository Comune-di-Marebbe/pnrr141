﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

public partial class HOME_Location_Type_Extended
{
    [Key]
    public Guid ID { get; set; }

    public Guid? HOME_Location_Type_ID { get; set; }

    public Guid? LANG_Language_ID { get; set; }

    public string Title { get; set; }

    public string DescriptionShort { get; set; }

    [ForeignKey("HOME_Location_Type_ID")]
    [InverseProperty("HOME_Location_Type_Extended")]
    public virtual HOME_Location_Type HOME_Location_Type { get; set; }
}