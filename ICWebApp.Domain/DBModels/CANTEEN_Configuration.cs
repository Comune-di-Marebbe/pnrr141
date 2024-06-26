﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

public partial class CANTEEN_Configuration
{
    [Key]
    public Guid ID { get; set; }

    [Column(TypeName = "money")]
    public decimal? BalanceLowWarning { get; set; }

    [Column(TypeName = "money")]
    public decimal? BalanceLowServiceStop { get; set; }

    public Guid? AUTH_Municipality_ID { get; set; }

    public long? ReminderIntervallDays { get; set; }

    [Column(TypeName = "money")]
    public decimal? RechargeMinAmount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastBalanceLowWarningListSent { get; set; }

    public bool ServiceStopEnabled { get; set; }

    public bool AllowCanteenDeregistrationIfServiceStopEnabled { get; set; }

    public bool PosMode { get; set; }

    public int RequestCardInterval { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal NewPosCardPrice { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastModificationDate { get; set; }

    [InverseProperty("CANTEEN_Configuration")]
    public virtual ICollection<CANTEEN_Configuration_Extended> CANTEEN_Configuration_Extended { get; set; } = new List<CANTEEN_Configuration_Extended>();
}