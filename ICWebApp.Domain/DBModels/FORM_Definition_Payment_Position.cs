﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

public partial class FORM_Definition_Payment_Position
{
    [Key]
    public Guid ID { get; set; }

    public Guid? FORM_Definition_ID { get; set; }

    [Column(TypeName = "money")]
    public decimal? Amount { get; set; }

    public long? SortOrder { get; set; }

    public int? PAY_PagoPa_Identifier_ID { get; set; }

    [ForeignKey("FORM_Definition_ID")]
    [InverseProperty("FORM_Definition_Payment_Position")]
    public virtual FORM_Definition FORM_Definition { get; set; }

    [InverseProperty("FORM_Definition_Payment_Position")]
    public virtual ICollection<FORM_Definition_Payment_Position_Extended> FORM_Definition_Payment_Position_Extended { get; set; } = new List<FORM_Definition_Payment_Position_Extended>();

    [ForeignKey("PAY_PagoPa_Identifier_ID")]
    [InverseProperty("FORM_Definition_Payment_Position")]
    public virtual PAY_PagoPa_Identifier PAY_PagoPa_Identifier { get; set; }
}