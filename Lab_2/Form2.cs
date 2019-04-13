using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Xml.Serialization;
namespace Lab_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void F2_Search_Click(object sender, EventArgs e)
        {
            if (Length.Text.Equals("") && Number_Of_Room.Text.Equals("") && Floor.Text.Equals(""))
            {
                MessageBox.Show("Please enter data to search");
            }
            XmlSerializer formatter = new XmlSerializer(typeof(House[]));
            using (FileStream fs = new FileStream("House.xml", FileMode.OpenOrCreate))
            {
                House[] newhouse = (House[])formatter.Deserialize(fs);
                Regex regex = new Regex("1");
                MatchCollection matches = regex.Matches(Length.Text);
                if (matches.Count > 0)
                {
                    foreach (Match match in matches)
                        MessageBox.Show("Эл-т найден, номер в таблице: " + match.Value);
                }
                else
                {
                    MessageBox.Show("Совпадений не найдено");
                }

                //foreach (House h in newhouse)
                //{

                //    if(Length.Text == h.Length_of_House && Number_Of_Room.Text == h.Number_of_Rooms && Floor.Text == h.Flat)
                //    {
                //        MessageBox.Show("This element is found");
                //    }   
                //}
                //}
            }
        }
    }
}
