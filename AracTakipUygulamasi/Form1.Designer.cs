namespace AracTakipUygulamasi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pbAvatar = new PictureBox();
            lstAraclar = new ListBox();
            cmsSil = new ContextMenuStrip(components);
            silToolStripMenuItem = new ToolStripMenuItem();
            txtMarka = new TextBox();
            txtMotorHacmi = new TextBox();
            label5 = new Label();
            txtModel = new TextBox();
            txtModelYili = new TextBox();
            txtSaseNo = new TextBox();
            btnKaydet = new Button();
            btnGuncelle = new Button();
            txtAra = new TextBox();
            dosyaAc = new OpenFileDialog();
            cmbYakıt = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            cmbVites = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pbAvatar).BeginInit();
            cmsSil.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(264, 22);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Marka:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(262, 60);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 0;
            label2.Text = "Model:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(251, 136);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 0;
            label3.Text = "Şase No:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(217, 174);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 0;
            label4.Text = "Motor Hacmi:";
            // 
            // pbAvatar
            // 
            pbAvatar.BorderStyle = BorderStyle.FixedSingle;
            pbAvatar.Location = new Point(45, 19);
            pbAvatar.Name = "pbAvatar";
            pbAvatar.Size = new Size(150, 121);
            pbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAvatar.TabIndex = 1;
            pbAvatar.TabStop = false;
            pbAvatar.Click += pbAvatar_Click;
            // 
            // lstAraclar
            // 
            lstAraclar.ContextMenuStrip = cmsSil;
            lstAraclar.FormattingEnabled = true;
            lstAraclar.ItemHeight = 20;
            lstAraclar.Location = new Point(44, 181);
            lstAraclar.Name = "lstAraclar";
            lstAraclar.Size = new Size(150, 304);
            lstAraclar.TabIndex = 2;
            lstAraclar.SelectedIndexChanged += lstAraclar_SelectedIndexChanged;
            // 
            // cmsSil
            // 
            cmsSil.ImageScalingSize = new Size(20, 20);
            cmsSil.Items.AddRange(new ToolStripItem[] { silToolStripMenuItem });
            cmsSil.Name = "cmsSil";
            cmsSil.Size = new Size(95, 28);
            // 
            // silToolStripMenuItem
            // 
            silToolStripMenuItem.Name = "silToolStripMenuItem";
            silToolStripMenuItem.Size = new Size(94, 24);
            silToolStripMenuItem.Text = "Sil";
            silToolStripMenuItem.Click += silToolStripMenuItem_Click;
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(323, 19);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(151, 27);
            txtMarka.TabIndex = 0;
            // 
            // txtMotorHacmi
            // 
            txtMotorHacmi.Location = new Point(323, 171);
            txtMotorHacmi.Name = "txtMotorHacmi";
            txtMotorHacmi.Size = new Size(151, 27);
            txtMotorHacmi.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(238, 98);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 7;
            label5.Text = "Model Yılı:";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(323, 57);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(151, 27);
            txtModel.TabIndex = 1;
            // 
            // txtModelYili
            // 
            txtModelYili.Location = new Point(323, 95);
            txtModelYili.Name = "txtModelYili";
            txtModelYili.Size = new Size(151, 27);
            txtModelYili.TabIndex = 2;
            // 
            // txtSaseNo
            // 
            txtSaseNo.Location = new Point(323, 133);
            txtSaseNo.Name = "txtSaseNo";
            txtSaseNo.Size = new Size(151, 27);
            txtSaseNo.TabIndex = 3;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(212, 431);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(132, 56);
            btnKaydet.TabIndex = 7;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(351, 431);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(132, 56);
            btnGuncelle.TabIndex = 8;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // txtAra
            // 
            txtAra.Location = new Point(45, 148);
            txtAra.Name = "txtAra";
            txtAra.PlaceholderText = "Ara...";
            txtAra.Size = new Size(149, 27);
            txtAra.TabIndex = 10;
            txtAra.KeyUp += txtAra_KeyUp;
            // 
            // dosyaAc
            // 
            dosyaAc.FileName = "openFileDialog1";
            // 
            // cmbYakıt
            // 
            cmbYakıt.FormattingEnabled = true;
            cmbYakıt.Items.AddRange(new object[] { "Benzin", "Dizel", "Elektrik", "LPG" });
            cmbYakıt.Location = new Point(323, 209);
            cmbYakıt.Name = "cmbYakıt";
            cmbYakıt.Size = new Size(151, 28);
            cmbYakıt.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(245, 212);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 12;
            label6.Text = "Yakıt Tipi:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(244, 250);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 13;
            label7.Text = "Vites Tipi:";
            // 
            // cmbVites
            // 
            cmbVites.FormattingEnabled = true;
            cmbVites.Items.AddRange(new object[] { "Manuel", "Otomatik", "Yarı Otomatik" });
            cmbVites.Location = new Point(323, 247);
            cmbVites.Name = "cmbVites";
            cmbVites.Size = new Size(151, 28);
            cmbVites.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 512);
            Controls.Add(cmbVites);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cmbYakıt);
            Controls.Add(txtAra);
            Controls.Add(btnGuncelle);
            Controls.Add(btnKaydet);
            Controls.Add(label5);
            Controls.Add(txtMotorHacmi);
            Controls.Add(txtSaseNo);
            Controls.Add(txtModelYili);
            Controls.Add(txtModel);
            Controls.Add(txtMarka);
            Controls.Add(lstAraclar);
            Controls.Add(pbAvatar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Click += Form1_Click;
            ((System.ComponentModel.ISupportInitialize)pbAvatar).EndInit();
            cmsSil.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pbAvatar;
        private ListBox lstAraclar;
        private TextBox txtMarka;
        private TextBox txtMotorHacmi;
        private Label label5;
        private TextBox txtModel;
        private TextBox txtModelYili;
        private TextBox txtSaseNo;
        private Button btnKaydet;
        private Button btnGuncelle;
        private TextBox txtAra;
        private OpenFileDialog dosyaAc;
        private ContextMenuStrip cmsSil;
        private ToolStripMenuItem silToolStripMenuItem;
        private ComboBox cmbYakıt;
        private Label label6;
        private Label label7;
        private ComboBox cmbVites;
    }
}