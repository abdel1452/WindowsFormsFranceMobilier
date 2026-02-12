
namespace WindowsFormsFranceMobilier
{
    partial class Fm_Detail_Vente
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
            this.btRetour = new System.Windows.Forms.Button();
            this.lblProduit = new System.Windows.Forms.Label();
            this.listViewProduit = new System.Windows.Forms.ListView();
            this.produit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prixHT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.enleve = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.montantHt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblClient = new System.Windows.Forms.Label();
            this.tbContactClient = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.tbNumVente = new System.Windows.Forms.TextBox();
            this.lblNumVente = new System.Windows.Forms.Label();
            this.btEnregistrer = new System.Windows.Forms.Button();
            this.lbEmploye = new System.Windows.Forms.Label();
            this.lblMagasin = new System.Windows.Forms.Label();
            this.tbDateVente = new System.Windows.Forms.TextBox();
            this.lblDateCommande = new System.Windows.Forms.Label();
            this.tbDateFacture = new System.Windows.Forms.TextBox();
            this.lblDateFacture = new System.Windows.Forms.Label();
            this.tbNumFacture = new System.Windows.Forms.TextBox();
            this.lblNumFacture = new System.Windows.Forms.Label();
            this.tbTvaHaut = new System.Windows.Forms.TextBox();
            this.lblTva = new System.Windows.Forms.Label();
            this.tbTotalCommandeHt = new System.Windows.Forms.TextBox();
            this.lblTotalHT = new System.Windows.Forms.Label();
            this.tbTotalTva = new System.Windows.Forms.TextBox();
            this.lblMontantTva = new System.Windows.Forms.Label();
            this.tbTotalCommandeTtc = new System.Windows.Forms.TextBox();
            this.lblTotalTtc = new System.Windows.Forms.Label();
            this.tbTvaBas = new System.Windows.Forms.TextBox();
            this.lablTvaBas = new System.Windows.Forms.Label();
            this.btFacturer = new System.Windows.Forms.Button();
            this.btImprimer = new System.Windows.Forms.Button();
            this.btAjouterProduit = new System.Windows.Forms.Button();
            this.btSupprimerProduit = new System.Windows.Forms.Button();
            this.cbEmploye = new System.Windows.Forms.ComboBox();
            this.errorProviderDetailVente = new System.Windows.Forms.ErrorProvider(this.components);
            this.btSupprimer = new System.Windows.Forms.Button();
            this.tbClient = new System.Windows.Forms.TextBox();
            this.tbMagasin = new System.Windows.Forms.TextBox();
            this.btRechercheClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDetailVente)).BeginInit();
            this.SuspendLayout();
            // 
            // btRetour
            // 
            this.btRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRetour.Location = new System.Drawing.Point(667, 595);
            this.btRetour.Name = "btRetour";
            this.btRetour.Size = new System.Drawing.Size(100, 35);
            this.btRetour.TabIndex = 21;
            this.btRetour.Text = "Fermer";
            this.btRetour.UseVisualStyleBackColor = true;
            this.btRetour.Click += new System.EventHandler(this.btRetour_Click);
            // 
            // lblProduit
            // 
            this.lblProduit.AutoSize = true;
            this.lblProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduit.Location = new System.Drawing.Point(21, 221);
            this.lblProduit.Name = "lblProduit";
            this.lblProduit.Size = new System.Drawing.Size(65, 16);
            this.lblProduit.TabIndex = 32;
            this.lblProduit.Text = "Produits : ";
            // 
            // listViewProduit
            // 
            this.listViewProduit.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.produit,
            this.prixHT,
            this.quantite,
            this.enleve,
            this.montantHt});
            this.listViewProduit.FullRowSelect = true;
            this.listViewProduit.HideSelection = false;
            this.listViewProduit.Location = new System.Drawing.Point(25, 244);
            this.listViewProduit.MultiSelect = false;
            this.listViewProduit.Name = "listViewProduit";
            this.listViewProduit.Size = new System.Drawing.Size(743, 236);
            this.listViewProduit.TabIndex = 12;
            this.listViewProduit.UseCompatibleStateImageBehavior = false;
            this.listViewProduit.View = System.Windows.Forms.View.Details;
            this.listViewProduit.Click += new System.EventHandler(this.listViewProduit_Click);
            this.listViewProduit.DoubleClick += new System.EventHandler(this.listViewProduit_DoubleClick);
            // 
            // produit
            // 
            this.produit.Text = "Produit";
            this.produit.Width = 402;
            // 
            // prixHT
            // 
            this.prixHT.Text = "Prix H.T. (€)";
            this.prixHT.Width = 102;
            // 
            // quantite
            // 
            this.quantite.Text = "Quantité";
            this.quantite.Width = 76;
            // 
            // enleve
            // 
            this.enleve.Text = "Enlevé";
            this.enleve.Width = 66;
            // 
            // montantHt
            // 
            this.montantHt.Text = "Montant H.T. (€)";
            this.montantHt.Width = 92;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.Location = new System.Drawing.Point(21, 134);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(49, 16);
            this.lblClient.TabIndex = 30;
            this.lblClient.Text = "Client : ";
            // 
            // tbContactClient
            // 
            this.tbContactClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContactClient.Location = new System.Drawing.Point(182, 168);
            this.tbContactClient.Name = "tbContactClient";
            this.tbContactClient.ReadOnly = true;
            this.tbContactClient.Size = new System.Drawing.Size(487, 22);
            this.tbContactClient.TabIndex = 9;
            // 
            // lblContact
            // 
            this.lblContact.AutoEllipsis = true;
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(114, 171);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(61, 16);
            this.lblContact.TabIndex = 25;
            this.lblContact.Text = "Contact : ";
            // 
            // tbNumVente
            // 
            this.tbNumVente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumVente.Location = new System.Drawing.Point(131, 47);
            this.tbNumVente.Name = "tbNumVente";
            this.tbNumVente.ReadOnly = true;
            this.tbNumVente.Size = new System.Drawing.Size(135, 22);
            this.tbNumVente.TabIndex = 3;
            // 
            // lblNumVente
            // 
            this.lblNumVente.AutoSize = true;
            this.lblNumVente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumVente.Location = new System.Drawing.Point(21, 50);
            this.lblNumVente.Name = "lblNumVente";
            this.lblNumVente.Size = new System.Drawing.Size(68, 16);
            this.lblNumVente.TabIndex = 23;
            this.lblNumVente.Text = "N° Vente : ";
            // 
            // btEnregistrer
            // 
            this.btEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnregistrer.Location = new System.Drawing.Point(25, 595);
            this.btEnregistrer.Name = "btEnregistrer";
            this.btEnregistrer.Size = new System.Drawing.Size(100, 35);
            this.btEnregistrer.TabIndex = 17;
            this.btEnregistrer.Text = "Enregistrer";
            this.btEnregistrer.UseVisualStyleBackColor = true;
            this.btEnregistrer.Click += new System.EventHandler(this.btEnregistrer_Click);
            // 
            // lbEmploye
            // 
            this.lbEmploye.AutoSize = true;
            this.lbEmploye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmploye.Location = new System.Drawing.Point(21, 9);
            this.lbEmploye.Name = "lbEmploye";
            this.lbEmploye.Size = new System.Drawing.Size(70, 16);
            this.lbEmploye.TabIndex = 20;
            this.lbEmploye.Text = "Employé : ";
            // 
            // lblMagasin
            // 
            this.lblMagasin.AutoSize = true;
            this.lblMagasin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMagasin.Location = new System.Drawing.Point(421, 9);
            this.lblMagasin.Name = "lblMagasin";
            this.lblMagasin.Size = new System.Drawing.Size(68, 16);
            this.lblMagasin.TabIndex = 33;
            this.lblMagasin.Text = "Magasin : ";
            // 
            // tbDateVente
            // 
            this.tbDateVente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDateVente.Location = new System.Drawing.Point(424, 47);
            this.tbDateVente.Name = "tbDateVente";
            this.tbDateVente.ReadOnly = true;
            this.tbDateVente.Size = new System.Drawing.Size(140, 22);
            this.tbDateVente.TabIndex = 4;
            // 
            // lblDateCommande
            // 
            this.lblDateCommande.AutoSize = true;
            this.lblDateCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateCommande.Location = new System.Drawing.Point(299, 50);
            this.lblDateCommande.Name = "lblDateCommande";
            this.lblDateCommande.Size = new System.Drawing.Size(83, 16);
            this.lblDateCommande.TabIndex = 37;
            this.lblDateCommande.Text = "Date Vente : ";
            // 
            // tbDateFacture
            // 
            this.tbDateFacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDateFacture.Location = new System.Drawing.Point(424, 87);
            this.tbDateFacture.Name = "tbDateFacture";
            this.tbDateFacture.ReadOnly = true;
            this.tbDateFacture.Size = new System.Drawing.Size(140, 22);
            this.tbDateFacture.TabIndex = 6;
            // 
            // lblDateFacture
            // 
            this.lblDateFacture.AutoSize = true;
            this.lblDateFacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFacture.Location = new System.Drawing.Point(299, 90);
            this.lblDateFacture.Name = "lblDateFacture";
            this.lblDateFacture.Size = new System.Drawing.Size(93, 16);
            this.lblDateFacture.TabIndex = 39;
            this.lblDateFacture.Text = "Date Facture : ";
            // 
            // tbNumFacture
            // 
            this.tbNumFacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumFacture.Location = new System.Drawing.Point(131, 87);
            this.tbNumFacture.Name = "tbNumFacture";
            this.tbNumFacture.ReadOnly = true;
            this.tbNumFacture.Size = new System.Drawing.Size(135, 22);
            this.tbNumFacture.TabIndex = 5;
            // 
            // lblNumFacture
            // 
            this.lblNumFacture.AutoSize = true;
            this.lblNumFacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumFacture.Location = new System.Drawing.Point(21, 90);
            this.lblNumFacture.Name = "lblNumFacture";
            this.lblNumFacture.Size = new System.Drawing.Size(78, 16);
            this.lblNumFacture.TabIndex = 41;
            this.lblNumFacture.Text = "N° Facture : ";
            // 
            // tbTvaHaut
            // 
            this.tbTvaHaut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTvaHaut.Location = new System.Drawing.Point(684, 87);
            this.tbTvaHaut.Name = "tbTvaHaut";
            this.tbTvaHaut.ReadOnly = true;
            this.tbTvaHaut.Size = new System.Drawing.Size(83, 22);
            this.tbTvaHaut.TabIndex = 7;
            // 
            // lblTva
            // 
            this.lblTva.AutoSize = true;
            this.lblTva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTva.Location = new System.Drawing.Point(589, 90);
            this.lblTva.Name = "lblTva";
            this.lblTva.Size = new System.Drawing.Size(99, 16);
            this.lblTva.TabIndex = 43;
            this.lblTva.Text = "Taux TVA (%) : ";
            // 
            // tbTotalCommandeHt
            // 
            this.tbTotalCommandeHt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalCommandeHt.Location = new System.Drawing.Point(684, 491);
            this.tbTotalCommandeHt.Name = "tbTotalCommandeHt";
            this.tbTotalCommandeHt.ReadOnly = true;
            this.tbTotalCommandeHt.Size = new System.Drawing.Size(83, 22);
            this.tbTotalCommandeHt.TabIndex = 14;
            // 
            // lblTotalHT
            // 
            this.lblTotalHT.AutoSize = true;
            this.lblTotalHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHT.Location = new System.Drawing.Point(593, 494);
            this.lblTotalHT.Name = "lblTotalHT";
            this.lblTotalHT.Size = new System.Drawing.Size(90, 16);
            this.lblTotalHT.TabIndex = 45;
            this.lblTotalHT.Text = "Total H.T. (€) :";
            // 
            // tbTotalTva
            // 
            this.tbTotalTva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalTva.Location = new System.Drawing.Point(684, 519);
            this.tbTotalTva.Name = "tbTotalTva";
            this.tbTotalTva.ReadOnly = true;
            this.tbTotalTva.Size = new System.Drawing.Size(83, 22);
            this.tbTotalTva.TabIndex = 15;
            // 
            // lblMontantTva
            // 
            this.lblMontantTva.AutoSize = true;
            this.lblMontantTva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontantTva.Location = new System.Drawing.Point(575, 522);
            this.lblMontantTva.Name = "lblMontantTva";
            this.lblMontantTva.Size = new System.Drawing.Size(108, 16);
            this.lblMontantTva.TabIndex = 47;
            this.lblMontantTva.Text = "Montant TVA (€) :";
            // 
            // tbTotalCommandeTtc
            // 
            this.tbTotalCommandeTtc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalCommandeTtc.Location = new System.Drawing.Point(684, 548);
            this.tbTotalCommandeTtc.Name = "tbTotalCommandeTtc";
            this.tbTotalCommandeTtc.ReadOnly = true;
            this.tbTotalCommandeTtc.Size = new System.Drawing.Size(83, 22);
            this.tbTotalCommandeTtc.TabIndex = 16;
            // 
            // lblTotalTtc
            // 
            this.lblTotalTtc.AutoSize = true;
            this.lblTotalTtc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTtc.Location = new System.Drawing.Point(582, 551);
            this.lblTotalTtc.Name = "lblTotalTtc";
            this.lblTotalTtc.Size = new System.Drawing.Size(101, 16);
            this.lblTotalTtc.TabIndex = 49;
            this.lblTotalTtc.Text = "Total T.T.C. (€) :";
            // 
            // tbTvaBas
            // 
            this.tbTvaBas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTvaBas.Location = new System.Drawing.Point(458, 519);
            this.tbTvaBas.Name = "tbTvaBas";
            this.tbTvaBas.ReadOnly = true;
            this.tbTvaBas.Size = new System.Drawing.Size(83, 22);
            this.tbTvaBas.TabIndex = 13;
            // 
            // lablTvaBas
            // 
            this.lablTvaBas.AutoSize = true;
            this.lablTvaBas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablTvaBas.Location = new System.Drawing.Point(362, 522);
            this.lablTvaBas.Name = "lablTvaBas";
            this.lablTvaBas.Size = new System.Drawing.Size(99, 16);
            this.lablTvaBas.TabIndex = 51;
            this.lablTvaBas.Text = "Taux TVA (%) : ";
            // 
            // btFacturer
            // 
            this.btFacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFacturer.Location = new System.Drawing.Point(150, 595);
            this.btFacturer.Name = "btFacturer";
            this.btFacturer.Size = new System.Drawing.Size(100, 35);
            this.btFacturer.TabIndex = 18;
            this.btFacturer.Text = "Facturer";
            this.btFacturer.UseVisualStyleBackColor = true;
            this.btFacturer.Click += new System.EventHandler(this.btFacturer_Click);
            // 
            // btImprimer
            // 
            this.btImprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImprimer.Location = new System.Drawing.Point(275, 595);
            this.btImprimer.Name = "btImprimer";
            this.btImprimer.Size = new System.Drawing.Size(100, 35);
            this.btImprimer.TabIndex = 19;
            this.btImprimer.Text = "Imprimer";
            this.btImprimer.UseVisualStyleBackColor = true;
            this.btImprimer.Click += new System.EventHandler(this.btImprimer_Click);
            // 
            // btAjouterProduit
            // 
            this.btAjouterProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAjouterProduit.Location = new System.Drawing.Point(93, 213);
            this.btAjouterProduit.Name = "btAjouterProduit";
            this.btAjouterProduit.Size = new System.Drawing.Size(32, 28);
            this.btAjouterProduit.TabIndex = 10;
            this.btAjouterProduit.Text = "+";
            this.btAjouterProduit.UseVisualStyleBackColor = true;
            this.btAjouterProduit.Click += new System.EventHandler(this.btAjouterProduit_Click);
            // 
            // btSupprimerProduit
            // 
            this.btSupprimerProduit.Enabled = false;
            this.btSupprimerProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSupprimerProduit.Location = new System.Drawing.Point(129, 213);
            this.btSupprimerProduit.Name = "btSupprimerProduit";
            this.btSupprimerProduit.Size = new System.Drawing.Size(32, 28);
            this.btSupprimerProduit.TabIndex = 11;
            this.btSupprimerProduit.Text = "-";
            this.btSupprimerProduit.UseVisualStyleBackColor = true;
            this.btSupprimerProduit.Click += new System.EventHandler(this.btSupprimerProduit_Click);
            // 
            // cbEmploye
            // 
            this.cbEmploye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmploye.FormattingEnabled = true;
            this.cbEmploye.Location = new System.Drawing.Point(117, 6);
            this.cbEmploye.Name = "cbEmploye";
            this.cbEmploye.Size = new System.Drawing.Size(263, 24);
            this.cbEmploye.TabIndex = 1;
            // 
            // errorProviderDetailVente
            // 
            this.errorProviderDetailVente.ContainerControl = this;
            // 
            // btSupprimer
            // 
            this.btSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSupprimer.Location = new System.Drawing.Point(450, 595);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(100, 35);
            this.btSupprimer.TabIndex = 20;
            this.btSupprimer.Text = "Supprimer";
            this.btSupprimer.UseVisualStyleBackColor = true;
            // 
            // tbClient
            // 
            this.tbClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClient.Location = new System.Drawing.Point(131, 131);
            this.tbClient.Name = "tbClient";
            this.tbClient.ReadOnly = true;
            this.tbClient.Size = new System.Drawing.Size(637, 22);
            this.tbClient.TabIndex = 53;
            // 
            // tbMagasin
            // 
            this.tbMagasin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMagasin.Location = new System.Drawing.Point(508, 6);
            this.tbMagasin.Name = "tbMagasin";
            this.tbMagasin.ReadOnly = true;
            this.tbMagasin.Size = new System.Drawing.Size(259, 22);
            this.tbMagasin.TabIndex = 54;
            // 
            // btRechercheClient
            // 
            this.btRechercheClient.BackgroundImage = global::WindowsFormsFranceMobilier.Properties.Resources.loupe;
            this.btRechercheClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btRechercheClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRechercheClient.Location = new System.Drawing.Point(79, 127);
            this.btRechercheClient.Name = "btRechercheClient";
            this.btRechercheClient.Size = new System.Drawing.Size(32, 28);
            this.btRechercheClient.TabIndex = 52;
            this.btRechercheClient.UseVisualStyleBackColor = true;
            this.btRechercheClient.Click += new System.EventHandler(this.btRechercheClient_Click);
            // 
            // Fm_Detail_Vente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(796, 643);
            this.ControlBox = false;
            this.Controls.Add(this.tbMagasin);
            this.Controls.Add(this.tbClient);
            this.Controls.Add(this.btRechercheClient);
            this.Controls.Add(this.btSupprimer);
            this.Controls.Add(this.cbEmploye);
            this.Controls.Add(this.btSupprimerProduit);
            this.Controls.Add(this.btAjouterProduit);
            this.Controls.Add(this.btImprimer);
            this.Controls.Add(this.btFacturer);
            this.Controls.Add(this.tbTvaBas);
            this.Controls.Add(this.lablTvaBas);
            this.Controls.Add(this.tbTotalCommandeTtc);
            this.Controls.Add(this.lblTotalTtc);
            this.Controls.Add(this.tbTotalTva);
            this.Controls.Add(this.lblMontantTva);
            this.Controls.Add(this.tbTotalCommandeHt);
            this.Controls.Add(this.lblTotalHT);
            this.Controls.Add(this.tbTvaHaut);
            this.Controls.Add(this.lblTva);
            this.Controls.Add(this.tbNumFacture);
            this.Controls.Add(this.lblNumFacture);
            this.Controls.Add(this.tbDateFacture);
            this.Controls.Add(this.lblDateFacture);
            this.Controls.Add(this.tbDateVente);
            this.Controls.Add(this.lblDateCommande);
            this.Controls.Add(this.lblMagasin);
            this.Controls.Add(this.lblProduit);
            this.Controls.Add(this.listViewProduit);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.tbContactClient);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.tbNumVente);
            this.Controls.Add(this.lblNumVente);
            this.Controls.Add(this.btEnregistrer);
            this.Controls.Add(this.lbEmploye);
            this.Controls.Add(this.btRetour);
            this.Name = "Fm_Detail_Vente";
            this.Text = "Vente";
            this.Activated += new System.EventHandler(this.Fm_Detail_Vente_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDetailVente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRetour;
        private System.Windows.Forms.Label lblProduit;
        private System.Windows.Forms.ListView listViewProduit;
        private System.Windows.Forms.ColumnHeader produit;
        private System.Windows.Forms.ColumnHeader prixHT;
        private System.Windows.Forms.ColumnHeader quantite;
        private System.Windows.Forms.ColumnHeader enleve;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.TextBox tbContactClient;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox tbNumVente;
        private System.Windows.Forms.Label lblNumVente;
        private System.Windows.Forms.Button btEnregistrer;
        private System.Windows.Forms.Label lbEmploye;
        private System.Windows.Forms.Label lblMagasin;
        private System.Windows.Forms.TextBox tbDateVente;
        private System.Windows.Forms.Label lblDateCommande;
        private System.Windows.Forms.TextBox tbDateFacture;
        private System.Windows.Forms.Label lblDateFacture;
        private System.Windows.Forms.TextBox tbNumFacture;
        private System.Windows.Forms.Label lblNumFacture;
        private System.Windows.Forms.TextBox tbTvaHaut;
        private System.Windows.Forms.Label lblTva;
        private System.Windows.Forms.TextBox tbTotalCommandeHt;
        private System.Windows.Forms.Label lblTotalHT;
        private System.Windows.Forms.TextBox tbTotalTva;
        private System.Windows.Forms.Label lblMontantTva;
        private System.Windows.Forms.TextBox tbTotalCommandeTtc;
        private System.Windows.Forms.Label lblTotalTtc;
        private System.Windows.Forms.TextBox tbTvaBas;
        private System.Windows.Forms.Label lablTvaBas;
        private System.Windows.Forms.ColumnHeader montantHt;
        private System.Windows.Forms.Button btFacturer;
        private System.Windows.Forms.Button btImprimer;
        private System.Windows.Forms.Button btAjouterProduit;
        private System.Windows.Forms.Button btSupprimerProduit;
        private System.Windows.Forms.ComboBox cbEmploye;
        private System.Windows.Forms.ErrorProvider errorProviderDetailVente;
        private System.Windows.Forms.Button btSupprimer;
        private System.Windows.Forms.Button btRechercheClient;
        private System.Windows.Forms.TextBox tbClient;
        private System.Windows.Forms.TextBox tbMagasin;
    }
}