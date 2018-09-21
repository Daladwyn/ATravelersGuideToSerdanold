using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ATravelersGuideToSerdan.Models
{
    public class Place
    {
        [Key]
        public int PlaceId { get; set; }

        [Required]
        [MaxLength(40)]
        public string PlaceName { get; set; }

        public int CityId{ get; set; }

        [MaxLength(200)]
        public string PlaceDescription { get; set; }
    }
}