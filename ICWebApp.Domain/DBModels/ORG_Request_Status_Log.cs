﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

public partial class ORG_Request_Status_Log
{
    [Key]
    public Guid ID { get; set; }

    public Guid? ORG_Request_ID { get; set; }

    public Guid? ORG_Request_User_ID { get; set; }

    public Guid? AUTH_Users_ID { get; set; }

    public Guid? ORG_Request_Status_ID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ChangeDate { get; set; }

    [ForeignKey("ORG_Request_ID")]
    [InverseProperty("ORG_Request_Status_Log")]
    public virtual ORG_Request ORG_Request { get; set; }

    [InverseProperty("ORG_Request_Status_Log")]
    public virtual ICollection<ORG_Request_Status_Log_Extended> ORG_Request_Status_Log_Extended { get; set; } = new List<ORG_Request_Status_Log_Extended>();

    [ForeignKey("ORG_Request_User_ID")]
    [InverseProperty("ORG_Request_Status_Log")]
    public virtual AUTH_Users ORG_Request_User { get; set; }
}