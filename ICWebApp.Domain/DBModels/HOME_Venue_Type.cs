﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

public partial class HOME_Venue_Type
{
    [Key]
    public Guid ID { get; set; }

    public Guid? AUTH_Municipality_ID { get; set; }

    [InverseProperty("HOME_Venue_Type")]
    public virtual ICollection<HOME_Venue_Type_Extended> HOME_Venue_Type_Extended { get; set; } = new List<HOME_Venue_Type_Extended>();
}