﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

[Keyless]
public partial class V_ROOM_Booking_Bookings
{
    public Guid? ROOM_BookingGroup_ID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    public string Description { get; set; }

    public Guid LANG_Languages_ID { get; set; }

    public string BuildingName { get; set; }

    public string Name { get; set; }
}