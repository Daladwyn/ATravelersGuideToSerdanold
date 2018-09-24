using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ATravelersGuideToSerdan.Models
{
    public class NpcStats
    {
        [Key]
        public int NpcStatsId { get; set; }

        [Required]
        public int NpcId { get; set; }

        public int KoordinationMotorikTot { get; set; }

        public int KoordinationMotorikUts { get; set; }
        //************************************************************
        public int WeaponValue { get; set; }

        public int WeaponTp { get; set; }

        public int WeaponExp { get; set; }

        public string WeaponTalang { get; set; }

        public int WeaponTTp { get; set; }

        public string WeaponSkills { get; set; }
        //************************************************************
        public int BalisticValue { get; set; }

        public int BalisticTp { get; set; }

        public int BalisticExp { get; set; }

        public string BalisticTalang { get; set; }

        public int BalisticTTp { get; set; }

        public string BalisticSkills { get; set; }
        //************************************************************
        public int FineMotorValue { get; set; }

        public int FineMotorTp { get; set; }

        public int FineMotorExp { get; set; }

        public string FineMotorTalang { get; set; }

        public int FineMotorTTp { get; set; }

        public string FineMotorSkills { get; set; }
        //************************************************************
        [Display(Name = "Kroppsbyggnad")]
        public int PhysiqueTot { get; set; }

        public int PhysiqueUts { get; set; }
        //************************************************************
        
        public int PhysicsValue { get; set; }

        public int PhysicsTp { get; set; }

        public int PhysicsExp { get; set; }

        public string PhysicsTalang { get; set; }

        public int PhysicsTTp { get; set; }

        public string PhysicsSkills { get; set; }
        //************************************************************
        public int StrenghtValue { get; set; }

        public int StrenghtTp { get; set; }

        public int StrenghtExp { get; set; }

        public string StrenghtTalang { get; set; }

        public int StrenghtTTp { get; set; }

        public string StrenghtSkills { get; set; }
        //************************************************************
        public int MobilityValue { get; set; }

        public int MobilityTp { get; set; }

        public int MobilityExp { get; set; }

        public string MobilityTalang { get; set; }

        public int MobilityTTp { get; set; }

        public string MobilitySkills { get; set; }
        //************************************************************
        public int PsykeTot { get; set; }

        public int PsykeUts { get; set; }
        //************************************************************
        public int WillValue { get; set; }

        public int WillTp { get; set; }

        public int WillExp { get; set; }

        public string WillTalang { get; set; }

        public int WillTTp { get; set; }

        public string WillSkills { get; set; }
        //************************************************************
        public int CreativityValue { get; set; }

        public int CreativityTp { get; set; }

        public int CreativityExp { get; set; }

        public string CreativityTalang { get; set; }

        public int CreativityTTp { get; set; }

        public string CreativitySkills { get; set; }
        //************************************************************
        public int EducationValue { get; set; }

        public int EducationTp { get; set; }

        public int EducationExp { get; set; }

        public string EducationTalang { get; set; }

        public int EducationTTp { get; set; }

        public string EducationSkills { get; set; }
        //************************************************************
        public int PerceptionTot { get; set; }

        public int PerceptionUts { get; set; }
        //************************************************************
        public int IntuitionValue { get; set; }

        public int IntuitionTp { get; set; }

        public int IntuitionExp { get; set; }

        public string IntuitionTalang { get; set; }

        public int IntuitionTTp { get; set; }

        public string IntuitionSkills { get; set; }
        //************************************************************
        public int MagicVisionValue { get; set; }

        public int MagicVisionTp { get; set; }

        public int MagicVisionExp { get; set; }

        public string MagicVisionTalang { get; set; }

        public int MagicVisionTTp { get; set; }

        public string MagicVisionSkills { get; set; }
        //************************************************************
        public int AttentionValue { get; set; }

        public int AttentionTp { get; set; }

        public int AttentionExp { get; set; }

        public string AttentionTalang { get; set; }

        public int AttentionTTp { get; set; }

        public string AttentionSkills { get; set; }
        //************************************************************
        public int SocialTot { get; set; }

        public int SocialUts { get; set; }
        //************************************************************
        public int CharismaValue { get; set; }

        public int CharismaTp { get; set; }

        public int CharismaExp { get; set; }

        public string CharismaTalang { get; set; }

        public int CharismaTTp { get; set; }

        public string CharismaSkills { get; set; }
        //************************************************************
        public int InsightValue { get; set; }

        public int InsightTp { get; set; }

        public int InsightExp { get; set; }

        public string InsightTalang { get; set; }

        public int InsightTTp { get; set; }

        public string InsightSkills { get; set; }
        //************************************************************
        public int ResistanceValue { get; set; }

        public int ResistanceTp { get; set; }

        public int ResistanceExp { get; set; }

        public string ResistanceTalang { get; set; }

        public int ResistanceTTp { get; set; }

        public string ResistanceSkills { get; set; }
        //************************************************************
        public int PhysicalDamageMax { get; set; }

        public int PhysicalDamage { get; set; }

        public int SoulDamageMax { get; set; }

        public int SoulDamage { get; set; }
        //************************************************************
        [Range(0,6)]
        public byte Draken { get; set; }

        [Range(0, 6)]
        public byte Enhorningen { get; set; }

        [Range(0, 5)]
        public byte Lakaren { get; set; }

        [Range(0, 6)]
        public byte Gripen { get; set; }

        [Range(0, 6)]
        public byte Mantikoran { get; set; }

        [Range(0, 5)]
        public byte Kroppen { get; set; }

        [Range(0, 6)]
        public byte Symbolen { get; set; }

        [Range(0, 2)]
        public byte Dorren { get; set; }

        [Range(0, 1)]
        public byte Elementa { get; set; }

        [Range(0, 6)]
        public byte Sinnets { get; set; }

        [Range(0, 5)]
        public byte Naturen { get; set; }

        [Range(0, 2)]
        public byte Djuret { get; set; }

        [Range(0, 5)]
        public byte Vattnet { get; set; }

        [Range(0, 5)]
        public byte Jorden { get; set; }

        [Range(0, 5)]
        public byte Ljuset { get; set; }

        [Range(0, 5)]
        public byte Elektricitet { get; set; }

        [Range(0, 5)]
        public byte Elden { get; set; }

        [Range(0, 5)]
        public byte Vinden { get; set; }

        [Range(0, 5)]
        public byte Morkret { get; set; }

        [Range(0, 5)]
        public byte Svardet { get; set; }

        [Range(0, 5)]
        public byte Materian { get; set; }

        public int SummaPoangKrafter { get; set; }
        //************************************************************
        [Range(0,3)]
        public byte DrakeKontakt { get; set; }

        [MaxLength(50)]
        public string DrakeKontaktVem { get; set; }

        [Range(0,3)]
        public byte GripKontakt { get; set; }

        [MaxLength(50)]
        public string GripKontaktVem { get; set; }

        [Range(0,5)]
        public byte DemonKontakt { get; set; }

        [MaxLength(50)]
        public string DemonKontaktVem { get; set; }

        [Range(0,5)]
        public byte AetKontakt { get; set; }

        [MaxLength(50)]
        public string AetKontaktVem { get; set; }

        [Range(0,4)]
        public byte SerdanKontakt { get; set; }

        [MaxLength(50)]
        public string SerdanKontaktVem { get; set; }

        [Range(0, 4)]
        public byte EdlosiKontakt { get; set; }

        [MaxLength(50)]
        public string EdlosiKontaktVem { get; set; }

        [Range(0,8)]
        public int VakandeVan { get; set; }

        [MaxLength(50)]
        public string VakandeVanVem { get; set; }

        [Range(0,5)]
        public int BraDaligtBlod { get; set; }

        public int SummaPoangKontakter { get; set; }
        //************************************************************
        public bool Visuellt { get; set; }

        public bool Symbol { get; set; }

        public bool Alkemi { get; set; }

        public bool Blod { get; set; }

        public bool Kraft { get; set; }

        public bool Verkligheten { get; set; }

        public bool Draperiet { get; set; }

        public bool Dysterheten { get; set; }

        public bool Etnor { get; set; }

        public bool Drommen { get; set; }

        public bool Slojan { get; set; }

        public bool Parallellium { get; set; }

        public bool ElementaMagi { get; set; }

        public bool Se { get; set; }

        public bool OkaMinska { get; set; }

        public bool Omvandling { get; set; }

        public bool Transformering { get; set; }

        public bool Skapa { get; set; }

        public bool Energi { get; set; }

        public bool Rum { get; set; }

        public bool Materia { get; set; }

        public bool Sinne { get; set; }

        public bool Liv { get; set; }

        public bool Sjal { get; set; }

        public bool Tid { get; set; }

        public int SummaPoangMagi { get; set; }
        //************************************************************
        public int TotalaPoang { get; set; }

        public int UtdeladePoang { get; set; }

        public int SparadePoang { get; set; }

        public int KraftPoang { get; set; }

        public int BundnaKraftPoang { get; set; }
        //************************************************************





    }
}