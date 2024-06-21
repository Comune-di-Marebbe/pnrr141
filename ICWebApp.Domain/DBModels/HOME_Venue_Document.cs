﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

public partial class HOME_Venue_Document
{
    [Key]
    public Guid ID { get; set; }

    public Guid? HOME_Venue_ID { get; set; }

    public Guid? HOME_Document_ID { get; set; }

    [ForeignKey("HOME_Document_ID")]
    [InverseProperty("HOME_Venue_Document")]
    public virtual HOME_Document HOME_Document { get; set; }

    [ForeignKey("HOME_Venue_ID")]
    [InverseProperty("HOME_Venue_Document")]
    public virtual HOME_Venue HOME_Venue { get; set; }
}