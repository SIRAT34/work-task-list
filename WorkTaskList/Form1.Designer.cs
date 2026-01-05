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
            txtTask.BackColor = SystemColors.Window;
            txtTask.Location = new Point(54, 12);
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(701, 23);
            txtTask.TabIndex = 0;
            txtTask.Text = "Yeni Görev Gir";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(680, 41);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lstTasks
            // 
            lstTasks.FormattingEnabled = true;
            lstTasks.ItemHeight = 15;
            lstTasks.Location = new Point(12, 175);
            lstTasks.Name = "lstTasks";
            lstTasks.Size = new Size(776, 259);
            lstTasks.TabIndex = 2;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(680, 70);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnToggle
            // 
            btnToggle.Location = new Point(670, 132);
            btnToggle.Name = "btnToggle";
            btnToggle.Size = new Size(95, 23);
            btnToggle.TabIndex = 4;
            btnToggle.Text = "Tamamlandı";
            btnToggle.UseVisualStyleBackColor = true;
            btnToggle.Click += btnToggle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
