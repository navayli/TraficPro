namespace Trafficpro
{
    partial class ProtocolForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnDrawProtocol = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSumPnBall = new System.Windows.Forms.Label();
            this.lblPnAmaount = new System.Windows.Forms.Label();
            this.lblCrNumber = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPenBall = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDriverName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Protc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarNun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Car Number";
            // 
            // btnDrawProtocol
            // 
            this.btnDrawProtocol.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDrawProtocol.Location = new System.Drawing.Point(60, 283);
            this.btnDrawProtocol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDrawProtocol.Name = "btnDrawProtocol";
            this.btnDrawProtocol.Size = new System.Drawing.Size(146, 46);
            this.btnDrawProtocol.TabIndex = 2;
            this.btnDrawProtocol.Text = "Print Protocol";
            this.btnDrawProtocol.UseVisualStyleBackColor = true;
            this.btnDrawProtocol.Click += new System.EventHandler(this.btnDrawProtocol_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Penalty Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(20, 243);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Summary of Penalty Ball";
            // 
            // lblSumPnBall
            // 
            this.lblSumPnBall.AutoSize = true;
            this.lblSumPnBall.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSumPnBall.Location = new System.Drawing.Point(175, 243);
            this.lblSumPnBall.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSumPnBall.Name = "lblSumPnBall";
            this.lblSumPnBall.Size = new System.Drawing.Size(0, 13);
            this.lblSumPnBall.TabIndex = 11;
            // 
            // lblPnAmaount
            // 
            this.lblPnAmaount.AutoSize = true;
            this.lblPnAmaount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPnAmaount.Location = new System.Drawing.Point(176, 175);
            this.lblPnAmaount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPnAmaount.Name = "lblPnAmaount";
            this.lblPnAmaount.Size = new System.Drawing.Size(0, 13);
            this.lblPnAmaount.TabIndex = 10;
            // 
            // lblCrNumber
            // 
            this.lblCrNumber.AutoSize = true;
            this.lblCrNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCrNumber.Location = new System.Drawing.Point(175, 108);
            this.lblCrNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCrNumber.Name = "lblCrNumber";
            this.lblCrNumber.Size = new System.Drawing.Size(0, 13);
            this.lblCrNumber.TabIndex = 9;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSpeed.Location = new System.Drawing.Point(175, 141);
            this.lblSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(0, 13);
            this.lblSpeed.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(20, 211);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Penalty Ball ";
            // 
            // lblPenBall
            // 
            this.lblPenBall.AutoSize = true;
            this.lblPenBall.Location = new System.Drawing.Point(176, 211);
            this.lblPenBall.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPenBall.Name = "lblPenBall";
            this.lblPenBall.Size = new System.Drawing.Size(0, 13);
            this.lblPenBall.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(20, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Driver Name";
            // 
            // lblDriverName
            // 
            this.lblDriverName.AutoSize = true;
            this.lblDriverName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDriverName.Location = new System.Drawing.Point(176, 71);
            this.lblDriverName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDriverName.Name = "lblDriverName";
            this.lblDriverName.Size = new System.Drawing.Size(0, 13);
            this.lblDriverName.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(431, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Protocol Date Base";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Protc,
            this.Drv,
            this.CarNun});
            this.dataGridView1.Location = new System.Drawing.Point(302, 52);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(336, 226);
            this.dataGridView1.TabIndex = 17;
            // 
            // Protc
            // 
            this.Protc.HeaderText = "Protocol №";
            this.Protc.Name = "Protc";
            // 
            // Drv
            // 
            this.Drv.HeaderText = "Driver №";
            this.Drv.Name = "Drv";
            // 
            // CarNun
            // 
            this.CarNun.HeaderText = "Car №";
            this.CarNun.Name = "CarNun";
            // 
            // ProtocolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 366);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblDriverName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPenBall);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSumPnBall);
            this.Controls.Add(this.lblPnAmaount);
            this.Controls.Add(this.lblCrNumber);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDrawProtocol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ProtocolForm";
            this.Text = "ProtocolForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDrawProtocol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSumPnBall;
        private System.Windows.Forms.Label lblPnAmaount;
        private System.Windows.Forms.Label lblCrNumber;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPenBall;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDriverName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Protc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drv;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarNun;
    }
}