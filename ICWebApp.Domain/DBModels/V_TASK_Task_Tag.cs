﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

[Keyless]
public partial class V_TASK_Task_Tag
{
    public Guid ID { get; set; }

    public Guid? TASK_Task_ID { get; set; }

    public Guid? TASK_Tag_ID { get; set; }

    public long? SortOrder { get; set; }

    [Unicode(false)]
    public string Color { get; set; }

    public bool? Enabled { get; set; }

    public string Description { get; set; }

    public Guid? LANG_Language_ID { get; set; }
}