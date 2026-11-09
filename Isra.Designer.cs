namespace Assignment5
{
    partial class Isra
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpNewEvent = new GroupBox();
            btnCreateEvent = new Button();
            txtFeePerParticipant = new TextBox();
            txtCostPerParticipant = new TextBox();
            txtEventTitle = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            grpEconomy = new GroupBox();
            txtSurplus = new Label();
            txtTotalFees = new Label();
            txtTotalCost = new Label();
            txtNumberOfParticipants = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            grpAddParticipant = new GroupBox();
            cmbCountry = new ComboBox();
            txtCity = new TextBox();
            txtZipCode = new TextBox();
            txtStreet = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            btnAddParticipant = new Button();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            listBox = new ListBox();
            label14 = new Label();
            label15 = new Label();
            grpBoxParticipants = new GroupBox();
            btnDelete = new Button();
            btnChange = new Button();
            grpNewEvent.SuspendLayout();
            grpEconomy.SuspendLayout();
            grpAddParticipant.SuspendLayout();
            grpBoxParticipants.SuspendLayout();
            SuspendLayout();
            // 
            // grpNewEvent
            // 
            grpNewEvent.Controls.Add(btnCreateEvent);
            grpNewEvent.Controls.Add(txtFeePerParticipant);
            grpNewEvent.Controls.Add(txtCostPerParticipant);
            grpNewEvent.Controls.Add(txtEventTitle);
            grpNewEvent.Controls.Add(label3);
            grpNewEvent.Controls.Add(label2);
            grpNewEvent.Controls.Add(label1);
            grpNewEvent.Font = new Font("Segoe UI", 10F);
            grpNewEvent.ForeColor = Color.Teal;
            grpNewEvent.Location = new Point(12, 12);
            grpNewEvent.Name = "grpNewEvent";
            grpNewEvent.Size = new Size(607, 259);
            grpNewEvent.TabIndex = 0;
            grpNewEvent.TabStop = false;
            grpNewEvent.Text = "New Event";
            // 
            // btnCreateEvent
            // 
            btnCreateEvent.ForeColor = Color.Teal;
            btnCreateEvent.Location = new Point(140, 191);
            btnCreateEvent.Name = "btnCreateEvent";
            btnCreateEvent.Size = new Size(219, 47);
            btnCreateEvent.TabIndex = 6;
            btnCreateEvent.Text = "Create Event";
            btnCreateEvent.UseVisualStyleBackColor = true;
            btnCreateEvent.Click += btnCreateEvent_Click_1;
            // 
            // txtFeePerParticipant
            // 
            txtFeePerParticipant.Location = new Point(299, 144);
            txtFeePerParticipant.Name = "txtFeePerParticipant";
            txtFeePerParticipant.Size = new Size(90, 30);
            txtFeePerParticipant.TabIndex = 5;
            // 
            // txtCostPerParticipant
            // 
            txtCostPerParticipant.Location = new Point(299, 86);
            txtCostPerParticipant.Name = "txtCostPerParticipant";
            txtCostPerParticipant.Size = new Size(90, 30);
            txtCostPerParticipant.TabIndex = 4;
            // 
            // txtEventTitle
            // 
            txtEventTitle.Location = new Point(299, 38);
            txtEventTitle.Name = "txtEventTitle";
            txtEventTitle.Size = new Size(287, 30);
            txtEventTitle.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(22, 147);
            label3.Name = "label3";
            label3.Size = new Size(153, 23);
            label3.TabIndex = 2;
            label3.Text = "Fee per participant";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(22, 93);
            label2.Name = "label2";
            label2.Size = new Size(161, 23);
            label2.TabIndex = 1;
            label2.Text = "Cost per participant";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(22, 45);
            label1.Name = "label1";
            label1.Size = new Size(86, 23);
            label1.TabIndex = 0;
            label1.Text = "Event title";
            // 
            // grpEconomy
            // 
            grpEconomy.Controls.Add(txtSurplus);
            grpEconomy.Controls.Add(txtTotalFees);
            grpEconomy.Controls.Add(txtTotalCost);
            grpEconomy.Controls.Add(txtNumberOfParticipants);
            grpEconomy.Controls.Add(label7);
            grpEconomy.Controls.Add(label6);
            grpEconomy.Controls.Add(label5);
            grpEconomy.Controls.Add(label4);
            grpEconomy.Location = new Point(637, 12);
            grpEconomy.Name = "grpEconomy";
            grpEconomy.Size = new Size(428, 259);
            grpEconomy.TabIndex = 1;
            grpEconomy.TabStop = false;
            grpEconomy.Text = "Event Economy";
            // 
            // txtSurplus
            // 
            txtSurplus.AutoSize = true;
            txtSurplus.Location = new Point(280, 181);
            txtSurplus.Name = "txtSurplus";
            txtSurplus.Size = new Size(36, 20);
            txtSurplus.TabIndex = 7;
            txtSurplus.Text = "0.00";
            // 
            // txtTotalFees
            // 
            txtTotalFees.AutoSize = true;
            txtTotalFees.Location = new Point(280, 135);
            txtTotalFees.Name = "txtTotalFees";
            txtTotalFees.Size = new Size(36, 20);
            txtTotalFees.TabIndex = 6;
            txtTotalFees.Text = "0.00";
            // 
            // txtTotalCost
            // 
            txtTotalCost.AutoSize = true;
            txtTotalCost.Location = new Point(280, 91);
            txtTotalCost.Name = "txtTotalCost";
            txtTotalCost.Size = new Size(36, 20);
            txtTotalCost.TabIndex = 5;
            txtTotalCost.Text = "0.00";
            // 
            // txtNumberOfParticipants
            // 
            txtNumberOfParticipants.AutoSize = true;
            txtNumberOfParticipants.Location = new Point(280, 48);
            txtNumberOfParticipants.Name = "txtNumberOfParticipants";
            txtNumberOfParticipants.Size = new Size(17, 20);
            txtNumberOfParticipants.TabIndex = 4;
            txtNumberOfParticipants.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Green;
            label7.Location = new Point(28, 181);
            label7.Name = "label7";
            label7.Size = new Size(105, 20);
            label7.TabIndex = 3;
            label7.Text = "Surplus/deficit";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Green;
            label6.Location = new Point(28, 135);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 2;
            label6.Text = "Total fees";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Green;
            label5.Location = new Point(28, 91);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 1;
            label5.Text = "Total Cost";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Green;
            label4.Location = new Point(28, 48);
            label4.Name = "label4";
            label4.Size = new Size(163, 20);
            label4.TabIndex = 0;
            label4.Text = "Number of participants";
            // 
            // grpAddParticipant
            // 
            grpAddParticipant.Controls.Add(cmbCountry);
            grpAddParticipant.Controls.Add(txtCity);
            grpAddParticipant.Controls.Add(txtZipCode);
            grpAddParticipant.Controls.Add(txtStreet);
            grpAddParticipant.Controls.Add(txtLastName);
            grpAddParticipant.Controls.Add(txtFirstName);
            grpAddParticipant.Controls.Add(btnAddParticipant);
            grpAddParticipant.Controls.Add(label13);
            grpAddParticipant.Controls.Add(label12);
            grpAddParticipant.Controls.Add(label11);
            grpAddParticipant.Controls.Add(label10);
            grpAddParticipant.Controls.Add(label9);
            grpAddParticipant.Controls.Add(label8);
            grpAddParticipant.ForeColor = Color.Teal;
            grpAddParticipant.Location = new Point(12, 289);
            grpAddParticipant.Name = "grpAddParticipant";
            grpAddParticipant.Size = new Size(449, 357);
            grpAddParticipant.TabIndex = 2;
            grpAddParticipant.TabStop = false;
            grpAddParticipant.Text = "Add participant";
            // 
            // cmbCountry
            // 
            cmbCountry.FormattingEnabled = true;
            cmbCountry.Location = new Point(243, 243);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new Size(189, 28);
            cmbCountry.TabIndex = 14;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(243, 203);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(189, 27);
            txtCity.TabIndex = 12;
            // 
            // txtZipCode
            // 
            txtZipCode.Location = new Point(243, 158);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(189, 27);
            txtZipCode.TabIndex = 11;
            // 
            // txtStreet
            // 
            txtStreet.Location = new Point(243, 118);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(189, 27);
            txtStreet.TabIndex = 10;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(243, 79);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(189, 27);
            txtLastName.TabIndex = 9;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(243, 45);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(189, 27);
            txtFirstName.TabIndex = 8;
            // 
            // btnAddParticipant
            // 
            btnAddParticipant.Location = new Point(140, 288);
            btnAddParticipant.Name = "btnAddParticipant";
            btnAddParticipant.Size = new Size(219, 41);
            btnAddParticipant.TabIndex = 7;
            btnAddParticipant.Text = "Add";
            btnAddParticipant.UseVisualStyleBackColor = true;
            btnAddParticipant.Click += btnAddParticipant_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Black;
            label13.Location = new Point(22, 251);
            label13.Name = "label13";
            label13.Size = new Size(60, 20);
            label13.TabIndex = 6;
            label13.Text = "Country";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Black;
            label12.Location = new Point(22, 210);
            label12.Name = "label12";
            label12.Size = new Size(34, 20);
            label12.TabIndex = 5;
            label12.Text = "City";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Black;
            label11.Location = new Point(22, 166);
            label11.Name = "label11";
            label11.Size = new Size(70, 20);
            label11.TabIndex = 4;
            label11.Text = "Zip Code";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Black;
            label10.Location = new Point(22, 125);
            label10.Name = "label10";
            label10.Size = new Size(48, 20);
            label10.TabIndex = 3;
            label10.Text = "Street";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Black;
            label9.Location = new Point(22, 86);
            label9.Name = "label9";
            label9.Size = new Size(83, 20);
            label9.TabIndex = 2;
            label9.Text = "Last Name ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Black;
            label8.Location = new Point(22, 48);
            label8.Name = "label8";
            label8.Size = new Size(84, 20);
            label8.TabIndex = 0;
            label8.Text = "First Name ";
            // 
            // listBox
            // 
            listBox.AccessibleRole = AccessibleRole.MenuBar;
            listBox.FormattingEnabled = true;
            listBox.Location = new Point(6, 67);
            listBox.Name = "listBox";
            listBox.Size = new Size(586, 224);
            listBox.TabIndex = 0;
            listBox.SelectedIndexChanged += listBox_SelectedIndexChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.Teal;
            label14.Location = new Point(39, 32);
            label14.Name = "label14";
            label14.Size = new Size(79, 20);
            label14.TabIndex = 1;
            label14.Text = "Participant";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.Teal;
            label15.Location = new Point(358, 32);
            label15.Name = "label15";
            label15.Size = new Size(53, 20);
            label15.TabIndex = 2;
            label15.Text = "Adress";
            // 
            // grpBoxParticipants
            // 
            grpBoxParticipants.Controls.Add(btnDelete);
            grpBoxParticipants.Controls.Add(btnChange);
            grpBoxParticipants.Controls.Add(label15);
            grpBoxParticipants.Controls.Add(label14);
            grpBoxParticipants.Controls.Add(listBox);
            grpBoxParticipants.Location = new Point(467, 289);
            grpBoxParticipants.Name = "grpBoxParticipants";
            grpBoxParticipants.Size = new Size(598, 357);
            grpBoxParticipants.TabIndex = 3;
            grpBoxParticipants.TabStop = false;
            grpBoxParticipants.Text = "Participants";
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = Color.Teal;
            btnDelete.Location = new Point(296, 304);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(186, 42);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnChange
            // 
            btnChange.ForeColor = Color.Teal;
            btnChange.Location = new Point(85, 304);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(186, 42);
            btnChange.TabIndex = 3;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // Isra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 658);
            Controls.Add(grpBoxParticipants);
            Controls.Add(grpAddParticipant);
            Controls.Add(grpEconomy);
            Controls.Add(grpNewEvent);
            Name = "Isra";
            Text = "Isra";
            grpNewEvent.ResumeLayout(false);
            grpNewEvent.PerformLayout();
            grpEconomy.ResumeLayout(false);
            grpEconomy.PerformLayout();
            grpAddParticipant.ResumeLayout(false);
            grpAddParticipant.PerformLayout();
            grpBoxParticipants.ResumeLayout(false);
            grpBoxParticipants.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpNewEvent;
        private Label label1;
        private TextBox txtCostPerParticipant;
        private TextBox txtEventTitle;
        private Label label3;
        private Label label2;
        private Button btnCreateEvent;
        private TextBox txtFeePerParticipant;
        private GroupBox grpEconomy;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private GroupBox grpAddParticipant;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox txtFirstName;
        private Button btnAddParticipant;
        private TextBox txtCity;
        private TextBox txtZipCode;
        private TextBox txtStreet;
        private TextBox txtLastName;
        private ListBox listBox;
        private Label label14;
        private Label label15;
        private GroupBox grpBoxParticipants;
        private Button btnDelete;
        private Button btnChange;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label txtNumberOfParticipants;
        private Label txtSurplus;
        private Label txtTotalFees;
        private Label txtTotalCost;
        private ComboBox cmbCountry;
    }
}
