﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

public partial class TICKET_Type
{
    [Key]
    public int ID { get; set; }

    [StringLength(150)]
    public string Name { get; set; }

    [StringLength(150)]
    public string TranslationCode { get; set; }
}