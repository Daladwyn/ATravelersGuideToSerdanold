using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ATravelersGuideToSerdan.Models.ViewModels
{
    public class NpcDiverseViewModel
    {
        [Required]
        public int NpcId { get; set; }

        [Display(Name = "Andra bostäder/platser av betydelse")]
        [MaxLength(200)]
        public string NpcOtherResideces { get; set; }

        [Display(Name = "Historia")]
        [MaxLength(300)]
        public string NpcInTheHistory { get; set; }

        [Display(Name = "Hemligheter")]
        [MaxLength(300)]
        public string NpcSecrets { get; set; }

        [Display(Name = "Tillgångar")]
        [MaxLength(200)]
        public string NpcAssets { get; set; }
    }
}