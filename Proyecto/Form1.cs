using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using AForge.Video.DirectShow;
using AForge.Video;

namespace Proyecto
{
    public partial class Form1 : Form
    {
        private bool ExistDevices;
        private FilterInfoCollection MyDevices;
        private VideoCaptureDevice MyWebCam;
        public Form1()
        {
            InitializeComponent();
        }

        private void btndescargar_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));

            string PaginaHTML_Texto = Properties.Resources.Plantilla.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@NOMBRE", txtnombres.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", txtdocumento.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CELULAR", txtdescripcion.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
           

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4,25,25,25,25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(picBox2.Image, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(550, 500);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;

                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Bottom + 100);
                    pdfDoc.Add(img);

                    iTextSharp.text.Image img2 = iTextSharp.text.Image.GetInstance(Properties.Resources.marca, System.Drawing.Imaging.ImageFormat.Png);
                    img2.ScaleToFit(60, 60);
                    img2.Alignment = iTextSharp.text.Image.UNDERLYING;

                    img2.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img2);

                    using (StringReader sr = new StringReader(PaginaHTML_Texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDevices();
            btnTakePhoto.Visible = false;
            btndescargar.Visible = false;
        }

        public void LoadDevices()
        {
            MyDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (MyDevices.Count > 0)
            {
                ExistDevices = true;
                for (int i = 0; i < MyDevices.Count; i++)
                    cboDevices.Items.Add(MyDevices[i].Name.ToString());
                cboDevices.Text = MyDevices[0].Name.ToString();
            }
            else
                ExistDevices = false;
        }

        private void CloseWebCam()
        {
            if (MyWebCam != null && MyWebCam.IsRunning)
            {
                MyWebCam.SignalToStop();
                MyWebCam = null;
            }
        }
        private void Capture(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap image = (Bitmap)eventArgs.Frame.Clone();
            picBox1.Image = image;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseWebCam();
        }

        private void btnStartCamera_Click(object sender, EventArgs e)
        {
            if (ExistDevices)
            {
                CloseWebCam();
                int i = cboDevices.SelectedIndex;
                string deviceName = MyDevices[i].MonikerString;
                MyWebCam = new VideoCaptureDevice(deviceName);
                MyWebCam.NewFrame += new NewFrameEventHandler(Capture);
                MyWebCam.Start();
                btnTakePhoto.Visible = true;
            }
        }

        private void btnTakePhoto_Click(object sender, EventArgs e)
        {
            if (MyWebCam != null && MyWebCam.IsRunning)
            {
                picBox2.Image = picBox1.Image;
                btndescargar.Visible = true;
            }
        }
    }
}
