namespace hopverk
{
    partial class Admin
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
            this.li_lager = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // li_lager
            // 
            this.li_lager.FullRowSelect = true;
            this.li_lager.GridLines = true;
            this.li_lager.Location = new System.Drawing.Point(4, 4);
            this.li_lager.Name = "li_lager";
            this.li_lager.Size = new System.Drawing.Size(434, 178);
            this.li_lager.TabIndex = 16;
            this.li_lager.UseCompatibleStateImageBehavior = false;
            this.li_lager.View = System.Windows.Forms.View.Details;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 188);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(434, 20);
            this.textBox1.TabIndex = 17;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 557);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.li_lager);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView li_lager;
        private System.Windows.Forms.TextBox textBox1;
    }
}