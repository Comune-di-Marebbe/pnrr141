﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

public partial class ORG_Request
{
    [Key]
    public Guid ID { get; set; }

    public string Firstname { get; set; }

    public string Lastname { get; set; }

    public string FiscalNumber { get; set; }

    public string VatNumber { get; set; }

    public string Email { get; set; }

    public string PECEmail { get; set; }

    public string Address { get; set; }

    public string DomicileMunicipality { get; set; }

    public string DomicileNation { get; set; }

    public string DomicilePostalCode { get; set; }

    public string DomicileProvince { get; set; }

    public string DomicileStreetAddress { get; set; }

    public string Phone { get; set; }

    public string MobilePhone { get; set; }

    public string CodiceDestinatario { get; set; }

    public Guid? AUTH_Company_LegalForm_ID { get; set; }

    public string HandelskammerEintragung { get; set; }

    public Guid? ORG_Request_Status_ID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    public Guid? AUTH_Users_ID { get; set; }

    public Guid? AUTH_Company_Type_ID { get; set; }

    public bool? GVEqualsUser { get; set; }

    public Guid? GV_AUTH_Users_ID { get; set; }

    public string GV_Firstname { get; set; }

    public string GV_Lastname { get; set; }

    public string GV_FiscalNumber { get; set; }

    public string GV_Email { get; set; }

    public string GV_DomicileMunicipality { get; set; }

    public string GV_DomicileNation { get; set; }

    public string GV_DomicilePostalCode { get; set; }

    public string GV_DomicileProvince { get; set; }

    public string GV_DomicileStreetAddress { get; set; }

    public string GV_Phone { get; set; }

    public string GV_CountyOfBirth { get; set; }

    public string GV_PlaceOfBirth { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? GV_DateOfBirth { get; set; }

    public string GV_Gender { get; set; }

    public bool? PrivacyConfirmed { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SubmitAt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SignetAt { get; set; }

    public Guid? AUTH_Municipality_ID { get; set; }

    public Guid? FILE_Fileinfo_ID { get; set; }

    public string User_Firstname { get; set; }

    public string User_Lastname { get; set; }

    public string User_FiscalNumber { get; set; }

    public string User_Email { get; set; }

    public string User_DomicileMunicipality { get; set; }

    public string User_DomicileNation { get; set; }

    public string User_DomicilePostalCode { get; set; }

    public string User_DomicileProvince { get; set; }

    public string User_DomicileStreetAddress { get; set; }

    public string User_Phone { get; set; }

    public string User_CountyOfBirth { get; set; }

    public string User_PlaceOfBirth { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? User_DateOfBirth { get; set; }

    public string User_Gender { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Archived { get; set; }

    public Guid? AUTH_BolloFree_Reason_ID { get; set; }

    public bool BolloFree { get; set; }

    public string EintragungNr { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EintragungDatum { get; set; }

    public string IBAN { get; set; }

    public bool IsNewOrgRequest { get; set; }

    public string Bankname { get; set; }

    public string KontoInhaber { get; set; }

    public long? ProgressivYear { get; set; }

    public long? ProgressivNumber { get; set; }

    public Guid? SelectedMunicipality { get; set; }

    public Guid? GV_SelectedMunicipality { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BolloFreeRegistrationDate { get; set; }

    public string BolloFreeRegistrationNumber { get; set; }

    public string BolloFreeCustomReasonDesc { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ProtocolDate { get; set; }

    [InverseProperty("ORG_Request")]
    public virtual ICollection<ORG_Request_Attachment> ORG_Request_Attachment { get; set; } = new List<ORG_Request_Attachment>();

    [InverseProperty("ORG_Request")]
    public virtual ICollection<ORG_Request_Ressource> ORG_Request_Ressource { get; set; } = new List<ORG_Request_Ressource>();

    [InverseProperty("ORG_Request")]
    public virtual ICollection<ORG_Request_Status_Log> ORG_Request_Status_Log { get; set; } = new List<ORG_Request_Status_Log>();
}