namespace WindowsFormsFranceMobilier.Vue
{
    partial class Fm_Detail_Client
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
            this.btSupprimer = new System.Windows.Forms.Button();
            this.btEnregistrer = new System.Windows.Forms.Button();
            this.tbTelFixeClient = new System.Windows.Forms.TextBox();
            this.lblTelFixeClient = new System.Windows.Forms.Label();
            this.tbMailClient = new System.Windows.Forms.TextBox();
            this.lblMailClient = new System.Windows.Forms.Label();
            this.tbPrenomClient = new System.Windows.Forms.TextBox();
            this.lblPrenomClient = new System.Windows.Forms.Label();
            this.tbNomClient = new System.Windows.Forms.TextBox();
            this.lblNomClient = new System.Windows.Forms.Label();
            this.tbIdClient = new System.Windows.Forms.TextBox();
            this.lblidClient = new System.Windows.Forms.Label();
            this.btRetour = new System.Windows.Forms.Button();
            this.tbAdresse1Client = new System.Windows.Forms.TextBox();
            this.lblAdresse1Client = new System.Windows.Forms.Label();
            this.tbAdresse2Client = new System.Windows.Forms.TextBox();
            this.lblAdresse2Client = new System.Windows.Forms.Label();
            this.tbCodePostalVilleClient = new System.Windows.Forms.TextBox();
            this.lblCodePostalVilleClient = new System.Windows.Forms.Label();
            this.tbTelPortableClient = new System.Windows.Forms.TextBox();
            this.lblTelPortableClient = new System.Windows.Forms.Label();
            this.errorProviderClient = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderClient)).BeginInit();
            this.SuspendLayout();
            // 
            // btSupprimer
            // 
            this.btSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSupprimer.Location = new System.Drawing.Point(318, 449);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(150, 35);
            this.btSupprimer.TabIndex = 23;
            this.btSupprimer.Text = "Supprimer";
            this.btSupprimer.UseVisualStyleBackColor = true;
            this.btSupprimer.Click += new System.EventHandler(this.btSupprimer_Click);
            // 
            // btEnregistrer
            // 
            this.btEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnregistrer.Location = new System.Drawing.Point(140, 449);
            this.btEnregistrer.Name = "btEnregistrer";
            this.btEnregistrer.Size = new System.Drawing.Size(150, 35);
            this.btEnregistrer.TabIndex = 22;
            this.btEnregistrer.Text = "Enregistrer";
            this.btEnregistrer.UseVisualStyleBackColor = true;
            this.btEnregistrer.Click += new System.EventHandler(this.btEnregistrer_Click);
            // 
            // tbTelFixeClient
            // 
            this.tbTelFixeClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelFixeClient.Location = new System.Drawing.Point(188, 293);
            this.tbTelFixeClient.MaxLength = 14;
            this.tbTelFixeClient.Name = "tbTelFixeClient";
            this.tbTelFixeClient.Size = new System.Drawing.Size(135, 22);
            this.tbTelFixeClient.TabIndex = 21;
            // 
            // lblTelFixeClient
            // 
            this.lblTelFixeClient.AutoSize = true;
            this.lblTelFixeClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelFixeClient.Location = new System.Drawing.Point(50, 296);
            this.lblTelFixeClient.Name = "lblTelFixeClient";
            this.lblTelFixeClient.Size = new System.Drawing.Size(110, 16);
            this.lblTelFixeClient.TabIndex = 29;
            this.lblTelFixeClient.Text = "Téléphone Fixe : ";
            // 
            // tbMailClient
            // 
            this.tbMailClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMailClient.Location = new System.Drawing.Point(188, 382);
            this.tbMailClient.MaxLength = 50;
            this.tbMailClient.Name = "tbMailClient";
            this.tbMailClient.Size = new System.Drawing.Size(417, 22);
            this.tbMailClient.TabIndex = 20;
            // 
            // lblMailClient
            // 
            this.lblMailClient.AutoSize = true;
            this.lblMailClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMailClient.Location = new System.Drawing.Point(50, 385);
            this.lblMailClient.Name = "lblMailClient";
            this.lblMailClient.Size = new System.Drawing.Size(50, 16);
            this.lblMailClient.TabIndex = 28;
            this.lblMailClient.Text = "Email : ";
            // 
            // tbPrenomClient
            // 
            this.tbPrenomClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrenomClient.Location = new System.Drawing.Point(188, 110);
            this.tbPrenomClient.MaxLength = 50;
            this.tbPrenomClient.Name = "tbPrenomClient";
            this.tbPrenomClient.Size = new System.Drawing.Size(211, 22);
            this.tbPrenomClient.TabIndex = 18;
            // 
            // lblPrenomClient
            // 
            this.lblPrenomClient.AutoSize = true;
            this.lblPrenomClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenomClient.Location = new System.Drawing.Point(50, 113);
            this.lblPrenomClient.Name = "lblPrenomClient";
            this.lblPrenomClient.Size = new System.Drawing.Size(63, 16);
            this.lblPrenomClient.TabIndex = 26;
            this.lblPrenomClient.Text = "Prénom : ";
            // 
            // tbNomClient
            // 
            this.tbNomClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomClient.Location = new System.Drawing.Point(188, 70);
            this.tbNomClient.MaxLength = 50;
            this.tbNomClient.Name = "tbNomClient";
            this.tbNomClient.Size = new System.Drawing.Size(211, 22);
            this.tbNomClient.TabIndex = 17;
            // 
            // lblNomClient
            // 
            this.lblNomClient.AutoSize = true;
            this.lblNomClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomClient.Location = new System.Drawing.Point(50, 73);
            this.lblNomClient.Name = "lblNomClient";
            this.lblNomClient.Size = new System.Drawing.Size(45, 16);
            this.lblNomClient.TabIndex = 24;
            this.lblNomClient.Text = "Nom : ";
            // 
            // tbIdClient
            // 
            this.tbIdClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdClient.Location = new System.Drawing.Point(188, 26);
            this.tbIdClient.Name = "tbIdClient";
            this.tbIdClient.ReadOnly = true;
            this.tbIdClient.Size = new System.Drawing.Size(100, 22);
            this.tbIdClient.TabIndex = 27;
            // 
            // lblidClient
            // 
            this.lblidClient.AutoSize = true;
            this.lblidClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidClient.Location = new System.Drawing.Point(50, 29);
            this.lblidClient.Name = "lblidClient";
            this.lblidClient.Size = new System.Drawing.Size(27, 16);
            this.lblidClient.TabIndex = 19;
            this.lblidClient.Text = "Id : ";
            // 
            // btRetour
            // 
            this.btRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRetour.Location = new System.Drawing.Point(643, 449);
            this.btRetour.Name = "btRetour";
            this.btRetour.Size = new System.Drawing.Size(100, 40);
            this.btRetour.TabIndex = 25;
            this.btRetour.Text = "Fermer";
            this.btRetour.UseVisualStyleBackColor = true;
            this.btRetour.Click += new System.EventHandler(this.btRetour_Click);
            // 
            // tbAdresse1Client
            // 
            this.tbAdresse1Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAdresse1Client.Location = new System.Drawing.Point(188, 157);
            this.tbAdresse1Client.MaxLength = 100;
            this.tbAdresse1Client.Name = "tbAdresse1Client";
            this.tbAdresse1Client.Size = new System.Drawing.Size(417, 22);
            this.tbAdresse1Client.TabIndex = 30;
            // 
            // lblAdresse1Client
            // 
            this.lblAdresse1Client.AutoSize = true;
            this.lblAdresse1Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresse1Client.Location = new System.Drawing.Point(50, 160);
            this.lblAdresse1Client.Name = "lblAdresse1Client";
            this.lblAdresse1Client.Size = new System.Drawing.Size(77, 16);
            this.lblAdresse1Client.TabIndex = 31;
            this.lblAdresse1Client.Text = "Adresse 1 : ";
            // 
            // tbAdresse2Client
            // 
            this.tbAdresse2Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAdresse2Client.Location = new System.Drawing.Point(188, 201);
            this.tbAdresse2Client.MaxLength = 100;
            this.tbAdresse2Client.Name = "tbAdresse2Client";
            this.tbAdresse2Client.Size = new System.Drawing.Size(417, 22);
            this.tbAdresse2Client.TabIndex = 32;
            // 
            // lblAdresse2Client
            // 
            this.lblAdresse2Client.AutoSize = true;
            this.lblAdresse2Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresse2Client.Location = new System.Drawing.Point(50, 204);
            this.lblAdresse2Client.Name = "lblAdresse2Client";
            this.lblAdresse2Client.Size = new System.Drawing.Size(77, 16);
            this.lblAdresse2Client.TabIndex = 33;
            this.lblAdresse2Client.Text = "Adresse 2 : ";
            // 
            // tbCodePostalVilleClient
            // 
            this.tbCodePostalVilleClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodePostalVilleClient.Location = new System.Drawing.Point(188, 248);
            this.tbCodePostalVilleClient.MaxLength = 100;
            this.tbCodePostalVilleClient.Name = "tbCodePostalVilleClient";
            this.tbCodePostalVilleClient.Size = new System.Drawing.Size(417, 22);
            this.tbCodePostalVilleClient.TabIndex = 34;
            // 
            // lblCodePostalVilleClient
            // 
            this.lblCodePostalVilleClient.AutoSize = true;
            this.lblCodePostalVilleClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodePostalVilleClient.Location = new System.Drawing.Point(50, 251);
            this.lblCodePostalVilleClient.Name = "lblCodePostalVilleClient";
            this.lblCodePostalVilleClient.Size = new System.Drawing.Size(126, 16);
            this.lblCodePostalVilleClient.TabIndex = 35;
            this.lblCodePostalVilleClient.Text = "Code Postal - Ville : ";
            // 
            // tbTelPortableClient
            // 
            this.tbTelPortableClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelPortableClient.Location = new System.Drawing.Point(188, 339);
            this.tbTelPortableClient.MaxLength = 14;
            this.tbTelPortableClient.Name = "tbTelPortableClient";
            this.tbTelPortableClient.Size = new System.Drawing.Size(135, 22);
            this.tbTelPortableClient.TabIndex = 36;
            // 
            // lblTelPortableClient
            // 
            this.lblTelPortableClient.AutoSize = true;
            this.lblTelPortableClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelPortableClient.Location = new System.Drawing.Point(50, 342);
            this.lblTelPortableClient.Name = "lblTelPortableClient";
            this.lblTelPortableClient.Size = new System.Drawing.Size(136, 16);
            this.lblTelPortableClient.TabIndex = 37;
            this.lblTelPortableClient.Text = "Téléphone Portable : ";
            // 
            // errorProviderClient
            // 
            this.errorProviderClient.ContainerControl = this;
            // 
            // Fm_Detail_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.ControlBox = false;
            this.Controls.Add(this.tbTelPortableClient);
            this.Controls.Add(this.lblTelPortableClient);
            this.Controls.Add(this.tbCodePostalVilleClient);
            this.Controls.Add(this.lblCodePostalVilleClient);
            this.Controls.Add(this.tbAdresse2Client);
            this.Controls.Add(this.lblAdresse2Client);
            this.Controls.Add(this.tbAdresse1Client);
            this.Controls.Add(this.lblAdresse1Client);
            this.Controls.Add(this.btSupprimer);
            this.Controls.Add(this.btEnregistrer);
            this.Controls.Add(this.tbTelFixeClient);
            this.Controls.Add(this.lblTelFixeClient);
            this.Controls.Add(this.tbMailClient);
            this.Controls.Add(this.lblMailClient);
            this.Controls.Add(this.tbPrenomClient);
            this.Controls.Add(this.lblPrenomClient);
            this.Controls.Add(this.tbNomClient);
            this.Controls.Add(this.lblNomClient);
            this.Controls.Add(this.tbIdClient);
            this.Controls.Add(this.lblidClient);
            this.Controls.Add(this.btRetour);
            this.Name = "Fm_Detail_Client";
            this.Text = "Fm_Detail_Client";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSupprimer;
        private System.Windows.Forms.Button btEnregistrer;
        private System.Windows.Forms.TextBox tbTelFixeClient;
        private System.Windows.Forms.Label lblTelFixeClient;
        private System.Windows.Forms.TextBox tbMailClient;
        private System.Windows.Forms.Label lblMailClient;
        private System.Windows.Forms.TextBox tbPrenomClient;
        private System.Windows.Forms.Label lblPrenomClient;
        private System.Windows.Forms.TextBox tbNomClient;
        private System.Windows.Forms.Label lblNomClient;
        private System.Windows.Forms.TextBox tbIdClient;
        private System.Windows.Forms.Label lblidClient;
        private System.Windows.Forms.Button btRetour;
        private System.Windows.Forms.TextBox tbAdresse1Client;
        private System.Windows.Forms.Label lblAdresse1Client;
        private System.Windows.Forms.TextBox tbAdresse2Client;
        private System.Windows.Forms.Label lblAdresse2Client;
        private System.Windows.Forms.TextBox tbCodePostalVilleClient;
        private System.Windows.Forms.Label lblCodePostalVilleClient;
        private System.Windows.Forms.TextBox tbTelPortableClient;
        private System.Windows.Forms.Label lblTelPortableClient;
        private System.Windows.Forms.ErrorProvider errorProviderClient;
    }
}