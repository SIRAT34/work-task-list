using WorkTaskList.Services;
using WorkTaskList.Models;


namespace WorkTaskList
{
    partial class Form1
    {
        private TaskService _taskService = new();
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
            txtTask = new TextBox();
            btnAdd = new Button();
            lstTasks = new ListBox();
            btnDelete = new Button();
            btnToggle = new Button();
            SuspendLayout();
            // 
            // txtTask
            // 
            txtTask.BackColor = SystemColors.Menu;
            txtTask.Location = new Point(54, 12);
            txtTask.Name = "txtTask";
            txtTask.PlaceholderText = "Yeni Görev Gir...";
            txtTask.Size = new Size(701, 23);
            txtTask.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MediumSeaGreen;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Location = new Point(680, 45);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 34);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lstTasks
            // 
            lstTasks.BackColor = SystemColors.Menu;
            lstTasks.DrawMode = DrawMode.OwnerDrawFixed;
            lstTasks.FormattingEnabled = true;
            lstTasks.ItemHeight = 15;
            lstTasks.Location = new Point(12, 175);
            lstTasks.Name = "lstTasks";
            lstTasks.Size = new Size(776, 259);
            lstTasks.TabIndex = 2;
            lstTasks.DrawItem += lstTasks_DrawItem;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Firebrick;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Location = new Point(680, 85);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 34);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnToggle
            // 
            btnToggle.BackColor = Color.SlateBlue;
            btnToggle.Cursor = Cursors.Hand;
            btnToggle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnToggle.ForeColor = SystemColors.Control;
            btnToggle.Location = new Point(670, 125);
            btnToggle.Name = "btnToggle";
            btnToggle.Size = new Size(95, 35);
            btnToggle.TabIndex = 4;
            btnToggle.Text = "Tamamlandı";
            btnToggle.UseVisualStyleBackColor = false;
            btnToggle.Click += btnToggle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(189, 189, 189);
            ClientSize = new Size(800, 450);
            Controls.Add(btnToggle);
            Controls.Add(btnDelete);
            Controls.Add(lstTasks);
            Controls.Add(btnAdd);
            Controls.Add(txtTask);
            Name = "Form1";
            Text = "WorkTaskList";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTask;
        private Button btnAdd;
        private ListBox lstTasks;
        private Button btnDelete;
        private Button btnToggle;
    }
}
