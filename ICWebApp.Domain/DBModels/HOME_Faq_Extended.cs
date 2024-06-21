﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

public partial class HOME_Faq_Extended
{
    [Key]
    public Guid ID { get; set; }

    public Guid? HOME_Faq_ID { get; set; }

    public Guid? LANG_Language_ID { get; set; }

    public string Question { get; set; }

    public string Answer { get; set; }

    [ForeignKey("HOME_Faq_ID")]
    [InverseProperty("HOME_Faq_Extended")]
    public virtual HOME_Faq HOME_Faq { get; set; }
}