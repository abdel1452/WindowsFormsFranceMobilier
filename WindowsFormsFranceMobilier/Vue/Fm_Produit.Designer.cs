
namespace WindowsFormsFranceMobilier
{
    partial class Fm_Produit
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
            this.listViewProduit = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reference = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.designation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prixHt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbCategorie = new System.Windows.Forms.ComboBox();
            this.btRetour = new System.Windows.Forms.Button();
            this.lblCategprie = new System.Windows.Forms.Label();
            this.btNouveauProduit = new System.Windows.Forms.Button();
            this.lblGamme = new System.Windows.Forms.Label();
            this.cbGamme = new System.Windows.Forms.ComboBox();
            this.btRechercher = new System.Windows.Forms.Button();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.tbDesignation = new System.Windows.Forms.TextBox();
            this.tbReference = new System.Windows.Forms.TextBox();
            this.lblReference = new System.Windows.Forms.Label();
            this.btReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewProduit
            // 
            this.listViewProduit.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.reference,
            this.designation,
            this.prixHt});
            this.listViewProduit.FullRowSelect = true;
            this.listViewProduit.HideSelection = false;
            this.listViewProduit.Location = new System.Drawing.Point(59, 61);
            this.listViewProduit.Name = "listViewProduit";
            this.listViewProduit.Size = new System.Drawing.Size(704, 454);
            this.listViewProduit.TabIndex = 0;
            this.listViewProduit.UseCompatibleStateImageBehavior = false;
            this.listViewProduit.View = System.Windows.Forms.View.Details;
            this.listViewProduit.DoubleClick += new System.EventHandler(this.listViewProduit_DoubleClick);
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 65;
            // 
            // reference
            // 
            this.reference.Text = "Référence";
            this.reference.Width = 100;
            // 
            // designation
            // 
            this.designation.Text = "Désignation";
            this.designation.Width = 391;
            // 
            // prixHt
            // 
            this.prixHt.Text = "Prix H.T.";
            this.prixHt.Width = 132;
            // 
            // cbCategorie
            // 
            this.cbCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategorie.FormattingEnabled = true;
            this.cbCategorie.Location = new System.Drawing.Point(966, 98);
            this.cbCategorie.Name = "cbCategorie";
            this.cbCategorie.Size = new System.Drawing.Size(185, 26);
            this.cbCategorie.TabIndex = 1;
            // 
            // btRetour
            // 
            this.btRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRetour.Location = new System.Drawing.Point(1051, 584);
            this.btRetour.Name = "btRetour";
            this.btRetour.Size = new System.Drawing.Size(100, 35);
            this.btRetour.TabIndex = 2;
            this.btRetour.Text = "Fermer";
            this.btRetour.UseVisualStyleBackColor = true;
            this.btRetour.Click += new System.EventHandler(this.btRetour_Click);
            // 
            // lblCategprie
            // 
            this.lblCategprie.AutoSize = true;
            this.lblCategprie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategprie.Location = new System.Drawing.Point(856, 100);
            this.lblCategprie.Name = "lblCategprie";
            this.lblCategprie.Size = new System.Drawing.Size(90, 20);
            this.lblCategprie.TabIndex = 3;
            this.lblCategprie.Text = "Catégorie : ";
            // 
            // btNouveauProduit
            // 
            this.btNouveauProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNouveauProduit.Location = new System.Drawing.Point(966, 439);
            this.btNouveauProduit.Name = "btNouveauProduit";
            this.btNouveauProduit.Size = new System.Drawing.Size(160, 35);
            this.btNouveauProduit.TabIndex = 4;
            this.btNouveauProduit.Text = "Nouveau produit";
            this.btNouveauProduit.UseVisualStyleBackColor = true;
            this.btNouveauProduit.Click += new System.EventHandler(this.btNouveauProduit_Click);
            // 
            // lblGamme
            // 
            this.lblGamme.AutoSize = true;
            this.lblGamme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamme.Location = new System.Drawing.Point(856, 155);
            this.lblGamme.Name = "lblGamme";
            this.lblGamme.Size = new System.Drawing.Size(78, 20);
            this.lblGamme.TabIndex = 6;
            this.lblGamme.Text = "Gamme : ";
            // 
            // cbGamme
            // 
            this.cbGamme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGamme.FormattingEnabled = true;
            this.cbGamme.Location = new System.Drawing.Point(966, 153);
            this.cbGamme.Name = "cbGamme";
            this.cbGamme.Size = new System.Drawing.Size(185, 26);
            this.cbGamme.TabIndex = 5;
            // 
            // btRechercher
            // 
            this.btRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRechercher.Location = new System.Drawing.Point(966, 320);
            this.btRechercher.Name = "btRechercher";
            this.btRechercher.Size = new System.Drawing.Size(160, 35);
            this.btRechercher.TabIndex = 7;
            this.btRechercher.Text = "Rechercher";
            this.btRechercher.UseVisualStyleBackColor = true;
            this.btRechercher.Click += new System.EventHandler(this.btRechercher_Click);
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignation.Location = new System.Drawing.Point(856, 210);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(106, 20);
            this.lblDesignation.TabIndex = 8;
            this.lblDesignation.Text = "Désignation : ";
            // 
            // tbDesignation
            // 
            this.tbDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDesignation.Location = new System.Drawing.Point(966, 210);
            this.tbDesignation.MaxLength = 25;
            this.tbDesignation.Name = "tbDesignation";
            this.tbDesignation.Size = new System.Drawing.Size(185, 22);
            this.tbDesignation.TabIndex = 9;
            // 
            // tbReference
            // 
            this.tbReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReference.Location = new System.Drawing.Point(966, 265);
            this.tbReference.MaxLength = 25;
            this.tbReference.Name = "tbReference";
            this.tbReference.Size = new System.Drawing.Size(185, 22);
            this.tbReference.TabIndex = 12;
            // 
            // lblReference
            // 
            this.lblReference.AutoSize = true;
            this.lblReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReference.Location = new System.Drawing.Point(856, 265);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(96, 20);
            this.lblReference.TabIndex = 11;
            this.lblReference.Text = "Référence : ";
            // 
            // btReset
            // 
            this.btReset.BackgroundImage = global::WindowsFormsFranceMobilier.Properties.Resources.reset;
            this.btReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btReset.Location = new System.Drawing.Point(1133, 313);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(50, 50);
            this.btReset.TabIndex = 14;
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // Fm_Produit
            // 
            this.AcceptButton = this.btRechercher;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1195, 642);
            this.ControlBox = false;
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.tbReference);
            this.Controls.Add(this.lblReference);
            this.Controls.Add(this.tbDesignation);
            this.Controls.Add(this.lblDesignation);
            this.Controls.Add(this.btRechercher);
            this.Controls.Add(this.lblGamme);
            this.Controls.Add(this.cbGamme);
            this.Controls.Add(this.btNouveauProduit);
            this.Controls.Add(this.lblCategprie);
            this.Controls.Add(this.btRetour);
            this.Controls.Add(this.cbCategorie);
            this.Controls.Add(this.listViewProduit);
            this.Name = "Fm_Produit";
            this.Text = "Produits";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewProduit;
        private System.Windows.Forms.ComboBox cbCategorie;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader designation;
        private System.Windows.Forms.ColumnHeader prixHt;
        private System.Windows.Forms.Button btRetour;
        private System.Windows.Forms.Label lblCategprie;
        private System.Windows.Forms.Button btNouveauProduit;
        private System.Windows.Forms.Label lblGamme;
        private System.Windows.Forms.ComboBox cbGamme;
        private System.Windows.Forms.Button btRechercher;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.TextBox tbDesignation;
        private System.Windows.Forms.ColumnHeader reference;
        private System.Windows.Forms.TextBox tbReference;
        private System.Windows.Forms.Label lblReference;
        private System.Windows.Forms.Button btReset;
    }
}