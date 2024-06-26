﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

public partial class CANTEEN_POS_Session
{
    [Key]
    public Guid ID { get; set; }

    public Guid? CANTEEN_Canteen_Pos_ID { get; set; }

    public Guid? SessionToken { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpirationDate { get; set; }

    public Guid? AUTH_Municipality_ID { get; set; }

    [ForeignKey("CANTEEN_Canteen_Pos_ID")]
    [InverseProperty("CANTEEN_POS_Session")]
    public virtual CANTEEN_Canteen_Pos CANTEEN_Canteen_Pos { get; set; }
}