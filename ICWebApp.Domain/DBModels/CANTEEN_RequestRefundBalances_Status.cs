﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

public partial class CANTEEN_RequestRefundBalances_Status
{
    [Key]
    public Guid ID { get; set; }

    public string TEXT_SystemTexts_Code { get; set; }

    public string Icon { get; set; }

    public string SortOrder { get; set; }

    public string Description { get; set; }

    public bool? DefaultStatus { get; set; }

    public bool? SignedStatus { get; set; }

    public bool? AcceptRequestStatus { get; set; }

    public bool StatusSelectable { get; set; }

    [InverseProperty("CANTEEN_RequestRefundAllCharge_Status")]
    public virtual ICollection<CANTEEN_RequestRefundBalances> CANTEEN_RequestRefundBalances { get; set; } = new List<CANTEEN_RequestRefundBalances>();
}