using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using System.IO;

using System.Security.Cryptography.X509Certificates;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;
using X509Certificate = Org.BouncyCastle.X509.IX509Extension;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.security;
using Org.BouncyCastle.Pkcs;

using Syncfusion.Pdf.Parsing;
using Syncfusion.Pdf.Security;
using System.Security.Cryptography.X509Certificates;
using Org.BouncyCastle.Crypto.Parameters;

namespace DSC
{
    public partial class frmDSC : Form
    {
        X509Certificate2 certClient = null;
        bool signingInProgress = false;
        X509Certificate2Collection collection;
        X509Store st;
        

        public frmDSC()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(signingInProgress == false)
            {
                this.Close();
            }
            
        }

        //private static void SignPdf(string filename, string folderPdf, string pathToNewSignFile, string pathToCerts, string nameCert, string passCert)
        //{
        //    var pathToCert = Path.Combine(pathToCerts, nameCert);// GetFullNameFile(pathToCerts, nameCert);

        //    if (!File.Exists(pathToCert))
        //    {
        //        //logger.Error("Certificate not exist " + pathToCert);
        //        return;
        //    }

        //    var pass = passCert.ToCharArray();

        //    FileStream fs;
        //    try
        //    {
        //        fs = new FileStream(pathToCert, FileMode.Open);
        //    }
        //    catch (Exception ex)
        //    {
        //        //logger.Error(ex, "Could not open cert" + pathToCert);
        //        return;
        //    }

        //    var store = new Pkcs12Store(fs, pass);

        //    fs.Close();

        //    var alias = "";

        //    // searching for private key
        //    foreach (string al in store.Aliases)
        //        if (store.IsKeyEntry(al) && store.GetKey(al).Key.IsPrivate)
        //        {
        //            alias = al;
        //            break;
        //        }

        //    var pk = store.GetKey(alias);

        //    X509Certificate[] chain = store.GetCertificateChain(alias).Select(c => c.Certificate).ToList();

        //    var parameters = pk.Key as RsaPrivateCrtKeyParameters;

        //    var pathPdf = Path.Combine(folderPdf, filename); 

        //    var pathToSigPdf = Path.Combine(pathToNewSignFile, filename);

        //    if (!File.Exists(pathPdf))
        //    {
        //        //logger.Error("Could not open file" + pathPdf + "  File not exist");
        //        return;
        //    }

        //    var reader = new PdfReader(pathPdf);


        //    FileStream fileStreamSigPdf;
        //    try
        //    {
        //        fileStreamSigPdf = new FileStream(pathToSigPdf, FileMode.Create);
        //    }
        //    catch (Exception ex)
        //    {
        //        //logger.Error(ex, "Could not create file" + pathToSigPdf);
        //        return;
        //    }

        //    var stamper = PdfStamper.CreateSignature(reader, fileStreamSigPdf, '\0', null, true);

        //    var appearance = stamper.SignatureAppearance;
        //    //appearance.Reason = "Утверждено";

        //    //appearance.SetVisibleSignature("---> ExistSignatureName <-----");

        //    IExternalSignature pks = new PrivateKeySignature(parameters, DigestAlgorithms.SHA256);
        //    MakeSignature.SignDetached(appearance, pks, new Org.BouncyCastle.X509.X509Certificate[] { chain } , null, null, null, 0, CryptoStandard.CMS);

        //    fileStreamSigPdf.Close();
        //    reader.Close();
        //    stamper.Close();

        //    //logger.Info("Signed successfully " + filename);
        //}

