﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

public partial class ORG_Request_Status
{
    [Key]
    public Guid ID { get; set; }

    public string TEXT_SystemText_Code { get; set; }

    public string Icon { get; set; }

    public bool IsFinalStatus { get; set; }

    public bool? GeneratesPDF { get; set; }

    public long? SortOrder { get; set; }

    public bool? UserSelectable { get; set; }
}