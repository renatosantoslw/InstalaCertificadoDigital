using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Drawing.Drawing2D;

namespace CERT
{
    public partial class frmPrincipal : Form
    {

        frmInputBox frm2 = new frmInputBox();


        public frmPrincipal()
        {
            InitializeComponent();
    
        }

        private void btnAcao_Click(object sender, EventArgs e)
        {


            try
            {



                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                openFileDialog1.Filter = "Arquivo do tipo pfx (*.pfx)|*.pfx";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    string filename = openFileDialog1.FileName;
                    var cert = new X509Certificate2(filename, frm2.strSenhaCertificado, X509KeyStorageFlags.Exportable);
                    var stringOfCertWithPrivateKey = Convert.ToBase64String(cert.Export(X509ContentType.Pkcs12));

                    X509Store store = new X509Store(StoreName.My);
                    store.Open(OpenFlags.ReadWrite);

                    store.Remove(cert);
                    MessageBox.Show("Certificado Removido!");

                    store.Add(cert);
                    txtCert.Text = stringOfCertWithPrivateKey;

                    MessageBox.Show("Certificado Instalado!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // string filename = @"C:\D\SANTOS DO VALE COMERCIO LTDA.pfx";
            // var cert = new X509Certificate2(filename,"12345678", X509KeyStorageFlags.Exportable);         
            // var stringOfCertWithPrivateKey = Convert.ToBase64String(cert.Export(X509ContentType.Pkcs12));
            //var stringOfCertWithoutPrivateKey = Convert.ToBase64String(cert.Export(X509ContentType.Cert));
            // txtVarcharCert.Text= stringOfCertWithPrivateKey;

        }

        private void btnAcao2_Click(object sender, EventArgs e)
        {

            try
            {

                var certBytes = Convert.FromBase64String(txtCert.Text);
                // var cert = new X509Certificate2(certBytes);
                var cert = new X509Certificate2(certBytes, (string)null, X509KeyStorageFlags.Exportable);

                //File.WriteAllBytes(@"C:\D\EXPORTADO.pfx", cert.Export(X509ContentType.Pkcs12, "12345678"));

                SaveFileDialog file = new SaveFileDialog();


                file.Filter = "Arquivo do tipo pfx (*.pfx)|*.pfx";
                file.ShowDialog();

                if (file.FileName != "")
                {
                    File.WriteAllBytes(file.FileName, cert.Export(X509ContentType.Pkcs12, frm2.strSenhaCertificado));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }





        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(pictBoxPainel.Width, pictBoxPainel.Height);
            LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(new PointF(0, 0), new PointF(img.Width, img.Height), Color.SteelBlue, SystemColors.Control);
            Graphics gr  = Graphics.FromImage(img);
            gr.FillRectangle(brush, new RectangleF(0, 0, img.Width, img.Height));
            pictBoxPainel.BackgroundImage = img;

            lblPainel.Parent = pictBoxPainel;
            lblPainel.BackColor = Color.Transparent;
            lblPainel.BringToFront();

            pictBoxLogoPainel.Parent = pictBoxPainel;
            pictBoxLogoPainel.BackColor = Color.Transparent;
            pictBoxLogoPainel.BringToFront();

        }

        private void lblIncluir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm2.ShowDialog();

            try
            {

                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                openFileDialog1.Filter = "Arquivo do tipo pfx (*.pfx)|*.pfx";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    string filename = openFileDialog1.FileName;
                    var cert = new X509Certificate2(filename, frm2.strSenhaCertificado, X509KeyStorageFlags.Exportable);
                    var stringOfCertWithPrivateKey = Convert.ToBase64String(cert.Export(X509ContentType.Pkcs12));

                    X509Store store = new X509Store(StoreName.My);
                    store.Open(OpenFlags.ReadWrite);

                    store.Remove(cert);
                    MessageBox.Show("Certificado Removido!");

                    store.Add(cert);
                    txtCert.Text = stringOfCertWithPrivateKey;

                    MessageBox.Show("Certificado Instalado!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }





            // string filename = @"C:\D\SANTOS DO VALE COMERCIO LTDA.pfx";
            // var cert = new X509Certificate2(filename,"12345678", X509KeyStorageFlags.Exportable);         
            // var stringOfCertWithPrivateKey = Convert.ToBase64String(cert.Export(X509ContentType.Pkcs12));
            //var stringOfCertWithoutPrivateKey = Convert.ToBase64String(cert.Export(X509ContentType.Cert));
            // txtVarcharCert.Text= stringOfCertWithPrivateKey;



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            frm2.ShowDialog();

      

            try
            {

                var certBytes = Convert.FromBase64String(txtCert.Text);
                // var cert = new X509Certificate2(certBytes);
                var cert = new X509Certificate2(certBytes, (string)null, X509KeyStorageFlags.Exportable);

                //File.WriteAllBytes(@"C:\D\EXPORTADO.pfx", cert.Export(X509ContentType.Pkcs12, "12345678"));

                SaveFileDialog file = new SaveFileDialog();


                file.Filter = "Arquivo do tipo pfx (*.pfx)|*.pfx";
                file.ShowDialog();

                if (file.FileName != "")
                {
                    File.WriteAllBytes(file.FileName, cert.Export(X509ContentType.Pkcs12, frm2.strSenhaCertificado));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
           
       
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
      

        }
    }



}
