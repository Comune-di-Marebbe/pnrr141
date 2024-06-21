﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

public partial class ROOM_Property_Extended
{
    [Key]
    public Guid ID { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public Guid? FILE_FileInfo_ID { get; set; }

    public Guid? ROOM_Property_ID { get; set; }

    public Guid? LANG_Languages_ID { get; set; }

    [ForeignKey("ROOM_Property_ID")]
    [InverseProperty("ROOM_Property_Extended")]
    public virtual ROOM_Property ROOM_Property { get; set; }
}