﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

public partial class TASK_Context
{
    [Key]
    public long ID { get; set; }

    [Unicode(false)]
    public string TEXT_SystemTextCode { get; set; }

    public bool? Enabled { get; set; }

    public int? SortOrder { get; set; }

    public Guid? APP_Applications_ID { get; set; }

    public bool? IsRooms { get; set; }

    public bool? IsCanteen { get; set; }

    public bool? IsOrg { get; set; }
}