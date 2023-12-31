﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BCMS.Models
{
    public partial class Blog
    {
        public Blog()
        {
            Media = new HashSet<Media>();
        }

        [Key]
        [StringLength(10)]
        public string BlogId { get; set; }
        [Required]
        public string BlogTitle { get; set; }
        [Required]
        public string BlogDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Datetime { get; set; }
        public bool Status { get; set; }
        [Required]
        [StringLength(10)]
        public string ManagerId { get; set; }

        [ForeignKey("ManagerId")]
        [InverseProperty("Blog")]
        public virtual Manager Manager { get; set; }
        [InverseProperty("Blog")]
        public virtual ICollection<Media> Media { get; set; }
    }
}