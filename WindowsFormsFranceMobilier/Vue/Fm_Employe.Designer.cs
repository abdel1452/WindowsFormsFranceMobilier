
namespace WindowsFormsFranceMobilier
{
    partial class Fm_Employe
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
            this.listViewEmploye = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.login = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.magasin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fonction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btRetour = new System.Windows.Forms.Button();
            this.btNouveauEmploye = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewEmploye
            // 
            this.listViewEmploye.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.login,
            this.nom,
            this.prenom,
            this.magasin,
            this.fonction});
            this.listViewEmploye.FullRowSelect = true;
            this.listViewEmploye.HideSelection = false;
            this.listViewEmploye.Location = new System.Drawing.Point(53, 46);
            this.listViewEmploye.Name = "listViewEmploye";
            this.listViewEmploye.Size = new System.Drawing.Size(626, 263);
            this.listViewEmploye.TabIndex = 0;
            this.listViewEmploye.UseCompatibleStateImageBehavior = false;
            this.listViewEmploye.View = System.Windows.Forms.View.Details;
            this.listViewEmploye.DoubleClick += new System.EventHandler(this.listViewEmploye_DoubleClick);
            // 
            // id
            // 
            this.id.Text = "id";
            // 
            // login
            // 
            this.login.Text = "login";
            this.login.Width = 108;
            // 
            // nom
            // 
            this.nom.Text = "Nom";
            this.nom.Width = 146;
            // 
            // prenom
            // 
            this.prenom.Text = "Prénom";
            this.prenom.Width = 145;
            // 
            // magasin
            // 
            this.magasin.Text = "Magasin";
            this.magasin.Width = 88;
            // 
            // fonction
            // 
            this.fonction.Text = "Fonction";
            this.fonction.Width = 81;
            // 
            // btRetour
            // 
            this.btRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRetour.Location = new System.Drawing.Point(776, 274);
            this.btRetour.Name = "btRetour";
            this.btRetour.Size = new System.Drawing.Size(100, 35);
            this.btRetour.TabIndex = 1;
            this.btRetour.Text = "Fermer";
            this.btRetour.UseVisualStyleBackColor = true;
            this.btRetour.Click += new System.EventHandler(this.btRetour_Click);
            // 
            // btNouveauEmploye
            // 
            this.btNouveauEmploye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNouveauEmploye.Location = new System.Drawing.Point(717, 172);
            this.btNouveauEmploye.Name = "btNouveauEmploye";
            this.btNouveauEmploye.Size = new System.Drawing.Size(160, 35);
            this.btNouveauEmploye.TabIndex = 5;
            this.btNouveauEmploye.Text = "Nouvel employé";
            this.btNouveauEmploye.UseVisualStyleBackColor = true;
            this.btNouveauEmploye.Click += new System.EventHandler(this.btNouveauEmploye_Click);
            // 
            // Fm_Employe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(910, 344);
            this.ControlBox = false;
            this.Controls.Add(this.btNouveauEmploye);
            this.Controls.Add(this.btRetour);
            this.Controls.Add(this.listViewEmploye);
            this.Name = "Fm_Employe";
            this.Text = "Employés";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewEmploye;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader nom;
        private System.Windows.Forms.ColumnHeader prenom;
        private System.Windows.Forms.ColumnHeader magasin;
        private System.Windows.Forms.ColumnHeader fonction;
        private System.Windows.Forms.Button btRetour;
        private System.Windows.Forms.Button btNouveauEmploye;
        private System.Windows.Forms.ColumnHeader login;
    }
}