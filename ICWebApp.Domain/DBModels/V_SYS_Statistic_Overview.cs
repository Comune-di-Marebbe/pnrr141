﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

[Keyless]
public partial class V_SYS_Statistic_Overview
{
    public Guid? ID { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string Month { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string Year { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string YearMonth { get; set; }

    public Guid? AUTH_Municipality_ID { get; set; }

    [StringLength(250)]
    public string Municipality { get; set; }

    public int TotalForms { get; set; }

    public int TotalFormsSigned { get; set; }

    public int TotalMaintenance { get; set; }

    public int TotalMaintenanceSigned { get; set; }

    public int TotalSMS { get; set; }

    public int TotalVeriff { get; set; }

    public int TotalCanteen { get; set; }

    public int TotalCanteenSigned { get; set; }

    public int TotalRoomBookings { get; set; }

    public int TotalRoomBookingsSigned { get; set; }

    public int? TotalApplications { get; set; }

    public int? TotalSigned { get; set; }
}