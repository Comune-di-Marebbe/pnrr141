﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels;

public partial class HOME_Document_Document_Type
{
    [Key]
    public Guid ID { get; set; }

    public Guid? HOME_Document_ID { get; set; }

    public Guid? HOME_Document_Type_ID { get; set; }
}