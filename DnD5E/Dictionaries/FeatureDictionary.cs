﻿using DnD5E.Enums;
using DnD5E.Models;
using System.Collections.Generic;
using System.ComponentModel;

namespace DnD5E.Dictionaries
{
    public static class FeatureDictionary
    {
        public static Dictionary<string, FeaturesModel> List = new Dictionary<string, FeaturesModel>()
        {
            {
                FeaturesEnum.brutalCritical.ToString(),
                new FeaturesModel
                {
                    Class = new List<ClassEnum>() {
                        ClassEnum.Barbarian
                    },
                    Key = FeaturesEnum.brutalCritical.ToString(),
                    Name = FeaturesEnum.brutalCritical.GetAttributeOfType<DescriptionAttribute>().Description
                }
            },
            {
                FeaturesEnum.dangerSense.ToString(),
                new FeaturesModel
                {
                    Class = new List<ClassEnum>() {
                        ClassEnum.Barbarian
                    },
                    Key = FeaturesEnum.dangerSense.ToString(),
                    Name = FeaturesEnum.dangerSense.GetAttributeOfType<DescriptionAttribute>().Description
                }
            },
            {
                FeaturesEnum.extraAttack.ToString(),
                new FeaturesModel
                {
                    Class = new List<ClassEnum>() {
                        ClassEnum.Barbarian
                    },
                    Key = FeaturesEnum.extraAttack.ToString(),
                    Name = FeaturesEnum.extraAttack.GetAttributeOfType<DescriptionAttribute>().Description
                }
            },
            {
                FeaturesEnum.fastMovement.ToString(),
                new FeaturesModel
                {
                    Class = new List<ClassEnum>() {
                        ClassEnum.Barbarian
                    },
                    Key = FeaturesEnum.fastMovement.ToString(),
                    Name = FeaturesEnum.fastMovement.GetAttributeOfType<DescriptionAttribute>().Description
                }
            },
            {
                FeaturesEnum.feralInstinct.ToString(),
                new FeaturesModel
                {
                    Class = new List<ClassEnum>() {
                        ClassEnum.Barbarian
                    },
                    Key = FeaturesEnum.feralInstinct.ToString(),
                    Name = FeaturesEnum.feralInstinct.GetAttributeOfType<DescriptionAttribute>().Description
                }
            },
            {
                FeaturesEnum.indomitableMight.ToString(),
                new FeaturesModel
                {
                    Class = new List<ClassEnum>() {
                        ClassEnum.Barbarian
                    },
                    Key = FeaturesEnum.indomitableMight.ToString(),
                    Name = FeaturesEnum.indomitableMight.GetAttributeOfType<DescriptionAttribute>().Description
                }
            },
            {
                FeaturesEnum.persistentRage.ToString(),
                new FeaturesModel
                {
                    Class = new List<ClassEnum>() {
                        ClassEnum.Barbarian
                    },
                    Key = FeaturesEnum.persistentRage.ToString(),
                    Name = FeaturesEnum.persistentRage.GetAttributeOfType<DescriptionAttribute>().Description
                }
            },
            {
                FeaturesEnum.primalChampion.ToString(),
                new FeaturesModel
                {
                    Class = new List<ClassEnum>() {
                        ClassEnum.Barbarian
                    },
                    Key = FeaturesEnum.primalChampion.ToString(),
                    Name = FeaturesEnum.primalChampion.GetAttributeOfType<DescriptionAttribute>().Description
                }
            },
            {
                FeaturesEnum.rage.ToString(),
                new FeaturesModel
                {
                    Class = new List<ClassEnum>() {
                        ClassEnum.Barbarian
                    },
                    Key = FeaturesEnum.rage.ToString(),
                    Name = FeaturesEnum.rage.GetAttributeOfType<DescriptionAttribute>().Description
                }
            },
            {
                FeaturesEnum.recklessAttack.ToString(),
                new FeaturesModel
                {
                    Class = new List<ClassEnum>() {
                        ClassEnum.Barbarian
                    },
                    Key = FeaturesEnum.recklessAttack.ToString(),
                    Name = FeaturesEnum.recklessAttack.GetAttributeOfType<DescriptionAttribute>().Description
                }
            },
            {
                FeaturesEnum.relentlessRage.ToString(),
                new FeaturesModel
                {
                    Class = new List<ClassEnum>() {
                        ClassEnum.Barbarian
                    },
                    Key = FeaturesEnum.relentlessRage.ToString(),
                    Name = FeaturesEnum.relentlessRage.GetAttributeOfType<DescriptionAttribute>().Description
                }
            },
            {
                FeaturesEnum.unarmoredDefenceBarbarian.ToString(),
                new FeaturesModel
                {
                    Class = new List<ClassEnum>() {
                        ClassEnum.Barbarian
                    },
                    Key = FeaturesEnum.unarmoredDefenceBarbarian.ToString(),
                    Name = FeaturesEnum.unarmoredDefenceBarbarian.GetAttributeOfType<DescriptionAttribute>().Description
                }
            }
        };
    }
}