        private void btnSign_Click(object sender, EventArgs e)
        {
            signingInProgress = true;
            btnSign.Enabled = false;
            toolStrip1.Items.Clear();

            IList<X509Certificate> chain = new List<X509Certificate>();
            X509Chain x509Chain = new X509Chain();
            x509Chain.Build(certClient);
            foreach (X509ChainElement x509ChainElement in x509Chain.ChainElements)
            {
                chain.Add(DotNetUtilities.FromX509Certificate(x509ChainElement.Certificate));
            }

            try
            {
                toolStrip1.Items.Clear();
                if (lstFiles.Items.Count > 0)
                {

                    //check this pk is accessible or not by using window or usb certificate
                    //comment all pk instances and check for window auth, if sign is occured or not  
                    //var pk = Org.BouncyCastle.Security.DotNetUtilities.GetKeyPair(certClient.PrivateKey).Private;

                    //var rsaPK = certClient.GetRSAPrivateKey();

                    //var pk = Org.BouncyCastle.Security.DotNetUtilities.GetKeyPair(certClient.PrivateKey);
                    //IExternalSignature es = new PrivateKeySignature(pk, DigestAlgorithms.SHA256);
                    
                    //check this certificate first and bcCert properties
                    Org.BouncyCastle.X509.X509Certificate bcCert = Org.BouncyCastle.Security.DotNetUtilities.FromX509Certificate(certClient);
                    var pk1 = certClient.PrivateKey;
                    
                    IExternalSignature es1 = new X509Certificate2Signature(certClient, DigestAlgorithms.SHA256);
                    
                    // get the pdf u want to sign
                    for (int i = 0; i < lstFiles.Items.Count; i++)
                    {
                        Application.DoEvents();
                        toolStrip1.Items.Clear();
                        string filename = txtFolderLoc.Text + "\\" + lstFiles.Items[i].Text + ".pdf";
                        string newFilename = txtFolderLoc.Text + "\\" + lstFiles.Items[i].Text + "_Signed" + ".pdf";

                        if (File.Exists(filename))
                        {
                            lstFiles.Items[i].BackColor = Color.LightBlue;

                            PdfReader pdfReader = new PdfReader(filename);
                            PdfStamper stamper = PdfStamper.CreateSignature(pdfReader, new FileStream(newFilename, FileMode.Create), '\0');
                            toolStrip1.Items.Add("Signing PDF : " + Path.GetFileName(filename));
                            PdfSignatureAppearance pdfSignatureAppearance = stamper.SignatureAppearance;
                            pdfSignatureAppearance.SignDate = DateTime.Now;
                            //CAG
                            //pdfSignatureAppearance.Reason = "CAG Digitization";
                            //THC
                            pdfSignatureAppearance.Reason = "Digitization of THC";
                            iTextSharp.text.Rectangle rectangle = new iTextSharp.text.Rectangle(100, 100, 250, 150);//20,10,170,10
                            try
                            {
                                pdfSignatureAppearance.SetVisibleSignature(rectangle, pdfReader.NumberOfPages, pdfSignatureAppearance.Reason);
                                pdfSignatureAppearance.SetStamper(stamper);
                                
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                continue; 
                            }

                            MakeSignature.SignDetached(pdfSignatureAppearance, es1, new Org.BouncyCastle.X509.X509Certificate[] { bcCert }, null, null, null, 0, CryptoStandard.CMS);

                            //verify
                            //toolStrip1.Items.Clear();
                            //toolStrip1.Items.Add("Verifying all signatures for PDF : " + Path.GetFileName(filename));
                            //AcroFields acroFields = pdfReader.AcroFields;
                            //var names = acroFields.GetSignatureNames();
                            //foreach (string name in names)
                            //{
                            //    PdfPKCS7 pdfPKCS7 = acroFields.VerifySignature(name);
                            //}
                            //toolStrip1.Items.Clear();
                            //toolStrip1.Items.Add("Verified all signatures for PDF : " + Path.GetFileName(filename));

                            stamper.Close();
                            pdfReader.Close();

                            File.Delete(filename);
                            File.Copy(newFilename, filename, true);
                            File.Delete(newFilename);

                            stamper.Dispose();
                            pdfReader.Dispose();

                            lstFiles.Items[i].BackColor = Color.YellowGreen;
                            
                        }
                        
                        GC.Collect();
                        //Dispose();

                        
                    }
                    toolStrip1.Items.Clear();
                    toolStrip1.Items.Add("All PDFs are signed successfully ");
                }
                else
                {
                    toolStrip1.Items.Add("There's no pdf to sign");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error ! " + ex.Message , "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //.SetCrypt(); sign the pdf
            //pdfSignatureAppearance.SetCrypto(pk, new Org.BouncyCastle.X509.X509Certificate[] { bcCert }, null, PdfSignatureAppearance.WINCER_SIGNED);
            
            //pdfSignatureAppearance.Reason = "Nothing";
            //pdfSignatureAppearance.Location = " Kolkata";
           
            

            signingInProgress = false;
        }

        private void btnSelectDSC_Click(object sender, EventArgs e)
        {
            if(cmbDSC.Items.Count>0)
            {
                if (cmbDSC.SelectedIndex >= 0)
                {
                    certClient = collection[cmbDSC.SelectedIndex];
                    lblDisplay.Text = "Issuer Name : " + certClient.IssuerName + " Version : " + certClient.Version;
                }
                else
                    lblDisplay.Text = "";
            }
            else
            { lblDisplay.Text = ""; }
        }

        private void frmDSC_Load(object sender, EventArgs e)
        {
            st = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            st.Open(OpenFlags.MaxAllowed);
            collection = st.Certificates;
            
            for (int i = 0; i < collection.Count; i++)
            {
                cmbDSC.Items.Add(collection[i]);
                foreach (X509Certificate2 cert in collection)
                {
                    certClient = cert;
                    string username = certClient.Subject;
                    string startdate = certClient.GetEffectiveDateString();
                    string enddate = certClient.GetExpirationDateString();

                }

            }
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            lstFiles.Items.Clear();

            DialogResult result = dlgFld.ShowDialog();
            if(result == DialogResult.OK)
            {
                txtFolderLoc.Text = dlgFld.SelectedPath;
                if(Directory.GetFiles(txtFolderLoc.Text).Length>0)
                {
                    
                    foreach(string file in Directory.GetFiles(txtFolderLoc.Text))
                    {
                        if(Path.GetExtension(file).ToLower()==".pdf")
                        {
                            string[] row = { Path.GetFileNameWithoutExtension(file) };
                            var listViewItem = new ListViewItem(row);
                            lstFiles.Items.Add(listViewItem);
                        }

                    }
                }
                else
                {
                    txtFolderLoc.Text = string.Empty;
                    MessageBox.Show(this, "No PDF found in the selected folder", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            if (lstFiles.Items.Count > 0)
            { 
                btnSign.Enabled = true; 
                for(int i =0;i<lstFiles.Items.Count;i++)
                {
                    if(i%2==0)
                    {
                        lstFiles.Items[i].BackColor = Color.Coral;
                    }
                    else {
                        lstFiles.Items[i].BackColor = Color.Cyan;
                    }
                }
            }
            else
                btnSign.Enabled = false;
        }

        private void cmbDSC_Leave(object sender, EventArgs e)
        {
            if (cmbDSC.Items.Count > 0)
            {
                if (cmbDSC.SelectedIndex >= 0)
                {
                    certClient = collection[cmbDSC.SelectedIndex];
                    lblDisplay.Text = "Issuer Name : " + certClient.IssuerName + " Version : " + certClient.Version;
                }
                else
                    lblDisplay.Text = "";
            }
            else
            { lblDisplay.Text = ""; }
        }
    }
}
