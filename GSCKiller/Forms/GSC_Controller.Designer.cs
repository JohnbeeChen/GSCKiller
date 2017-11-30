namespace GSCKiller.Forms
{
    partial class GSC_Controller
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
            this.btn_HomeX = new System.Windows.Forms.Button();
            this.btn_HomeY = new System.Windows.Forms.Button();
            this.btn_HomeR = new System.Windows.Forms.Button();
            this.btn_JogX = new System.Windows.Forms.Button();
            this.btn_JogY = new System.Windows.Forms.Button();
            this.btn_JogR = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_HomeX
            // 
            this.btn_HomeX.Location = new System.Drawing.Point(161, 42);
            this.btn_HomeX.Name = "btn_HomeX";
            this.btn_HomeX.Size = new System.Drawing.Size(90, 75);
            this.btn_HomeX.TabIndex = 0;
            this.btn_HomeX.Text = "HomeX";
            this.btn_HomeX.UseVisualStyleBackColor = true;
            this.btn_HomeX.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // btn_HomeY
            // 
            this.btn_HomeY.Location = new System.Drawing.Point(322, 42);
            this.btn_HomeY.Name = "btn_HomeY";
            this.btn_HomeY.Size = new System.Drawing.Size(90, 75);
            this.btn_HomeY.TabIndex = 1;
            this.btn_HomeY.Text = "HomeY";
            this.btn_HomeY.UseVisualStyleBackColor = true;
            this.btn_HomeY.Click += new System.EventHandler(this.btn_HomeY_Click);
            // 
            // btn_HomeR
            // 
            this.btn_HomeR.Location = new System.Drawing.Point(487, 42);
            this.btn_HomeR.Name = "btn_HomeR";
            this.btn_HomeR.Size = new System.Drawing.Size(90, 75);
            this.btn_HomeR.TabIndex = 2;
            this.btn_HomeR.Text = "HomeR";
            this.btn_HomeR.UseVisualStyleBackColor = true;
            this.btn_HomeR.Click += new System.EventHandler(this.btn_HomeR_Click);
            // 
            // btn_JogX
            // 
            this.btn_JogX.Location = new System.Drawing.Point(161, 188);
            this.btn_JogX.Name = "btn_JogX";
            this.btn_JogX.Size = new System.Drawing.Size(90, 75);
            this.btn_JogX.TabIndex = 3;
            this.btn_JogX.Text = "JogX";
            this.btn_JogX.UseVisualStyleBackColor = true;
            this.btn_JogX.Click += new System.EventHandler(this.btn_JogX_Click);
            // 
            // btn_JogY
            // 
            this.btn_JogY.Location = new System.Drawing.Point(322, 188);
            this.btn_JogY.Name = "btn_JogY";
            this.btn_JogY.Size = new System.Drawing.Size(90, 75);
            this.btn_JogY.TabIndex = 4;
            this.btn_JogY.Text = "JogY";
            this.btn_JogY.UseVisualStyleBackColor = true;
            this.btn_JogY.Click += new System.EventHandler(this.btn_JogY_Click);
            // 
            // btn_JogR
            // 
            this.btn_JogR.Location = new System.Drawing.Point(487, 188);
            this.btn_JogR.Name = "btn_JogR";
            this.btn_JogR.Size = new System.Drawing.Size(90, 75);
            this.btn_JogR.TabIndex = 5;
            this.btn_JogR.Text = "JogR";
            this.btn_JogR.UseVisualStyleBackColor = true;
            this.btn_JogR.Click += new System.EventHandler(this.btn_JogR_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(487, 318);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(90, 75);
            this.btn_Stop.TabIndex = 6;
            this.btn_Stop.Text = "StopR";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 75);
            this.button1.TabIndex = 7;
            this.button1.Text = "StopX";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(322, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 75);
            this.button2.TabIndex = 8;
            this.button2.Text = "StopY";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GSC_Controller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_JogR);
            this.Controls.Add(this.btn_JogY);
            this.Controls.Add(this.btn_JogX);
            this.Controls.Add(this.btn_HomeR);
            this.Controls.Add(this.btn_HomeY);
            this.Controls.Add(this.btn_HomeX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GSC_Controller";
            this.Text = "GSC_Controller";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_HomeX;
        private System.Windows.Forms.Button btn_HomeY;
        private System.Windows.Forms.Button btn_HomeR;
        private System.Windows.Forms.Button btn_JogX;
        private System.Windows.Forms.Button btn_JogY;
        private System.Windows.Forms.Button btn_JogR;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}