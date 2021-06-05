using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Security.AccessControl;

namespace lab1part6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void P5_Click(object sender, EventArgs e)
        {
            using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            using (var runKey = hklm.OpenSubKey(@"SOFTWARE\SYTNYCHENKO", true))
            {
                string[] F = (string[])runKey.GetValue("P5", new string[] { "CCCC", "DDDDDD" });
                string Fin = "";
                foreach (string line in F)
                {
                    Fin += line + "\n";
                }
                MessageBox.Show(Fin);
            }

        }

        private void P6_Click(object sender, EventArgs e)
        {
            using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            using (var runKey = hklm.OpenSubKey(@"SOFTWARE\SYTNYCHENKO", true))
            {
                runKey.SetValue("P6", new string[] { "Я - відповідальний студент", "кафедри КІ!" }, RegistryValueKind.MultiString);
                MessageBox.Show("Data modified");
            }

        }
    }
}
