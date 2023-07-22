using HeroLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hero_Maker_Windows_Forms
{
    public partial class Form2 : Form
    {
        HeroList Heros;
        public Form2(HeroList heros)
        {
            InitializeComponent();
            Heros = heros;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            //add all created Heros into the Listbox
            foreach (var hero in Heros)
            {
                HerosListBox.Items.Add(hero);
            }
            HerosListBox.DisplayMember = "Name";//only display the hero's name property
            HeroTriatsListBox.SelectionMode = SelectionMode.None;//not selectable


        }

        //add selected hero's traits to the list box
        private void HerosListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            HeroTriatsListBox.Items.Clear();
            SuperHero hero = Heros.Get(HerosListBox.SelectedIndex);
            HeroTriatsListBox.Items.Add("Name: " + hero.Name);
            HeroTriatsListBox.Items.Add("Powers:");
            foreach (var item in hero.Powers) { HeroTriatsListBox.Items.Add("  " + item); }
            HeroTriatsListBox.Items.Add("Birthday: " + hero.Birthday);
            HeroTriatsListBox.Items.Add("Super Power Discovery: " + hero.SuperPowerDiscovery);
            HeroTriatsListBox.Items.Add("Birth Name: " + hero.BirthName);
            HeroTriatsListBox.Items.Add("Years of Experience: " + hero.YearsExperience);
            HeroTriatsListBox.Items.Add("Office Locations:");
            foreach (var item in hero.OfficeLocations) { HeroTriatsListBox.Items.Add("  " + item); }
            HeroTriatsListBox.Items.Add("Prefered Transport: " + hero.PreferedTransport);
            HeroTriatsListBox.Items.Add("Primary Color: " + hero.PrimaryColor.ToString());
            HeroTriatsListBox.Items.Add("Speed: " + hero.Speed);
            HeroTriatsListBox.Items.Add("Strength: " + hero.Strength);
            HeroTriatsListBox.Items.Add("Stamina: " + hero.Stamina);
        }

        //close form2, same as exit button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
