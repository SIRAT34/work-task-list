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
            _taskService.Load();
            RefreshList();
        }

        private void RefreshList()
        {
            lstTasks.Items.Clear();

            foreach (var task in _taskService.GetAll())
            {
                string status = task.IsCompleted ? "[TAMAMLANMIÞ] " : "[] ";
                lstTasks.Items.Add($"{status}{task.Title}");
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _taskService.Add(txtTask.Text);
            txtTask.Clear();
            RefreshList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex < 0) return;

            var task = _taskService.GetAll()[lstTasks.SelectedIndex];
            _taskService.Delete(task.Id);
            RefreshList();
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex < 0) return;

            var task = _taskService.GetAll()[lstTasks.SelectedIndex];
            _taskService.Toggle(task.Id);
            RefreshList();
        }
    }
}
