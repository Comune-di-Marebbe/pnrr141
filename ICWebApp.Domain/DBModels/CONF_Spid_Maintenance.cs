﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

public partial class CONF_Spid_Maintenance
{
    [Key]
    public Guid ID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EndDate { get; set; }

    public bool Enabled { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DisplayFrom { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DisplayTo { get; set; }
}