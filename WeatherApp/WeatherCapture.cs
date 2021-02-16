using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class WeatherCapture : Form
    {
        public WeatherCapture()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            refreshUI();
        }

        // This method is used to save a weather and clears the form for new entry
        private void btnSave_Click(object sender, EventArgs e)
        {
            saveWeather();
            refreshUI();
        }

        // This method displays the captured information that has been set by the forcaster
        private void btnView_Click(object sender, EventArgs e)
        {
            this.Hide();
            WeatherReport form = new WeatherReport();
            form.ShowDialog();
        }

        // This button deletes any forcast that the user wishes to remove from the list
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d;
                string msg = "Are you sure you want to Delete this Forcast ?";
                string title = "Weather Report";

                if (lstCities.SelectedItem.Equals(""))
                {
                    MessageBox.Show("Select a City you Wish to Delete");
                }
                else
                {

                    d = MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (d == DialogResult.Yes)
                    {
                        lstCities.Items.RemoveAt(lstCities.SelectedIndex);
                        WeatherWorker.weathersList.RemoveAt(lstCities.SelectedIndex);
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Select a City you Wish to remove from the list");

            }
        }

        // This method clears all the fields that have been populated by the forcaster
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (lstCities.Items != null)
            {
                lstCities.Items.Clear();
            }
            else
            {
                MessageBox.Show("The List Box is Empty");
            }

        }

        // This method is used to store the value into a list of objects and converts it to a type that is acceptable by the constructor
        private void saveWeather()
        {
            try
            {
                string city = txtCity.Text;
                DateTime date = Convert.ToDateTime(dtpDate.Value);
                int min = Convert.ToInt32(txtMin.Text);
                int max = Convert.ToInt32(txtMax.Text);
                int prec = Convert.ToInt32(txtPrec.Text);
                int hum = Convert.ToInt32(numUpDownHum.Text);
                int wind = Convert.ToInt32(numUpDownWind.Text);

                Weather weather = new Weather(city, date, min, max, prec, hum, wind);
                WeatherWorker.weathersList.Add(weather);

                string title = "Weather Forcast";
                string message = "Saved !" + "\n\n" + "Add another CITY or VIEW the Weather report";
                MessageBox.Show(message, title);

            }
            catch (Exception)
            {
                MessageBox.Show("Please Populate Empty fields");
            }

        }

        // this method clears the form for new entry and adds the captured weather to the list box
        public void refreshUI()
        {
            txtCity.Clear();
            dtpDate.ResetText();
            txtMin.Clear();
            txtMax.Clear();
            numUpDownHum.ResetText();
            txtPrec.Clear();
            numUpDownWind.ResetText();

            WeatherWorker.weathersList.Sort();
            lstCities.Items.Clear();
            foreach (Weather item in WeatherWorker.weathersList)
            {
                lstCities.Items.Add(item.City + " " + item.Date);
            }
        }


    }
}
