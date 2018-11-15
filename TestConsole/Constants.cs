using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsole.Enums;

namespace TestConsole
{
    public static class Consts
    {
        public static readonly int[] ABILITY_SCORES = { 10, 10, 10, 10, 10, 10 };
        public const int LEVEL = 1;
        public const int MAX_LEVEL = 20;
        public const int XP = 0;

        public static class Dragonborn
        {
            public static readonly int[] ASI = {2, 0, 0, 0, 0, 1};
            public static readonly string[] LANGUAGES = { "Common", "Draconic" };
            public static Sizes SIZE = Sizes.Medium;
            public static int SPEED = 30;
        }

        public static class Human
        {
            public static readonly string[] LANGUAGES = { "Common", "+1" };
            public static Sizes SIZE = Sizes.Medium;
            public static int SPEED = 30;
        }

        public static class HumanStandard
        {
            public static readonly int[] ASI = { 1, 1, 1, 1, 1, 1 };
        }

        public static class HumanVariant
        {
            public static readonly int[] ASI = { 0, 0, 0, 0, 0, 0 };
            public static readonly List<string> FEATS = new List<string>(){"+1"};
            public static readonly List<string> SKILLS = new List<string>() { "+1" };
        }
    }
}
