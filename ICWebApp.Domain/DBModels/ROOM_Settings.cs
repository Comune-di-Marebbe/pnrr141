﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

public partial class ROOM_Settings
{
    [Key]
    public Guid ID { get; set; }

    public string DefaultRoomOptions { get; set; }

    public bool HasTasks { get; set; }

    public int? MaxRoomBookingDays { get; set; }

    public int? MinRoomBookingDays { get; set; }

    public Guid? AUTH_Municipality_ID { get; set; }

    [InverseProperty("ROOM_Settings")]
    public virtual ICollection<ROOM_Settings_Extended> ROOM_Settings_Extended { get; set; } = new List<ROOM_Settings_Extended>();
}