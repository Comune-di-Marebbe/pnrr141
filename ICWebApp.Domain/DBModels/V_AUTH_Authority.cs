﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

[Keyless]
public partial class V_AUTH_Authority
{
    public Guid ID { get; set; }

    public string Name_DE { get; set; }

    public string Name_IT { get; set; }

    public string Mail { get; set; }

    public string Telefon { get; set; }

    public string MailIT { get; set; }

    public bool IsRooms { get; set; }

    public bool IsMensa { get; set; }

    public Guid? AUTH_Municipality_ID { get; set; }
}