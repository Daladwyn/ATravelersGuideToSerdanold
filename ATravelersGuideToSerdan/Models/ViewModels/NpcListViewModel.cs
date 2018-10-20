using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ATravelersGuideToSerdan.Models.ViewModels
{
    public class NpcListViewModel
    {
        [Required]
        public int NpcId { get; set; }

        [Required]
        public string NpcName { get; set; }
    }
}