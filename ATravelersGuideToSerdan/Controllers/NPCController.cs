using ATravelersGuideToSerdan.Models;
using ATravelersGuideToSerdan.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATravelersGuideToSerdan.Controllers
{
    public class NPCController : Controller
    {
        private SerdanDb Db;

        public NPCController()
        {
            Db = new SerdanDb();
        }

        // GET: NPC
        public ActionResult NPCIndex()
        {
            return View();
        }

        public ActionResult GetNpcs([Bind(Include = "race")]string race)
        {
            ViewBag.Title = race;
            List<NPC> ListOfNPCs = Db.NPCs.ToList();
            List<NPC> RequestedTypeOfNPCs = new List<NPC>();
            List<NpcGeneralViewModel> ConvertedNpcData = new List<NpcGeneralViewModel>();
            NpcGeneralViewModel aConvertedNpc = new NpcGeneralViewModel();
            foreach (var NPC in ListOfNPCs)
            {
                if (NPC.NpcRace == race)
                {
                    RequestedTypeOfNPCs.Add(NPC);
                }
            }
            foreach (var NPC in RequestedTypeOfNPCs)
            {
                aConvertedNpc.NpcId = NPC.NpcId;
                aConvertedNpc.NpcName = NPC.NpcName;
                ConvertedNpcData.Add(aConvertedNpc);
            }

            return View("_GetNpcList", ConvertedNpcData);


        }

        public ActionResult GetNpc([Bind(Include= "Id")]int Id)
        {
            NPC selectedNpc = Db.NPCs.SingleOrDefault(i => i.NpcId == Id);
            NpcGeneralViewModel ASpecificNpcData = new NpcGeneralViewModel
            {
                NpcId = selectedNpc.NpcId,
                NpcName = selectedNpc.NpcName,
                NpcEvenKnownAs = selectedNpc.NpcEvenKnownAs,
                NpcAlias = selectedNpc.NpcAlias,
                NpcDescriptivePhrase = selectedNpc.NpcDescriptivePhrase,
                NpcArchetyp = selectedNpc.NpcArchetyp,
                NpcCurrentResidence = selectedNpc.NpcCurrentResidence,
                NpcDescription = selectedNpc.NpcDescription,
                NpcFamily = selectedNpc.NpcFamily,
                NpcKilledBy = selectedNpc.NpcKilledBy,
                NpcLooks = selectedNpc.NpcLooks
            };
            return PartialView("_SpecificNpc", ASpecificNpcData);
        }

        [HttpPost]
        public ActionResult GetStats([Bind(Include = "Id")]int Id)
        {
            NpcStat NpcToFetch = Db.NpcStats.SingleOrDefault(i => i.NpcId == Id);
            if (NpcToFetch == null)
            {
                ViewBag.ErrorMessage = "No Npc was fetched.";
                return PartialView("_GetStats");
            }
            NpcStatsViewModel NpcStats = NpcStatsViewModel.AssignStatsData(NpcToFetch); ;

            return PartialView("_GetStats", NpcStats);
        }

        [HttpPost]
        public ActionResult GetApperance([Bind(Include = "Id")]int Id)
        {
            NPC NpcToFetch = Db.NPCs.SingleOrDefault(i => i.NpcId == Id);
            if (NpcToFetch == null)
            {
                ViewBag.ErrorMessage = "No Npc was fetched.";
                return PartialView("_GetApperance");
            }
            NpcApperanceViewModel NpcApperance = NpcApperanceViewModel.AssignApperanceData(NpcToFetch);
            return PartialView("_GetApperance", NpcApperance);
        }

        [HttpPost]
        public ActionResult GetRelatives([Bind(Include = "Id")]int Id)
        {
            NPC NpcToFetch = Db.NPCs.SingleOrDefault(i => i.NpcId == Id);
            if (NpcToFetch == null)
            {
                return PartialView("_GetRelatives");
            }
            NpcRelativesViewModel NpcRelatives = NpcRelativesViewModel.AssignRelativesData(NpcToFetch);
            return PartialView("_GetRelatives", NpcRelatives);
        }

        [HttpPost]
        public ActionResult GetOthers([Bind(Include = "Id")]int Id)
        {
            NPC NpcToFetch = Db.NPCs.SingleOrDefault(i => i.NpcId == Id);
            if (NpcToFetch == null)
            {
                return PartialView("_GetOthers");
            }
            NpcOthersViewModel NpcOthers = NpcOthersViewModel.AssignOthersData(NpcToFetch);
            return PartialView("_GetOthers", NpcOthers);
        }
        [HttpPost]
        public ActionResult GetDiverse([Bind(Include = "Id")]int Id)
        {
            NPC NpcToFetch = Db.NPCs.SingleOrDefault(i => i.NpcId == Id);
            if (NpcToFetch == null)
            {
                return PartialView("_GetDiverse");
            }
            NpcDiverseViewModel NpcDiverse = NpcDiverseViewModel.AssignDiverseData(NpcToFetch);
            return PartialView("_GetDiverse", NpcDiverse);
        }
    }
}