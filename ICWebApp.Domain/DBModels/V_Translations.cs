﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

[Keyless]
public partial class V_Translations
{
    public Guid DEID { get; set; }

    public string Code { get; set; }

    public Guid Lang_ID_DE { get; set; }

    public string TextDE { get; set; }

    public Guid? ITID { get; set; }

    public string Code_IT { get; set; }

    public Guid? Lang_ID_IT { get; set; }

    public string TextIT { get; set; }
}