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
            this.btn_Home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Home
            // 
            this.btn_Home.Location = new System.Drawing.Point(341, 216);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(90, 75);
            this.btn_Home.TabIndex = 0;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // GSC_Controller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 561);
            this.Controls.Add(this.btn_Home);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GSC_Controller";
            this.Text = "GSC_Controller";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Home;
    }
}