﻿namespace hopverk
{
    partial class Form1
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
            this.bt_korfu = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bt_admin = new System.Windows.Forms.Button();
            this.bt_Check_out = new System.Windows.Forms.Button();
            this.li_korfa = new System.Windows.Forms.ListView();
            this.li_lager = new System.Windows.Forms.ListView();
            this.bt_eda = new System.Windows.Forms.Button();
            this.tb_magn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_korfu
            // 
            this.bt_korfu.Location = new System.Drawing.Point(484, 34);
            this.bt_korfu.Name = "bt_korfu";
            this.bt_korfu.Size = new System.Drawing.Size(75, 23);
            this.bt_korfu.TabIndex = 1;
            this.bt_korfu.Text = "bæta i korfu";
            this.bt_korfu.UseVisualStyleBackColor = true;
            this.bt_korfu.Click += new System.EventHandler(this.bt_korfu_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 226);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(391, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bt_admin
            // 
            this.bt_admin.Location = new System.Drawing.Point(24, 5);
            this.bt_admin.Name = "bt_admin";
            this.bt_admin.Size = new System.Drawing.Size(75, 23);
            this.bt_admin.TabIndex = 5;
            this.bt_admin.Text = "Admin";
            this.bt_admin.UseVisualStyleBackColor = true;
            this.bt_admin.Click += new System.EventHandler(this.bt_admin_Click);
            // 
            // bt_Check_out
            // 
            this.bt_Check_out.Location = new System.Drawing.Point(756, 227);
            this.bt_Check_out.Name = "bt_Check_out";
            this.bt_Check_out.Size = new System.Drawing.Size(75, 23);
            this.bt_Check_out.TabIndex = 6;
            this.bt_Check_out.Text = "Check out";
            this.bt_Check_out.UseVisualStyleBackColor = true;
            this.bt_Check_out.Click += new System.EventHandler(this.bt_Check_out_Click);
            // 
            // li_korfa
            // 
            this.li_korfa.FullRowSelect = true;
            this.li_korfa.GridLines = true;
            this.li_korfa.Location = new System.Drawing.Point(583, 34);
            this.li_korfa.Name = "li_korfa";
            this.li_korfa.Size = new System.Drawing.Size(434, 187);
            this.li_korfa.TabIndex = 14;
            this.li_korfa.UseCompatibleStateImageBehavior = false;
            this.li_korfa.View = System.Windows.Forms.View.Details;
            this.li_korfa.SelectedIndexChanged += new System.EventHandler(this.li_korfa_SelectedIndexChanged);
            // 
            // li_lager
            // 
            this.li_lager.FullRowSelect = true;
            this.li_lager.GridLines = true;
            this.li_lager.Location = new System.Drawing.Point(24, 34);
            this.li_lager.Name = "li_lager";
            this.li_lager.Size = new System.Drawing.Size(434, 187);
            this.li_lager.TabIndex = 15;
            this.li_lager.UseCompatibleStateImageBehavior = false;
            this.li_lager.View = System.Windows.Forms.View.Details;
            this.li_lager.SelectedIndexChanged += new System.EventHandler(this.li_lager_SelectedIndexChanged);
            this.li_lager.DoubleClick += new System.EventHandler(this.bt_korfu_Click);
            // 
            // bt_eda
            // 
            this.bt_eda.Location = new System.Drawing.Point(484, 153);
            this.bt_eda.Name = "bt_eda";
            this.bt_eda.Size = new System.Drawing.Size(75, 23);
            this.bt_eda.TabIndex = 16;
            this.bt_eda.Text = "Eða ur korfu";
            this.bt_eda.UseVisualStyleBackColor = true;
            this.bt_eda.Click += new System.EventHandler(this.bt_eda_Click);
            // 
            // tb_magn
            // 
            this.tb_magn.Location = new System.Drawing.Point(504, 63);
            this.tb_magn.Name = "tb_magn";
            this.tb_magn.Size = new System.Drawing.Size(73, 20);
            this.tb_magn.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Magn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Leita:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 659);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_magn);
            this.Controls.Add(this.bt_eda);
            this.Controls.Add(this.li_lager);
            this.Controls.Add(this.li_korfa);
            this.Controls.Add(this.bt_Check_out);
            this.Controls.Add(this.bt_admin);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bt_korfu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_korfu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bt_admin;
        private System.Windows.Forms.Button bt_Check_out;
        private System.Windows.Forms.ListView li_korfa;
        private System.Windows.Forms.ListView li_lager;
        private System.Windows.Forms.Button bt_eda;
        private System.Windows.Forms.TextBox tb_magn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

