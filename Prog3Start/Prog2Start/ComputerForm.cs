//5436514
//Program 3
//Nov 17 2023
//CIS 200 75 4238
//Using the techer provided program from Program 2 the inputs in the form are saved and loaded in and out of Xml formatter
// unsure of what to do after recieving errot that the Prog3Start file is private(saving and load would not work because of this)

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;


namespace Prog3Start
{
    public partial class computerViewForm : Form
    {
        public computerViewForm()
        {
            InitializeComponent();
        }

      internal List<Computer> computers = new List<Computer>();

        private void detailsButton_Click(object sender, EventArgs e)
        {
            if (compListView.SelectedIndices.Count >= 1)
            {
                int selectedIndex = compListView.SelectedIndices[0];

                MessageBox.Show(computers[selectedIndex].ToString());
            }
            else
            {
                MessageBox.Show("No Item Selected", "No Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Grading ID: XXXXXXX, Section 75");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void laptopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaptopForm laptopCreate = new LaptopForm();
            laptopCreate.ShowDialog();
            if (laptopCreate.DialogResult == DialogResult.OK)
            {
                Laptop created = laptopCreate.CreatedLaptop;

                string[] listItem = { created.Manufacturer, created.CalcTDP().ToString(), "Laptop" };

                ListViewItem toAdd = new ListViewItem(listItem);

                compListView.Items.Add(toAdd);
                computers.Add(created);
            }
            laptopCreate.Dispose();

        }

        private void allInOneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllInOneForm aioCreate = new AllInOneForm();
            aioCreate.ShowDialog();
            if (aioCreate.DialogResult == DialogResult.OK)
            {
                AllInOne created = aioCreate.CreatedAllInOne;

                string[] listItem = { created.Manufacturer, created.CalcTDP().ToString(), "All In One" };

                ListViewItem toAdd = new ListViewItem(listItem);

                compListView.Items.Add(toAdd);
                computers.Add(created);
            }
            aioCreate.Dispose();
        }

        private void towerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TowerForm towerCreate = new TowerForm();
            towerCreate.ShowDialog();
            if (towerCreate.DialogResult == DialogResult.OK)
            {
                Tower created = towerCreate.CreatedTower;
                string[] listItem = { created.Manufacturer, created.CalcTDP().ToString(), "Tower" };

                ListViewItem toAdd = new ListViewItem(listItem);

                compListView.Items.Add(toAdd);
                computers.Add(created);
            }
            towerCreate.Dispose();

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)//save is clicked on
        {
            string filename = "computers.xml"; //file to save too

            XmlDocument computerDocument = new XmlDocument();
            XmlSerializer computerSerializer = new XmlSerializer(computers.GetType());//typeof(List<Computer>)


            using (MemoryStream computerStream = new MemoryStream())
            {
                computerSerializer.Serialize(computerStream, computers);
                computerStream.Position = 0;// limit redundance/ override
                computerDocument.Load(computerStream);
                computerDocument.Save(filename); //save data to file name
                computerStream.Close();//end stream
            }
            MessageBox.Show("Save Successful!", "Successful!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);// save is successful
        }

            private void loadToolStripMenuItem_Click(object sender, EventArgs e)// load is clicked on 
            {
            string filename = "computers.xml"; //file to save too

            XmlDocument computerDocument = new XmlDocument();
            computerDocument.Load(filename);//loading computer.xml

            string rawXml = computerDocument.OuterXml;//retrieving raw xml data

            try
            {
                using(StringReader computerStringReader = new StringReader(rawXml))
                {
                    Type computerType= computers.GetType();//verifying type

                    XmlSerializer computerDeserializer = new XmlSerializer(computerType);

                    using (XmlReader computerReader = new XmlTextReader(computerStringReader))
                    {
                        computers =(List<Computer>)computerDeserializer.Deserialize(computerReader);//deserialize xml file
                        computerReader.Close();
                    }

                    computerStringReader.Close();//closing string reader
                }
                MessageBox.Show("Load Successful!", "Successful!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);//appears if the load is successful
            }
            catch (Exception)
            {
                MessageBox.Show("Load Error!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);//if load is anything but successful
            }
           
            }
        }
    } 

