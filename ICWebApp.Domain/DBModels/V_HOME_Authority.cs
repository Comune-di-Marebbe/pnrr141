﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

[Keyless]
public partial class V_HOME_Authority
{
    public Guid ID { get; set; }

    public Guid? AUTH_Municipality_ID { get; set; }

    public string Icon { get; set; }

    public long? SortOrder { get; set; }

    public string Telefon { get; set; }

    public bool IsOfficial { get; set; }

    public Guid? LANG_Language_ID { get; set; }

    public string Address { get; set; }

    public string Room { get; set; }

    public string EMail { get; set; }

    public string PecEmail { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public string DescriptionShort { get; set; }

    public string Managed_Person { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastChangeDate { get; set; }

    public bool Highlight { get; set; }

    public Guid? HOME_Person_ID { get; set; }

    public Guid? HOME_Municipality_ID { get; set; }

    public Guid? Managed_HOME_Person_ID { get; set; }

    public bool DynamicForms { get; set; }

    [StringLength(2)]
    public string IdentificationLetters { get; set; }

    public int? NextFormIndex { get; set; }

    public int MinDaysAheadOfBooking { get; set; }

    public int MaxDaysBookable { get; set; }

    public bool AllowTimeslots { get; set; }

    public bool AllowOfficeHours { get; set; }

    public string Color { get; set; }

    public double? Lat { get; set; }

    public double? Lang { get; set; }
}