//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using TestConsole.Models;

//namespace TestConsole.Dictionaries.PHB
//{
//    public class Races
//    {
//        public static Dictionary<string, Race> Core()
//        {
//            Dictionary<string, Race> core = new Dictionary<string, Race>();

//            core.Add("Human", new Race()
//            {
//                Languages = new List<string>() { "Common", "+1" },
//                Size = "Medium",
//                Speed = 30
//            });

//            core.Add("HumanStandard", new Race()
//            {
//                Asi = "1,1,1,1,1,1"
//            });

//            core.Add("HumanVariant", new Race()
//            {
//                Asi = "0,0,0,0,0,0",
//                Feats = new List<string>() { "+1" },
//                Skills = new List<string>() {"+1"}
//            });

//            return core;
//        }

//        //public static Dictionary<string, Race> Expanded()
//        //{
//        //    //Dictionary<string, Race> expanded = new Dictionary<string, Race>();

//        //    //expanded.Add("Half Elf", new Race()
//        //    //{
//        //    //    Name = "Human"
//        //    //});

//        //    //return expanded;
//        //}
//    }
//}
