﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

[Keyless]
public partial class V_ORG_Request_Status
{
    public Guid ID { get; set; }

    public string TEXT_SystemText_Code { get; set; }

    public Guid? LANG_LanguagesID { get; set; }

    public string Description { get; set; }

    public string Icon { get; set; }

    public bool? GeneratesPDF { get; set; }

    public bool IsFinalStatus { get; set; }

    public long? SortOrder { get; set; }

    public bool? UserSelectable { get; set; }
}