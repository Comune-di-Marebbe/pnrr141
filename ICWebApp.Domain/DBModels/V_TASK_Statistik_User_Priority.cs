﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

[Keyless]
public partial class V_TASK_Statistik_User_Priority
{
    public int? Count { get; set; }

    public Guid? AUTH_Municipal_Users_ID { get; set; }

    public Guid? LANG_Language_ID { get; set; }

    public string Description { get; set; }
}