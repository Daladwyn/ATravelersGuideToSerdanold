using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ATravelersGuideToSerdan.Models.ViewModels
{
    public class NPCGenerationViewModel
    {
        [Required]
        public int NpcId { get; set; }

        [Range(0,7)]
        public byte NPCGeneration { get; set; }

        public string NpcName { get; set; }

    }

}