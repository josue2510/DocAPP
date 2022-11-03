namespace Proyecto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btndescargar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combosex = new System.Windows.Forms.ComboBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.cboDevices = new System.Windows.Forms.ComboBox();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.btnTakePhoto = new System.Windows.Forms.Button();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTakePhoto2 = new System.Windows.Forms.Button();
            this.cboDevices2 = new System.Windows.Forms.ComboBox();
            this.btnCaptureAgain = new System.Windows.Forms.Button();
            this.btnCaptureAgain2 = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnCaptureAgain3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTakePhoto3 = new System.Windows.Forms.Button();
            this.picBox3 = new System.Windows.Forms.PictureBox();
            this.cboDevices3 = new System.Windows.Forms.ComboBox();
            this.btnCaptureAgain5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTakePhoto5 = new System.Windows.Forms.Button();
            this.picBox5 = new System.Windows.Forms.PictureBox();
            this.cboDevices5 = new System.Windows.Forms.ComboBox();
            this.btnCaptureAgain4 = new System.Windows.Forms.Button();
            this.cboDevices4 = new System.Windows.Forms.ComboBox();
            this.btnTakePhoto4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.picBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btndescargar
            // 
            this.btndescargar.BackColor = System.Drawing.Color.LimeGreen;
            this.btndescargar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndescargar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndescargar.ForeColor = System.Drawing.Color.White;
            this.btndescargar.Location = new System.Drawing.Point(1864, 651);
            this.btndescargar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btndescargar.Name = "btndescargar";
            this.btndescargar.Size = new System.Drawing.Size(123, 36);
            this.btndescargar.TabIndex = 0;
            this.btndescargar.Text = "Guardar";
            this.btndescargar.UseVisualStyleBackColor = false;
            this.btndescargar.Click += new System.EventHandler(this.btndescargar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 87;
            this.label1.Text = "Nombre Completo";
            // 
            // txtnombres
            // 
            this.txtnombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombres.Location = new System.Drawing.Point(150, 29);
            this.txtnombres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.Size = new System.Drawing.Size(430, 22);
            this.txtnombres.TabIndex = 88;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combosex);
            this.groupBox1.Controls.Add(this.txtGenero);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtEdad);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtnombres);
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(607, 123);
            this.groupBox1.TabIndex = 89;
            this.groupBox1.TabStop = false;
            // 
            // combosex
            // 
            this.combosex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combosex.FormattingEnabled = true;
            this.combosex.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.combosex.Location = new System.Drawing.Point(375, 76);
            this.combosex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.combosex.Name = "combosex";
            this.combosex.Size = new System.Drawing.Size(205, 24);
            this.combosex.TabIndex = 97;
            // 
            // txtGenero
            // 
            this.txtGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenero.Location = new System.Drawing.Point(93, 119);
            this.txtGenero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(0, 22);
            this.txtGenero.TabIndex = 96;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 76);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 94;
            this.label7.Text = "Edad :";
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(77, 76);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(203, 22);
            this.txtEdad.TabIndex = 95;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(303, 76);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 91;
            this.label6.Text = "Género:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 89;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDiagnostico);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 191);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(607, 120);
            this.groupBox2.TabIndex = 91;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Diagnóstico";
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagnostico.Location = new System.Drawing.Point(15, 23);
            this.txtDiagnostico.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(565, 84);
            this.txtDiagnostico.TabIndex = 0;
            // 
            // cboDevices
            // 
            this.cboDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDevices.FormattingEnabled = true;
            this.cboDevices.Location = new System.Drawing.Point(112, 366);
            this.cboDevices.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboDevices.Name = "cboDevices";
            this.cboDevices.Size = new System.Drawing.Size(275, 24);
            this.cboDevices.TabIndex = 93;
            this.cboDevices.SelectedIndexChanged += new System.EventHandler(this.startCamera1);
            // 
            // picBox1
            // 
            this.picBox1.Location = new System.Drawing.Point(13, 403);
            this.picBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(608, 628);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox1.TabIndex = 94;
            this.picBox1.TabStop = false;
            // 
            // btnTakePhoto
            // 
            this.btnTakePhoto.BackgroundImage = global::OrthoAnalisis.Properties.Resources.camera;
            this.btnTakePhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTakePhoto.FlatAppearance.BorderSize = 0;
            this.btnTakePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakePhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakePhoto.Location = new System.Drawing.Point(414, 356);
            this.btnTakePhoto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTakePhoto.Name = "btnTakePhoto";
            this.btnTakePhoto.Size = new System.Drawing.Size(88, 41);
            this.btnTakePhoto.TabIndex = 97;
            this.btnTakePhoto.UseVisualStyleBackColor = true;
            this.btnTakePhoto.Click += new System.EventHandler(this.btnTakePhoto_Click);
            // 
            // picBox2
            // 
            this.picBox2.Location = new System.Drawing.Point(631, 59);
            this.picBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(583, 628);
            this.picBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox2.TabIndex = 98;
            this.picBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 366);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 97;
            this.label3.Text = "Cámara 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(643, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 99;
            this.label4.Text = "Cámara 2:";
            // 
            // btnTakePhoto2
            // 
            this.btnTakePhoto2.BackgroundImage = global::OrthoAnalisis.Properties.Resources.camera;
            this.btnTakePhoto2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTakePhoto2.FlatAppearance.BorderSize = 0;
            this.btnTakePhoto2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakePhoto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakePhoto2.Location = new System.Drawing.Point(1026, 12);
            this.btnTakePhoto2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTakePhoto2.Name = "btnTakePhoto2";
            this.btnTakePhoto2.Size = new System.Drawing.Size(88, 41);
            this.btnTakePhoto2.TabIndex = 100;
            this.btnTakePhoto2.UseVisualStyleBackColor = true;
            this.btnTakePhoto2.Click += new System.EventHandler(this.btnTakePhoto2_Click);
            // 
            // cboDevices2
            // 
            this.cboDevices2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDevices2.FormattingEnabled = true;
            this.cboDevices2.Location = new System.Drawing.Point(729, 22);
            this.cboDevices2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboDevices2.Name = "cboDevices2";
            this.cboDevices2.Size = new System.Drawing.Size(273, 24);
            this.cboDevices2.TabIndex = 101;
            this.cboDevices2.SelectedIndexChanged += new System.EventHandler(this.startCamera2);
            // 
            // btnCaptureAgain
            // 
            this.btnCaptureAgain.BackColor = System.Drawing.Color.Transparent;
            this.btnCaptureAgain.BackgroundImage = global::OrthoAnalisis.Properties.Resources.retry;
            this.btnCaptureAgain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCaptureAgain.FlatAppearance.BorderSize = 0;
            this.btnCaptureAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaptureAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaptureAgain.Location = new System.Drawing.Point(506, 361);
            this.btnCaptureAgain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCaptureAgain.Name = "btnCaptureAgain";
            this.btnCaptureAgain.Size = new System.Drawing.Size(80, 32);
            this.btnCaptureAgain.TabIndex = 102;
            this.btnCaptureAgain.UseVisualStyleBackColor = false;
            this.btnCaptureAgain.Visible = false;
            this.btnCaptureAgain.Click += new System.EventHandler(this.startCamera1);
            // 
            // btnCaptureAgain2
            // 
            this.btnCaptureAgain2.BackgroundImage = global::OrthoAnalisis.Properties.Resources.retry;
            this.btnCaptureAgain2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCaptureAgain2.FlatAppearance.BorderSize = 0;
            this.btnCaptureAgain2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaptureAgain2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaptureAgain2.Location = new System.Drawing.Point(1120, 17);
            this.btnCaptureAgain2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCaptureAgain2.Name = "btnCaptureAgain2";
            this.btnCaptureAgain2.Size = new System.Drawing.Size(80, 32);
            this.btnCaptureAgain2.TabIndex = 103;
            this.btnCaptureAgain2.UseVisualStyleBackColor = true;
            this.btnCaptureAgain2.Visible = false;
            this.btnCaptureAgain2.Click += new System.EventHandler(this.startCamera2);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.BackColor = System.Drawing.Color.Tomato;
            this.btnDeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteAll.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAll.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAll.Location = new System.Drawing.Point(1864, 737);
            this.btnDeleteAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(123, 36);
            this.btnDeleteAll.TabIndex = 104;
            this.btnDeleteAll.Text = "Borrar Todo";
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnCaptureAgain3
            // 
            this.btnCaptureAgain3.BackColor = System.Drawing.Color.Transparent;
            this.btnCaptureAgain3.BackgroundImage = global::OrthoAnalisis.Properties.Resources.retry;
            this.btnCaptureAgain3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCaptureAgain3.FlatAppearance.BorderSize = 0;
            this.btnCaptureAgain3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaptureAgain3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaptureAgain3.Location = new System.Drawing.Point(1728, 17);
            this.btnCaptureAgain3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCaptureAgain3.Name = "btnCaptureAgain3";
            this.btnCaptureAgain3.Size = new System.Drawing.Size(80, 32);
            this.btnCaptureAgain3.TabIndex = 113;
            this.btnCaptureAgain3.UseVisualStyleBackColor = false;
            this.btnCaptureAgain3.Visible = false;
            this.btnCaptureAgain3.Click += new System.EventHandler(this.startCamera3);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1248, 22);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 107;
            this.label8.Text = "Cámara 3:";
            // 
            // btnTakePhoto3
            // 
            this.btnTakePhoto3.BackgroundImage = global::OrthoAnalisis.Properties.Resources.camera;
            this.btnTakePhoto3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTakePhoto3.FlatAppearance.BorderSize = 0;
            this.btnTakePhoto3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakePhoto3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakePhoto3.Location = new System.Drawing.Point(1636, 12);
            this.btnTakePhoto3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTakePhoto3.Name = "btnTakePhoto3";
            this.btnTakePhoto3.Size = new System.Drawing.Size(88, 41);
            this.btnTakePhoto3.TabIndex = 108;
            this.btnTakePhoto3.UseVisualStyleBackColor = true;
            this.btnTakePhoto3.Click += new System.EventHandler(this.btnTakePhoto3_Click);
            // 
            // picBox3
            // 
            this.picBox3.Location = new System.Drawing.Point(1235, 59);
            this.picBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picBox3.Name = "picBox3";
            this.picBox3.Size = new System.Drawing.Size(608, 628);
            this.picBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox3.TabIndex = 106;
            this.picBox3.TabStop = false;
            // 
            // cboDevices3
            // 
            this.cboDevices3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDevices3.FormattingEnabled = true;
            this.cboDevices3.Location = new System.Drawing.Point(1334, 22);
            this.cboDevices3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboDevices3.Name = "cboDevices3";
            this.cboDevices3.Size = new System.Drawing.Size(275, 24);
            this.cboDevices3.TabIndex = 105;
            this.cboDevices3.SelectedIndexChanged += new System.EventHandler(this.startCamera3);
            // 
            // btnCaptureAgain5
            // 
            this.btnCaptureAgain5.BackColor = System.Drawing.Color.Transparent;
            this.btnCaptureAgain5.BackgroundImage = global::OrthoAnalisis.Properties.Resources.retry;
            this.btnCaptureAgain5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCaptureAgain5.FlatAppearance.BorderSize = 0;
            this.btnCaptureAgain5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaptureAgain5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaptureAgain5.Location = new System.Drawing.Point(1728, 695);
            this.btnCaptureAgain5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCaptureAgain5.Name = "btnCaptureAgain5";
            this.btnCaptureAgain5.Size = new System.Drawing.Size(80, 32);
            this.btnCaptureAgain5.TabIndex = 123;
            this.btnCaptureAgain5.UseVisualStyleBackColor = false;
            this.btnCaptureAgain5.Visible = false;
            this.btnCaptureAgain5.Click += new System.EventHandler(this.startCamera5);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1248, 700);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 121;
            this.label5.Text = "Cámara 5:";
            // 
            // btnTakePhoto5
            // 
            this.btnTakePhoto5.BackgroundImage = global::OrthoAnalisis.Properties.Resources.camera;
            this.btnTakePhoto5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTakePhoto5.FlatAppearance.BorderSize = 0;
            this.btnTakePhoto5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakePhoto5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakePhoto5.Location = new System.Drawing.Point(1636, 690);
            this.btnTakePhoto5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTakePhoto5.Name = "btnTakePhoto5";
            this.btnTakePhoto5.Size = new System.Drawing.Size(88, 41);
            this.btnTakePhoto5.TabIndex = 122;
            this.btnTakePhoto5.UseVisualStyleBackColor = true;
            this.btnTakePhoto5.Click += new System.EventHandler(this.btnTakePhoto5_Click);
            // 
            // picBox5
            // 
            this.picBox5.Location = new System.Drawing.Point(1235, 737);
            this.picBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picBox5.Name = "picBox5";
            this.picBox5.Size = new System.Drawing.Size(608, 628);
            this.picBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox5.TabIndex = 120;
            this.picBox5.TabStop = false;
            // 
            // cboDevices5
            // 
            this.cboDevices5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDevices5.FormattingEnabled = true;
            this.cboDevices5.Location = new System.Drawing.Point(1334, 700);
            this.cboDevices5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboDevices5.Name = "cboDevices5";
            this.cboDevices5.Size = new System.Drawing.Size(275, 24);
            this.cboDevices5.TabIndex = 119;
            this.cboDevices5.SelectedIndexChanged += new System.EventHandler(this.startCamera5);
            // 
            // btnCaptureAgain4
            // 
            this.btnCaptureAgain4.BackgroundImage = global::OrthoAnalisis.Properties.Resources.retry;
            this.btnCaptureAgain4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCaptureAgain4.FlatAppearance.BorderSize = 0;
            this.btnCaptureAgain4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaptureAgain4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaptureAgain4.Location = new System.Drawing.Point(1120, 695);
            this.btnCaptureAgain4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCaptureAgain4.Name = "btnCaptureAgain4";
            this.btnCaptureAgain4.Size = new System.Drawing.Size(80, 32);
            this.btnCaptureAgain4.TabIndex = 118;
            this.btnCaptureAgain4.UseVisualStyleBackColor = true;
            this.btnCaptureAgain4.Visible = false;
            this.btnCaptureAgain4.Click += new System.EventHandler(this.startCamera4);
            // 
            // cboDevices4
            // 
            this.cboDevices4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDevices4.FormattingEnabled = true;
            this.cboDevices4.Location = new System.Drawing.Point(729, 700);
            this.cboDevices4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboDevices4.Name = "cboDevices4";
            this.cboDevices4.Size = new System.Drawing.Size(273, 24);
            this.cboDevices4.TabIndex = 117;
            this.cboDevices4.SelectedIndexChanged += new System.EventHandler(this.startCamera4);
            // 
            // btnTakePhoto4
            // 
            this.btnTakePhoto4.BackgroundImage = global::OrthoAnalisis.Properties.Resources.camera;
            this.btnTakePhoto4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTakePhoto4.FlatAppearance.BorderSize = 0;
            this.btnTakePhoto4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakePhoto4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakePhoto4.Location = new System.Drawing.Point(1026, 690);
            this.btnTakePhoto4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTakePhoto4.Name = "btnTakePhoto4";
            this.btnTakePhoto4.Size = new System.Drawing.Size(88, 41);
            this.btnTakePhoto4.TabIndex = 116;
            this.btnTakePhoto4.UseVisualStyleBackColor = true;
            this.btnTakePhoto4.Click += new System.EventHandler(this.btnTakePhoto4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(643, 703);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 115;
            this.label9.Text = "Cámara 4:";
            // 
            // picBox4
            // 
            this.picBox4.Location = new System.Drawing.Point(631, 737);
            this.picBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picBox4.Name = "picBox4";
            this.picBox4.Size = new System.Drawing.Size(583, 628);
            this.picBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox4.TabIndex = 114;
            this.picBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2484, 1421);
            this.Controls.Add(this.btnCaptureAgain5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTakePhoto5);
            this.Controls.Add(this.picBox5);
            this.Controls.Add(this.cboDevices5);
            this.Controls.Add(this.btnCaptureAgain4);
            this.Controls.Add(this.cboDevices4);
            this.Controls.Add(this.btnTakePhoto4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.picBox4);
            this.Controls.Add(this.btnCaptureAgain3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnTakePhoto3);
            this.Controls.Add(this.picBox3);
            this.Controls.Add(this.cboDevices3);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnCaptureAgain2);
            this.Controls.Add(this.btnCaptureAgain);
            this.Controls.Add(this.cboDevices2);
            this.Controls.Add(this.btnTakePhoto2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picBox2);
            this.Controls.Add(this.btnTakePhoto);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.cboDevices);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btndescargar);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrthoAnalisis";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndescargar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombres;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboDevices;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.Button btnTakePhoto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.PictureBox picBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTakePhoto2;
        private System.Windows.Forms.ComboBox cboDevices2;
        private System.Windows.Forms.Button btnCaptureAgain;
        private System.Windows.Forms.Button btnCaptureAgain2;
        private System.Windows.Forms.ComboBox combosex;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnCaptureAgain3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTakePhoto3;
        private System.Windows.Forms.PictureBox picBox3;
        private System.Windows.Forms.ComboBox cboDevices3;
        private System.Windows.Forms.Button btnCaptureAgain5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTakePhoto5;
        private System.Windows.Forms.PictureBox picBox5;
        private System.Windows.Forms.ComboBox cboDevices5;
        private System.Windows.Forms.Button btnCaptureAgain4;
        private System.Windows.Forms.ComboBox cboDevices4;
        private System.Windows.Forms.Button btnTakePhoto4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox picBox4;
    }
}

