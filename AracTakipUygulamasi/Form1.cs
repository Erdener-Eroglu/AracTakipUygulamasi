using Newtonsoft.Json;

namespace AracTakipUygulamasi;

public partial class Form1 : Form
{
    private List<Arac> _araclar = new List<Arac>();
    private Arac? _seciliArac;
    private MemoryStream _memoryStream = new MemoryStream();
    private int _bufferSize = 64;
    private byte[] _photoBytes = new byte[64];
    public Form1()
    {
        InitializeComponent();
        DosyaIceriAktar();
        btnGuncelle.Enabled = false;
        Form1_Click(this, new EventArgs());
    }
    private void btnKaydet_Click(object sender, EventArgs e)
    {

        try
        {
            Arac yeniArac = new Arac()
            {
                Marka = txtMarka.Text,
                Model = txtModel.Text,
                ModelYili = txtModelYili.Text,
                SaseNo = txtSaseNo.Text,
                MotorHacmi = txtMotorHacmi.Text,
                VitesTipi = cmbVites.SelectedItem.ToString(),
                YakitTipi = cmbYakýt.SelectedItem.ToString()
            };
            if (_memoryStream.Length > 0)
                yeniArac.Fotograf = _memoryStream.ToArray();
            _memoryStream = new MemoryStream();
            _araclar.Insert(0, yeniArac);
            lstAraclar.DataSource = null;
            lstAraclar.DataSource = _araclar;
            DosyaKaydet();
            FormuTemizle(this.Controls);
        }
        catch
        {
            MessageBox.Show("Marka ve model boþ geçilemez.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }

    public void FormuTemizle(Control.ControlCollection collection)
    {
        foreach (Control item in collection)
        {
            if (item is TextBox)
            {
                item.Text = string.Empty;
            }
            else if (item is RadioButton rBtn)
            {
                rBtn.Checked = false;
            }
            else if (item is ListBox lstBox)
            {
                lstBox.SelectedIndex = -1;
            }
            if (item is PictureBox pbBox)
            {
                pbBox.Image = null;
            }
            if (item is ComboBox cmbBox)
            {
                cmbBox.SelectedIndex = -1;
            }
        }
    }

    private void lstAraclar_SelectedIndexChanged(object sender, EventArgs e)
    {

        if (lstAraclar.SelectedItem == null)
        {
            _seciliArac = null;
            btnGuncelle.Enabled = false;
            btnKaydet.Enabled = true;
            return;
        }
        btnGuncelle.Enabled = true;
        btnKaydet.Enabled = false;
        _seciliArac = lstAraclar.SelectedItem as Arac;

        txtMarka.Text = _seciliArac.Marka;
        txtModel.Text = _seciliArac.Model;
        txtModelYili.Text = _seciliArac.ModelYili;
        txtMotorHacmi.Text = _seciliArac.MotorHacmi;
        txtSaseNo.Text = _seciliArac.SaseNo;
        cmbVites.SelectedItem = _seciliArac.VitesTipi;
        cmbYakýt.SelectedItem = _seciliArac.YakitTipi;
        pbAvatar.Image = _seciliArac.Fotograf != null ? Image.FromStream(new MemoryStream(_seciliArac.Fotograf)) : null;

    }

    private void pbAvatar_Click(object sender, EventArgs e)
    {
        dosyaAc.Title = "Bir fotoðraf dosyasý seçiniz";
        dosyaAc.Filter = "JPG Dosyalarý(*.jpg)|*.jpg|PNG Dosyalarý(*.png)|(*.png)";
        dosyaAc.FileName = string.Empty;
        dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        if (dosyaAc.ShowDialog() == DialogResult.OK)
        {
            _memoryStream = new MemoryStream();
            //FileStream fileStream = new FileStream(dosyaAc.FileName, FileMode.Open);
            FileStream fileStream = File.Open(dosyaAc.FileName, FileMode.Open);
            while (fileStream.Read(_photoBytes, 0, _bufferSize) != 0)
            {
                _memoryStream.Write(_photoBytes, 0, _bufferSize);
            }
            fileStream.Close();
            fileStream.Dispose();
            //pbAvatar.Image = Image.FromStream(_memoryStream);
            pbAvatar.Image = new Bitmap(_memoryStream);
        }
    }
    private void btnGuncelle_Click(object sender, EventArgs e)
    {
        _seciliArac.Marka = txtMarka.Text;
        _seciliArac.Model = txtModel.Text;
        _seciliArac.ModelYili = txtModelYili.Text;
        _seciliArac.SaseNo = txtSaseNo.Text;
        _seciliArac.MotorHacmi = txtMotorHacmi.Text;
        _seciliArac.YakitTipi = cmbYakýt.SelectedItem.ToString();
        _seciliArac.VitesTipi = cmbVites.SelectedItem.ToString();
        if (_memoryStream.Length > 0)
        {
            _seciliArac.Fotograf = _memoryStream.ToArray();

        }
        _seciliArac = null;
        lstAraclar.DataSource = null;
        lstAraclar.DataSource = _araclar;
        FormuTemizle(this.Controls);
        DosyaKaydet();
        lstAraclar.SelectedIndex = -1;
    }

    private void Form1_Click(object sender, EventArgs e)
    {
        lstAraclar.SelectedIndex = -1;
        FormuTemizle(this.Controls);
    }

    private void silToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (lstAraclar.SelectedItem == null) return;
        _seciliArac = lstAraclar.SelectedItem as Arac;
        DialogResult result = MessageBox.Show($"{_seciliArac.Marka}-{_seciliArac.Model} aracýný silmek istiyor musunuz)",
            "Silme Onayý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            _araclar.Remove(_seciliArac);
            lstAraclar.DataSource = null;
            lstAraclar.DataSource = _araclar;
            FormuTemizle(this.Controls);
            DosyaKaydet();
        }

    }

    private void txtAra_KeyUp(object sender, KeyEventArgs e)
    {
        string arama = txtAra.Text.ToLower();
        List<Arac> sonuc = new List<Arac>();
        sonuc = _araclar
            .Where(item => item.Marka.ToLower().Contains(arama) || item.Model.ToLower().Contains(arama)).ToList();
        lstAraclar.DataSource = null;
        lstAraclar.DataSource = sonuc;
    }
    private void DosyaKaydet()
    {
        string dosyaYolu = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Araclar.json";
        FileStream file = File.Open(dosyaYolu, FileMode.Create);
        StreamWriter writer = new StreamWriter(file);
        writer.Write(JsonConvert.SerializeObject(_araclar));
        writer.Close();
        writer.Dispose();
    }

    private void DosyaIceriAktar()
    {
        string dosyaYolu = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Araclar.json";
        FileStream dosya = File.Open(dosyaYolu, FileMode.OpenOrCreate);
        StreamReader reader = new StreamReader(dosya);
        string dosyaIcerigi = reader.ReadToEnd();
        if (dosyaIcerigi.Length <= 0)
        {
            reader.Close();
            reader.Dispose();
            return;
        }
        _araclar = JsonConvert.DeserializeObject<List<Arac>>(dosyaIcerigi);
        reader.Close();
        reader.Dispose();
        lstAraclar.DataSource = null;
        lstAraclar.DataSource = _araclar;
    }

}