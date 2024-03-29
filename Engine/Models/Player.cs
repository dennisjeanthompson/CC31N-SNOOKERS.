﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Player : BaseNotifcationClass
    {
        private int _gold;
        private int _level;
        private int _hitPoints;
        private string? _characterClass;
        private string? _name;
        private int _experiencePoints;
      public  string? Name {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
      public  string? CharacterClass{
            get 
            {
                return _characterClass;
            }
            set 
            {
                _characterClass = value;
                OnPropertyChanged(nameof(CharacterClass));



    }
        }
      public  int HitPoints {
            get 
            {
                return _hitPoints;
            }
            set 
            {
                _hitPoints = value;
                OnPropertyChanged(nameof(HitPoints));
            }
        }
       public int ExperiencePoints
        {
            get
            {
                return _experiencePoints;
            }
            set
            {
                _experiencePoints = value;
                OnPropertyChanged(nameof(ExperiencePoints));
            }
        }
        public int Level 
        {
            get
            {
                return _level;
            }
            set 
            {
                _level = value;
                OnPropertyChanged(nameof(Level));
            }
        }
        public  int Gold {
            get
            {
                return _gold;
            }
            set
            {
                _gold = value;
                OnPropertyChanged(nameof(Gold));
            }
        }

       
    }
}
