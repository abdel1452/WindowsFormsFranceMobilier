
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsFranceMobilier
{
    public class FacturePdf
    {
        public static void GeneratePdf(int idVente)
        {

            try
            {

                Modele_Vente modeleVente = new Modele_Vente();
                Vente uneVente = modeleVente.GetVente(idVente);

                List<Contenir> lesProduits = uneVente.GetListeLigneVente();

                Modele_Client modeleClient = new Modele_Client();
                Client unClient = modeleClient.GetClient(uneVente.GetIdClient());

                Modele_Magasin modeleMagasin = new Modele_Magasin();
                Magasin unMagasin = modeleMagasin.GetMagasin(uneVente.GetMagasin());

                Modele_Employe modeleEmploye = new Modele_Employe();
                Employe unEmploye = modeleEmploye.GetEmploye(uneVente.GetIdEmploye());

                PdfWriter writer = new PdfWriter("../../../facture" + uneVente.GetNumFacture() + "_" + unClient.GetNom() + ".pdf"); //Le dossier Courant est NomDuProjet/bin/debug
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);

                //**************** ENTETE
                Paragraph header = new Paragraph("\nFACTURE n°" + uneVente.GetNumFacture() + "\n\n\n");
                header.SetTextAlignment(TextAlignment.CENTER);
                header.SetFontSize(24);
                document.Add(header);

                //**************** INFO France Mobilier
                Paragraph p1 = new Paragraph(unMagasin.GetNom() + "\n" + unMagasin.GetAdresseRue() + "\n" + unMagasin.GetCpVille() + "\n");
                p1.SetTextAlignment(TextAlignment.LEFT);
                document.Add(p1);

                //**************** INFO CLIENT
                string adresseClient = unClient.GetAdresse1();
                if (unClient.GetAdresse2() != "")
                {
                    adresseClient = adresseClient + "\n" + unClient.GetAdresse2();
                }
                Paragraph p2 = new Paragraph(unClient.GetNom() + unClient.GetPrenom() + "\n" + adresseClient + "\n" + unClient.GetMail() + "\n" + unClient.GetTelFixe() + "\n" + unClient.GetTelPortable());
                p2.SetTextAlignment(TextAlignment.RIGHT);
                document.Add(p2);

                //**************** DATE Facture
                Paragraph p3 = new Paragraph(DateTime.Parse(uneVente.GetDateFacture().ToString()).ToShortDateString());
                p3.SetTextAlignment(TextAlignment.LEFT);
                document.Add(p3);

                //*************** Vendeur
                Paragraph p4 = new Paragraph("\nVendeur : " + unEmploye.GetNom() + " " + unEmploye.GetPrenom() + "\n" + unEmploye.GetMail() + "\n" + unEmploye.GetTel() + "\n");
                p4.SetTextAlignment(TextAlignment.LEFT);
                document.Add(p4);

                //**************** PRODUITS ACHETES
                Table table = new Table(5);
                table.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.RIGHT);
                table.SetTextAlignment(TextAlignment.RIGHT); 
                table.AddHeaderCell("Référence");
                table.AddHeaderCell("Quantité");
                table.AddHeaderCell("Emporté");
                table.AddHeaderCell("Prix unitaire HT (€)");
                table.AddHeaderCell("Prix total HT (€)");

                decimal montantTotalHtCommande = 0;
                Modele_Produit modeleProduit = new Modele_Produit();

                //string lignesCommande = "";

                foreach (Contenir uneLigneCommande in lesProduits)
                {

                    Produit leProduit = modeleProduit.GetProduit(uneLigneCommande.GetIdProduit());

                    decimal montantTotalHtLigne = Math.Round(uneLigneCommande.GetPrixUnitaireHt(), 2) * uneLigneCommande.GetQuantiteVendue();
                    decimal prixUnitaireHTLigne = Math.Round(uneLigneCommande.GetPrixUnitaireHt(), 2);
                   
                    table.AddCell(leProduit.GetReference().ToString() + " " + leProduit.GetDesignation().ToString());
                    table.AddCell(uneLigneCommande.GetQuantiteVendue().ToString());
                    table.AddCell(uneLigneCommande.GetQuantiteRetiree().ToString());
                    table.AddCell(prixUnitaireHTLigne.ToString());
                    table.AddCell(montantTotalHtLigne.ToString());
                    
                    montantTotalHtCommande = montantTotalHtCommande + montantTotalHtLigne;
                }

                document.Add(table);

                decimal tauxTva = uneVente.GetTauxTva();

                Paragraph p5 = new Paragraph("\n\nTotal HT (€) : " + montantTotalHtCommande + "\n" +
                                                $"TVA (€) : " + Math.Round((montantTotalHtCommande * tauxTva), 2) + "\n" +
                                                $"Prix Total TTC (€) : " + Math.Round((montantTotalHtCommande * (tauxTva + 1M)), 2) + "\n");
                p5.SetTextAlignment(TextAlignment.RIGHT);
                document.Add(p5);

                document.Close();


                //Affichage du Pdf avec le programme par défaut de Windows
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                process.StartInfo = startInfo;

                startInfo.FileName = @"..\..\..\facture" + uneVente.GetNumFacture() + "_" + unClient.GetNom() + ".pdf";
                process.Start();

            }
            catch (Exception exception)
            {
                MessageBox.Show("Erreur lors de la génération du PDF.\n" + exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
