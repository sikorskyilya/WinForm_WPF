using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Text.RegularExpressions;
namespace Lab_2
{
    public partial class AnotherMaterial : Form
    {
        List<House> houses = new List<House>();
        public AnotherMaterial()
        {
            InitializeComponent();
        }
        private void Go_Click(object sender, EventArgs e)
        {
            bool flagRoom = false, flagMaterial = false ;
            List<string> room = new List<string>();
            List<string> material = new List<string>();
            try
            {
                #region Rooms
                if (this.bath.Checked == true)
                {
                    room.Add("Ванная");
                    flagRoom = true;
                }
                if (this.kitchen.Checked == true)
                {
                    room.Add("Кухня");
                    flagRoom = true;
                }
                if (this.toilet.Checked == true)
                {
                    room.Add("Туалет");
                    flagRoom = true;
                }
                if (this.balcony.Checked == true)
                {
                    room.Add("Балкон");
                    flagRoom = true;
                }
                if (this.basement.Checked == true)
                {
                    room.Add("Подвал");
                    flagRoom = true;
                }
                #endregion
                #region Material
                if (this.TreeMaterial.Checked == true)
                {
                    material.Add("Дерево");
                    flagMaterial = true;
                }
                if (this.BlockMaterial.Checked == true)
                {
                    material.Add("Блок");
                    flagMaterial = true;
                }
                if (this.AnotherM.Checked == true)
                {
                    material.Add("Другое");
                    flagMaterial = true;
                }
                #endregion
                if (this.Length.Text.Equals("") || this.NumberOfRoom.Text.Equals("") || flagRoom == false || flagMaterial == false || this.Year.Text.Equals("")
                    || this.FloatNumber.Text.Equals(""))
                {
                    MessageBox.Show("information isn't found");
                }
                else
                {
                    //textBox1.Text = "Length of house: " + this.Length.Text + "\nNumber of room: " + this.NumberOfRoom.Text + "\nYear: " + 
                       //this.Year.Text + "\nMaterial: " + material.First() + "\nFloat: " + this.FloatNumber.Text;
                    House house = new House(this.Length.Text, NumberOfRoom.Text, this.Year.Text, material, this.FloatNumber.Text, room);
                    houses.Add(house);
                    XmlSerializeWrapper.Serialize(houses, "House.xml");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }
        private void Clear_House_Click(object sender, EventArgs e)
        {
            this.Length.Clear();
            this.NumberOfRoom.Clear();
            this.kitchen.Checked = this.balcony.Checked = this.toilet.Checked = this.basement.Checked = this.bath.Checked = false;
            this.Year.Clear();
            this.Country.Clear();
            this.City.Clear();
            this.street.Clear();
            this.NumberOfHouse.Clear();
            this.apartment.Clear();
            
        }

        private void ToFile_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch
            {

            }
        }
        private void Label5_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public static class XmlSerializeWrapper
        {
            public static void Serialize<T>(T obj, string filename)
            {
                XmlSerializer formatter = new XmlSerializer(typeof(T));
                using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, obj);
                }
            }
            public static T Deserialize<T>(string filename)
            {
                T obj;
                using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
                {
                    XmlSerializer formatter = new XmlSerializer(typeof(T));
                    obj = (T)formatter.Deserialize(fs);
                }
                return obj;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by\nIlya Sikorsky");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            var result = from u in houses
                         orderby u.Length_of_House
                         select u;
            foreach (House u in result)
               MessageBox.Show(u.Length_of_House);
            XmlSerializeWrapper.Serialize(houses, "House.xml");
        }
    }
}
