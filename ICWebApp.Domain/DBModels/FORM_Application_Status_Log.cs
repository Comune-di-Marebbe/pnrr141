﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

public partial class FORM_Application_Status_Log
{
    [Key]
    public Guid ID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ChangeDate { get; set; }

    public Guid? AUTH_Users_ID { get; set; }

    public Guid? FORM_Application_ID { get; set; }

    public Guid? FORM_Application_Status_ID { get; set; }

    [ForeignKey("FORM_Application_ID")]
    [InverseProperty("FORM_Application_Status_Log")]
    public virtual FORM_Application FORM_Application { get; set; }

    [InverseProperty("FORM_Application_Status_Log")]
    public virtual ICollection<FORM_Application_Status_Log_Extended> FORM_Application_Status_Log_Extended { get; set; } = new List<FORM_Application_Status_Log_Extended>();
}