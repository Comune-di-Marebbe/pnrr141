﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

public partial class AUTH_Roles
{
    [Key]
    public Guid ID { get; set; }

    [Required]
    public string Name { get; set; }

    public Guid? AUTH_Municipality_ID { get; set; }

    public string TEXT_SystemText_Code { get; set; }

    public bool? OnlyMunicipalUser { get; set; }

    [InverseProperty("AUTH_Roles")]
    public virtual ICollection<AUTH_Municipal_Users_Roles> AUTH_Municipal_Users_Roles { get; set; } = new List<AUTH_Municipal_Users_Roles>();

    [InverseProperty("AUTH_Roles")]
    public virtual ICollection<AUTH_Roles_MainMenu> AUTH_Roles_MainMenu { get; set; } = new List<AUTH_Roles_MainMenu>();
}