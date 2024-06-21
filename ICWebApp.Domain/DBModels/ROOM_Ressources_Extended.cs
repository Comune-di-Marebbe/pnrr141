﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

public partial class ROOM_Ressources_Extended
{
    [Key]
    public Guid ID { get; set; }

    public Guid? ROOM_Ressources_ID { get; set; }

    public string Description { get; set; }

    public Guid? LANG_Language_ID { get; set; }

    public Guid? FILE_FileInfo_ID { get; set; }

    [ForeignKey("FILE_FileInfo_ID")]
    [InverseProperty("ROOM_Ressources_Extended")]
    public virtual FILE_FileInfo FILE_FileInfo { get; set; }

    [ForeignKey("ROOM_Ressources_ID")]
    [InverseProperty("ROOM_Ressources_Extended")]
    public virtual ROOM_Ressources ROOM_Ressources { get; set; }
}