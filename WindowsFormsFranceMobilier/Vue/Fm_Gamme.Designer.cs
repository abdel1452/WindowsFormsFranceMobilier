
namespace WindowsFormsFranceMobilier
{
    partial class Fm_Gamme
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
            this.btNouvelleGamme = new System.Windows.Forms.Button();
            this.btRetour = new System.Windows.Forms.Button();
            this.listViewGamme = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gamme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btNouvelleGamme
            // 
            this.btNouvelleGamme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNouvelleGamme.Location = new System.Drawing.Point(478, 282);
            this.btNouvelleGamme.Name = "btNouvelleGamme";
            this.btNouvelleGamme.Size = new System.Drawing.Size(160, 35);
            this.btNouvelleGamme.TabIndex = 2;
            this.btNouvelleGamme.Text = "Nouvelle gamme";
            this.btNouvelleGamme.UseVisualStyleBackColor = true;
            this.btNouvelleGamme.Click += new System.EventHandler(this.btNouvelleGamme_Click);
            // 
            // btRetour
            // 
            this.btRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRetour.Location = new System.Drawing.Point(538, 394);
            this.btRetour.Name = "btRetour";
            this.btRetour.Size = new System.Drawing.Size(100, 35);
            this.btRetour.TabIndex = 3;
            this.btRetour.Text = "Fermer";
            this.btRetour.UseVisualStyleBackColor = true;
            this.btRetour.Click += new System.EventHandler(this.btRetour_Click);
            // 
            // listViewGamme
            // 
            this.listViewGamme.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.gamme});
            this.listViewGamme.FullRowSelect = true;
            this.listViewGamme.HideSelection = false;
            this.listViewGamme.Location = new System.Drawing.Point(43, 12);
            this.listViewGamme.Name = "listViewGamme";
            this.listViewGamme.Size = new System.Drawing.Size(395, 417);
            this.listViewGamme.TabIndex = 1;
            this.listViewGamme.UseCompatibleStateImageBehavior = false;
            this.listViewGamme.View = System.Windows.Forms.View.Details;
            this.listViewGamme.DoubleClick += new System.EventHandler(this.listViewCategorie_DoubleClick);
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 75;
            // 
            // gamme
            // 
            this.gamme.Text = "Gamme";
            this.gamme.Width = 312;
            // 
            // Fm_Gamme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(694, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btNouvelleGamme);
            this.Controls.Add(this.btRetour);
            this.Controls.Add(this.listViewGamme);
            this.Name = "Fm_Gamme";
            this.Text = "Gammes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btNouvelleGamme;
        private System.Windows.Forms.Button btRetour;
        private System.Windows.Forms.ListView listViewGamme;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader gamme;
    }
}