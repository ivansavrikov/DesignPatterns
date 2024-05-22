namespace Patterns
{
    partial class MainNavigationForm
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
            this.btnNavToMapCreator = new System.Windows.Forms.Button();
            this.btnNavToAbstractFactory = new System.Windows.Forms.Button();
            this.btnNavToAdapter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNavToMapCreator
            // 
            this.btnNavToMapCreator.Location = new System.Drawing.Point(239, 362);
            this.btnNavToMapCreator.Name = "btnNavToMapCreator";
            this.btnNavToMapCreator.Size = new System.Drawing.Size(220, 60);
            this.btnNavToMapCreator.TabIndex = 13;
            this.btnNavToMapCreator.Text = "Прототип";
            this.btnNavToMapCreator.UseVisualStyleBackColor = true;
            this.btnNavToMapCreator.Click += new System.EventHandler(this.BtnNavToMapCreator_Click);
            // 
            // btnNavToAbstractFactory
            // 
            this.btnNavToAbstractFactory.Location = new System.Drawing.Point(239, 296);
            this.btnNavToAbstractFactory.Name = "btnNavToAbstractFactory";
            this.btnNavToAbstractFactory.Size = new System.Drawing.Size(220, 60);
            this.btnNavToAbstractFactory.TabIndex = 7;
            this.btnNavToAbstractFactory.Text = "Абстрактная фабрика";
            this.btnNavToAbstractFactory.UseVisualStyleBackColor = true;
            this.btnNavToAbstractFactory.Click += new System.EventHandler(this.BtnNavToAbstractFactory_Click);
            // 
            // btnNavToAdapter
            // 
            this.btnNavToAdapter.Location = new System.Drawing.Point(239, 230);
            this.btnNavToAdapter.Name = "btnNavToAdapter";
            this.btnNavToAdapter.Size = new System.Drawing.Size(220, 60);
            this.btnNavToAdapter.TabIndex = 15;
            this.btnNavToAdapter.Text = "Фабричный метод и адаптер";
            this.btnNavToAdapter.UseVisualStyleBackColor = true;
            this.btnNavToAdapter.Click += new System.EventHandler(this.btnNavToAdapter_Click);
            // 
            // NavToPatternsMainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(702, 673);
            this.Controls.Add(this.btnNavToAdapter);
            this.Controls.Add(this.btnNavToAbstractFactory);
            this.Controls.Add(this.btnNavToMapCreator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "NavToPatternsMainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Навигация к паттернам";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNavToMapCreator;
        private System.Windows.Forms.Button btnNavToAbstractFactory;
        private System.Windows.Forms.Button btnNavToAdapter;
    }
}

