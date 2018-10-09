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
            NpcRelativesViewModel NpcRelatives = new NpcRelativesViewModel();
            return PartialView("_GetRelatives", NpcRelatives);
        }

        public ActionResult GetOthers(int Id)
        {
            NpcOthersViewModel NpcOthers = new NpcOthersViewModel();
            return PartialView("_GetOthers", NpcOthers);
        }

        public ActionResult GetDiverse(int Id)
        {
            NpcDiverseViewModel NpcDiverse = new NpcDiverseViewModel();
            return PartialView("_GetDiverse", NpcDiverse);
        }
    }
}