using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RollForLoot
{
    public partial class FormMainMneu : Form
    {
        public FormMainMneu()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            label1CharacterName.Visible = true;
            textBoxCharacterName.Visible = true;
            labelRoll.Visible = true;
            numericUpDownRoll.Visible = true;
            labelTimes.Visible = true;
            numericUpDownTimes.Visible = true;
            buttonGiveLoot.Visible = true;
            comboBoxMode.Visible = true;
            labelMode.Visible = true;
            listBoxLoot.Visible = true;
            buttonSaveLoot.Visible = true;



        }


        public void LoadDataItems()
        {

            DataTable tableItems = new DataTable();

                tableItems.Columns.Add("Item", typeof(string));
                tableItems.Columns.Add("Roll to Reach", typeof(int));
                dataGridView1.DataSource = tableItems;

                string[] lines = File.ReadAllLines(@"files/RollForItems.txt");
                string[] values;


            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split(',');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }

                tableItems.Rows.Add(row);
            }


        }



        public void LoadDataCurrency()
        {
            DataTable tableCurrency = new DataTable();

            tableCurrency.Columns.Add("Gold", typeof(string));
            tableCurrency.Columns.Add("Roll to Reach", typeof(int));
            dataGridView1.DataSource = tableCurrency;

            string[] lines = File.ReadAllLines(@"files/RollForCurrency.txt");
            string[] values;


            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split(',');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }

                tableCurrency.Rows.Add(row);
            }


        }

        private void buttonGiveLoot_Click(object sender, EventArgs e)
        {

            listBoxLoot.Items.Clear();

            if (comboBoxMode.SelectedIndex == 0)
            {
                LoadDataItems();
                int timesRolled = ((int)numericUpDownTimes.Value);
                int playerRoll = ((int)numericUpDownRoll.Value);
                FillListBox(@"files/RollForItems.txt", timesRolled, playerRoll);

            }

            if (comboBoxMode.SelectedIndex == 1)
            {
                LoadDataCurrency();
                int timesRolled = ((int)numericUpDownTimes.Value);
                int playerRoll = ((int)numericUpDownRoll.Value);
                FillListBox(@"files/RollForCurrency.txt", timesRolled, playerRoll);
                
            }
        }

        private void FillListBox(string path, int times, int roll)
        {
            string[] lines = File.ReadAllLines(path);
            Random random = new Random();

            List<string> validItems = new List<string>();

            foreach (string line in lines)
            {
                string[] columns = line.Split(',');

                if (columns.Length >= 2 &&
                    int.TryParse(columns[1].Trim(), out int columnValue))
                {

                    if (columnValue <= roll)
                    {

                        validItems.Add(columns[0].Trim());
                    }
                }
            }

            for (int i = 0; i < times; i++)
            {
                if (validItems.Count > 0)
                {

                    string randomItem = validItems[random.Next(validItems.Count)];
                    listBoxLoot.Items.Add(randomItem);
                }
                else
                {

                    listBoxLoot.Items.Add("Nenhum item válido encontrado");
                    break;
                }
            }


        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        private void buttonOpenDatabase_Click(object sender, EventArgs e)
        {
            if (comboBoxDatabase.SelectedIndex == 0) {
                Process.Start("notepad.exe", @"files\RollForItems.txt");

            }

            if (comboBoxDatabase.SelectedIndex == 1) {
                Process.Start("notepad.exe", @"files\RollForCurrency.txt");

            }

            else {
                MessageBox.Show("Please select one of the databases");
            }
        }

        private void buttonSaveLoot_Click(object sender, EventArgs e)
        {
            string dateFormat = DateTime.Now.ToString("HHmm");
            string path = "../../lootLog/" + textBoxCharacterName.Text + " " + dateFormat + ".txt";
            var file = new FileInfo(path);
            file.Directory.Create(); 
            var listBoxText = "";

            foreach (var item in listBoxLoot.Items)
            {
                listBoxText += item.ToString() + "\n"; 
            }

            File.WriteAllText(path, listBoxText, Encoding.UTF8);

            DialogResult dialogResult = MessageBox.Show(textBoxCharacterName.Text + "'s loot was save, do you wish to open the file?", "Loot saved", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes) {
                Process.Start("notepad.exe", @"../../lootLog/" + textBoxCharacterName.Text + " " + dateFormat + ".txt");

            }

            else {

                //nothing
            }
        }
    }

        
}
