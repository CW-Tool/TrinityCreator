﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityCreator
{
    public class DamageType
    {
        public DamageType(int id, string description)
        {
            Id = id;
            Description = description;
        }

        private int _id;
        private string _description;


        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }

        public override string ToString()
        {
            return Description;
        }

        public static DamageType[] GetDamageTypes()
        {
            return new DamageType[] {
                new DamageType(0, "Physical"),
                new DamageType(1, "Holy"),
                new DamageType(2, "Fire"),
                new DamageType(3, "Nature"),
                new DamageType(4, "Frost"),
                new DamageType(5, "Shadow"),
                new DamageType(6, "Arcane"),
            };
        }
    }
}