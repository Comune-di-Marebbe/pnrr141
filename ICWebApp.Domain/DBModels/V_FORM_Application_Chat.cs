﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

[Keyless]
public partial class V_FORM_Application_Chat
{
    public Guid ID { get; set; }

    public Guid? FORM_Application_ID { get; set; }

    public Guid? AUTH_Users_ID { get; set; }

    public string Message { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SendDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RemovedDate { get; set; }

    public string Firstname { get; set; }

    public string Lastname { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReadDate { get; set; }

    public string HyperlinkPastedUrl { get; set; }

    public string HyperlinkFaviconUrl { get; set; }

    public string HyperlinkLinkName { get; set; }
}