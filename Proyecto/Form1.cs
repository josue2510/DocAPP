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
using System.util;
using OrthoAnalisis.Properties;

namespace Proyecto
{
    public partial class Form1 : Form
    {
        private bool ExistDevices;
        private FilterInfoCollection MyDevices;
        private VideoCaptureDevice MyWebCam;
        private VideoCaptureDevice MyWebCam2;
        private VideoCaptureDevice MyWebCam3;
        private VideoCaptureDevice MyWebCam4;
        private VideoCaptureDevice MyWebCam5;
        private bool photoTaken1 = false;
        private bool photoTaken2 = false;
        private bool photoTaken3 = false;
        private bool photoTaken4 = false;
        private bool photoTaken5 = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btndescargar_Click(object sender, EventArgs e)
        {
            if (validateFields()) {
                SaveFileDialog savefile = new SaveFileDialog();

                string PaginaHTML_Texto = Resources.Plantilla.ToString();
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Nombre", txtnombres.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Edad", txtEdad.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Genero", combosex.SelectedItem.ToString());
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Diagnostico", txtDiagnostico.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Fecha", DateTime.Now.ToString("dd/MM/yyyy"));


                savefile.FileName = string.Format("{0}-{1}.pdf", txtnombres.Text.Replace(" ", "") ,DateTime.Now.ToString("dd-MM-yyyy"));


                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();

                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Resources.olivos, System.Drawing.Imaging.ImageFormat.Png);
                        img.ScaleToFit(120, 120);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;

                        img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                        pdfDoc.Add(img);

                        iTextSharp.text.Image imgCamera1 = iTextSharp.text.Image.GetInstance(picBox1.Image, System.Drawing.Imaging.ImageFormat.Png);
                        imgCamera1.ScaleToFit(240, 240);
                        imgCamera1.Alignment = iTextSharp.text.Image.UNDERLYING;

                        imgCamera1.SetAbsolutePosition(pdfDoc.LeftMargin + 170, pdfDoc.Bottom + 262);
                        pdfDoc.Add(imgCamera1);


                        iTextSharp.text.Image imgCamera2 = iTextSharp.text.Image.GetInstance(picBox2.Image, System.Drawing.Imaging.ImageFormat.Png);
                        imgCamera2.ScaleToFit(250, 250);
                        imgCamera2.Alignment = iTextSharp.text.Image.UNDERLYING;

                        imgCamera2.SetAbsolutePosition(pdfDoc.LeftMargin + 170, pdfDoc.Bottom + 8);
                        pdfDoc.Add(imgCamera2);

                        pdfDoc.NewPage();

                        iTextSharp.text.Image img2 = iTextSharp.text.Image.GetInstance(Resources.olivos, System.Drawing.Imaging.ImageFormat.Png);
                        img2.ScaleToFit(120, 120);
                        img2.Alignment = iTextSharp.text.Image.UNDERLYING;

                        img2.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                        pdfDoc.Add(img2);

                        iTextSharp.text.Image imgCamera4 = iTextSharp.text.Image.GetInstance(picBox4.Image, System.Drawing.Imaging.ImageFormat.Png);
                        imgCamera4.ScaleToFit(240, 240);
                        imgCamera4.Alignment = iTextSharp.text.Image.ALIGN_LEFT;

                        imgCamera4.SetAbsolutePosition(pdfDoc.LeftMargin + 170, pdfDoc.Bottom + 8);
                        pdfDoc.Add(imgCamera4);

                        iTextSharp.text.Image imgCamera5 = iTextSharp.text.Image.GetInstance(picBox5.Image, System.Drawing.Imaging.ImageFormat.Png);
                        imgCamera5.ScaleToFit(250, 250);
                        imgCamera5.Alignment = iTextSharp.text.Image.ALIGN_RIGHT;

                        imgCamera5.SetAbsolutePosition(pdfDoc.LeftMargin + 170, pdfDoc.Bottom + 8);
                        pdfDoc.Add(imgCamera5);

                        using (StringReader sr = new StringReader(PaginaHTML_Texto))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                        }

