namespace GSCkiller.Forms
{
    partial class PortDetailSeting
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
            this.cBox_Crlf = new System.Windows.Forms.CheckBox();
            this.cBox_RTS = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comb_databit = new System.Windows.Forms.ComboBox();
            this.comb_stopbit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comb_parity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_setting = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cBox_Crlf
            // 
            this.cBox_Crlf.AutoSize = true;
            this.cBox_Crlf.Location = new System.Drawing.Point(274, 45);
            this.cBox_Crlf.Name = "cBox_Crlf";
            this.cBox_Crlf.Size = new System.Drawing.Size(69, 19);
            this.cBox_Crlf.TabIndex = 0;
            this.cBox_Crlf.Text = "CR+LF";
            this.cBox_Crlf.UseVisualStyleBackColor = true;
            // 
            // cBox_RTS
            // 
            this.cBox_RTS.AutoSize = true;
            this.cBox_RTS.Location = new System.Drawing.Point(274, 92);
            this.cBox_RTS.Name = "cBox_RTS";
            this.cBox_RTS.Size = new System.Drawing.Size(53, 19);
            this.cBox_RTS.TabIndex = 1;
            this.cBox_RTS.Text = "RTS";
            this.cBox_RTS.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data bits:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comb_databit
            // 
            this.comb_databit.FormattingEnabled = true;
            this.comb_databit.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.comb_databit.Location = new System.Drawing.Point(111, 26);
            this.comb_databit.Name = "comb_databit";
            this.comb_databit.Size = new System.Drawing.Size(121, 23);
            this.comb_databit.TabIndex = 3;
            // 
            // comb_stopbit
            // 
            this.comb_stopbit.FormattingEnabled = true;
            this.comb_stopbit.Items.AddRange(new object[] {
            "None",
            "One",
            "Two"});
            this.comb_stopbit.Location = new System.Drawing.Point(111, 68);
            this.comb_stopbit.Name = "comb_stopbit";
            this.comb_stopbit.Size = new System.Drawing.Size(121, 23);
            this.comb_stopbit.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Stop bits:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comb_parity
            // 
            this.comb_parity.FormattingEnabled = true;
            this.comb_parity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.comb_parity.Location = new System.Drawing.Point(111, 109);
            this.comb_parity.Name = "comb_parity";
            this.comb_parity.Size = new System.Drawing.Size(121, 23);
            this.comb_parity.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "   Parity:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_setting
            // 
            this.btn_setting.Location = new System.Drawing.Point(84, 204);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(75, 35);
            this.btn_setting.TabIndex = 9;
            this.btn_setting.Text = "Setting";
            this.btn_setting.UseVisualStyleBackColor = true;
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(243, 204);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 35);
            this.btn_cancel.TabIndex = 10;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // PortDetailSeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 264);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_setting);
            this.Controls.Add(this.comb_parity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comb_stopbit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comb_databit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBox_RTS);
            this.Controls.Add(this.cBox_Crlf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PortDetailSeting";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PortDetailSeting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cBox_Crlf;
        private System.Windows.Forms.CheckBox cBox_RTS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comb_databit;
        private System.Windows.Forms.ComboBox comb_stopbit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comb_parity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.Button btn_cancel;
    }
}