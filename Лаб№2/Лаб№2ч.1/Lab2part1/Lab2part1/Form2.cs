using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2part1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try {
                if (PassFormatString(textBox2.Text) || radioButtonGet.Checked || radioButtonDelete.Checked)
                {
                    if (PassFormatDescription(textBox3.Text) || radioButtonGet.Checked || radioButtonDelete.Checked)
                    {
                        errorProvider1.Clear();
                        using (CarSpecificationEntities db = new CarSpecificationEntities())
                        {
                            if (radioButtonGet.Checked)
                            {
                                var partdrow = db.PartDs;
                                Form2DGW.DataSource = partdrow.ToList();
                            }

                            if (radioButtonDelete.Checked)
                            {
                                var partdd = new PartD { ID = int.Parse(textBox1.Text) };
                                db.PartDs.Attach(partdd);
                                db.PartDs.Remove(partdd);
                                db.SaveChanges();
                                var partdrow = db.PartDs;
                                Form2DGW.DataSource = partdrow.ToList();

                            }

                            if (radioButtonRefresh.Checked)
                            {
                                int d = int.Parse(textBox1.Text);
                                var partdup = db.PartDs.Where(p => p.ID == d).FirstOrDefault();
                                partdup.Abbreviation = textBox2.Text;
                                partdup.Description = textBox3.Text;
                                db.SaveChanges();
                                var partdrow = db.PartDs;
                                Form2DGW.DataSource = partdrow.ToList();

                            }

                            if (radioButtonAdd.Checked)
                            {
                                PartD p1 = new PartD { Abbreviation = textBox2.Text, Description = textBox3.Text };
                                db.PartDs.Add(p1);
                                db.SaveChanges();
                                var partdrow = db.PartDs;
                                Form2DGW.DataSource = partdrow.ToList();

                            }

                        }


                    }
                    else
                    {
                        errorProvider1.SetError(textBox3, "Put in format 'smth smth' ");
                    }
                }
                else
                {
                    errorProvider1.SetError(textBox2, "Put in format 'AB'");
                }
            }
            catch(Exception exc) {MessageBox.Show(exc.Message);};
            
        }

            public bool PassFormatInt(string p)
        {
            Regex R = new Regex("^[0-9]{1,4}$");
            Match M = R.Match(p);
            return M.Success;
        }

        public bool PassFormatString(string p)
        {
            Regex R = new Regex("^[А-я,A-Z,a-z,і,ї,є]{1,}$");
            Match M = R.Match(p);
            return M.Success;
        }

        public bool PassFormatDescription(string p)
        {
            Regex R = new Regex("^[А-я,A-Z,a-z,і,ї,є]{0,} +[А-я,A-Z,a-z,і,ї,є]{0,}$");
            Match M = R.Match(p);
            return M.Success;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 newForm1 = new Form1();
            newForm1.Show();
            this.Hide();
        }

        private void radioButtonGet_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGet.Checked)
            {
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
            }
        }

        private void radioButtonAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAdd.Checked)
            {
                textBox1.Visible = false;
                textBox2.Visible = true;
                textBox3.Visible = true;
                label1.Visible = false;
                label2.Visible = true;
                label3.Visible = true;
            }
        }

        private void radioButtonRefresh_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonRefresh.Checked)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
            }
        }

        private void radioButtonDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDelete.Checked)
            {
                textBox1.Visible = true;
                textBox2.Visible = false;
                textBox3.Visible = false;
                label1.Visible = true;
                label2.Visible = false;
                label3.Visible = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
