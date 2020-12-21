
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.userControl11 = new WindowsFormsControlLibrary1.UserControlCheckedListBox();
            this.userControlTreeView = new WindowsFormsControlLibrary1.UserControlTreeView();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.CheckedIndex = ((System.Collections.Generic.List<int>)(resources.GetObject("userControl11.CheckedIndex")));
            this.userControl11.Location = new System.Drawing.Point(12, 12);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(177, 96);
            this.userControl11.TabIndex = 0;
            // 
            // userControlTreeView
            // 
            this.userControlTreeView.Location = new System.Drawing.Point(268, 12);
            this.userControlTreeView.Name = "userControlTreeView";
            this.userControlTreeView.Size = new System.Drawing.Size(408, 290);
            this.userControlTreeView.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControlTreeView);
            this.Controls.Add(this.userControl11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private WindowsFormsControlLibrary1.UserControlCheckedListBox userControl11;
        private WindowsFormsControlLibrary1.UserControlTreeView userControlTreeView;
    }
}

