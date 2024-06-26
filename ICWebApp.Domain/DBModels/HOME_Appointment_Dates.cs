﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

public partial class HOME_Appointment_Dates
{
    [Key]
    public Guid ID { get; set; }

    public Guid? HOME_Appointment_ID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateFrom { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateTo { get; set; }

    [ForeignKey("HOME_Appointment_ID")]
    [InverseProperty("HOME_Appointment_Dates")]
    public virtual HOME_Appointment HOME_Appointment { get; set; }
}