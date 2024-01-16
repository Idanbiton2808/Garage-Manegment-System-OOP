namespace Garage_managment_system_project
{
    partial class CarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarForm));
            this.Year_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Kilometer_txt = new System.Windows.Forms.TextBox();
            this.Vehicle_id_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.dataGridViewCar = new System.Windows.Forms.DataGridView();
            this.veichal_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilometer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number_of_doors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Import = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Model_txt = new System.Windows.Forms.ListBox();
            this.Numdoors_txt = new System.Windows.Forms.ListBox();
            this.Cargo_txt = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Year_txt
            // 
            this.Year_txt.Location = new System.Drawing.Point(275, 244);
            this.Year_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Year_txt.Name = "Year_txt";
            this.Year_txt.Size = new System.Drawing.Size(151, 22);
            this.Year_txt.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(195, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 30;
            this.label7.Text = "Year:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(77, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "Number of doors:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(141, 108);
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
            this.label4.Location = new System.Drawing.Point(181, 146);
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
            this.label3.Location = new System.Drawing.Point(149, 190);
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
            this.label2.Location = new System.Drawing.Point(145, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Capacity: ";
            // 
            // Kilometer_txt
            // 
            this.Kilometer_txt.Location = new System.Drawing.Point(275, 192);
            this.Kilometer_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Kilometer_txt.Name = "Kilometer_txt";
            this.Kilometer_txt.Size = new System.Drawing.Size(151, 22);
            this.Kilometer_txt.TabIndex = 23;
            // 
            // Vehicle_id_txt
            // 
            this.Vehicle_id_txt.Location = new System.Drawing.Point(275, 108);
            this.Vehicle_id_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Vehicle_id_txt.Name = "Vehicle_id_txt";
            this.Vehicle_id_txt.Size = new System.Drawing.Size(151, 22);
            this.Vehicle_id_txt.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(464, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 50);
            this.label1.TabIndex = 18;
            this.label1.Text = "Car Invetory";
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Save.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Save.Location = new System.Drawing.Point(961, 437);
            this.Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(139, 57);
            this.Save.TabIndex = 17;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Motorcycle_btn_Click);
            // 
            // dataGridViewCar
            // 
            this.dataGridViewCar.AllowUserToAddRows = false;
            this.dataGridViewCar.AllowUserToDeleteRows = false;
            this.dataGridViewCar.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridViewCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.veichal_id,
            this.model,
            this.kilometer,
            this.year,
            this.cargo,
            this.number_of_doors});
            this.dataGridViewCar.Location = new System.Drawing.Point(463, 85);
            this.dataGridViewCar.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewCar.Name = "dataGridViewCar";
            this.dataGridViewCar.ReadOnly = true;
            this.dataGridViewCar.RowHeadersWidth = 51;
            this.dataGridViewCar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCar.Size = new System.Drawing.Size(801, 337);
            this.dataGridViewCar.TabIndex = 33;
            // 
            // veichal_id
            // 
            this.veichal_id.HeaderText = "veichal_id";
            this.veichal_id.MinimumWidth = 6;
            this.veichal_id.Name = "veichal_id";
            this.veichal_id.ReadOnly = true;
            this.veichal_id.Width = 125;
            // 
            // model
            // 
            this.model.HeaderText = "model";
            this.model.MinimumWidth = 6;
            this.model.Name = "model";
            this.model.ReadOnly = true;
            this.model.Width = 125;
            // 
            // kilometer
            // 
            this.kilometer.HeaderText = "kiliometer";
            this.kilometer.MinimumWidth = 6;
            this.kilometer.Name = "kilometer";
            this.kilometer.ReadOnly = true;
            this.kilometer.Width = 125;
            // 
            // year
            // 
            this.year.HeaderText = "year";
            this.year.MinimumWidth = 6;
            this.year.Name = "year";
            this.year.ReadOnly = true;
            this.year.Width = 125;
            // 
            // cargo
            // 
            this.cargo.HeaderText = "cargo";
            this.cargo.MinimumWidth = 6;
            this.cargo.Name = "cargo";
            this.cargo.ReadOnly = true;
            this.cargo.Width = 125;
            // 
            // number_of_doors
            // 
            this.number_of_doors.HeaderText = "number_of_doors";
            this.number_of_doors.MinimumWidth = 6;
            this.number_of_doors.Name = "number_of_doors";
            this.number_of_doors.ReadOnly = true;
            this.number_of_doors.Width = 125;
            // 
            // Import
            // 
            this.Import.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Import.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Import.Location = new System.Drawing.Point(1125, 437);
            this.Import.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(139, 57);
            this.Import.TabIndex = 34;
            this.Import.Text = "Import";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.Import_Click_1);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Delete.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Delete.Location = new System.Drawing.Point(802, 437);
            this.Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(139, 57);
            this.Delete.TabIndex = 35;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click_1);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Add.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Add.Location = new System.Drawing.Point(638, 437);
            this.Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(139, 57);
            this.Add.TabIndex = 36;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Update.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Update.Location = new System.Drawing.Point(463, 437);
            this.Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(139, 57);
            this.Update.TabIndex = 37;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Model_txt
            // 
            this.Model_txt.FormattingEnabled = true;
            this.Model_txt.ItemHeight = 16;
            this.Model_txt.Items.AddRange(new object[] {
            "Toyota",
            "Porshe",
            "Mazda",
            "Nissan",
            "Seat"});
            this.Model_txt.Location = new System.Drawing.Point(275, 146);
            this.Model_txt.Name = "Model_txt";
            this.Model_txt.Size = new System.Drawing.Size(151, 20);
            this.Model_txt.TabIndex = 38;
            // 
            // Numdoors_txt
            // 
            this.Numdoors_txt.FormattingEnabled = true;
            this.Numdoors_txt.ItemHeight = 16;
            this.Numdoors_txt.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "7"});
            this.Numdoors_txt.Location = new System.Drawing.Point(275, 338);
            this.Numdoors_txt.Name = "Numdoors_txt";
            this.Numdoors_txt.Size = new System.Drawing.Size(151, 20);
            this.Numdoors_txt.TabIndex = 39;
            // 
            // Cargo_txt
            // 
            this.Cargo_txt.FormattingEnabled = true;
            this.Cargo_txt.ItemHeight = 16;
            this.Cargo_txt.Items.AddRange(new object[] {
            "2",
            "5",
            "7"});
            this.Cargo_txt.Location = new System.Drawing.Point(275, 299);
            this.Cargo_txt.Name = "Cargo_txt";
            this.Cargo_txt.Size = new System.Drawing.Size(151, 20);
            this.Cargo_txt.TabIndex = 40;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(82, 498);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1297, 599);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Cargo_txt);
            this.Controls.Add(this.Numdoors_txt);
            this.Controls.Add(this.Model_txt);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.dataGridViewCar);
            this.Controls.Add(this.Year_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Kilometer_txt);
            this.Controls.Add(this.Vehicle_id_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Save);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CarForm";
            this.Text = "CarForm";
            this.Load += new System.EventHandler(this.CarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Year_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Kilometer_txt;
        private System.Windows.Forms.TextBox Vehicle_id_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.DataGridView dataGridViewCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn veichal_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilometer;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn number_of_doors;
        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.ListBox Model_txt;
        private System.Windows.Forms.ListBox Numdoors_txt;
        private System.Windows.Forms.ListBox Cargo_txt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}