namespace WorkTaskList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // Uygulama açýlýrken görevler dosyadan yüklenir
            _taskService.Load();
            // Görev listesi ekrana basýlýr
            RefreshList();
        }

        private void RefreshList()
        {
            // ListBox içeriði temizlenir
            lstTasks.Items.Clear();

            // Tüm görevler alýnarak listeye eklenir
            foreach (var task in _taskService.GetAll())
            {

                // Görev durumuna göre metin hazýrlanýr
                string status = task.IsCompleted ? "TAMAMLANDI - " : "BEKLENÝYOR - ";

                // Durum ve görev baþlýðý birlikte listeye eklenir
                lstTasks.Items.Add($"{status}{task.Title}");
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // TextBox içeriðiyle yeni görev eklenir
            _taskService.Add(txtTask.Text);
            // Giriþ alaný temizlenir
            txtTask.Clear();
            // Liste güncellenir
            RefreshList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Listede seçim yoksa iþlem yapýlmaz
            if (lstTasks.SelectedIndex < 0) return;

            // Seçili görev alýnýr
            var task = _taskService.GetAll()[lstTasks.SelectedIndex];

            // Görev silinir
            _taskService.Delete(task.Id);

            // Liste güncellenir
            RefreshList();
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            // Listede seçim yoksa iþlem yapýlmaz
            if (lstTasks.SelectedIndex < 0) return;

            // Seçili görev alýnýr
            var task = _taskService.GetAll()[lstTasks.SelectedIndex];

            // Görev durumu deðiþtirilir
            _taskService.Toggle(task.Id);

            // Liste güncellenir
            RefreshList();
        }

        private void lstTasks_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Geçersiz indeks kontrolü
            if (e.Index < 0) return;

            // Ýlgili görev alýnýr
            var task = _taskService.GetAll()[e.Index];

            // Görev durumuna göre yazý rengi belirlenir
            Color textColor = task.IsCompleted ? Color.Green : Color.Red;

            // Arka plan çizilir
            e.DrawBackground();

            // Metin seçilen renkle çizilir
            using (Brush brush = new SolidBrush(textColor))
            {
                e.Graphics.DrawString(
                    lstTasks.Items[e.Index].ToString(),
                    e.Font,
                    brush,
                    e.Bounds
                );
            }

            // Seçili öðe için focus çerçevesi çizilir
            e.DrawFocusRectangle();
        }

    }
}
