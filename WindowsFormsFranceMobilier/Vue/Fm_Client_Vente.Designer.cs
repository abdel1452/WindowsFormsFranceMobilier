namespace WindowsFormsFranceMobilier.Vue
{
    partial class Fm_Client_Vente
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
            this.tbNumClient = new System.Windows.Forms.TextBox();
            this.lblNumClient = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.btRechercher = new System.Windows.Forms.Button();
            this.btNouveauClient = new System.Windows.Forms.Button();
            this.btRetour = new System.Windows.Forms.Button();
            this.listViewClient = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cpVille = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btReset = new System.Windows.Forms.Button();
            this.progressBarRecherche = new System.Windows.Forms.ProgressBar();
            this.timerRecherche = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tbNumClient
            // 
            this.tbNumClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumClient.Location = new System.Drawing.Point(942, 106);
            this.tbNumClient.MaxLength = 25;
            this.tbNumClient.Name = "tbNumClient";
            this.tbNumClient.Size = new System.Drawing.Size(185, 22);
            this.tbNumClient.TabIndex = 26;
            // 
            // lblNumClient
            // 
            this.lblNumClient.AutoSize = true;
            this.lblNumClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumClient.Location = new System.Drawing.Point(832, 106);
            this.lblNumClient.Name = "lblNumClient";
            this.lblNumClient.Size = new System.Drawing.Size(81, 20);
            this.lblNumClient.TabIndex = 25;
            this.lblNumClient.Text = "N° Client : ";
            // 
            // tbNom
            // 
            this.tbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNom.Location = new System.Drawing.Point(942, 51);
            this.tbNom.MaxLength = 25;
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(185, 22);
            this.tbNom.TabIndex = 24;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(832, 51);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(54, 20);
            this.lblNom.TabIndex = 23;
            this.lblNom.Text = "Nom : ";
            // 
            // btRechercher
            // 
            this.btRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRechercher.Location = new System.Drawing.Point(942, 161);
            this.btRechercher.Name = "btRechercher";
            this.btRechercher.Size = new System.Drawing.Size(160, 35);
            this.btRechercher.TabIndex = 22;
            this.btRechercher.Text = "Rechercher";
            this.btRechercher.UseVisualStyleBackColor = true;
            this.btRechercher.Click += new System.EventHandler(this.btRechercher_Click);
            // 
            // btNouveauClient
            // 
            this.btNouveauClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNouveauClient.Location = new System.Drawing.Point(942, 420);
            this.btNouveauClient.Name = "btNouveauClient";
            this.btNouveauClient.Size = new System.Drawing.Size(160, 35);
            this.btNouveauClient.TabIndex = 19;
            this.btNouveauClient.Text = "Nouveau client";
            this.btNouveauClient.UseVisualStyleBackColor = true;
            this.btNouveauClient.Click += new System.EventHandler(this.btNouveauClient_Click);
            // 
            // btRetour
            // 
            this.btRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRetour.Location = new System.Drawing.Point(1027, 565);
            this.btRetour.Name = "btRetour";
            this.btRetour.Size = new System.Drawing.Size(100, 35);
            this.btRetour.TabIndex = 17;
            this.btRetour.Text = "Fermer";
            this.btRetour.UseVisualStyleBackColor = true;
            this.btRetour.Click += new System.EventHandler(this.btRetour_Click);
            // 
            // listViewClient
            // 
            this.listViewClient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.nom,
            this.prenom,
            this.cpVille});
            this.listViewClient.FullRowSelect = true;
            this.listViewClient.HideSelection = false;
            this.listViewClient.Location = new System.Drawing.Point(35, 42);
            this.listViewClient.Name = "listViewClient";
            this.listViewClient.Size = new System.Drawing.Size(704, 454);
            this.listViewClient.TabIndex = 15;
            this.listViewClient.UseCompatibleStateImageBehavior = false;
            this.listViewClient.View = System.Windows.Forms.View.Details;
            this.listViewClient.DoubleClick += new System.EventHandler(this.listViewClient_DoubleClick);
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 65;
            // 
            // nom
            // 
            this.nom.Text = "Nom";
            this.nom.Width = 163;
            // 
            // prenom
            // 
            this.prenom.Text = "Prénom";
            this.prenom.Width = 163;
            // 
            // cpVille
            // 
            this.cpVille.Text = "Code Postal - Ville";
            this.cpVille.Width = 308;
            // 
            // btReset
            // 
            this.btReset.BackgroundImage = global::WindowsFormsFranceMobilier.Properties.Resources.reset;
            this.btReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btReset.Location = new System.Drawing.Point(1109, 154);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(50, 50);
            this.btReset.TabIndex = 27;
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // progressBarRecherche
            // 
            this.progressBarRecherche.Location = new System.Drawing.Point(836, 228);
            this.progressBarRecherche.Name = "progressBarRecherche";
            this.progressBarRecherche.Size = new System.Drawing.Size(323, 23);
            this.progressBarRecherche.TabIndex = 28;
            // 
            // timerRecherche
            // 
            this.timerRecherche.Tick += new System.EventHandler(this.timerRecherche_Tick);
            // 
            // Fm_Client_Vente
            // 
            this.AcceptButton = this.btRechercher;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 642);
            this.ControlBox = false;
            this.Controls.Add(this.progressBarRecherche);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.tbNumClient);
            this.Controls.Add(this.lblNumClient);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.btRechercher);
            this.Controls.Add(this.btNouveauClient);
            this.Controls.Add(this.btRetour);
            this.Controls.Add(this.listViewClient);
            this.Name = "Fm_Client_Vente";
            this.Text = "Clients";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.TextBox tbNumClient;
        private System.Windows.Forms.Label lblNumClient;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Button btRechercher;
        private System.Windows.Forms.Button btNouveauClient;
        private System.Windows.Forms.Button btRetour;
        private System.Windows.Forms.ListView listViewClient;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader nom;
        private System.Windows.Forms.ColumnHeader prenom;
        private System.Windows.Forms.ColumnHeader cpVille;
        private System.Windows.Forms.ProgressBar progressBarRecherche;
        private System.Windows.Forms.Timer timerRecherche;
    }
}