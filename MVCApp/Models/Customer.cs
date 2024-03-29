﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "BirthDate")]
        public DateTime? BirthDate { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }

        public MembershipType MembershipType { get; set; }
        [Display(Name = "Membership Type")]

        public byte MemberShipTypeId { get; set; }
    }
}