﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

[Keyless]
public partial class V_FORM_Application_Users
{
    public Guid? AUTH_User_ID { get; set; }

    public Guid? AUTH_Municipality_ID { get; set; }

    public string Name { get; set; }

    public string FiscalNumber { get; set; }
}