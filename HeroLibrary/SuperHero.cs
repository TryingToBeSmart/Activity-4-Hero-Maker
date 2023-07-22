using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroLibrary
{
    //construct Super Heros
    public class SuperHero
    {
        public string Name { get; set; }
        public List<string> Powers { get; set; }
        public string Birthday { get; set; }
        public string SuperPowerDiscovery { get; set; }
        public string BirthName { get; set; }
        public int YearsExperience { get; set; }
        public List<string> OfficeLocations { get; set; }
        public string PreferedTransport { get; set; }
        public Color PrimaryColor { get; set; }
        public int Speed { get; set; }
        public int Strength { get; set; }
        public int Stamina { get; set; }

        public SuperHero() { }
        public SuperHero(string name, List<string> powers, string birthday,
            string superPowerDiscovery, string birthName, int yearsExperience,
            List<string> officeLocations, string preferedTransport,
            Color primaryColor, int speed, int strength, int stamina)
        {
            Name = name;
            Powers = powers;
            Birthday = birthday;
            SuperPowerDiscovery = superPowerDiscovery;
            BirthName = birthName;
            YearsExperience = yearsExperience;
            OfficeLocations = officeLocations;
            PreferedTransport = preferedTransport;
            PrimaryColor = primaryColor;
            Speed = speed;
            Strength = strength;
            Stamina = stamina;
        }

        //used to test
        public override string ToString()
        {
            string hero = "Name: " + this.Name;
            hero += "\nPowers:";
            foreach (var item in Powers) { hero += " " + item; }
            hero += "\nBirthday: " + this.Birthday;
            hero += "\nSuper Power Discovery: " + this.SuperPowerDiscovery;
            hero += "\nBirth Name: " + this.BirthName;
            hero += "\nYears of Experience: " + this.YearsExperience;
            hero += "\nOffice Locations:";
            foreach (var item in OfficeLocations) {  hero += " " + item; }
            hero += "\nPrefered Transport: " + this.PreferedTransport;
            hero += "\nPrimary Color: " + this.PrimaryColor.ToString();
            hero += "\nSpeed: " + this.Speed;
            hero += "\nStrength: " + this.Strength;
            hero += "\nStamina: " + this.Stamina;

            return hero;
        }
    }
}
