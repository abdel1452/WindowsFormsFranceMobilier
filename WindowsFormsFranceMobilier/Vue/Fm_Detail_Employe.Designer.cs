
namespace WindowsFormsFranceMobilier
{
    partial class Fm_Detail_Employe
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
            this.tbLoginEmploye = new System.Windows.Forms.TextBox();
            this.lblLoginEmploye = new System.Windows.Forms.Label();
            this.tbIdEmploye = new System.Windows.Forms.TextBox();
            this.lblidEmploye = new System.Windows.Forms.Label();
            this.tbNomEmploye = new System.Windows.Forms.TextBox();
            this.lblNomEmploye = new System.Windows.Forms.Label();
            this.tbPrenomEmploye = new System.Windows.Forms.TextBox();
            this.lblPrenomEmploye = new System.Windows.Forms.Label();
            this.tbMailEmploye = new System.Windows.Forms.TextBox();
            this.lblMailEmploye = new System.Windows.Forms.Label();
            this.tbTelEmploye = new System.Windows.Forms.TextBox();
            this.lblTelEmploye = new System.Windows.Forms.Label();
            this.btEnregistrer = new System.Windows.Forms.Button();
            this.lblMagasin = new System.Windows.Forms.Label();
            this.cbMagasin = new System.Windows.Forms.ComboBox();
            this.lblFonction = new System.Windows.Forms.Label();
            this.cbFonction = new System.Windows.Forms.ComboBox();
            this.errorProviderDetailEmploye = new System.Windows.Forms.ErrorProvider(this.components);
            this.btSupprimer = new System.Windows.Forms.Button();
            this.tbMdpEmploye = new System.Windows.Forms.TextBox();
            this.lblMdp = new System.Windows.Forms.Label();
            this.tbConfirmationMdpEmploye = new System.Windows.Forms.TextBox();
            this.lblConfirmationMdp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDetailEmploye)).BeginInit();
            this.SuspendLayout();
            // 
            // btRetour
            // 
            this.btRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRetour.Location = new System.Drawing.Point(645, 450);
            this.btRetour.Name = "btRetour";
            this.btRetour.Size = new System.Drawing.Size(100, 40);
            this.btRetour.TabIndex = 11;
            this.btRetour.Text = "Fermer";
            this.btRetour.UseVisualStyleBackColor = true;
            this.btRetour.Click += new System.EventHandler(this.btRetour_Click);
            // 
            // tbLoginEmploye
            // 
            this.tbLoginEmploye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLoginEmploye.Location = new System.Drawing.Point(142, 80);
            this.tbLoginEmploye.MaxLength = 25;
            this.tbLoginEmploye.Name = "tbLoginEmploye";
            this.tbLoginEmploye.Size = new System.Drawing.Size(135, 22);
            this.tbLoginEmploye.TabIndex = 13;
            // 
            // lblLoginEmploye
            // 
            this.lblLoginEmploye.AutoSize = true;
            this.lblLoginEmploye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginEmploye.Location = new System.Drawing.Point(45, 82);
            this.lblLoginEmploye.Name = "lblLoginEmploye";
            this.lblLoginEmploye.Size = new System.Drawing.Size(49, 16);
            this.lblLoginEmploye.TabIndex = 8;
            this.lblLoginEmploye.Text = "Login : ";
            // 
            // tbIdEmploye
            // 
            this.tbIdEmploye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdEmploye.Location = new System.Drawing.Point(142, 40);
            this.tbIdEmploye.Name = "tbIdEmploye";
            this.tbIdEmploye.ReadOnly = true;
            this.tbIdEmploye.Size = new System.Drawing.Size(100, 22);
            this.tbIdEmploye.TabIndex = 12;
            // 
            // lblidEmploye
            // 
            this.lblidEmploye.AutoSize = true;
            this.lblidEmploye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidEmploye.Location = new System.Drawing.Point(45, 42);
            this.lblidEmploye.Name = "lblidEmploye";
            this.lblidEmploye.Size = new System.Drawing.Size(27, 16);
            this.lblidEmploye.TabIndex = 6;
            this.lblidEmploye.Text = "Id : ";
            // 
            // tbNomEmploye
            // 
            this.tbNomEmploye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomEmploye.Location = new System.Drawing.Point(142, 180);
            this.tbNomEmploye.MaxLength = 50;
            this.tbNomEmploye.Name = "tbNomEmploye";
            this.tbNomEmploye.Size = new System.Drawing.Size(211, 22);
            this.tbNomEmploye.TabIndex = 3;
            // 
            // lblNomEmploye
            // 
            this.lblNomEmploye.AutoSize = true;
            this.lblNomEmploye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomEmploye.Location = new System.Drawing.Point(45, 182);
            this.lblNomEmploye.Name = "lblNomEmploye";
            this.lblNomEmploye.Size = new System.Drawing.Size(45, 16);
            this.lblNomEmploye.TabIndex = 10;
            this.lblNomEmploye.Text = "Nom : ";
            // 
            // tbPrenomEmploye
            // 
            this.tbPrenomEmploye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrenomEmploye.Location = new System.Drawing.Point(142, 220);
            this.tbPrenomEmploye.MaxLength = 50;
            this.tbPrenomEmploye.Name = "tbPrenomEmploye";
            this.tbPrenomEmploye.Size = new System.Drawing.Size(211, 22);
            this.tbPrenomEmploye.TabIndex = 4;
            // 
            // lblPrenomEmploye
            // 
            this.lblPrenomEmploye.AutoSize = true;
            this.lblPrenomEmploye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenomEmploye.Location = new System.Drawing.Point(45, 222);
            this.lblPrenomEmploye.Name = "lblPrenomEmploye";
            this.lblPrenomEmploye.Size = new System.Drawing.Size(63, 16);
            this.lblPrenomEmploye.TabIndex = 12;
            this.lblPrenomEmploye.Text = "Prénom : ";
            // 
            // tbMailEmploye
            // 
            this.tbMailEmploye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMailEmploye.Location = new System.Drawing.Point(142, 340);
            this.tbMailEmploye.MaxLength = 50;
            this.tbMailEmploye.Name = "tbMailEmploye";
            this.tbMailEmploye.Size = new System.Drawing.Size(417, 22);
            this.tbMailEmploye.TabIndex = 7;
            // 
            // lblMailEmploye
            // 
            this.lblMailEmploye.AutoSize = true;
            this.lblMailEmploye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMailEmploye.Location = new System.Drawing.Point(45, 342);
            this.lblMailEmploye.Name = "lblMailEmploye";
            this.lblMailEmploye.Size = new System.Drawing.Size(50, 16);
            this.lblMailEmploye.TabIndex = 14;
            this.lblMailEmploye.Text = "Email : ";
            // 
            // tbTelEmploye
            // 
            this.tbTelEmploye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelEmploye.Location = new System.Drawing.Point(142, 380);
            this.tbTelEmploye.MaxLength = 14;
            this.tbTelEmploye.Name = "tbTelEmploye";
            this.tbTelEmploye.Size = new System.Drawing.Size(135, 22);
            this.tbTelEmploye.TabIndex = 8;
            // 
            // lblTelEmploye
            // 
            this.lblTelEmploye.AutoSize = true;
            this.lblTelEmploye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelEmploye.Location = new System.Drawing.Point(45, 382);
            this.lblTelEmploye.Name = "lblTelEmploye";
            this.lblTelEmploye.Size = new System.Drawing.Size(82, 16);
            this.lblTelEmploye.TabIndex = 16;
            this.lblTelEmploye.Text = "Téléphone : ";
            // 
            // btEnregistrer
            // 
            this.btEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnregistrer.Location = new System.Drawing.Point(142, 450);
            this.btEnregistrer.Name = "btEnregistrer";
            this.btEnregistrer.Size = new System.Drawing.Size(150, 35);
            this.btEnregistrer.TabIndex = 9;
            this.btEnregistrer.Text = "Enregistrer";
            this.btEnregistrer.UseVisualStyleBackColor = true;
            this.btEnregistrer.Click += new System.EventHandler(this.btEnregistrer_Click);
            // 
            // lblMagasin
            // 
            this.lblMagasin.AutoSize = true;
            this.lblMagasin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMagasin.Location = new System.Drawing.Point(45, 262);
            this.lblMagasin.Name = "lblMagasin";
            this.lblMagasin.Size = new System.Drawing.Size(68, 16);
            this.lblMagasin.TabIndex = 20;
            this.lblMagasin.Text = "Magasin : ";
            // 
            // cbMagasin
            // 
            this.cbMagasin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMagasin.FormattingEnabled = true;
            this.cbMagasin.Location = new System.Drawing.Point(142, 260);
            this.cbMagasin.Name = "cbMagasin";
            this.cbMagasin.Size = new System.Drawing.Size(327, 24);
            this.cbMagasin.TabIndex = 5;
            // 
            // lblFonction
            // 
            this.lblFonction.AutoSize = true;
            this.lblFonction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFonction.Location = new System.Drawing.Point(45, 302);
            this.lblFonction.Name = "lblFonction";
            this.lblFonction.Size = new System.Drawing.Size(67, 16);
            this.lblFonction.TabIndex = 21;
            this.lblFonction.Text = "Fonction : ";
            // 
            // cbFonction
            // 
            this.cbFonction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFonction.FormattingEnabled = true;
            this.cbFonction.Location = new System.Drawing.Point(142, 300);
            this.cbFonction.Name = "cbFonction";
            this.cbFonction.Size = new System.Drawing.Size(205, 24);
            this.cbFonction.TabIndex = 6;
            // 
            // errorProviderDetailEmploye
            // 
            this.errorProviderDetailEmploye.ContainerControl = this;
            // 
            // btSupprimer
            // 
            this.btSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSupprimer.Location = new System.Drawing.Point(320, 450);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(150, 35);
            this.btSupprimer.TabIndex = 10;
            this.btSupprimer.Text = "Supprimer";
            this.btSupprimer.UseVisualStyleBackColor = true;
            this.btSupprimer.Click += new System.EventHandler(this.btSupprimer_Click);
            // 
            // tbMdpEmploye
            // 
            this.tbMdpEmploye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMdpEmploye.Location = new System.Drawing.Point(142, 120);
            this.tbMdpEmploye.MaxLength = 50;
            this.tbMdpEmploye.Name = "tbMdpEmploye";
            this.tbMdpEmploye.Size = new System.Drawing.Size(211, 22);
            this.tbMdpEmploye.TabIndex = 1;
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMdp.Location = new System.Drawing.Point(45, 122);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(98, 16);
            this.lblMdp.TabIndex = 27;
            this.lblMdp.Text = "Mot de passe : ";
            // 
            // tbConfirmationMdpEmploye
            // 
            this.tbConfirmationMdpEmploye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfirmationMdpEmploye.Location = new System.Drawing.Point(562, 120);
            this.tbConfirmationMdpEmploye.MaxLength = 50;
            this.tbConfirmationMdpEmploye.Name = "tbConfirmationMdpEmploye";
            this.tbConfirmationMdpEmploye.Size = new System.Drawing.Size(211, 22);
            this.tbConfirmationMdpEmploye.TabIndex = 2;
            // 
            // lblConfirmationMdp
            // 
            this.lblConfirmationMdp.AutoSize = true;
            this.lblConfirmationMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmationMdp.Location = new System.Drawing.Point(388, 122);
            this.lblConfirmationMdp.Name = "lblConfirmationMdp";
            this.lblConfirmationMdp.Size = new System.Drawing.Size(175, 16);
            this.lblConfirmationMdp.TabIndex = 29;
            this.lblConfirmationMdp.Text = "Confirmation mot de passe : ";
            // 
            // Fm_Detail_Employe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.ControlBox = false;
            this.Controls.Add(this.tbConfirmationMdpEmploye);
            this.Controls.Add(this.lblConfirmationMdp);
            this.Controls.Add(this.tbMdpEmploye);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.btSupprimer);
            this.Controls.Add(this.cbFonction);
            this.Controls.Add(this.lblFonction);
            this.Controls.Add(this.lblMagasin);
            this.Controls.Add(this.cbMagasin);
            this.Controls.Add(this.btEnregistrer);
            this.Controls.Add(this.tbTelEmploye);
            this.Controls.Add(this.lblTelEmploye);
            this.Controls.Add(this.tbMailEmploye);
            this.Controls.Add(this.lblMailEmploye);
            this.Controls.Add(this.tbPrenomEmploye);
            this.Controls.Add(this.lblPrenomEmploye);
            this.Controls.Add(this.tbNomEmploye);
            this.Controls.Add(this.lblNomEmploye);
            this.Controls.Add(this.tbLoginEmploye);
            this.Controls.Add(this.lblLoginEmploye);
            this.Controls.Add(this.tbIdEmploye);
            this.Controls.Add(this.lblidEmploye);
            this.Controls.Add(this.btRetour);
            this.Name = "Fm_Detail_Employe";
            this.Text = "Detail Employé";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDetailEmploye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRetour;
        private System.Windows.Forms.TextBox tbLoginEmploye;
        private System.Windows.Forms.Label lblLoginEmploye;
        private System.Windows.Forms.TextBox tbIdEmploye;
        private System.Windows.Forms.Label lblidEmploye;
        private System.Windows.Forms.TextBox tbNomEmploye;
        private System.Windows.Forms.Label lblNomEmploye;
        private System.Windows.Forms.TextBox tbPrenomEmploye;
        private System.Windows.Forms.Label lblPrenomEmploye;
        private System.Windows.Forms.TextBox tbMailEmploye;
        private System.Windows.Forms.Label lblMailEmploye;
        private System.Windows.Forms.TextBox tbTelEmploye;
        private System.Windows.Forms.Label lblTelEmploye;
        private System.Windows.Forms.Button btEnregistrer;
        private System.Windows.Forms.Label lblMagasin;
        private System.Windows.Forms.ComboBox cbMagasin;
        private System.Windows.Forms.Label lblFonction;
        private System.Windows.Forms.ComboBox cbFonction;
        private System.Windows.Forms.ErrorProvider errorProviderDetailEmploye;
        private System.Windows.Forms.Button btSupprimer;
        private System.Windows.Forms.TextBox tbConfirmationMdpEmploye;
        private System.Windows.Forms.Label lblConfirmationMdp;
        private System.Windows.Forms.TextBox tbMdpEmploye;
        private System.Windows.Forms.Label lblMdp;
    }
}