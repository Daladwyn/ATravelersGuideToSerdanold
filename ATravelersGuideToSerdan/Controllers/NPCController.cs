using ATravelersGuideToSerdan.Models;
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
            List<NPC> ListOfNPCs = Db.NPCs.ToList();
            List<NPC> RequestedTypeOfNPCs = new List<NPC>();
            foreach (var NPC in ListOfNPCs)
            {
                if (NPC.NpcFamily==type)
                {
                    RequestedTypeOfNPCs.Add(NPC);
                }
            }
            
            
            return View("GetNpcs", RequestedTypeOfNPCs);
        }
    }
}