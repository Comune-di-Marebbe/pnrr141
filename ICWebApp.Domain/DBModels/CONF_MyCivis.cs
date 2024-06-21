﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

public partial class CONF_MyCivis
{
    [Key]
    public Guid ID { get; set; }

    public string ServiceUid { get; set; }

    public string ServiceName_DE { get; set; }

    public string ServiceName_IT { get; set; }

    public string Url_DE { get; set; }

    public string Url_IT { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ValidFrom { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ValidTill { get; set; }

    public Guid? AUTH_Municipality_ID { get; set; }

    public string API_Username { get; set; }

    public string API_Password { get; set; }
}