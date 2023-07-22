using HeroLibrary;

namespace Hero_Maker_Windows_Forms
{
    public partial class Form1 : Form
    {
        HeroList heroList = new HeroList();
        public Form1()
        {
            InitializeComponent();
        }

        //change color of picture box to user's selection
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pictureBox1.BackColor = colorDialog1.Color;
        }

        //speed track bar
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            SpeedLabel.Text = SpeedTrackBar.Value.ToString();

            //lower other track bars so that total < 100
            while (SpeedStrengthStaminaValue() > 100)
            {
                try
                {
                    StrengthTrackBar.Value -= 1;

                }
                catch (Exception)
                {
                }
                try
                {
                    StaminaTrackBar.Value -= 1;
                }
                catch (Exception)
                {
                }
            }
        }

        //strength track bar
        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            StrengthLabel.Text = StrengthTrackBar.Value.ToString();

            //lower other track bars so that total < 100
            while (SpeedStrengthStaminaValue() > 100)
            {
                try
                {
                    SpeedTrackBar.Value -= 1;

                }
                catch (Exception)
                {
                }
                try
                {
                    StaminaTrackBar.Value -= 1;
                }
                catch (Exception)
                {
                }
            }
        }

        //stamina track bar
        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            StaminaLabel.Text = StaminaTrackBar.Value.ToString();

            //lower other track bars so that total < 100
            while (SpeedStrengthStaminaValue() > 100)
            {
                try
                {
                    SpeedTrackBar.Value -= 1;

                }
                catch (Exception)
                {
                }
                try
                {
                    StrengthTrackBar.Value -= 1;
                }
                catch (Exception)
                {
                }
            }
        }

        //helper function to return total of all track bar values
        private int SpeedStrengthStaminaValue()
        {
            return SpeedTrackBar.Value + StrengthTrackBar.Value + StaminaTrackBar.Value;
        }

        //Create the new Hero from input
        private void CreateButton_Click(object sender, EventArgs e)
        {
            bool validInput = true;

            //create list of powers
            List<string> powersList = new List<string>();

            //make sure that text boxes are not blank
            if (HeroNameTextBox.Text.Length <= 0)
            {
                validInput = false;
                MessageBox.Show("Enter Hero Name");
            }

            if (BirthNameTextBox.Text.Length <= 0)
            {
                validInput = false;
                MessageBox.Show("Enter Birth Name");
            }

            //got the idea of getting a list from the groupbox from https://www.codeproject.com/Questions/1190690/How-to-iterate-checkboxes-held-in-groupbox-in-corr
            List<CheckBox> listOfCheckboxes = PowersGroupBox.Controls.Cast<CheckBox>().ToList();

            //add checked boxes to a list
            foreach (var box in listOfCheckboxes)
            {
                if (box.Checked) powersList.Add(box.Text);
            }

            //ensure list of powers is not blank
            if (powersList.Count <= 0)
            {
                validInput = false;
                MessageBox.Show("Select Powers"); 
            }

            //create list of office locations from listbox
            List<string> locations = new List<string>();
            if (LocationListBox.SelectedItems.Count <= 0)
            {
                validInput = false;
                MessageBox.Show("Select Office Locations");
            }
            else
            {
                foreach (var item in LocationListBox.SelectedItems)
                {
                    locations.Add(item.ToString());
                }
            }

            //get prefered transport from the radio buttons
            string transport = PreferedTransportGroupBox.Controls.Cast<RadioButton>().FirstOrDefault(r => r.Checked).Text;

            //create hero from input and then add to the Hero List
            if (validInput)
            {
                heroList.Add(new SuperHero(HeroNameTextBox.Text, powersList, BirthdayDateTimePicker.Text, DiscoveryDateTimePicker.Text,
                    BirthNameTextBox.Text, Decimal.ToInt32(ExperienceNumericUpDown.Value), locations, transport, pictureBox1.BackColor,
                    int.Parse(SpeedLabel.Text), int.Parse(StrengthLabel.Text), int.Parse(StaminaLabel.Text)));

                MessageBox.Show($"{HeroNameTextBox.Text} added to List");
            }
        }

        //show the form2 list of heros, then wait for that form to close and show the form1 create a hero again.
        private void ViewHerosButton_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(heroList);
            if (f2.DialogResult != DialogResult.Cancel) 
            {
                this.Hide();
                f2.ShowDialog();
            }

            //when the form2 closes, go back to the form1
            this.Show();
        }
    }
}