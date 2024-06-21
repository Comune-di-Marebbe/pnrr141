﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

public partial class CHAT_Message_Document
{
    [Key]
    public Guid ID { get; set; }

    public Guid CHAT_Message_ID { get; set; }

    public Guid FILE_FileInfo_ID { get; set; }

    [Required]
    [StringLength(255)]
    [Unicode(false)]
    public string ContextElementId { get; set; }

    [ForeignKey("CHAT_Message_ID")]
    [InverseProperty("CHAT_Message_Document")]
    public virtual CHAT_Message CHAT_Message { get; set; }

    [ForeignKey("FILE_FileInfo_ID")]
    [InverseProperty("CHAT_Message_Document")]
    public virtual FILE_FileInfo FILE_FileInfo { get; set; }
}