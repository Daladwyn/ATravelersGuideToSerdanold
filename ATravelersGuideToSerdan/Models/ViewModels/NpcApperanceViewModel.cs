using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ATravelersGuideToSerdan.Models.ViewModels
{
    public class NpcApperanceViewModel
    {
        [Required]
        public int NpcId { get; set; }

        [Display(Name = "Uppträdande")]
        [MaxLength(200)]
        public string NpcBehaviour { get; set; }

        [Display(Name = "Som förälder")]
        [MaxLength(200)]
        public string NpcAsAParent { get; set; }

        [Display(Name = "Mål")]
        [MaxLength(200)]
        public string NpcGoal { get; set; }

        [Display(Name = "Strid")]
        [MaxLength(200)]
        public string NpcInBattle { get; set; }

    }
}