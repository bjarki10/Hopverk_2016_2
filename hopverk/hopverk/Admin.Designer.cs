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
            this.bt_remove = new System.Windows.Forms.Button();
            this.tb_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tb_remove = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nafn = new System.Windows.Forms.TextBox();
            this.tb_voruflokur = new System.Windows.Forms.TextBox();
            this.tb_verd = new System.Windows.Forms.TextBox();
            this.tb_alager = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            // bt_remove
            // 
            this.bt_remove.Location = new System.Drawing.Point(40, 261);
            this.bt_remove.Name = "bt_remove";
            this.bt_remove.Size = new System.Drawing.Size(143, 22);
            this.bt_remove.TabIndex = 18;
            this.bt_remove.Text = "Remove";
            this.bt_remove.UseVisualStyleBackColor = true;
            this.bt_remove.Click += new System.EventHandler(this.bt_remove_Click);
            // 
            // tb_add
            // 
            this.tb_add.Location = new System.Drawing.Point(67, 482);
            this.tb_add.Name = "tb_add";
            this.tb_add.Size = new System.Drawing.Size(100, 23);
            this.tb_add.TabIndex = 19;
            this.tb_add.Text = "Bætu við";
            this.tb_add.UseVisualStyleBackColor = true;
            this.tb_add.Click += new System.EventHandler(this.tb_add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Leita:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 188);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(391, 20);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_remove
            // 
            this.tb_remove.Location = new System.Drawing.Point(40, 235);
            this.tb_remove.Name = "tb_remove";
            this.tb_remove.Size = new System.Drawing.Size(143, 20);
            this.tb_remove.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nafn:";
            // 
            // tb_nafn
            // 
            this.tb_nafn.Location = new System.Drawing.Point(67, 367);
            this.tb_nafn.Name = "tb_nafn";
            this.tb_nafn.Size = new System.Drawing.Size(100, 20);
            this.tb_nafn.TabIndex = 24;
            // 
            // tb_voruflokur
            // 
            this.tb_voruflokur.Location = new System.Drawing.Point(67, 393);
            this.tb_voruflokur.Name = "tb_voruflokur";
            this.tb_voruflokur.Size = new System.Drawing.Size(100, 20);
            this.tb_voruflokur.TabIndex = 25;
            // 
            // tb_verd
            // 
            this.tb_verd.Location = new System.Drawing.Point(67, 419);
            this.tb_verd.Name = "tb_verd";
            this.tb_verd.Size = new System.Drawing.Size(100, 20);
            this.tb_verd.TabIndex = 26;
            // 
            // tb_alager
            // 
            this.tb_alager.Location = new System.Drawing.Point(67, 445);
            this.tb_alager.Name = "tb_alager";
            this.tb_alager.Size = new System.Drawing.Size(100, 20);
            this.tb_alager.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Nafn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Voruflokur";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Verd";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 448);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Á lager";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 557);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_alager);
            this.Controls.Add(this.tb_verd);
            this.Controls.Add(this.tb_voruflokur);
            this.Controls.Add(this.tb_nafn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_remove);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tb_add);
            this.Controls.Add(this.bt_remove);
            this.Controls.Add(this.li_lager);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView li_lager;
        private System.Windows.Forms.Button bt_remove;
        private System.Windows.Forms.Button tb_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tb_remove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nafn;
        private System.Windows.Forms.TextBox tb_voruflokur;
        private System.Windows.Forms.TextBox tb_verd;
        private System.Windows.Forms.TextBox tb_alager;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}