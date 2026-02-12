
namespace WindowsFormsFranceMobilier
{
    partial class Fm_Detail_Ligne_Vente
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
            this.components = new System.ComponentModel.Container();
            this.tbTotalHt = new System.Windows.Forms.TextBox();
            this.tbQuantite = new System.Windows.Forms.TextBox();
            this.tbPrixHt = new System.Windows.Forms.TextBox();
            this.cbProduit = new System.Windows.Forms.ComboBox();
            this.tbEnleve = new System.Windows.Forms.TextBox();
            this.btEnregistrer = new System.Windows.Forms.Button();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.lblMontantHt = new System.Windows.Forms.Label();
            this.lblEnleve = new System.Windows.Forms.Label();
            this.lblPrixHt = new System.Windows.Forms.Label();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.lblProduit = new System.Windows.Forms.Label();
            this.errorProviderLigneVente = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblStock = new System.Windows.Forms.Label();
            this.listViewStock = new System.Windows.Forms.ListView();
            this.magasin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stockActuel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stockAlivrer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stockFutur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLigneVente)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTotalHt
            // 
            this.tbTotalHt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalHt.Location = new System.Drawing.Point(134, 254);
            this.tbTotalHt.Name = "tbTotalHt";
            this.tbTotalHt.ReadOnly = true;
            this.tbTotalHt.Size = new System.Drawing.Size(83, 22);
            this.tbTotalHt.TabIndex = 5;
            // 
            // tbQuantite
            // 
            this.tbQuantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuantite.Location = new System.Drawing.Point(134, 198);
            this.tbQuantite.MaxLength = 4;
            this.tbQuantite.Name = "tbQuantite";
            this.tbQuantite.Size = new System.Drawing.Size(53, 22);
            this.tbQuantite.TabIndex = 3;
            this.tbQuantite.TextChanged += new System.EventHandler(this.tbQuantite_TextChanged);
            this.tbQuantite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQuantite_KeyPress);
            // 
            // tbPrixHt
            // 
            this.tbPrixHt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrixHt.Location = new System.Drawing.Point(134, 170);
            this.tbPrixHt.Name = "tbPrixHt";
            this.tbPrixHt.ReadOnly = true;
            this.tbPrixHt.Size = new System.Drawing.Size(83, 22);
            this.tbPrixHt.TabIndex = 2;
            // 
            // cbProduit
            // 
            this.cbProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProduit.FormattingEnabled = true;
            this.cbProduit.Location = new System.Drawing.Point(134, 12);
            this.cbProduit.Name = "cbProduit";
            this.cbProduit.Size = new System.Drawing.Size(494, 24);
            this.cbProduit.TabIndex = 1;
            this.cbProduit.SelectedIndexChanged += new System.EventHandler(this.cbProduit_SelectedIndexChanged);
            // 
            // tbEnleve
            // 
            this.tbEnleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEnleve.Location = new System.Drawing.Point(134, 226);
            this.tbEnleve.MaxLength = 4;
            this.tbEnleve.Name = "tbEnleve";
            this.tbEnleve.Size = new System.Drawing.Size(53, 22);
            this.tbEnleve.TabIndex = 4;
            this.tbEnleve.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEnleve_KeyPress);
            // 
            // btEnregistrer
            // 
            this.btEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnregistrer.Location = new System.Drawing.Point(41, 305);
            this.btEnregistrer.Name = "btEnregistrer";
            this.btEnregistrer.Size = new System.Drawing.Size(124, 35);
            this.btEnregistrer.TabIndex = 6;
            this.btEnregistrer.Text = "Enregistrer";
            this.btEnregistrer.UseVisualStyleBackColor = true;
            this.btEnregistrer.Click += new System.EventHandler(this.btEnregistrer_Click);
            // 
            // btAnnuler
            // 
            this.btAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnnuler.Location = new System.Drawing.Point(205, 305);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(100, 35);
            this.btAnnuler.TabIndex = 7;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // lblMontantHt
            // 
            this.lblMontantHt.AutoSize = true;
            this.lblMontantHt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontantHt.Location = new System.Drawing.Point(35, 257);
            this.lblMontantHt.Name = "lblMontantHt";
            this.lblMontantHt.Size = new System.Drawing.Size(90, 16);
            this.lblMontantHt.TabIndex = 58;
            this.lblMontantHt.Text = "Total H.T. (€) :";
            // 
            // lblEnleve
            // 
            this.lblEnleve.AutoSize = true;
            this.lblEnleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnleve.Location = new System.Drawing.Point(35, 229);
            this.lblEnleve.Name = "lblEnleve";
            this.lblEnleve.Size = new System.Drawing.Size(58, 16);
            this.lblEnleve.TabIndex = 59;
            this.lblEnleve.Text = "Enlevé : ";
            // 
            // lblPrixHt
            // 
            this.lblPrixHt.AutoSize = true;
            this.lblPrixHt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrixHt.Location = new System.Drawing.Point(35, 173);
            this.lblPrixHt.Name = "lblPrixHt";
            this.lblPrixHt.Size = new System.Drawing.Size(81, 16);
            this.lblPrixHt.TabIndex = 60;
            this.lblPrixHt.Text = "Prix H.T. (€) :";
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantite.Location = new System.Drawing.Point(35, 201);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(65, 16);
            this.lblQuantite.TabIndex = 61;
            this.lblQuantite.Text = "Quantité : ";
            // 
            // lblProduit
            // 
            this.lblProduit.AutoSize = true;
            this.lblProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduit.Location = new System.Drawing.Point(35, 15);
            this.lblProduit.Name = "lblProduit";
            this.lblProduit.Size = new System.Drawing.Size(58, 16);
            this.lblProduit.TabIndex = 62;
            this.lblProduit.Text = "Produit : ";
            // 
            // errorProviderLigneVente
            // 
            this.errorProviderLigneVente.ContainerControl = this;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblStock.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStock.Location = new System.Drawing.Point(35, 53);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(50, 16);
            this.lblStock.TabIndex = 64;
            this.lblStock.Text = "Stock : ";
            // 
            // listViewStock
            // 
            this.listViewStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.magasin,
            this.stockActuel,
            this.stockAlivrer,
            this.stockFutur});
            this.listViewStock.HideSelection = false;
            this.listViewStock.Location = new System.Drawing.Point(134, 53);
            this.listViewStock.Name = "listViewStock";
            this.listViewStock.Size = new System.Drawing.Size(428, 97);
            this.listViewStock.TabIndex = 65;
            this.listViewStock.UseCompatibleStateImageBehavior = false;
            this.listViewStock.View = System.Windows.Forms.View.Details;
            // 
            // magasin
            // 
            this.magasin.Text = "Magasin";
            this.magasin.Width = 225;
            // 
            // stockActuel
            // 
            this.stockActuel.Text = "actuel";
            this.stockActuel.Width = 65;
            // 
            // stockAlivrer
            // 
            this.stockAlivrer.Text = "A livrer";
            this.stockAlivrer.Width = 65;
            // 
            // stockFutur
            // 
            this.stockFutur.Text = "Futur";
            this.stockFutur.Width = 65;
            // 
            // Fm_Detail_Ligne_Vente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(654, 378);
            this.ControlBox = false;
            this.Controls.Add(this.listViewStock);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblProduit);
            this.Controls.Add(this.lblQuantite);
            this.Controls.Add(this.lblPrixHt);
            this.Controls.Add(this.lblEnleve);
            this.Controls.Add(this.lblMontantHt);
            this.Controls.Add(this.btEnregistrer);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.tbEnleve);
            this.Controls.Add(this.tbTotalHt);
            this.Controls.Add(this.tbQuantite);
            this.Controls.Add(this.tbPrixHt);
            this.Controls.Add(this.cbProduit);
            this.Name = "Fm_Detail_Ligne_Vente";
            this.Text = "Ajout et modification des produits";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLigneVente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTotalHt;
        private System.Windows.Forms.TextBox tbQuantite;
        private System.Windows.Forms.TextBox tbPrixHt;
        private System.Windows.Forms.ComboBox cbProduit;
        private System.Windows.Forms.TextBox tbEnleve;
        private System.Windows.Forms.Button btEnregistrer;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.Label lblMontantHt;
        private System.Windows.Forms.Label lblEnleve;
        private System.Windows.Forms.Label lblPrixHt;
        private System.Windows.Forms.Label lblQuantite;
        private System.Windows.Forms.Label lblProduit;
        private System.Windows.Forms.ErrorProvider errorProviderLigneVente;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.ListView listViewStock;
        private System.Windows.Forms.ColumnHeader magasin;
        private System.Windows.Forms.ColumnHeader stockActuel;
        private System.Windows.Forms.ColumnHeader stockAlivrer;
        private System.Windows.Forms.ColumnHeader stockFutur;
    }
}