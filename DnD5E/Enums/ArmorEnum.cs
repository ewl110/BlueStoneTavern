using System.ComponentModel;

namespace DnD5E.Enums
{
    public enum ArmorEnum
    {
        Breastplate,
        [Description("Chain Mail")]
        ChainMail,
        [Description("Chain Shirt")]
        ChainShirt,
        [Description("Half Plate")]
        HalfPlate,
        [Description("Heavy Armor")]
        Heavy,
        Hide,
        Leather,
        [Description("Light Armor")]
        Light,
        [Description("Medium Armor")]
        Medium,
        Padded,
        Plate,
        [Description("Ring Mail")]
        RingMail,
        [Description("Scale Mail")]
        ScaleMail,
        Shield,
        Splint,
        [Description("Studded Leather")]
        StuddedLeather
    }
}
