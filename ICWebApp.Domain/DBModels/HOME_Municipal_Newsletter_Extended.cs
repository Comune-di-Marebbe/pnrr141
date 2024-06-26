﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

public partial class HOME_Municipal_Newsletter_Extended
{
    [Key]
    public Guid ID { get; set; }

    public Guid? HOME_Municipal_Newsletter_ID { get; set; }

    public Guid? LANG_Language_ID { get; set; }

    public string Title { get; set; }

    public Guid? Download_FILE_FileInfo_ID { get; set; }

    public Guid? Image_FILE_FileInfo_ID { get; set; }

    public string Description { get; set; }

    public string DescriptionShort { get; set; }

    [ForeignKey("HOME_Municipal_Newsletter_ID")]
    [InverseProperty("HOME_Municipal_Newsletter_Extended")]
    public virtual HOME_Municipal_Newsletter HOME_Municipal_Newsletter { get; set; }
}