                        pdfDoc.Close();
                        stream.Close();
                        btnDeleteAll_Click(sender, e);
                    }
                    
                }
            } else
            {
                MessageBox.Show("Llene Todos los Campos y Capture las dos Imagenes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool validateFields()
        {
            return ( photoTaken1 && photoTaken2 && photoTaken3 && photoTaken4 && photoTaken5
                && txtDiagnostico.Text.Length > 0
                && txtEdad.Text.Length > 0
                && txtnombres.Text.Length > 0 ? true : false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDevices();
            combosex.SelectedIndex = 0;
        }

        public void LoadDevices()
        {
            MyDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (MyDevices.Count > 0)
            {
                ExistDevices = true;
                for (int i = 0; i < MyDevices.Count; i++) { 
                        cboDevices.Items.Add(MyDevices[i].Name.ToString());
                        cboDevices2.Items.Add(MyDevices[i].Name.ToString());
                        cboDevices3.Items.Add(MyDevices[i].Name.ToString());
                        cboDevices4.Items.Add(MyDevices[i].Name.ToString());
                        cboDevices5.Items.Add(MyDevices[i].Name.ToString());
                }
                cboDevices.Text = MyDevices[0].Name.ToString();
                cboDevices2.Text = MyDevices[0].Name.ToString();
                cboDevices3.Text = MyDevices[0].Name.ToString();
                cboDevices4.Text = MyDevices[0].Name.ToString();
                cboDevices5.Text = MyDevices[0].Name.ToString();
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

        private void CloseWebCam2()
        {
            if (MyWebCam2 != null && MyWebCam2.IsRunning)
            {
                MyWebCam2.SignalToStop();
                MyWebCam2 = null;
            }
        }

        private void CloseWebCam3()
        {
            if (MyWebCam3 != null && MyWebCam3.IsRunning)
            {
                MyWebCam3.SignalToStop();
                MyWebCam3 = null;
            }
        }

        private void CloseWebCam4()
        {
            if (MyWebCam4 != null && MyWebCam4.IsRunning)
            {
                MyWebCam4.SignalToStop();
                MyWebCam4 = null;
            }
        }

        private void CloseWebCam5()
        {
            if (MyWebCam5 != null && MyWebCam5.IsRunning)
            {
                MyWebCam5.SignalToStop();
                MyWebCam5 = null;
            }
        }

        private void resetFields()
        {
            txtnombres.ResetText();
            txtEdad.ResetText();
            txtDiagnostico.ResetText();
            combosex.SelectedIndex=0;
        }

        private new void Capture(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap image = new Bitmap((Bitmap)eventArgs.Frame.Clone(), new Size(picBox1.Width,picBox1.Height));
            picBox1.Image = image;
        }

        private void Capture2(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap image = new Bitmap((Bitmap)eventArgs.Frame.Clone(), new Size(picBox2.Width, picBox2.Height));
            picBox2.Image = image;
        }

        private void Capture3(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap image = new Bitmap((Bitmap)eventArgs.Frame.Clone(), new Size(picBox3.Width, picBox3.Height));
            picBox3.Image = image;
        }

        private void Capture4(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap image = new Bitmap((Bitmap)eventArgs.Frame.Clone(), new Size(picBox4.Width, picBox4.Height));
            picBox4.Image = image;
        }

        private void Capture5(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap image = new Bitmap((Bitmap)eventArgs.Frame.Clone(), new Size(picBox5.Width, picBox5.Height));
            picBox5.Image = image;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseWebCam();
            CloseWebCam2();
            CloseWebCam3();
            CloseWebCam4();
            CloseWebCam5();
        }

        private void startCamera1(object sender, EventArgs e)
        {
            if (ExistDevices)
            {
                CloseWebCam();
                photoTaken1 = false;
                int i = cboDevices.SelectedIndex;
                string deviceName = MyDevices[i].MonikerString;
                MyWebCam = new VideoCaptureDevice(deviceName);
                MyWebCam.NewFrame += new NewFrameEventHandler(Capture);
                MyWebCam.Start();
                btnTakePhoto.Visible = true;
            }
        }
        private void startCamera2(object sender, EventArgs e)
        {
            if (ExistDevices)
            {
                CloseWebCam2();
                photoTaken2 = false;
                int i = cboDevices2.SelectedIndex;
                string deviceName = MyDevices[i].MonikerString;
                MyWebCam2 = new VideoCaptureDevice(deviceName);
                MyWebCam2.NewFrame += new NewFrameEventHandler(Capture2);
                MyWebCam2.Start();
                btnTakePhoto2.Visible = true;
            }
        }

        private void startCamera3(object sender, EventArgs e)
        {
            if (ExistDevices)
            {
                CloseWebCam3();
                photoTaken3 = false;
                int i = cboDevices3.SelectedIndex;
                string deviceName = MyDevices[i].MonikerString;
                MyWebCam3 = new VideoCaptureDevice(deviceName);
                MyWebCam3.NewFrame += new NewFrameEventHandler(Capture3);
                MyWebCam3.Start();
                btnTakePhoto3.Visible = true;
            }
        }

        private void startCamera4(object sender, EventArgs e)
        {
            if (ExistDevices)
            {
                CloseWebCam4();
                photoTaken4 = false;
                int i = cboDevices4.SelectedIndex;
                string deviceName = MyDevices[i].MonikerString;
                MyWebCam4 = new VideoCaptureDevice(deviceName);
                MyWebCam4.NewFrame += new NewFrameEventHandler(Capture4);
                MyWebCam4.Start();
                btnTakePhoto4.Visible = true;
            }
        }

        private void startCamera5(object sender, EventArgs e)
        {
            if (ExistDevices)
            {
                CloseWebCam5();
                photoTaken5 = false;
                int i = cboDevices5.SelectedIndex;
                string deviceName = MyDevices[i].MonikerString;
                MyWebCam5 = new VideoCaptureDevice(deviceName);
                MyWebCam5.NewFrame += new NewFrameEventHandler(Capture5);
                MyWebCam5.Start();
                btnTakePhoto5.Visible = true;
            }
        }

        private void btnTakePhoto_Click(object sender, EventArgs e)
        {
            if (MyWebCam != null && MyWebCam.IsRunning)
            {
                photoTaken1 = true;
                CloseWebCam();
                btnTakePhoto.Visible = false;
                btnCaptureAgain.Visible = true;
            }
        }

        private void btnTakePhoto2_Click(object sender, EventArgs e)
        {
            if (MyWebCam2 != null && MyWebCam2.IsRunning)
            {
                photoTaken2 = true;
                CloseWebCam2();
                btnCaptureAgain2.Visible = true;
                btnTakePhoto2.Visible = false;
            }
        }

        private void btnTakePhoto3_Click(object sender, EventArgs e)
        {
            if (MyWebCam3 != null && MyWebCam3.IsRunning)
            {
                photoTaken3 = true;
                CloseWebCam3();
                btnCaptureAgain3.Visible = true;
                btnTakePhoto3.Visible = false;
            }
        }

        private void btnTakePhoto4_Click(object sender, EventArgs e)
        {
            if (MyWebCam4 != null && MyWebCam4.IsRunning)
            {
                photoTaken4 = true;
                CloseWebCam4();
                btnCaptureAgain4.Visible = true;
                btnTakePhoto4.Visible = false;
            }
        }

        private void btnTakePhoto5_Click(object sender, EventArgs e)
        {
            if (MyWebCam5 != null && MyWebCam5.IsRunning)
            {
                photoTaken5 = true;
                CloseWebCam5();
                btnCaptureAgain5.Visible = true;
                btnTakePhoto5.Visible = false;
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            startCamera1(sender, e);
            startCamera2(sender, e);
            startCamera3(sender, e);
            startCamera4(sender, e);
            startCamera5(sender, e);

            resetFields();
            photoTaken1 = false;
            photoTaken2 = false;
            photoTaken3 = false;
            photoTaken4 = false;
            photoTaken5 = false;
        }
    }
}
