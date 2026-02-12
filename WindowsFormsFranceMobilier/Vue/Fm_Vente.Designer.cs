
namespace WindowsFormsFranceMobilier
{
    partial class Fm_Vente
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
            this.btRetour = new System.Windows.Forms.Button();
            this.lblClient = new System.Windows.Forms.Label();
            this.tbContactClient = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.listViewVente = new System.Windows.Forms.ListView();
            this.numVente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.detailVente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbClient = new System.Windows.Forms.TextBox();
            this.btRechercheClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btRetour
            // 
            this.btRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRetour.Location = new System.Drawing.Point(662, 388);
            this.btRetour.Name = "btRetour";
            this.btRetour.Size = new System.Drawing.Size(100, 35);
            this.btRetour.TabIndex = 4;
            this.btRetour.Text = "Fermer";
            this.btRetour.UseVisualStyleBackColor = true;
            this.btRetour.Click += new System.EventHandler(this.btRetour_Click);
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.Location = new System.Drawing.Point(16, 47);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(49, 16);
            this.lblClient.TabIndex = 34;
            this.lblClient.Text = "Client : ";
            // 
            // tbContactClient
            // 
            this.tbContactClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContactClient.Location = new System.Drawing.Point(177, 84);
            this.tbContactClient.Name = "tbContactClient";
            this.tbContactClient.ReadOnly = true;
            this.tbContactClient.Size = new System.Drawing.Size(487, 22);
            this.tbContactClient.TabIndex = 2;
            // 
            // lblContact
            // 
            this.lblContact.AutoEllipsis = true;
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(109, 87);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(61, 16);
            this.lblContact.TabIndex = 31;
            this.lblContact.Text = "Contact : ";
            // 
            // listViewVente
            // 
            this.listViewVente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.numVente,
            this.detailVente});
            this.listViewVente.FullRowSelect = true;
            this.listViewVente.HideSelection = false;
            this.listViewVente.Location = new System.Drawing.Point(19, 128);
            this.listViewVente.MultiSelect = false;
            this.listViewVente.Name = "listViewVente";
            this.listViewVente.Size = new System.Drawing.Size(743, 236);
            this.listViewVente.TabIndex = 3;
            this.listViewVente.UseCompatibleStateImageBehavior = false;
            this.listViewVente.View = System.Windows.Forms.View.Details;
            this.listViewVente.DoubleClick += new System.EventHandler(this.listViewVente_DoubleClick);
            // 
            // numVente
            // 
            this.numVente.Text = "N° vente";
            this.numVente.Width = 107;
            // 
            // detailVente
            // 
            this.detailVente.Text = "Détail vente";
            this.detailVente.Width = 628;
            // 
            // tbClient
            // 
            this.tbClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClient.Location = new System.Drawing.Point(125, 44);
            this.tbClient.Name = "tbClient";
            this.tbClient.ReadOnly = true;
            this.tbClient.Size = new System.Drawing.Size(637, 22);
            this.tbClient.TabIndex = 55;
            // 
            // btRechercheClient
            // 
            this.btRechercheClient.BackgroundImage = global::WindowsFormsFranceMobilier.Properties.Resources.loupe;
            this.btRechercheClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btRechercheClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRechercheClient.Location = new System.Drawing.Point(73, 40);
            this.btRechercheClient.Name = "btRechercheClient";
            this.btRechercheClient.Size = new System.Drawing.Size(32, 28);
            this.btRechercheClient.TabIndex = 54;
            this.btRechercheClient.UseVisualStyleBackColor = true;
            this.btRechercheClient.Click += new System.EventHandler(this.btRechercheClient_Click);
            // 
            // Fm_Vente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.tbClient);
            this.Controls.Add(this.btRechercheClient);
            this.Controls.Add(this.listViewVente);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.tbContactClient);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.btRetour);
            this.Name = "Fm_Vente";
            this.Text = "Vente";
            this.Activated += new System.EventHandler(this.Fm_Vente_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRetour;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.TextBox tbContactClient;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.ListView listViewVente;
        private System.Windows.Forms.ColumnHeader numVente;
        private System.Windows.Forms.ColumnHeader detailVente;
        private System.Windows.Forms.TextBox tbClient;
        private System.Windows.Forms.Button btRechercheClient;
    }
}