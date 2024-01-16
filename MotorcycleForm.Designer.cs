namespace Garage_managment_system_project
{
    partial class MotorcycleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MotorcycleForm));
            this.Motorcycle_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.vehicle_id_txt = new System.Windows.Forms.TextBox();
            this.Kilometer_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Year_txt = new System.Windows.Forms.TextBox();
            this.wheelsamount_txt = new System.Windows.Forms.ListBox();
            this.Model_txt = new System.Windows.Forms.ListBox();
            this.Engin_txt = new System.Windows.Forms.ListBox();
            this.Type_txt = new System.Windows.Forms.ListBox();
            this.Save_btn = new System.Windows.Forms.Button();
            this.import_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.engine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kilometer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wheels_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vehicle_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Motorcycle_btn
            // 
            this.Motorcycle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Motorcycle_btn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Motorcycle_btn.Location = new System.Drawing.Point(554, 377);
            this.Motorcycle_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Motorcycle_btn.Name = "Motorcycle_btn";
            this.Motorcycle_btn.Size = new System.Drawing.Size(139, 57);
            this.Motorcycle_btn.TabIndex = 0;
            this.Motorcycle_btn.Text = "Add";
            this.Motorcycle_btn.UseVisualStyleBackColor = true;
            this.Motorcycle_btn.Click += new System.EventHandler(this.Motorcycle_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(342, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Motorcycle Invetory\r\n";
            // 
            // vehicle_id_txt
            // 
            this.vehicle_id_txt.Location = new System.Drawing.Point(187, 101);
            this.vehicle_id_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vehicle_id_txt.Name = "vehicle_id_txt";
            this.vehicle_id_txt.Size = new System.Drawing.Size(151, 22);
            this.vehicle_id_txt.TabIndex = 4;
            // 
            // Kilometer_txt
            // 
            this.Kilometer_txt.Location = new System.Drawing.Point(187, 185);
            this.Kilometer_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Kilometer_txt.Name = "Kilometer_txt";
            this.Kilometer_txt.Size = new System.Drawing.Size(151, 22);
            this.Kilometer_txt.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(32, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Engin volume:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(61, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kilometer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(93, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Model:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(57, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Vehicle id:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(104, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Type:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(107, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Year:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(0, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Wheels Amount:";
            // 
            // Year_txt
            // 
            this.Year_txt.Location = new System.Drawing.Point(187, 273);
            this.Year_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Year_txt.Name = "Year_txt";
            this.Year_txt.Size = new System.Drawing.Size(151, 22);
            this.Year_txt.TabIndex = 16;
            // 
            // wheelsamount_txt
            // 
            this.wheelsamount_txt.FormattingEnabled = true;
            this.wheelsamount_txt.ItemHeight = 16;
            this.wheelsamount_txt.Items.AddRange(new object[] {
            "2",
            "3"});
            this.wheelsamount_txt.Location = new System.Drawing.Point(187, 229);
            this.wheelsamount_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wheelsamount_txt.Name = "wheelsamount_txt";
            this.wheelsamount_txt.Size = new System.Drawing.Size(149, 20);
            this.wheelsamount_txt.TabIndex = 17;
            // 
            // Model_txt
            // 
            this.Model_txt.FormattingEnabled = true;
            this.Model_txt.ItemHeight = 16;
            this.Model_txt.Items.AddRange(new object[] {
            "Toyota",
            "Kawasaki",
            "Yamaha",
            "Suzuki"});
            this.Model_txt.Location = new System.Drawing.Point(185, 144);
            this.Model_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Model_txt.Name = "Model_txt";
            this.Model_txt.Size = new System.Drawing.Size(151, 20);
            this.Model_txt.TabIndex = 18;
            // 
            // Engin_txt
            // 
            this.Engin_txt.FormattingEnabled = true;
            this.Engin_txt.ItemHeight = 16;
            this.Engin_txt.Items.AddRange(new object[] {
            "125",
            "250",
            "500"});
            this.Engin_txt.Location = new System.Drawing.Point(187, 322);
            this.Engin_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Engin_txt.Name = "Engin_txt";
            this.Engin_txt.Size = new System.Drawing.Size(149, 20);
            this.Engin_txt.TabIndex = 19;
            // 
            // Type_txt
            // 
            this.Type_txt.FormattingEnabled = true;
            this.Type_txt.ItemHeight = 16;
            this.Type_txt.Items.AddRange(new object[] {
            "dirt",
            "moped",
            "race"});
            this.Type_txt.Location = new System.Drawing.Point(187, 367);
            this.Type_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Type_txt.Name = "Type_txt";
            this.Type_txt.Size = new System.Drawing.Size(151, 20);
            this.Type_txt.TabIndex = 20;
            // 
            // Save_btn
            // 
            this.Save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Save_btn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Save_btn.Location = new System.Drawing.Point(952, 377);
            this.Save_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(116, 57);
            this.Save_btn.TabIndex = 21;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // import_btn
            // 
            this.import_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.import_btn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.import_btn.Location = new System.Drawing.Point(1145, 377);
            this.import_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.import_btn.Name = "import_btn";
            this.import_btn.Size = new System.Drawing.Size(139, 57);
            this.import_btn.TabIndex = 22;
            this.import_btn.Text = "Import";
            this.import_btn.UseVisualStyleBackColor = true;
            this.import_btn.Click += new System.EventHandler(this.import_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.engine,
            this.Model,
            this.Kilometer,
            this.Wheels_amount,
            this.Vehicle_id,
            this.Year,
            this.type});
            this.dataGridView1.Location = new System.Drawing.Point(351, 101);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(933, 249);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // engine
            // 
            this.engine.HeaderText = "engine";
            this.engine.MinimumWidth = 6;
            this.engine.Name = "engine";
            this.engine.ReadOnly = true;
            this.engine.Width = 125;
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
            // Wheels_amount
            // 
            this.Wheels_amount.HeaderText = "Wheels_amount";
            this.Wheels_amount.MinimumWidth = 6;
            this.Wheels_amount.Name = "Wheels_amount";
            this.Wheels_amount.ReadOnly = true;
            this.Wheels_amount.Width = 125;
            // 
            // Vehicle_id
            // 
            this.Vehicle_id.HeaderText = "Vehicle_id";
            this.Vehicle_id.MinimumWidth = 6;
            this.Vehicle_id.Name = "Vehicle_id";
            this.Vehicle_id.ReadOnly = true;
            this.Vehicle_id.Width = 125;
            // 
            // Year
            // 
            this.Year.HeaderText = "Year";
            this.Year.MinimumWidth = 6;
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            this.Year.Width = 125;
            // 
            // type
            // 
            this.type.HeaderText = "type";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 125;
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Delete.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Delete.Location = new System.Drawing.Point(766, 377);
            this.Delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(113, 57);
            this.Delete.TabIndex = 24;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Update.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Update.Location = new System.Drawing.Point(351, 377);
            this.Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(139, 57);
            this.Update.TabIndex = 25;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 459);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MotorcycleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1361, 572);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.import_btn);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.Type_txt);
            this.Controls.Add(this.Engin_txt);
            this.Controls.Add(this.Model_txt);
            this.Controls.Add(this.wheelsamount_txt);
            this.Controls.Add(this.Year_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Kilometer_txt);
            this.Controls.Add(this.vehicle_id_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Motorcycle_btn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MotorcycleForm";
            this.Text = "g";
            this.Load += new System.EventHandler(this.MotorcycleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Motorcycle_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vehicle_id_txt;
        private System.Windows.Forms.TextBox Kilometer_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Year_txt;
        private System.Windows.Forms.ListBox wheelsamount_txt;
        private System.Windows.Forms.ListBox Model_txt;
        private System.Windows.Forms.ListBox Engin_txt;
        private System.Windows.Forms.ListBox Type_txt;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Button import_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.DataGridViewTextBoxColumn engine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kilometer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wheels_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vehicle_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}