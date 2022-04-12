namespace Mission3
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.tb_duree = new System.Windows.Forms.TextBox();
            this.tb_idportarrivee = new System.Windows.Forms.TextBox();
            this.tb_idportdepart = new System.Windows.Forms.TextBox();
            this.tb_idsecteur = new System.Windows.Forms.TextBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_idliaison_supp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1396, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(363, 524);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(165, 36);
            this.btn_insert.TabIndex = 2;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(855, 524);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(165, 36);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(609, 524);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(165, 36);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // tb_duree
            // 
            this.tb_duree.Location = new System.Drawing.Point(1103, 72);
            this.tb_duree.Name = "tb_duree";
            this.tb_duree.Size = new System.Drawing.Size(100, 20);
            this.tb_duree.TabIndex = 5;
            this.tb_duree.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_idportarrivee
            // 
            this.tb_idportarrivee.Location = new System.Drawing.Point(1103, 157);
            this.tb_idportarrivee.Name = "tb_idportarrivee";
            this.tb_idportarrivee.Size = new System.Drawing.Size(100, 20);
            this.tb_idportarrivee.TabIndex = 6;
            this.tb_idportarrivee.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tb_idportdepart
            // 
            this.tb_idportdepart.Location = new System.Drawing.Point(1103, 115);
            this.tb_idportdepart.Name = "tb_idportdepart";
            this.tb_idportdepart.Size = new System.Drawing.Size(100, 20);
            this.tb_idportdepart.TabIndex = 7;
            // 
            // tb_idsecteur
            // 
            this.tb_idsecteur.Location = new System.Drawing.Point(1103, 205);
            this.tb_idsecteur.Name = "tb_idsecteur";
            this.tb_idsecteur.Size = new System.Drawing.Size(100, 20);
            this.tb_idsecteur.TabIndex = 8;
            this.tb_idsecteur.TextChanged += new System.EventHandler(this.tb_idsecteur_TextChanged);
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(71, 27);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.Size = new System.Drawing.Size(317, 282);
            this.dgv1.TabIndex = 9;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1006, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Durrée";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1006, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID Port de départ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1006, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "ID Port d\'arrivé";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1006, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "ID Secteur";
            // 
            // tb_idliaison_supp
            // 
            this.tb_idliaison_supp.Location = new System.Drawing.Point(763, 498);
            this.tb_idliaison_supp.Name = "tb_idliaison_supp";
            this.tb_idliaison_supp.Size = new System.Drawing.Size(100, 20);
            this.tb_idliaison_supp.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(782, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Id Liaison :";
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(523, 27);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowHeadersWidth = 51;
            this.dgv2.Size = new System.Drawing.Size(317, 282);
            this.dgv2.TabIndex = 16;
            this.dgv2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv2_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 618);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_idliaison_supp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.tb_idsecteur);
            this.Controls.Add(this.tb_idportdepart);
            this.Controls.Add(this.tb_idportarrivee);
            this.Controls.Add(this.tb_duree);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox tb_duree;
        private System.Windows.Forms.TextBox tb_idportarrivee;
        private System.Windows.Forms.TextBox tb_idportdepart;
        private System.Windows.Forms.TextBox tb_idsecteur;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_idliaison_supp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv2;
    }
}

