namespace ATravelersGuideToSerdan.Migrations
{
    using ATravelersGuideToSerdan.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ATravelersGuideToSerdan.Models.SerdanDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ATravelersGuideToSerdan.Models.SerdanDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.NPCs.AddOrUpdate(i => i.NpcName,
                new NPC
                {
                    NpcName = "David",
                    NpcEvenKnownAs = "Farbror Blå",
                    NpcAlias = "FarFar",
                    NpcDescriptivePhrase = "David är urfadern för alla Serdan.",
                    NpcLooks = "En äldre man med vit skägg.",
                    NpcDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    NpcCurrentResidence = "Aisela",
                    NpcRace = "Serdan",
                    NpcIsAPlayer = false,
                    NpcFamily = "Serdan",
                    NpcArchetyp = 1,
                    NpcKilledBy = 0,
                    NpcBehaviour = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    NpcAsAParent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    NpcGoal = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    NpcInBattle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    NpcsMother = 4,
                    NpcsFather = 3,
                    //NpcsSerdanEdlosiChildren = { 10, 11, 12, 13 },
                    //NpcsRegularChildren = { 100, 101, 102 },
                    NpcRegardingAets = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    NpcRegardingDemons = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    NpcRegardingDragons = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    NpcRegardingGrips = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    NpcRegardingOthers = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    //NpcFriends = { 4, 3 },
                    //NpcAllies = { 4, 3 },
                    //NpcRivals = { 50, 51, 52, 53, 54 },
                    //NpcEnemies = { 60, 61, 62 },
                    NpcOtherResideces = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    NpcInTheHistory = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    NpcSecrets = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    NpcAssets = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
                },
                new NPC
                {
                    NpcName = "Xara",
                    NpcEvenKnownAs = "Mormor Röd",
                    NpcAlias = "MorMor",
                    NpcDescriptivePhrase = "Xara är urmodern för alla Edlosi.",
                    NpcLooks = "En äldre kvinna med vit långt hår.",
                    NpcDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    NpcCurrentResidence = "Kalandri",
                    NpcRace = "Edlosi",
                    NpcIsAPlayer = false,
                    NpcFamily = "Edlosi",
                    NpcArchetyp = 1,
                    NpcKilledBy = 0,
                    NpcBehaviour = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    NpcAsAParent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    NpcGoal = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    NpcInBattle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    NpcsMother = 10,
                    NpcsFather = 11,
                    //NpcsSerdanEdlosiChildren = { 14, 15, 16, 17 },
                    //NpcsRegularChildren = { 103, 104, 105 },
                    NpcRegardingAets = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    NpcRegardingDemons = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    NpcRegardingDragons = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    NpcRegardingGrips = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    NpcRegardingOthers = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    //NpcFriends = { 10, 11 },
                    //NpcAllies = { 10, 11 },
                    //NpcRivals = { 50, 51, 52, 53, 54 },
                    //NpcEnemies = { 60, 61, 62 },
                    NpcOtherResideces = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    NpcInTheHistory = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    NpcSecrets = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    NpcAssets = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."

                });
            context.SaveChanges();
        }
    }
}
