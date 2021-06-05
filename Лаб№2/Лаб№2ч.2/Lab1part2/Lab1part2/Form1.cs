using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1part2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (CarSpecificationEntities db = new CarSpecificationEntities())
            {
                var partr = db.PartDs;
                if (partr.Count() < 2)
                {
                    PartD p1 = new PartD { Abbreviation = "E", Description = "Petrol Engine" };
                    PartD p2 = new PartD { Abbreviation = "HL", Description = "Head Light" };
                    db.PartDs.Add(p1);
                    db.PartDs.Add(p2);
                    db.SaveChanges();
                }
                var det = db.DetailDs.Join(db.PartDs, d => d.Part_ID, p => p.ID, (d, p) => new
                {

                    ID = d.ID,
                    Name = d.Name,
                    Quantity = d.Quantity,
                    Material = d.Material,
                    Price = d.Price,
                    CarPart = p.Description
                });
                comboBox1.DataSource = db.PartDs.ToList();
                comboBox1.DisplayMember = "Description";
                comboBox1.ValueMember = "ID";
            }
        }
        int add;
        int chk;
        int del;

        public bool PassFormatInt(string p)
        {
            Regex R = new Regex("^[0-9]{1,4}$");
            Match M = R.Match(p);
            return M.Success;
        }

        public bool PassFormatString(string p)
        {
            Regex R = new Regex("^[А-я,A-Z,a-z,і,ї,є,І,Ї,Є]{2,}$");
            Match M = R.Match(p);
            return M.Success;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (PassFormatString(textBox2.Text) || radioButtonGet.Checked || radioButtonDelete.Checked)
                {
                    if (PassFormatInt(textBox3.Text) || radioButtonGet.Checked || radioButtonDelete.Checked)
                    {
                        if (PassFormatString(textBox4.Text) || radioButtonGet.Checked || radioButtonDelete.Checked)
                        {
                            if (PassFormatInt(textBox5.Text) || radioButtonGet.Checked || radioButtonDelete.Checked)
                            {
                                errorProvider1.Clear();
                                using (CarSpecificationEntities db = new CarSpecificationEntities())
                                {
                                    var det = db.DetailDs.Join(db.PartDs, d => d.Part_ID, p => p.ID, (d, p) => new
                                    {
                                        ID = d.ID,
                                        Name = d.Name,
                                        Quantity = d.Quantity,
                                        Material = d.Material,
                                        Price = d.Price,
                                        CarPart = p.Description
                                    });
                                    PartD temp = comboBox1.SelectedItem as PartD;

                                    if (radioButtonGet.Checked & checkBoxID.Checked == false & checkBoxPART_ID.Checked == false)
                                    {
                                        DGWF1.DataSource = det.ToList();
                                        result.Text = $"{det.ToList().Count} row(s) dsplayed";

                                    }

                                    if (radioButtonGet.Checked & checkBoxID.Checked)
                                    {

                                        int c = int.Parse(textBox1.Text);
                                        var row = det.Where(r => r.ID == c);
                                        DGWF1.DataSource = row.ToList();
                                        result.Text = $"{row.ToList().Count} row(s) dsplayed";

                                    }

                                    if (radioButtonGet.Checked & checkBoxPART_ID.Checked)
                                    {
                                        var row = det.Where(r => r.CarPart == temp.Description);
                                        DGWF1.DataSource = row.ToList();
                                        result.Text = $"{row.ToList().Count} row(s) dsplayed";

                                    }

                                    if (radioButtonAdd.Checked)
                                    {
                                        int w = 0;
                                        DetailD d = new DetailD() { Name = textBox2.Text, Quantity = int.Parse(textBox3.Text), Material = textBox4.Text, Price = int.Parse(textBox5.Text), Part_ID = temp.ID };
                                        db.DetailDs.Add(d);
                                        var partdrow = db.DetailDs;
                                        w += db.SaveChanges();
                                        add += w;
                                        DGWF1.DataSource = partdrow.ToList();
                                        result.Text = add.ToString() + " row(s) was added";


                                    }

                                    if (radioButtonDelete.Checked)
                                    {
                                        int w = 0;
                                        var partdd = new DetailD { ID = int.Parse(textBox1.Text) };
                                        db.DetailDs.Attach(partdd);
                                        db.DetailDs.Remove(partdd);
                                        var partdrow = db.DetailDs;
                                        w += db.SaveChanges();
                                        del += w;
                                        DGWF1.DataSource = partdrow.ToList();
                                        result.Text = del.ToString() + " row(s) was deleted";

                                    }

                                    if (radioButtonRefresh.Checked)
                                    {
                                        int w = 0;
                                        int d = int.Parse(textBox1.Text);
                                        var partdup = db.DetailDs.Where(p => p.ID == d).FirstOrDefault();
                                        partdup.Name = textBox2.Text;
                                        partdup.Quantity = int.Parse(textBox3.Text);
                                        partdup.Material = textBox4.Text;
                                        partdup.Price = int.Parse(textBox5.Text);
                                        partdup.Part_ID = temp.ID;
                                        w += db.SaveChanges();
                                        chk += w;
                                        var partdrow = db.DetailDs;
                                        DGWF1.DataSource = partdrow.ToList();
                                        result.Text = chk.ToString() + " row(s) was changed";
                                    }
                                }
                            }
                            else
                            {
                                errorProvider1.SetError(textBox5, "Put in format '5'");
                            }


                        }
                        else
                        {
                            errorProvider1.SetError(textBox4, "Put in format 'cotton'");
                        }

                    }
                    else
                    {
                        errorProvider1.SetError(textBox3, "Put in format '5'");
                    }


                }
                else
                {
                    errorProvider1.SetError(textBox2, "Put in format'screw");
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); };

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
            this.Hide();
        }

        private void checkBoxPART_ID_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPART_ID.Checked)
            {
                checkBoxID.Enabled = false;
            }
            else
            {
                checkBoxID.Enabled = true;
            }
            if (radioButtonGet.Checked & checkBoxPART_ID.Checked && !checkBoxID.Checked)
            {
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                comboBox1.Visible = true;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = true;
            }
            else if (radioButtonGet.Checked && !checkBoxPART_ID.Checked && checkBoxID.Checked)
            {
                textBox1.Visible = true;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                comboBox1.Visible = false;
                label1.Visible = true;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
            }
            else
            {
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                comboBox1.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
            }
        }

        private void checkBoxID_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxID.Checked)
            {
                checkBoxPART_ID.Enabled = false;
            }
            else
            {
                checkBoxPART_ID.Enabled = true;
            }
            if (radioButtonGet.Checked & checkBoxPART_ID.Checked && !checkBoxID.Checked)
            {
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                comboBox1.Visible = true;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = true;
            }
            else if (radioButtonGet.Checked && !checkBoxPART_ID.Checked && checkBoxID.Checked)
            {
                textBox1.Visible = true;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                comboBox1.Visible = false;
                label1.Visible = true;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
            }
            else
            {
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                comboBox1.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
            }
        }

        private void radioButtonGet_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxID.Enabled = true;
            checkBoxPART_ID.Enabled = true;
            if (radioButtonGet.Checked & checkBoxPART_ID.Checked && !checkBoxID.Checked)
            {
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                comboBox1.Visible = true;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = true;
            }
            else if (radioButtonGet.Checked && !checkBoxPART_ID.Checked && checkBoxID.Checked)
            {
                textBox1.Visible = true;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                comboBox1.Visible = false;
                label1.Visible = true;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
            }
            else
            {
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                comboBox1.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
            }
        }

        private void radioButtonAdd_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxID.Enabled = false;
            checkBoxPART_ID.Enabled = false;
            if (radioButtonAdd.Checked)
            {
                textBox1.Visible = false;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                comboBox1.Visible = true;
                label1.Visible = false;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
            }
        }

        private void radioButtonDelete_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxID.Enabled = false;
            checkBoxPART_ID.Enabled = false;
            if (radioButtonDelete.Checked)
            {
                textBox1.Visible = true;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                comboBox1.Visible = false;
                label1.Visible = true;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
            }
        }

        private void radioButtonRefresh_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxID.Enabled = false;
            checkBoxPART_ID.Enabled = false;
            if (radioButtonRefresh.Checked)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                comboBox1.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
            }
        }
        private void Form1_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
