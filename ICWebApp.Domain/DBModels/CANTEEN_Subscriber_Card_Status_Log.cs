﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

public partial class CANTEEN_Subscriber_Card_Status_Log
{
    [Key]
    public Guid ID { get; set; }

    public Guid? CANTEEN_Subscriber_Card_ID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ChangedDate { get; set; }

    public int? CANTEEN_Subscriber_Card_Status_ID { get; set; }

    [ForeignKey("CANTEEN_Subscriber_Card_ID")]
    [InverseProperty("CANTEEN_Subscriber_Card_Status_Log")]
    public virtual CANTEEN_Subscriber_Card CANTEEN_Subscriber_Card { get; set; }
}