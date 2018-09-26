using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ATravelersGuideToSerdan.Models.ViewModels
{
    public class NpcRelativesViewModel
    {
        [Required]
        public int NpcId { get; set; }

        [Display(Name = "Mor")]
        public int NpcsMother { get; set; }

        [Display(Name = "Far")]
        public int NpcsFather { get; set; }

        [Display(Name = "Serdan/Edlosi barn")]
        public List<int> NpcsSerdanEdlosiChildren { get; set; }

        [Display(Name = "Vanliga Barn")]
        public List<int> NpcsRegularChildren { get; set; }
    }

}