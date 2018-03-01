using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Librarymmh.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }


        [DataType(DataType.Date)]
        [Display(Name="Date Of Birth")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }


        [Display(Name="Street Number")]
        public string StreetNumber { get; set; }


        [Display(Name="Street Name")]
        public string StreetName { get; set; }

        [Display(Name="City")]
        public string CityName { get; set; }

        [Display(Name="Postal Code")]
        public string PostalCode { get; set; }
        public MemberShipType MemberShipType { get; set; }
        public byte MemberShipTypeId { get; set; }
        
        
    }
}