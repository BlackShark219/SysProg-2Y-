using System;

namespace Lab2part1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radioButtonGet = new System.Windows.Forms.RadioButton();
            this.radioButtonAdd = new System.Windows.Forms.RadioButton();
            this.radioButtonRefresh = new System.Windows.Forms.RadioButton();
            this.radioButtonDelete = new System.Windows.Forms.RadioButton();
            this.checkBoxPART_ID = new System.Windows.Forms.CheckBox();
            this.checkBoxID = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DGWF1 = new System.Windows.Forms.DataGridView();
            this.detailDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carSpecificationDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.car_SpecificationDataSet = new Lab2part1.Car_SpecificationDataSet();
            this.detailDTableAdapter = new Lab2part1.Car_SpecificationDataSetTableAdapters.DetailDTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.result = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGWF1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carSpecificationDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_SpecificationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonGet
            // 
            this.radioButtonGet.AutoSize = true;
            this.radioButtonGet.Location = new System.Drawing.Point(34, 156);
            this.radioButtonGet.Name = "radioButtonGet";
            this.radioButtonGet.Size = new System.Drawing.Size(52, 21);
            this.radioButtonGet.TabIndex = 0;
            this.radioButtonGet.TabStop = true;
            this.radioButtonGet.Text = "Get";
            this.radioButtonGet.UseVisualStyleBackColor = true;
            this.radioButtonGet.CheckedChanged += new System.EventHandler(this.radioButtonGet_CheckedChanged);
            // 
            // radioButtonAdd
            // 
            this.radioButtonAdd.AutoSize = true;
            this.radioButtonAdd.Location = new System.Drawing.Point(34, 183);
            this.radioButtonAdd.Name = "radioButtonAdd";
            this.radioButtonAdd.Size = new System.Drawing.Size(54, 21);
            this.radioButtonAdd.TabIndex = 2;
            this.radioButtonAdd.TabStop = true;
            this.radioButtonAdd.Text = "Add";
            this.radioButtonAdd.UseVisualStyleBackColor = true;
            this.radioButtonAdd.CheckedChanged += new System.EventHandler(this.radioButtonAdd_CheckedChanged);
            // 
            // radioButtonRefresh
            // 
            this.radioButtonRefresh.AutoSize = true;
            this.radioButtonRefresh.Location = new System.Drawing.Point(34, 210);
            this.radioButtonRefresh.Name = "radioButtonRefresh";
            this.radioButtonRefresh.Size = new System.Drawing.Size(79, 21);
            this.radioButtonRefresh.TabIndex = 4;
            this.radioButtonRefresh.TabStop = true;
            this.radioButtonRefresh.Text = "Refresh";
            this.radioButtonRefresh.UseVisualStyleBackColor = true;
            this.radioButtonRefresh.CheckedChanged += new System.EventHandler(this.radioButtonRefresh_CheckedChanged);
            // 
            // radioButtonDelete
            // 
            this.radioButtonDelete.AutoSize = true;
            this.radioButtonDelete.Location = new System.Drawing.Point(34, 237);
            this.radioButtonDelete.Name = "radioButtonDelete";
            this.radioButtonDelete.Size = new System.Drawing.Size(70, 21);
            this.radioButtonDelete.TabIndex = 6;
            this.radioButtonDelete.TabStop = true;
            this.radioButtonDelete.Text = "Delete";
            this.radioButtonDelete.UseVisualStyleBackColor = true;
            this.radioButtonDelete.CheckedChanged += new System.EventHandler(this.radioButtonDelete_CheckedChanged);
            // 
            // checkBoxPART_ID
            // 
            this.checkBoxPART_ID.AutoSize = true;
            this.checkBoxPART_ID.Location = new System.Drawing.Point(346, 156);
            this.checkBoxPART_ID.Name = "checkBoxPART_ID";
            this.checkBoxPART_ID.Size = new System.Drawing.Size(110, 21);
            this.checkBoxPART_ID.TabIndex = 7;
            this.checkBoxPART_ID.Text = "BY PART_ID";
            this.checkBoxPART_ID.UseVisualStyleBackColor = true;
            this.checkBoxPART_ID.CheckedChanged += new System.EventHandler(this.checkBoxPART_ID_CheckedChanged);
            // 
            // checkBoxID
            // 
            this.checkBoxID.AutoSize = true;
            this.checkBoxID.Location = new System.Drawing.Point(503, 157);
            this.checkBoxID.Name = "checkBoxID";
            this.checkBoxID.Size = new System.Drawing.Size(65, 21);
            this.checkBoxID.TabIndex = 8;
            this.checkBoxID.Text = "BY ID";
            this.checkBoxID.UseVisualStyleBackColor = true;
            this.checkBoxID.CheckedChanged += new System.EventHandler(this.checkBoxID_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 318);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(182, 318);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(327, 318);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(468, 318);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(609, 318);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(777, 316);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Accept";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(34, 442);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Part_ID";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Material";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(606, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(774, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Car Part";
            // 
            // DGWF1
            // 
            this.DGWF1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGWF1.Location = new System.Drawing.Point(139, 426);
            this.DGWF1.Name = "DGWF1";
            this.DGWF1.RowTemplate.Height = 24;
            this.DGWF1.Size = new System.Drawing.Size(695, 228);
            this.DGWF1.TabIndex = 23;
            // 
            // detailDBindingSource
            // 
            this.detailDBindingSource.DataMember = "DetailD";
            this.detailDBindingSource.DataSource = this.carSpecificationDataSetBindingSource;
            // 
            // carSpecificationDataSetBindingSource
            // 
            this.carSpecificationDataSetBindingSource.DataSource = this.car_SpecificationDataSet;
            this.carSpecificationDataSetBindingSource.Position = 0;
            // 
            // car_SpecificationDataSet
            // 
            this.car_SpecificationDataSet.DataSetName = "Car_SpecificationDataSet";
            this.car_SpecificationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detailDTableAdapter
            // 
            this.detailDTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(427, 393);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 21);
            this.result.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(373, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(273, 35);
            this.label7.TabIndex = 25;
            this.label7.Text = "DETAIL SPECIFICATION";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 666);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.result);
            this.Controls.Add(this.DGWF1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBoxID);
            this.Controls.Add(this.checkBoxPART_ID);
            this.Controls.Add(this.radioButtonDelete);
            this.Controls.Add(this.radioButtonRefresh);
            this.Controls.Add(this.radioButtonAdd);
            this.Controls.Add(this.radioButtonGet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGWF1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carSpecificationDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_SpecificationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.RadioButton radioButtonGet;
        private System.Windows.Forms.RadioButton radioButtonAdd;
        private System.Windows.Forms.RadioButton radioButtonRefresh;
        private System.Windows.Forms.RadioButton radioButtonDelete;
        private System.Windows.Forms.CheckBox checkBoxPART_ID;
        private System.Windows.Forms.CheckBox checkBoxID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DGWF1;
        private System.Windows.Forms.BindingSource carSpecificationDataSetBindingSource;
        private Car_SpecificationDataSet car_SpecificationDataSet;
        private System.Windows.Forms.BindingSource detailDBindingSource;
        private Car_SpecificationDataSetTableAdapters.DetailDTableAdapter detailDTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
    }
}

