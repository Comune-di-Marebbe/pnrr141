﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace ICWebApp.Domain.DBModels
{
    public partial class V_HOME_Theme
    {
        [NotMapped]
        private bool _checked = false;
        [NotMapped]
        public bool Checked 
        {
            get
            {
                return _checked;
            }
            set
            {
                _checked = value;
                OnNotifyChecked();
            } 
        }
        public event Action OnChecked;
        private void OnNotifyChecked() => OnChecked?.Invoke();
    }
}