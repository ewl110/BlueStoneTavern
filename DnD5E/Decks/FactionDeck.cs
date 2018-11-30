using DnD5E.Models;
using System.Collections.Generic;

namespace DnD5E.Decks
{
    public static class FactionDeck
    {
        public static List<FactionCard> Cards = new List<FactionCard>() {
            new FactionCard
            {
                Name = "Emerald Enclave",
                Description = "Members of the Emerald Enclave are spread far and wide, and usually operate in isolation. They learn to depend on themselves more than others. Survival in a harsh world also demands great fortitude and mastery of certain fighting and survival skills. Members of the Enclave who dedicate themselves to helping others survive the perils of the wilderness are more social than others who are charged with defending sacred glades and preserving the natural balance.",
                Summary = "a far-ranging group that opposes threats to the natural world and helps others survive the many perils of the wild",
            },
            new FactionCard
            {
                Name = "Harpers",
                Description ="Harper agents are trained to act alone and depend on their own resources. When they get into scrapes, they don’t count on their fellow Harpers to rescue them. Nevertheless, Harpers are dedicated to helping one another in times of need, and friendships between Harpers are nigh unbreakable. Masterful spies and infiltrators, they use various guises and secret identities to form relationships, cultivate their information networks, and manipulate others into doing what needs to be done. Although most Harpers prefer to operate in the shadows, there are exceptions.",
                Summary = "a clandestine organization who work against tyranny through the sharing of information and lore"
            },
            new FactionCard
            {
                Name = "Lords' Alliance",
                Description = "To seek out and destroy threats to their homelands, agents of the Lords’ Alliance must be highly trained at what they do. Few can compare to their skills in the field. They fight for the glory and the security of their people and for the lords who rule over them, and they do so with pride. However, the Lords’ Alliance can only survive if its members “play nice” with one another, which requires a certain measure of diplomacy. Rogue agents within the Lords’ Alliance are rare, but defections have been known to occur.",
                Summary = "a loose coalition of established political powers concerned with mutual security and prosperity"
            },
            new FactionCard
            {
                Name = "Order of the Gauntlet",
                Description = "The Order of the Gauntlet is a dedicated, tightly knit group of like-minded individuals driven by religious zeal or a finely honed sense of justice. Friendship and camaraderie are important to members of the Order of the Gauntlet, and they share a trust and a bond normally reserved for siblings. Like highly motivated soldiers, members of the Order of the Gauntlet seek to become the best at what they do and look forward to testing their mettle. There are few, if any, “lone wolves” in this organization.",
                Summary = "an organization dedicated to smiting evil wherever it lurks and without hesitation"
            },
            new FactionCard
            {
                Name = "Zhentarim",
                Description = "The Zhentarim seeks to become omnipresent and inescapable, more wealthy and powerful, and most importantly, untouchable. The public face of the organization appears much more benign, offering the best mercenaries money can buy. When a merchant needs an escort for his caravan, when a noble needs bodyguards to protect her holdings, or when a city needs trained soldiers to defend its honor, the Zhentarim provides the best-trained fighting men and women money can buy. However, the cost of doing business with the Black Network can be high.",
                Summary = "an organization of welltrained mercenaries, savvy rogues, and crafty warlocks who seek to expand their influence and power"
            },
        };
    }
}
