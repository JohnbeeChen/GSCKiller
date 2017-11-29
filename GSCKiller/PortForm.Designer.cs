namespace GSCKiller
{
    partial class PortForm
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
            this.Comb_parity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Comb_stopbit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Comb_databit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBox_RTS = new System.Windows.Forms.CheckBox();
            this.cBox_Crlf = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Comb_Bps = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Comb_Port = new System.Windows.Forms.ComboBox();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Comb_parity
            // 
            this.Comb_parity.FormattingEnabled = true;
            this.Comb_parity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.Comb_parity.Location = new System.Drawing.Point(139, 177);
            this.Comb_parity.Name = "Comb_parity";
            this.Comb_parity.Size = new System.Drawing.Size(121, 23);
            this.Comb_parity.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "   Parity:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Comb_stopbit
            // 
            this.Comb_stopbit.FormattingEnabled = true;
            this.Comb_stopbit.Items.AddRange(new object[] {
            "None",
            "One",
            "Two"});
            this.Comb_stopbit.Location = new System.Drawing.Point(395, 109);
            this.Comb_stopbit.Name = "Comb_stopbit";
            this.Comb_stopbit.Size = new System.Drawing.Size(121, 23);
            this.Comb_stopbit.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Stop bits:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Comb_databit
            // 
            this.Comb_databit.FormattingEnabled = true;
            this.Comb_databit.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.Comb_databit.Location = new System.Drawing.Point(138, 112);
            this.Comb_databit.Name = "Comb_databit";
            this.Comb_databit.Size = new System.Drawing.Size(121, 23);
            this.Comb_databit.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Data bits:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cBox_RTS
            // 
            this.cBox_RTS.AutoSize = true;
            this.cBox_RTS.Location = new System.Drawing.Point(446, 181);
            this.cBox_RTS.Name = "cBox_RTS";
            this.cBox_RTS.Size = new System.Drawing.Size(53, 19);
            this.cBox_RTS.TabIndex = 12;
            this.cBox_RTS.Text = "RTS";
            this.cBox_RTS.UseVisualStyleBackColor = true;
            // 
            // cBox_Crlf
            // 
            this.cBox_Crlf.AutoSize = true;
            this.cBox_Crlf.Location = new System.Drawing.Point(324, 179);
            this.cBox_Crlf.Name = "cBox_Crlf";
            this.cBox_Crlf.Size = new System.Drawing.Size(69, 19);
            this.cBox_Crlf.TabIndex = 11;
            this.cBox_Crlf.Text = "CR+LF";
            this.cBox_Crlf.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "BaudRate:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Comb_Bps
            // 
            this.Comb_Bps.FormattingEnabled = true;
            this.Comb_Bps.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.Comb_Bps.Location = new System.Drawing.Point(395, 51);
            this.Comb_Bps.Name = "Comb_Bps";
            this.Comb_Bps.Size = new System.Drawing.Size(121, 23);
            this.Comb_Bps.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "PortName:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Comb_Port
            // 
            this.Comb_Port.FormattingEnabled = true;
            this.Comb_Port.Items.AddRange(new object[] {
            "None",
            "One",
            "Two"});
            this.Comb_Port.Location = new System.Drawing.Point(138, 55);
            this.Comb_Port.Name = "Comb_Port";
            this.Comb_Port.Size = new System.Drawing.Size(121, 23);
            this.Comb_Port.TabIndex = 25;
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(163, 272);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(75, 35);
            this.btn_open.TabIndex = 26;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(347, 272);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 35);
            this.btn_refresh.TabIndex = 27;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // PortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 357);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.cBox_Crlf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Comb_Bps);
            this.Controls.Add(this.cBox_RTS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Comb_parity);
            this.Controls.Add(this.Comb_Port);
            this.Controls.Add(this.Comb_databit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Comb_stopbit);
            this.Name = "PortForm";
            this.Text = "PortForm";
            this.Load += new System.EventHandler(this.PortForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox Comb_parity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Comb_stopbit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Comb_databit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cBox_RTS;
        private System.Windows.Forms.CheckBox cBox_Crlf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Comb_Bps;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Comb_Port;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_refresh;
    }
}