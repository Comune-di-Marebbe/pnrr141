﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

public partial class FORM_Definition_Municipal_Field_Extended
{
    [Key]
    public Guid ID { get; set; }

    public string Description { get; set; }

    public Guid? LANG_Languages_ID { get; set; }

    public Guid? FORM_Definition_Municipal_Field_ID { get; set; }

    [ForeignKey("FORM_Definition_Municipal_Field_ID")]
    [InverseProperty("FORM_Definition_Municipal_Field_Extended")]
    public virtual FORM_Definition_Municipal_Field FORM_Definition_Municipal_Field { get; set; }
}