namespace CarDealership.view
{
    partial class MainMenu
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
            btnSeuraava = new System.Windows.Forms.Button();
            gbAuto = new System.Windows.Forms.GroupBox();
            label9 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            cb_Fuel = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            cb_Color = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            cb_Model = new System.Windows.Forms.ComboBox();
            dtp_reg_date = new System.Windows.Forms.DateTimePicker();
            tb_mileage = new System.Windows.Forms.TextBox();
            tb_eng_cap = new System.Windows.Forms.TextBox();
            tb_price = new System.Windows.Forms.TextBox();
            tbId = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            cb_Brand = new System.Windows.Forms.ComboBox();
            btnEdellinen = new System.Windows.Forms.Button();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            Test_DB_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            btn_Add_Car = new System.Windows.Forms.Button();
            btn_Close = new System.Windows.Forms.Button();
            btn_Edit = new System.Windows.Forms.Button();
            btn_CancelChange = new System.Windows.Forms.Button();
            btn_SaveChange = new System.Windows.Forms.Button();
            btn_DeleteCar = new System.Windows.Forms.Button();
            gbAuto.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSeuraava
            // 
            btnSeuraava.Location = new System.Drawing.Point(162, 316);
            btnSeuraava.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSeuraava.Name = "btnSeuraava";
            btnSeuraava.Size = new System.Drawing.Size(89, 41);
            btnSeuraava.TabIndex = 1;
            btnSeuraava.Text = "&Next";
            btnSeuraava.UseVisualStyleBackColor = true;
            btnSeuraava.Click += btnSeuraava_Click;
            // 
            // gbAuto
            // 
            gbAuto.Controls.Add(label9);
            gbAuto.Controls.Add(label5);
            gbAuto.Controls.Add(label6);
            gbAuto.Controls.Add(label7);
            gbAuto.Controls.Add(label8);
            gbAuto.Controls.Add(label4);
            gbAuto.Controls.Add(cb_Fuel);
            gbAuto.Controls.Add(label3);
            gbAuto.Controls.Add(cb_Color);
            gbAuto.Controls.Add(label2);
            gbAuto.Controls.Add(cb_Model);
            gbAuto.Controls.Add(dtp_reg_date);
            gbAuto.Controls.Add(tb_mileage);
            gbAuto.Controls.Add(tb_eng_cap);
            gbAuto.Controls.Add(tb_price);
            gbAuto.Controls.Add(tbId);
            gbAuto.Controls.Add(label1);
            gbAuto.Controls.Add(cb_Brand);
            gbAuto.Location = new System.Drawing.Point(12, 45);
            gbAuto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gbAuto.Name = "gbAuto";
            gbAuto.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gbAuto.Size = new System.Drawing.Size(597, 241);
            gbAuto.TabIndex = 18;
            gbAuto.TabStop = false;
            gbAuto.Text = "Car Details";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(19, 124);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(125, 20);
            label9.TabIndex = 34;
            label9.Text = "Registration Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(19, 195);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(63, 20);
            label5.TabIndex = 33;
            label5.Text = "Mileage";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(19, 157);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(115, 20);
            label6.TabIndex = 32;
            label6.Text = "Engine Capacity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(19, 87);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(41, 20);
            label7.TabIndex = 31;
            label7.Text = "Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(19, 52);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(50, 20);
            label8.TabIndex = 30;
            label8.Text = "Car ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(321, 192);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(36, 20);
            label4.TabIndex = 29;
            label4.Text = "Fuel";
            // 
            // cb_Fuel
            // 
            cb_Fuel.FormattingEnabled = true;
            cb_Fuel.Location = new System.Drawing.Point(425, 192);
            cb_Fuel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cb_Fuel.Name = "cb_Fuel";
            cb_Fuel.Size = new System.Drawing.Size(121, 28);
            cb_Fuel.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(321, 145);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(45, 20);
            label3.TabIndex = 27;
            label3.Text = "Color";
            // 
            // cb_Color
            // 
            cb_Color.FormattingEnabled = true;
            cb_Color.Location = new System.Drawing.Point(425, 145);
            cb_Color.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cb_Color.Name = "cb_Color";
            cb_Color.Size = new System.Drawing.Size(121, 28);
            cb_Color.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(321, 100);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(52, 20);
            label2.TabIndex = 25;
            label2.Text = "Model";
            // 
            // cb_Model
            // 
            cb_Model.FormattingEnabled = true;
            cb_Model.Location = new System.Drawing.Point(425, 100);
            cb_Model.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cb_Model.Name = "cb_Model";
            cb_Model.Size = new System.Drawing.Size(121, 28);
            cb_Model.TabIndex = 21;
            // 
            // dtp_reg_date
            // 
            dtp_reg_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtp_reg_date.Location = new System.Drawing.Point(167, 122);
            dtp_reg_date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dtp_reg_date.Name = "dtp_reg_date";
            dtp_reg_date.Size = new System.Drawing.Size(116, 27);
            dtp_reg_date.TabIndex = 17;
            // 
            // tb_mileage
            // 
            tb_mileage.Location = new System.Drawing.Point(167, 192);
            tb_mileage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tb_mileage.Name = "tb_mileage";
            tb_mileage.Size = new System.Drawing.Size(116, 27);
            tb_mileage.TabIndex = 19;
            // 
            // tb_eng_cap
            // 
            tb_eng_cap.Location = new System.Drawing.Point(167, 157);
            tb_eng_cap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tb_eng_cap.Name = "tb_eng_cap";
            tb_eng_cap.Size = new System.Drawing.Size(116, 27);
            tb_eng_cap.TabIndex = 18;
            // 
            // tb_price
            // 
            tb_price.Location = new System.Drawing.Point(167, 87);
            tb_price.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tb_price.Name = "tb_price";
            tb_price.Size = new System.Drawing.Size(116, 27);
            tb_price.TabIndex = 16;
            // 
            // tbId
            // 
            tbId.Location = new System.Drawing.Point(167, 52);
            tbId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbId.Name = "tbId";
            tbId.ReadOnly = true;
            tbId.Size = new System.Drawing.Size(116, 27);
            tbId.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(321, 56);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(74, 20);
            label1.TabIndex = 18;
            label1.Text = "Car Brand";
            // 
            // cb_Brand
            // 
            cb_Brand.FormattingEnabled = true;
            cb_Brand.Location = new System.Drawing.Point(423, 56);
            cb_Brand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cb_Brand.Name = "cb_Brand";
            cb_Brand.Size = new System.Drawing.Size(123, 28);
            cb_Brand.TabIndex = 20;
            cb_Brand.SelectedIndexChanged += cb_Brand_SelectedIndexChanged;
            // 
            // btnEdellinen
            // 
            btnEdellinen.Location = new System.Drawing.Point(63, 316);
            btnEdellinen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnEdellinen.Name = "btnEdellinen";
            btnEdellinen.Size = new System.Drawing.Size(93, 41);
            btnEdellinen.TabIndex = 4;
            btnEdellinen.Text = "&Previous";
            btnEdellinen.UseVisualStyleBackColor = true;
            btnEdellinen.Click += btnEdellinen_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { exitToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(761, 28);
            menuStrip1.TabIndex = 20;
            menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { exitToolStripMenuItem1 });
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            exitToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            exitToolStripMenuItem1.Text = "Poistu";
            exitToolStripMenuItem1.Click += exitToolStripMenuItem1_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { Test_DB_ToolStripMenuItem });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            aboutToolStripMenuItem.Text = "About...";
            // 
            // Test_DB_ToolStripMenuItem
            // 
            Test_DB_ToolStripMenuItem.Name = "Test_DB_ToolStripMenuItem";
            Test_DB_ToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            Test_DB_ToolStripMenuItem.Text = "Test Database (connection)";
            Test_DB_ToolStripMenuItem.Click += test_DataBase_ToolStripMenuItem_Click;
            // 
            // btn_Add_Car
            // 
            btn_Add_Car.Location = new System.Drawing.Point(645, 111);
            btn_Add_Car.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btn_Add_Car.Name = "btn_Add_Car";
            btn_Add_Car.Size = new System.Drawing.Size(89, 41);
            btn_Add_Car.TabIndex = 6;
            btn_Add_Car.Text = "Add Car";
            btn_Add_Car.UseVisualStyleBackColor = true;
            btn_Add_Car.Click += btn_Add_Car_Click;
            // 
            // btn_Close
            // 
            btn_Close.Location = new System.Drawing.Point(669, 330);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new System.Drawing.Size(65, 27);
            btn_Close.TabIndex = 12;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // btn_Edit
            // 
            btn_Edit.Location = new System.Drawing.Point(645, 159);
            btn_Edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new System.Drawing.Size(89, 41);
            btn_Edit.TabIndex = 8;
            btn_Edit.Text = "Edit Car";
            btn_Edit.UseVisualStyleBackColor = true;
            btn_Edit.Click += btn_Edit_Click;
            // 
            // btn_CancelChange
            // 
            btn_CancelChange.Location = new System.Drawing.Point(520, 316);
            btn_CancelChange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btn_CancelChange.Name = "btn_CancelChange";
            btn_CancelChange.Size = new System.Drawing.Size(89, 41);
            btn_CancelChange.TabIndex = 25;
            btn_CancelChange.Text = "Cancel";
            btn_CancelChange.UseVisualStyleBackColor = true;
            btn_CancelChange.Click += btn_CancelChange_Click;
            // 
            // btn_SaveChange
            // 
            btn_SaveChange.Location = new System.Drawing.Point(425, 316);
            btn_SaveChange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btn_SaveChange.Name = "btn_SaveChange";
            btn_SaveChange.Size = new System.Drawing.Size(89, 41);
            btn_SaveChange.TabIndex = 24;
            btn_SaveChange.Text = "Save";
            btn_SaveChange.UseVisualStyleBackColor = true;
            btn_SaveChange.Click += btn_SaveChange_Click;
            // 
            // btn_DeleteCar
            // 
            btn_DeleteCar.Location = new System.Drawing.Point(645, 206);
            btn_DeleteCar.Name = "btn_DeleteCar";
            btn_DeleteCar.Size = new System.Drawing.Size(87, 40);
            btn_DeleteCar.TabIndex = 10;
            btn_DeleteCar.Text = "Delete Car";
            btn_DeleteCar.UseVisualStyleBackColor = true;
            btn_DeleteCar.Click += btn_DeleteCar_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
            ClientSize = new System.Drawing.Size(761, 366);
            Controls.Add(btn_DeleteCar);
            Controls.Add(btn_CancelChange);
            Controls.Add(btn_SaveChange);
            Controls.Add(btn_Edit);
            Controls.Add(btn_Close);
            Controls.Add(btn_Add_Car);
            Controls.Add(btnEdellinen);
            Controls.Add(gbAuto);
            Controls.Add(btnSeuraava);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "MainMenu";
            Text = "Car Dealership";
            Load += MainMenu_Load;
            gbAuto.ResumeLayout(false);
            gbAuto.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnSeuraava;
        private System.Windows.Forms.GroupBox gbAuto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_Fuel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Color;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Model;
        private System.Windows.Forms.DateTimePicker dtp_reg_date;
        private System.Windows.Forms.TextBox tb_mileage;
        private System.Windows.Forms.TextBox tb_eng_cap;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Brand;
        private System.Windows.Forms.Button btnEdellinen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Test_DB_ToolStripMenuItem;
        private System.Windows.Forms.Button btn_Add_Car;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_CancelChange;
        private System.Windows.Forms.Button btn_SaveChange;
        private System.Windows.Forms.Button btn_DeleteCar;
    }
}