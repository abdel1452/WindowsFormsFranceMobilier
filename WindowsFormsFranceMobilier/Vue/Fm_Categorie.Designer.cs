
namespace WindowsFormsFranceMobilier
{
    partial class Fm_Categorie
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
            this.btNouvelleCategorie = new System.Windows.Forms.Button();
            this.btRetour = new System.Windows.Forms.Button();
            this.listViewCategorie = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categorie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btNouvelleCategorie
            // 
            this.btNouvelleCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNouvelleCategorie.Location = new System.Drawing.Point(675, 442);
            this.btNouvelleCategorie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btNouvelleCategorie.Name = "btNouvelleCategorie";
            this.btNouvelleCategorie.Size = new System.Drawing.Size(240, 54);
            this.btNouvelleCategorie.TabIndex = 2;
            this.btNouvelleCategorie.Text = "Nouvelle catégorie";
            this.btNouvelleCategorie.UseVisualStyleBackColor = true;
            this.btNouvelleCategorie.Click += new System.EventHandler(this.btNouvelleCategorie_Click);
            // 
            // btRetour
            // 
            this.btRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRetour.Location = new System.Drawing.Point(765, 614);
            this.btRetour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRetour.Name = "btRetour";
            this.btRetour.Size = new System.Drawing.Size(150, 54);
            this.btRetour.TabIndex = 3;
            this.btRetour.Text = "Fermer";
            this.btRetour.UseVisualStyleBackColor = true;
            this.btRetour.Click += new System.EventHandler(this.btRetour_Click);
            // 
            // listViewCategorie
            // 
            this.listViewCategorie.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.categorie});
            this.listViewCategorie.FullRowSelect = true;
            this.listViewCategorie.HideSelection = false;
            this.listViewCategorie.Location = new System.Drawing.Point(22, 26);
            this.listViewCategorie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewCategorie.Name = "listViewCategorie";
            this.listViewCategorie.Size = new System.Drawing.Size(590, 639);
            this.listViewCategorie.TabIndex = 1;
            this.listViewCategorie.UseCompatibleStateImageBehavior = false;
            this.listViewCategorie.View = System.Windows.Forms.View.Details;
            this.listViewCategorie.DoubleClick += new System.EventHandler(this.listViewCategorie_DoubleClick);
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 75;
            // 
            // categorie
            // 
            this.categorie.Text = "Catégorie";
            this.categorie.Width = 312;
            // 
            // Fm_Categorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(994, 692);
            this.ControlBox = false;
            this.Controls.Add(this.btNouvelleCategorie);
            this.Controls.Add(this.btRetour);
            this.Controls.Add(this.listViewCategorie);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Fm_Categorie";
            this.Text = "Catégories";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btNouvelleCategorie;
        private System.Windows.Forms.Button btRetour;
        private System.Windows.Forms.ListView listViewCategorie;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader categorie;
    }
}