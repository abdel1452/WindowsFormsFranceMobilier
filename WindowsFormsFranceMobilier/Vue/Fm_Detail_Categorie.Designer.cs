
namespace WindowsFormsFranceMobilier
{
    partial class Fm_Detail_Categorie
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
            this.btEnregistrer = new System.Windows.Forms.Button();
            this.btRetour = new System.Windows.Forms.Button();
            this.tbLibelleCategorie = new System.Windows.Forms.TextBox();
            this.lblLibelleCategorie = new System.Windows.Forms.Label();
            this.tbIdCategorie = new System.Windows.Forms.TextBox();
            this.lblidCategorie = new System.Windows.Forms.Label();
            this.errorProviderDetailCategorie = new System.Windows.Forms.ErrorProvider(this.components);
            this.btSupprimer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDetailCategorie)).BeginInit();
            this.SuspendLayout();
            // 
            // btEnregistrer
            // 
            this.btEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnregistrer.Location = new System.Drawing.Point(170, 390);
            this.btEnregistrer.Name = "btEnregistrer";
            this.btEnregistrer.Size = new System.Drawing.Size(150, 35);
            this.btEnregistrer.TabIndex = 20;
            this.btEnregistrer.Text = "Enregistrer";
            this.btEnregistrer.UseVisualStyleBackColor = true;
            this.btEnregistrer.Click += new System.EventHandler(this.btEnregistrer_Click);
            // 
            // btRetour
            // 
            this.btRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRetour.Location = new System.Drawing.Point(670, 390);
            this.btRetour.Name = "btRetour";
            this.btRetour.Size = new System.Drawing.Size(100, 40);
            this.btRetour.TabIndex = 4;
            this.btRetour.Text = "Fermer";
            this.btRetour.UseVisualStyleBackColor = true;
            this.btRetour.Click += new System.EventHandler(this.btRetour_Click);
            // 
            // tbLibelleCategorie
            // 
            this.tbLibelleCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLibelleCategorie.Location = new System.Drawing.Point(170, 97);
            this.tbLibelleCategorie.Name = "tbLibelleCategorie";
            this.tbLibelleCategorie.Size = new System.Drawing.Size(262, 22);
            this.tbLibelleCategorie.TabIndex = 24;
            // 
            // lblLibelleCategorie
            // 
            this.lblLibelleCategorie.AutoSize = true;
            this.lblLibelleCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibelleCategorie.Location = new System.Drawing.Point(85, 100);
            this.lblLibelleCategorie.Name = "lblLibelleCategorie";
            this.lblLibelleCategorie.Size = new System.Drawing.Size(56, 16);
            this.lblLibelleCategorie.TabIndex = 23;
            this.lblLibelleCategorie.Text = "Libellé : ";
            // 
            // tbIdCategorie
            // 
            this.tbIdCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdCategorie.Location = new System.Drawing.Point(170, 52);
            this.tbIdCategorie.Name = "tbIdCategorie";
            this.tbIdCategorie.ReadOnly = true;
            this.tbIdCategorie.Size = new System.Drawing.Size(100, 22);
            this.tbIdCategorie.TabIndex = 22;
            // 
            // lblidCategorie
            // 
            this.lblidCategorie.AutoSize = true;
            this.lblidCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidCategorie.Location = new System.Drawing.Point(85, 55);
            this.lblidCategorie.Name = "lblidCategorie";
            this.lblidCategorie.Size = new System.Drawing.Size(27, 16);
            this.lblidCategorie.TabIndex = 21;
            this.lblidCategorie.Text = "Id : ";
            // 
            // errorProviderDetailCategorie
            // 
            this.errorProviderDetailCategorie.ContainerControl = this;
            // 
            // btSupprimer
            // 
            this.btSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSupprimer.Location = new System.Drawing.Point(350, 390);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(150, 35);
            this.btSupprimer.TabIndex = 25;
            this.btSupprimer.Text = "Supprimer";
            this.btSupprimer.UseVisualStyleBackColor = true;
            this.btSupprimer.Click += new System.EventHandler(this.btSupprimer_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(170, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Enregistrer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btEnregistrer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Id : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Libellé : ";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(350, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Supprimer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btSupprimer_Click);
            // 
            // Fm_Detail_Categorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btSupprimer);
            this.Controls.Add(this.tbLibelleCategorie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLibelleCategorie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIdCategorie);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblidCategorie);
            this.Controls.Add(this.btEnregistrer);
            this.Controls.Add(this.btRetour);
            this.Name = "Fm_Detail_Categorie";
            this.Text = "Détail catégorie";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDetailCategorie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btEnregistrer;
        private System.Windows.Forms.Button btRetour;
        private System.Windows.Forms.TextBox tbLibelleCategorie;
        private System.Windows.Forms.Label lblLibelleCategorie;
        private System.Windows.Forms.TextBox tbIdCategorie;
        private System.Windows.Forms.Label lblidCategorie;
        private System.Windows.Forms.ErrorProvider errorProviderDetailCategorie;
        private System.Windows.Forms.Button btSupprimer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}