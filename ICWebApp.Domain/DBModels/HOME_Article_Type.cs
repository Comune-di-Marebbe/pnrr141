﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

public partial class HOME_Article_Type
{
    [Key]
    public Guid ID { get; set; }

    public string TEXT_System_Text_Code { get; set; }

    public string DescriptionTEXT_System_Text_Code { get; set; }

    public string PageTitleTEXT_System_Text_Code { get; set; }
}