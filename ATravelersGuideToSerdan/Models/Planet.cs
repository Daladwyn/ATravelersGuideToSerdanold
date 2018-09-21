﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ATravelersGuideToSerdan.Models
{
    public class Planet
    {
        [Key]
        public int PlanetId { get; set; }

        [Required]
        [MaxLength(40)]
        public string PlanetName { get; set; }

        public int PlanetRulerId { get; set; }

        public List<int> PlanetsCountries { get; set; }

        [MaxLength(100)]
        public string DistanceToGalo { get; set; }

        [MaxLength(200)]
        public string PlanetDescription { get; set; }
    }
}