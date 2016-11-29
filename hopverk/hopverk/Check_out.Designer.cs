namespace hopverk
{
    partial class Check_out
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
            this.li_korfa = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // li_korfa
            // 
            this.li_korfa.FullRowSelect = true;
            this.li_korfa.GridLines = true;
            this.li_korfa.Location = new System.Drawing.Point(16, 15);
            this.li_korfa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.li_korfa.Name = "li_korfa";
            this.li_korfa.Size = new System.Drawing.Size(577, 229);
            this.li_korfa.TabIndex = 15;
            this.li_korfa.UseCompatibleStateImageBehavior = false;
            this.li_korfa.View = System.Windows.Forms.View.Details;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(317, 53);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Check_out
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 362);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.li_korfa);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Check_out";
            this.Text = "Check_out";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView li_korfa;
        private System.Windows.Forms.Button button1;
    }
}