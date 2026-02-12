
namespace WindowsFormsFranceMobilier
{
    partial class Fm_Detail_Produit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fm_Detail_Produit));
            this.lblidProduit = new System.Windows.Forms.Label();
            this.tbIdProduit = new System.Windows.Forms.TextBox();
            this.btRetour = new System.Windows.Forms.Button();
            this.btEnregistrer = new System.Windows.Forms.Button();
            this.tbReferenceProduit = new System.Windows.Forms.TextBox();
            this.lblRefProduit = new System.Windows.Forms.Label();
            this.tbDesignationProduit = new System.Windows.Forms.TextBox();
            this.lblDesignationProduit = new System.Windows.Forms.Label();
            this.tbPrixHtProduit = new System.Windows.Forms.TextBox();
            this.lblPrixHtProduit = new System.Windows.Forms.Label();
            this.cbCategorie = new System.Windows.Forms.ComboBox();
            this.cbGamme = new System.Windows.Forms.ComboBox();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.lblGamme = new System.Windows.Forms.Label();
            this.lblObsolete = new System.Windows.Forms.Label();
            this.ckbObsolete = new System.Windows.Forms.CheckBox();
            this.listViewStock = new System.Windows.Forms.ListView();
            this.magasin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stockActuel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stockAlivrer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stockFutur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblStock = new System.Windows.Forms.Label();
            this.picBoxProduit = new System.Windows.Forms.PictureBox();
            this.errorProviderProduit = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialogImg = new System.Windows.Forms.OpenFileDialog();
            this.BtParcourir = new System.Windows.Forms.Button();
            this.btSupprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblidProduit
            // 
            resources.ApplyResources(this.lblidProduit, "lblidProduit");
            this.lblidProduit.Name = "lblidProduit";
            // 
            // tbIdProduit
            // 
            resources.ApplyResources(this.tbIdProduit, "tbIdProduit");
            this.tbIdProduit.Name = "tbIdProduit";
            this.tbIdProduit.ReadOnly = true;
            // 
            // btRetour
            // 
            resources.ApplyResources(this.btRetour, "btRetour");
            this.btRetour.Name = "btRetour";
            this.btRetour.UseVisualStyleBackColor = true;
            this.btRetour.Click += new System.EventHandler(this.btRetour_Click);
            // 
            // btEnregistrer
            // 
            resources.ApplyResources(this.btEnregistrer, "btEnregistrer");
            this.btEnregistrer.Name = "btEnregistrer";
            this.btEnregistrer.UseVisualStyleBackColor = true;
            this.btEnregistrer.Click += new System.EventHandler(this.btEnregistrer_Click);
            // 
            // tbReferenceProduit
            // 
            resources.ApplyResources(this.tbReferenceProduit, "tbReferenceProduit");
            this.tbReferenceProduit.Name = "tbReferenceProduit";
            // 
            // lblRefProduit
            // 
            resources.ApplyResources(this.lblRefProduit, "lblRefProduit");
            this.lblRefProduit.Name = "lblRefProduit";
            // 
            // tbDesignationProduit
            // 
            resources.ApplyResources(this.tbDesignationProduit, "tbDesignationProduit");
            this.tbDesignationProduit.Name = "tbDesignationProduit";
            // 
            // lblDesignationProduit
            // 
            this.lblDesignationProduit.AutoEllipsis = true;
            resources.ApplyResources(this.lblDesignationProduit, "lblDesignationProduit");
            this.lblDesignationProduit.Name = "lblDesignationProduit";
            // 
            // tbPrixHtProduit
            // 
            resources.ApplyResources(this.tbPrixHtProduit, "tbPrixHtProduit");
            this.tbPrixHtProduit.Name = "tbPrixHtProduit";
            // 
            // lblPrixHtProduit
            // 
            resources.ApplyResources(this.lblPrixHtProduit, "lblPrixHtProduit");
            this.lblPrixHtProduit.Name = "lblPrixHtProduit";
            // 
            // cbCategorie
            // 
            resources.ApplyResources(this.cbCategorie, "cbCategorie");
            this.cbCategorie.FormattingEnabled = true;
            this.cbCategorie.Name = "cbCategorie";
            // 
            // cbGamme
            // 
            resources.ApplyResources(this.cbGamme, "cbGamme");
            this.cbGamme.FormattingEnabled = true;
            this.cbGamme.Name = "cbGamme";
            // 
            // lblCategorie
            // 
            resources.ApplyResources(this.lblCategorie, "lblCategorie");
            this.lblCategorie.Name = "lblCategorie";
            // 
            // lblGamme
            // 
            resources.ApplyResources(this.lblGamme, "lblGamme");
            this.lblGamme.Name = "lblGamme";
            // 
            // lblObsolete
            // 
            resources.ApplyResources(this.lblObsolete, "lblObsolete");
            this.lblObsolete.Name = "lblObsolete";
            // 
            // ckbObsolete
            // 
            resources.ApplyResources(this.ckbObsolete, "ckbObsolete");
            this.ckbObsolete.Name = "ckbObsolete";
            this.ckbObsolete.UseVisualStyleBackColor = true;
            // 
            // listViewStock
            // 
            this.listViewStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.magasin,
            this.stockActuel,
            this.stockAlivrer,
            this.stockFutur});
            this.listViewStock.HideSelection = false;
            resources.ApplyResources(this.listViewStock, "listViewStock");
            this.listViewStock.Name = "listViewStock";
            this.listViewStock.UseCompatibleStateImageBehavior = false;
            this.listViewStock.View = System.Windows.Forms.View.Details;
            // 
            // magasin
            // 
            resources.ApplyResources(this.magasin, "magasin");
            // 
            // stockActuel
            // 
            resources.ApplyResources(this.stockActuel, "stockActuel");
            // 
            // stockAlivrer
            // 
            resources.ApplyResources(this.stockAlivrer, "stockAlivrer");
            // 
            // stockFutur
            // 
            resources.ApplyResources(this.stockFutur, "stockFutur");
            // 
            // lblStock
            // 
            resources.ApplyResources(this.lblStock, "lblStock");
            this.lblStock.Name = "lblStock";
            // 
            // picBoxProduit
            // 
            this.picBoxProduit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.picBoxProduit, "picBoxProduit");
            this.picBoxProduit.Name = "picBoxProduit";
            this.picBoxProduit.TabStop = false;
            // 
            // errorProviderProduit
            // 
            this.errorProviderProduit.ContainerControl = this;
            // 
            // openFileDialogImg
            // 
            this.openFileDialogImg.FileName = "openFileDialog1";
            // 
            // BtParcourir
            // 
            resources.ApplyResources(this.BtParcourir, "BtParcourir");
            this.BtParcourir.Name = "BtParcourir";
            this.BtParcourir.UseVisualStyleBackColor = true;
            this.BtParcourir.Click += new System.EventHandler(this.BtParcourir_Click);
            // 
            // btSupprimer
            // 
            resources.ApplyResources(this.btSupprimer, "btSupprimer");
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.UseVisualStyleBackColor = true;
            this.btSupprimer.Click += new System.EventHandler(this.btSupprimer_Click);
            // 
            // Fm_Detail_Produit
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ControlBox = false;
            this.Controls.Add(this.btSupprimer);
            this.Controls.Add(this.BtParcourir);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.listViewStock);
            this.Controls.Add(this.ckbObsolete);
            this.Controls.Add(this.lblObsolete);
            this.Controls.Add(this.lblGamme);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.cbGamme);
            this.Controls.Add(this.cbCategorie);
            this.Controls.Add(this.picBoxProduit);
            this.Controls.Add(this.tbPrixHtProduit);
            this.Controls.Add(this.lblPrixHtProduit);
            this.Controls.Add(this.tbDesignationProduit);
            this.Controls.Add(this.lblDesignationProduit);
            this.Controls.Add(this.tbReferenceProduit);
            this.Controls.Add(this.lblRefProduit);
            this.Controls.Add(this.btEnregistrer);
            this.Controls.Add(this.btRetour);
            this.Controls.Add(this.tbIdProduit);
            this.Controls.Add(this.lblidProduit);
            this.Name = "Fm_Detail_Produit";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblidProduit;
        private System.Windows.Forms.TextBox tbIdProduit;
        private System.Windows.Forms.Button btRetour;
        private System.Windows.Forms.Button btEnregistrer;
        private System.Windows.Forms.TextBox tbReferenceProduit;
        private System.Windows.Forms.Label lblRefProduit;
        private System.Windows.Forms.TextBox tbDesignationProduit;
        private System.Windows.Forms.Label lblDesignationProduit;
        private System.Windows.Forms.TextBox tbPrixHtProduit;
        private System.Windows.Forms.Label lblPrixHtProduit;
        private System.Windows.Forms.PictureBox picBoxProduit;
        private System.Windows.Forms.ComboBox cbCategorie;
        private System.Windows.Forms.ComboBox cbGamme;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Label lblGamme;
        private System.Windows.Forms.Label lblObsolete;
        private System.Windows.Forms.CheckBox ckbObsolete;
        private System.Windows.Forms.ListView listViewStock;
        private System.Windows.Forms.ColumnHeader magasin;
        private System.Windows.Forms.ColumnHeader stockActuel;
        private System.Windows.Forms.ColumnHeader stockAlivrer;
        private System.Windows.Forms.ColumnHeader stockFutur;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.ErrorProvider errorProviderProduit;
        private System.Windows.Forms.Button BtParcourir;
        private System.Windows.Forms.OpenFileDialog openFileDialogImg;
        private System.Windows.Forms.Button btSupprimer;
    }
}