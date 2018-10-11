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

        public ActionResult GetNpcs(string type)
        {
            ViewBag.Title = type;
            List<NPC> ListOfNPCs = Db.NPCs.ToList();
            List<NPC> RequestedTypeOfNPCs = new List<NPC>();
            foreach (var NPC in ListOfNPCs)
            {
                if (NPC.NpcFamily == type)
                {
                    RequestedTypeOfNPCs.Add(NPC);
                }
            }


            return View("_GetNpcList", RequestedTypeOfNPCs);


        }

        public ActionResult GetNpc(int Id)
        {
            NPCCompleteStatsViewModel ASpecificNpcData = new NPCCompleteStatsViewModel();

            return PartialView("_SpecificNpc", ASpecificNpcData);
        }

        public ActionResult GetStats(int Id)
        {
            NpcStatsViewModel NpcStats = new NpcStatsViewModel();

            return PartialView("_GetStats", NpcStats);
        }

        public ActionResult GetApperance(int Id)
        {
            NpcApperanceViewModel NpcApperance = new NpcApperanceViewModel();
            return PartialView("_GetApperance", NpcApperance);
        }

        public ActionResult GetRelatives(int Id)
        {
            NPC NpcToFetch = Db.NPCs.SingleOrDefault(i => i.NpcId == Id);
            if (NpcToFetch == null)
            {
                return PartialView("_GetRelatives");
            }
            NpcRelativesViewModel NpcRelatives = new NpcRelativesViewModel();
            NpcRelatives.NpcId = NpcToFetch.NpcId;
            NpcRelatives.NpcsFather = NpcToFetch.NpcsFather;
            NpcRelatives.NpcsMother = NpcToFetch.NpcsMother;
            NpcRelatives.NpcsRegularChildren = NpcToFetch.NpcsRegularChildren;
            NpcRelatives.NpcsSerdanEdlosiChildren = NpcToFetch.NpcsSerdanEdlosiChildren;
            return PartialView("_GetRelatives", NpcRelatives);
        }

        public ActionResult GetOthers(int Id)
        {
            NPC NpcToFetch = Db.NPCs.SingleOrDefault(i => i.NpcId == Id);
            if (NpcToFetch == null)
            {
                return PartialView("_GetOthers");
            }
            NpcOthersViewModel NpcOthers = new NpcOthersViewModel();
            NpcOthers.NpcId = NpcToFetch.NpcId;
            NpcOthers.NpcAllies = NpcToFetch.NpcAllies;
            NpcOthers.NpcEnemies = NpcToFetch.NpcEnemies;
            NpcOthers.NpcFriends = NpcToFetch.NpcFriends;
            NpcOthers.NpcRegardingAets = NpcToFetch.NpcRegardingAets;
            NpcOthers.NpcRegardingDemons = NpcToFetch.NpcRegardingDemons;
            NpcOthers.NpcRegardingDragons = NpcToFetch.NpcRegardingDragons;
            NpcOthers.NpcRegardingGrips = NpcToFetch.NpcRegardingGrips;
            NpcOthers.NpcRegardingOthers = NpcToFetch.NpcRegardingOthers;
            NpcOthers.NpcRivals = NpcToFetch.NpcRivals;
            return PartialView("_GetOthers", NpcOthers);
        }

        public ActionResult GetDiverse(int Id)
        {
            NpcDiverseViewModel NpcDiverse = new NpcDiverseViewModel();
            return PartialView("_GetDiverse", NpcDiverse);
        }
    }
}