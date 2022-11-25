using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ChangeCounter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            updateCount();
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            Button clickedBttnSub = sender as Button;
            String stripSubName = clickedBttnSub.Name.Replace("Sub", "");

            foreach (Control x in this.Controls)
            {
                if (x.Name.Replace("Count", "") == stripSubName)
                {
                    x.Text = (Int32.Parse(x.Text) - 1).ToString();
                }
            }
            updateCount();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Button clickedBttnAdd = sender as Button;
            String stripAddName = clickedBttnAdd.Name.Replace("Add", "");

            foreach (Control x in this.Controls)
            {
                if (x.Name.Replace("Count", "") == stripAddName)
                {
                    x.Text = (Int32.Parse(x.Text) + 1).ToString();
                }
            }
            updateCount();
        }

        private void InputTextChanged(object sender, KeyEventArgs e)
        {
            TextBox inputTxtChange = sender as TextBox;
            String stripName = inputTxtChange.Name.Replace("Input", "");

            if (e.KeyCode == Keys.Enter)
            {
                foreach (Control x in this.Controls)
                {
                    if (x.Name.Replace("Count", "") == stripName && inputTxtChange.Text != "")
                    {
                        int a = 0;
                        Int32.TryParse(inputTxtChange.Text, out a);
                        x.Text = a.ToString();
                        inputTxtChange.Clear();
                    }
                    else
                    {
                        if (x.Name.Replace("Count", "") == stripName)
                        {
                            x.Text = 0.ToString();
                        }
                    }
                }
                updateCount();
            }
        }

        Dictionary<string, float> money = new Dictionary<string, float>();

        private void con2VarInt()
        {
            foreach (Control x in this.Controls)
            {
                if (x.Name.Contains("Count"))
                {
                    String replacedName = x.Name.Replace("Count", "");
                    if (money.ContainsKey(replacedName))
                    {
                        money[replacedName] = float.Parse(x.Text);
                    } 
                    else
                    {
                        money.Add(replacedName, float.Parse(x.Text));
                    }
                    
                }
            }
        }

        private void updateCount(Boolean updateLoadCount=false)
        {
            if (updateLoadCount==false)
            {
                con2VarInt();
                double totVal = money["Nickel"] * 0.05 + money["Dime"] * 0.10 + money["Quarter"] * 0.25 + money["Loonie"] * 1.00 + money["Toonie"] * 2.00;
                total.Text = "$" + totVal.ToString("0.00");
            }
            else
            {
                foreach (Control x in this.Controls)
                {
                    if (x.Name.Contains("Count"))
                    {
                        foreach (KeyValuePair<string, float> kv in money)
                        {
                            if (x.Name.Replace("Count", "") == kv.Key)
                            {
                                x.Text = kv.Value.ToString();
                            }
                        }
                    }
                }

                double totVal = money["Nickel"] * 0.05 + money["Dime"] * 0.10 + money["Quarter"] * 0.25 + money["Loonie"] * 1.00 + money["Toonie"] * 2.00;
                total.Text = "$" + totVal.ToString("0.00");
            }
        }

        private void SaveBttnClick(object sender, EventArgs e)
        {
            string moneyJson = System.Text.Json.JsonSerializer.Serialize(money);

            SaveFileDialog saveJsonDiag = new SaveFileDialog();
            saveJsonDiag.Title = "Save .JSON File";
            saveJsonDiag.FileName = "coins.json";
            saveJsonDiag.RestoreDirectory = true;
            saveJsonDiag.Filter = "JSON files|*.json|All files (*.*)|*.*";

            if (saveJsonDiag.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveJsonDiag.FileName, moneyJson);
            }
        }

        private void ImportBttnClick(object sender, EventArgs e)
        {
            OpenFileDialog openJsonDiag = new OpenFileDialog();
            openJsonDiag.Filter = "JSON files|*.json|All files (*.*)|*.*";
            openJsonDiag.Title = "Pick .JSON File to Import";

            if (openJsonDiag.ShowDialog() == DialogResult.OK)
            {
                string openedFile = File.ReadAllText(openJsonDiag.FileName);
                money = JsonConvert.DeserializeObject<Dictionary<string, float>>(openedFile);
                updateCount(true);
            }
        }

        private void ZeroOut(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x.Name.Contains("Count"))
                {
                    x.Text = "0";
                }
            }
            updateCount();
        }
    }
}