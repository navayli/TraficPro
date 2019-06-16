namespace Trafficpro
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbxDrNumİnput = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPenalty = new System.Windows.Forms.Label();
            this.lblExpireDate = new System.Windows.Forms.Label();
            this.lblDriverSurname = new System.Windows.Forms.Label();
            this.lblDriverName = new System.Windows.Forms.Label();
            this.lxbxDriverNumber = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lnkProtocolForm = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Driver Number";
            // 
            // txbxDrNumİnput
            // 
            this.txbxDrNumİnput.Location = new System.Drawing.Point(15, 38);
            this.txbxDrNumİnput.Name = "txbxDrNumİnput";
            this.txbxDrNumİnput.Size = new System.Drawing.Size(163, 20);
            this.txbxDrNumİnput.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(49, 84);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Driver Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Driver Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "License Expire Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Penalty Ball";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblPenalty
            // 
            this.lblPenalty.AutoSize = true;
            this.lblPenalty.Location = new System.Drawing.Point(136, 301);
            this.lblPenalty.Name = "lblPenalty";
            this.lblPenalty.Size = new System.Drawing.Size(0, 13);
            this.lblPenalty.TabIndex = 10;
            // 
            // lblExpireDate
            // 
            this.lblExpireDate.AutoSize = true;
            this.lblExpireDate.Location = new System.Drawing.Point(135, 253);
            this.lblExpireDate.Name = "lblExpireDate";
            this.lblExpireDate.Size = new System.Drawing.Size(0, 13);
            this.lblExpireDate.TabIndex = 9;
            // 
            // lblDriverSurname
            // 
            this.lblDriverSurname.AutoSize = true;
            this.lblDriverSurname.Location = new System.Drawing.Point(135, 205);
            this.lblDriverSurname.Name = "lblDriverSurname";
            this.lblDriverSurname.Size = new System.Drawing.Size(0, 13);
            this.lblDriverSurname.TabIndex = 8;
            // 
            // lblDriverName
            // 
            this.lblDriverName.AutoSize = true;
            this.lblDriverName.Location = new System.Drawing.Point(136, 159);
            this.lblDriverName.Name = "lblDriverName";
            this.lblDriverName.Size = new System.Drawing.Size(0, 13);
            this.lblDriverName.TabIndex = 7;
            // 
            // lxbxDriverNumber
            // 
            this.lxbxDriverNumber.FormattingEnabled = true;
            this.lxbxDriverNumber.Location = new System.Drawing.Point(252, 150);
            this.lxbxDriverNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lxbxDriverNumber.Name = "lxbxDriverNumber";
            this.lxbxDriverNumber.Size = new System.Drawing.Size(131, 134);
            this.lxbxDriverNumber.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(261, 115);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Radar Info System";
            // 
            // lnkProtocolForm
            // 
            this.lnkProtocolForm.AutoSize = true;
            this.lnkProtocolForm.Location = new System.Drawing.Point(373, 26);
            this.lnkProtocolForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkProtocolForm.Name = "lnkProtocolForm";
            this.lnkProtocolForm.Size = new System.Drawing.Size(72, 13);
            this.lnkProtocolForm.TabIndex = 13;
            this.lnkProtocolForm.TabStop = true;
            this.lnkProtocolForm.Text = "Protocol Form";
            this.lnkProtocolForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkProtocolForm_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 406);
            this.Controls.Add(this.lnkProtocolForm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lxbxDriverNumber);
            this.Controls.Add(this.lblPenalty);
            this.Controls.Add(this.lblExpireDate);
            this.Controls.Add(this.lblDriverSurname);
            this.Controls.Add(this.lblDriverName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txbxDrNumİnput);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbxDrNumİnput;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPenalty;
        private System.Windows.Forms.Label lblExpireDate;
        private System.Windows.Forms.Label lblDriverSurname;
        private System.Windows.Forms.Label lblDriverName;
        private System.Windows.Forms.ListBox lxbxDriverNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel lnkProtocolForm;
    }
}

