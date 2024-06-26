﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

[Keyless]
public partial class V_FORM_Application_Chat_Notifications
{
    public Guid ID { get; set; }

    public Guid? FORM_Application_ID { get; set; }

    public Guid? AUTH_Users_ID { get; set; }

    public string Message { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SendDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RemovedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReadDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? NotificationSendDate { get; set; }

    public Guid? AUTH_Authority_ID { get; set; }

    public Guid? ApplicationUser { get; set; }

    public Guid Definition_ID { get; set; }

    public string FormName { get; set; }

    public Guid? AUTH_Municipality_ID { get; set; }
}