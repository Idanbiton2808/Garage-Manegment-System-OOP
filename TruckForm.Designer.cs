namespace Garage_managment_system_project
{
    partial class TruckForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TruckForm));
            this.Year_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Kilometer_txt = new System.Windows.Forms.TextBox();
            this.Vehicle_id_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.dataGridViewTruck = new System.Windows.Forms.DataGridView();
            this.Vehicle_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kilometer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wheels_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model_txt = new System.Windows.Forms.ListBox();
            this.whellsamount_txt = new System.Windows.Forms.ListBox();
            this.weight_txt = new System.Windows.Forms.ListBox();
            this.Update = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Import = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.capacity_txt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTruck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Year_txt
            // 
            this.Year_txt.Location = new System.Drawing.Point(275, 282);
            this.Year_txt.Name = "Year_txt";
            this.Year_txt.Size = new System.Drawing.Size(151, 22);
            this.Year_txt.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(78, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 25);
            this.label8.TabIndex = 31;
            this.label8.Text = "Wheels Amount:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(185, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 30;
            this.label7.Text = "Year:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(136, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Vehicle id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(172, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(150, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Kilometer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(168, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "weight:";
            // 
            // Kilometer_txt
            // 
            this.Kilometer_txt.Location = new System.Drawing.Point(275, 175);
            this.Kilometer_txt.Name = "Kilometer_txt";
            this.Kilometer_txt.Size = new System.Drawing.Size(151, 22);
            this.Kilometer_txt.TabIndex = 23;
            // 
            // Vehicle_id_txt
            // 
            this.Vehicle_id_txt.Location = new System.Drawing.Point(275, 87);
            this.Vehicle_id_txt.Name = "Vehicle_id_txt";
            this.Vehicle_id_txt.Size = new System.Drawing.Size(151, 22);
            this.Vehicle_id_txt.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(438, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 50);
            this.label1.TabIndex = 18;
            this.label1.Text = "Truck Invetory";
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.save_btn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.save_btn.Location = new System.Drawing.Point(1025, 415);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(138, 56);
            this.save_btn.TabIndex = 17;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // dataGridViewTruck
            // 
            this.dataGridViewTruck.AllowUserToAddRows = false;
            this.dataGridViewTruck.AllowUserToDeleteRows = false;
            this.dataGridViewTruck.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridViewTruck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTruck.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Vehicle_id,
            this.Model,
            this.Kilometer,
            this.Wheels_Amount,
            this.Year,
            this.Weight,
            this.Capacity});
            this.dataGridViewTruck.Location = new System.Drawing.Point(447, 116);
            this.dataGridViewTruck.Name = "dataGridViewTruck";
            this.dataGridViewTruck.ReadOnly = true;
            this.dataGridViewTruck.RowHeadersWidth = 51;
            this.dataGridViewTruck.RowTemplate.Height = 24;
            this.dataGridViewTruck.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTruck.Size = new System.Drawing.Size(901, 293);
            this.dataGridViewTruck.TabIndex = 33;
            // 
            // Vehicle_id
            // 
            this.Vehicle_id.HeaderText = "Vehicle_id";
            this.Vehicle_id.MinimumWidth = 6;
            this.Vehicle_id.Name = "Vehicle_id";
            this.Vehicle_id.ReadOnly = true;
            this.Vehicle_id.Width = 125;
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.MinimumWidth = 6;
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            this.Model.Width = 125;
            // 
            // Kilometer
            // 
            this.Kilometer.HeaderText = "Kilometer";
            this.Kilometer.MinimumWidth = 6;
            this.Kilometer.Name = "Kilometer";
            this.Kilometer.ReadOnly = true;
            this.Kilometer.Width = 125;
            // 
            // Wheels_Amount
            // 
            this.Wheels_Amount.HeaderText = "Wheels_Amount";
            this.Wheels_Amount.MinimumWidth = 6;
            this.Wheels_Amount.Name = "Wheels_Amount";
            this.Wheels_Amount.ReadOnly = true;
            this.Wheels_Amount.Width = 125;
            // 
            // Year
            // 
            this.Year.HeaderText = "Year";
            this.Year.MinimumWidth = 6;
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            this.Year.Width = 125;
            // 
            // Weight
            // 
            this.Weight.HeaderText = "Weight";
            this.Weight.MinimumWidth = 6;
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            this.Weight.Width = 125;
            // 
            // Model_txt
            // 
            this.Model_txt.FormattingEnabled = true;
            this.Model_txt.ItemHeight = 16;
            this.Model_txt.Items.AddRange(new object[] {
            "Nissan",
            "Isuzu",
            "GT-Max"});
            this.Model_txt.Location = new System.Drawing.Point(275, 129);
            this.Model_txt.Name = "Model_txt";
            this.Model_txt.Size = new System.Drawing.Size(151, 20);
            this.Model_txt.TabIndex = 34;
            // 
            // whellsamount_txt
            // 
            this.whellsamount_txt.FormattingEnabled = true;
            this.whellsamount_txt.ItemHeight = 16;
            this.whellsamount_txt.Items.AddRange(new object[] {
            "4",
            "8",
            "12",
            "16"});
            this.whellsamount_txt.Location = new System.Drawing.Point(275, 230);
            this.whellsamount_txt.Name = "whellsamount_txt";
            this.whellsamount_txt.Size = new System.Drawing.Size(151, 20);
            this.whellsamount_txt.TabIndex = 35;
            // 
            // weight_txt
            // 
            this.weight_txt.FormattingEnabled = true;
            this.weight_txt.ItemHeight = 16;
            this.weight_txt.Items.AddRange(new object[] {
            "12",
            "15",
            "20"});
            this.weight_txt.Location = new System.Drawing.Point(275, 332);
            this.weight_txt.Name = "weight_txt";
            this.weight_txt.Size = new System.Drawing.Size(151, 20);
            this.weight_txt.TabIndex = 36;
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Update.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Update.Location = new System.Drawing.Point(447, 415);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(138, 56);
            this.Update.TabIndex = 37;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Add.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Add.Location = new System.Drawing.Point(636, 415);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(138, 56);
            this.Add.TabIndex = 38;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Import
            // 
            this.Import.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Import.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Import.Location = new System.Drawing.Point(1210, 415);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(138, 56);
            this.Import.TabIndex = 39;
            this.Import.Text = "Import";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Delete.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Delete.Location = new System.Drawing.Point(827, 415);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(138, 56);
            this.Delete.TabIndex = 40;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Capacity
            // 
            this.Capacity.HeaderText = "Capacity";
            this.Capacity.MinimumWidth = 6;
            this.Capacity.Name = "Capacity";
            this.Capacity.ReadOnly = true;
            this.Capacity.Width = 125;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(145, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 41;
            this.label6.Text = "Capacity:";
            // 
            // capacity_txt
            // 
            this.capacity_txt.Location = new System.Drawing.Point(275, 387);
            this.capacity_txt.Name = "capacity_txt";
            this.capacity_txt.Size = new System.Drawing.Size(151, 22);
            this.capacity_txt.TabIndex = 42;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(67, 459);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TruckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1360, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.capacity_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.weight_txt);
            this.Controls.Add(this.whellsamount_txt);
            this.Controls.Add(this.Model_txt);
            this.Controls.Add(this.dataGridViewTruck);
            this.Controls.Add(this.Year_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Kilometer_txt);
            this.Controls.Add(this.Vehicle_id_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save_btn);
            this.Name = "TruckForm";
            this.Text = "TruckForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTruck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Year_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Kilometer_txt;
        private System.Windows.Forms.TextBox Vehicle_id_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.DataGridView dataGridViewTruck;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vehicle_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kilometer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wheels_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.ListBox Model_txt;
        private System.Windows.Forms.ListBox whellsamount_txt;
        private System.Windows.Forms.ListBox weight_txt;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox capacity_txt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}