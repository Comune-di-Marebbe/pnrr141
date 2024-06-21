﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

[Keyless]
public partial class V_CANTEEN_RequestRefundBalances
{
    public Guid ID { get; set; }

    public Guid? AUTH_User_ID { get; set; }

    public Guid? AUTH_Municipality_ID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Date { get; set; }

    public string UserFirstName { get; set; }

    public string UserLastName { get; set; }

    public string UserTaxNumber { get; set; }

    public string UserGender { get; set; }

    public string UserCountryOfBirth { get; set; }

    public string UserPlaceOfBirth { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UserDateOfBirth { get; set; }

    public string UserEmail { get; set; }

    public string UserMobilePhone { get; set; }

    public string UserDomicileEntireAdress { get; set; }

    public string UserDomicileStreetAdress { get; set; }

    public string UserDomicilePostalCode { get; set; }

    public string UserDomicileMunicipality { get; set; }

    public string UserDomicileProvince { get; set; }

    public string UserDomicileNation { get; set; }

    public string Owner { get; set; }

    public string Bank { get; set; }

    public string IBAN { get; set; }

    [Column(TypeName = "money")]
    public decimal? Fee { get; set; }

    public bool? PrivacyPolices { get; set; }

    public Guid LANG_LanguageID { get; set; }

    public string LANG_Language { get; set; }

    public Guid? CANTEEN_RequestRefundAllCharge_Status_ID { get; set; }

    public string Status_Text { get; set; }

    public string Status_Icon { get; set; }

    public Guid? FILE_FileInfoID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SignedDate { get; set; }

    public long? ProgressivNumber { get; set; }

    public int? ProgressivYear { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ProtocolDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ArchivedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RequestAcceptedDate { get; set; }

    public string ProgressivNumberCombined { get; set; }
}