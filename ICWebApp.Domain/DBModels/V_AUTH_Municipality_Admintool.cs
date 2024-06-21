﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

[Keyless]
public partial class V_AUTH_Municipality_Admintool
{
    public Guid? ID { get; set; }

    public Guid AUTH_Municipality_ID { get; set; }

    public Guid LANG_Languages_ID { get; set; }

    [StringLength(250)]
    public string InternalName { get; set; }

    public string Name_Text_SystemTexts_Code { get; set; }

    public string Name_Text { get; set; }

    public string Prefix_Text_SystemTexts_Code { get; set; }

    public string Prefix_Text { get; set; }

    public int? Applications { get; set; }

    public byte[] Logo { get; set; }

    public double? Lat { get; set; }

    public double? Lng { get; set; }

    [StringLength(50)]
    public string PhoneCanteenManagement { get; set; }

    public string Address { get; set; }

    public string Location { get; set; }

    public string Phone { get; set; }

    public string Mail { get; set; }

    public string ReportName { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string MensaPNPrefix { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string RoomPNPrefix { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string OrgPNPrefix { get; set; }

    public bool? FESR_EFRE_Logo { get; set; }

    public bool ShowOnLanding { get; set; }

    [Column(TypeName = "image")]
    public byte[] PanoramicImage { get; set; }

    [Unicode(false)]
    public string D3ProtocolEmail { get; set; }

    public string Province_Text_SystemTexts_Code { get; set; }

    public string Province_Text { get; set; }

    public string Soc_Twitter { get; set; }

    public string Soc_Facebook { get; set; }

    public string Soc_Youtube { get; set; }

    public string Soc_Telegramm { get; set; }

    public string Soc_Instagram { get; set; }

    public string Soc_Whatsapp { get; set; }

    public string Soc_RSS { get; set; }

    public string Aemterkodex { get; set; }

    public string TaxNumber { get; set; }

    public bool? EU_Logo_Active { get; set; }

    public bool? ShowGreenSupportNumber { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string MensaRefundPNPrefix { get; set; }
}