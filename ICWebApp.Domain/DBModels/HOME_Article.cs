﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

public partial class HOME_Article
{
    [Key]
    public Guid ID { get; set; }

    public bool Highlight { get; set; }

    public int? ReadDuration { get; set; }

    public Guid? FILE_FileInfo_ID { get; set; }

    public bool Visible { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModificationDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReleaseDate { get; set; }

    public Guid? Managed_HOME_Person_ID { get; set; }

    public Guid? Managed_AUTH_Authority_ID { get; set; }

    public Guid AUTH_Municipality_ID { get; set; }

    public Guid? AUTH_Users_ID { get; set; }

    public Guid? HOME_Article_Type_ID { get; set; }

    [InverseProperty("HOME_Article")]
    public virtual ICollection<HOME_Article_Document> HOME_Article_Document { get; set; } = new List<HOME_Article_Document>();

    [InverseProperty("HOME_Article")]
    public virtual ICollection<HOME_Article_Extended> HOME_Article_Extended { get; set; } = new List<HOME_Article_Extended>();

    [InverseProperty("HOME_Article")]
    public virtual ICollection<HOME_Article_Theme> HOME_Article_Theme { get; set; } = new List<HOME_Article_Theme>();
}