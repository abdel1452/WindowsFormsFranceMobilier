
namespace WindowsFormsFranceMobilier
{
    partial class Fm_Detail_Gamme
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
            this.tbLibelleGamme = new System.Windows.Forms.TextBox();
            this.lblLibelleGamme = new System.Windows.Forms.Label();
            this.tbIdGamme = new System.Windows.Forms.TextBox();
            this.lblidGamme = new System.Windows.Forms.Label();
            this.btEnregistrer = new System.Windows.Forms.Button();
            this.btRetour = new System.Windows.Forms.Button();
            this.errorProviderDetailGamme = new System.Windows.Forms.ErrorProvider(this.components);
            this.btSupprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDetailGamme)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLibelleGamme
            // 
            this.tbLibelleGamme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLibelleGamme.Location = new System.Drawing.Point(145, 82);
            this.tbLibelleGamme.MaxLength = 50;
            this.tbLibelleGamme.Name = "tbLibelleGamme";
            this.tbLibelleGamme.Size = new System.Drawing.Size(262, 22);
            this.tbLibelleGamme.TabIndex = 1;
            // 
            // lblLibelleGamme
            // 
            this.lblLibelleGamme.AutoSize = true;
            this.lblLibelleGamme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibelleGamme.Location = new System.Drawing.Point(55, 84);
            this.lblLibelleGamme.Name = "lblLibelleGamme";
            this.lblLibelleGamme.Size = new System.Drawing.Size(56, 16);
            this.lblLibelleGamme.TabIndex = 29;
            this.lblLibelleGamme.Text = "Libellé : ";
            // 
            // tbIdGamme
            // 
            this.tbIdGamme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdGamme.Location = new System.Drawing.Point(145, 37);
            this.tbIdGamme.Name = "tbIdGamme";
            this.tbIdGamme.ReadOnly = true;
            this.tbIdGamme.Size = new System.Drawing.Size(100, 22);
            this.tbIdGamme.TabIndex = 5;
            // 
            // lblidGamme
            // 
            this.lblidGamme.AutoSize = true;
            this.lblidGamme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidGamme.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            this.lblidGamme.Location = new System.Drawing.Point(55, 39);
            this.lblidGamme.Name = "lblidGamme";
            this.lblidGamme.Size = new System.Drawing.Size(27, 16);
            this.lblidGamme.TabIndex = 27;
            this.lblidGamme.Text = "Id : ";
            // 
            // btEnregistrer
            // 
            this.btEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnregistrer.Location = new System.Drawing.Point(145, 375);
            this.btEnregistrer.Name = "btEnregistrer";
            this.btEnregistrer.Size = new System.Drawing.Size(150, 35);
            this.btEnregistrer.TabIndex = 2;
            this.btEnregistrer.Text = "Enregistrer";
            this.btEnregistrer.UseVisualStyleBackColor = true;
            this.btEnregistrer.Click += new System.EventHandler(this.btEnregistrer_Click);
            // 
            // btRetour
            // 
            this.btRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRetour.Location = new System.Drawing.Point(650, 375);
            this.btRetour.Name = "btRetour";
            this.btRetour.Size = new System.Drawing.Size(100, 40);
            this.btRetour.TabIndex = 4;
            this.btRetour.Text = "Fermer";
            this.btRetour.UseVisualStyleBackColor = true;
            this.btRetour.Click += new System.EventHandler(this.btRetour_Click);
            // 
            // errorProviderDetailGamme
            // 
            this.errorProviderDetailGamme.ContainerControl = this;
            // 
            // btSupprimer
            // 
            this.btSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSupprimer.Location = new System.Drawing.Point(335, 375);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(150, 35);
            this.btSupprimer.TabIndex = 3;
            this.btSupprimer.Text = "Supprimer";
            this.btSupprimer.UseVisualStyleBackColor = true;
            this.btSupprimer.Click += new System.EventHandler(this.btSupprimer_Click);
            // 
            // Fm_Detail_Gamme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btSupprimer);
            this.Controls.Add(this.tbLibelleGamme);
            this.Controls.Add(this.lblLibelleGamme);
            this.Controls.Add(this.tbIdGamme);
            this.Controls.Add(this.lblidGamme);
            this.Controls.Add(this.btEnregistrer);
            this.Controls.Add(this.btRetour);
            this.Name = "Fm_Detail_Gamme";
            this.Text = "Fm_Detail_Gamme";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDetailGamme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLibelleGamme;
        private System.Windows.Forms.Label lblLibelleGamme;
        private System.Windows.Forms.TextBox tbIdGamme;
        private System.Windows.Forms.Label lblidGamme;
        private System.Windows.Forms.Button btEnregistrer;
        private System.Windows.Forms.Button btRetour;
        private System.Windows.Forms.ErrorProvider errorProviderDetailGamme;
        private System.Windows.Forms.Button btSupprimer;
    }
}