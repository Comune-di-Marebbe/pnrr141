﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

[Keyless]
public partial class V_HOME_Location
{
    public Guid ID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastChangeDate { get; set; }

    public Guid? Managed_Home_Person_ID { get; set; }

    public bool Highlight { get; set; }

    public Guid? HOME_Location_Type_ID { get; set; }

    public Guid? AUTH_Municipality_ID { get; set; }

    public Guid? FILE_FileImage_ID { get; set; }

    public double? Lat { get; set; }

    public double? Lang { get; set; }

    public Guid? LANG_Language_ID { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public string DescriptionShort { get; set; }

    public string Address { get; set; }

    public string Room { get; set; }

    public string Type { get; set; }
}