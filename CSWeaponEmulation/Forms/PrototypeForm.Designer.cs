namespace Patterns
{
    partial class PrototypeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreateMirage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateMirage
            // 
            this.btnCreateMirage.Location = new System.Drawing.Point(291, 276);
            this.btnCreateMirage.Name = "btnCreateMirage";
            this.btnCreateMirage.Size = new System.Drawing.Size(120, 120);
            this.btnCreateMirage.TabIndex = 6;
            this.btnCreateMirage.Text = "Создать Mirage";
            this.btnCreateMirage.UseVisualStyleBackColor = true;
            this.btnCreateMirage.Click += new System.EventHandler(this.BtnCreateMirage_Click);
            // 
            // PrototypeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(702, 673);
            this.Controls.Add(this.btnCreateMirage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "PrototypeForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PrototypeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateMirage;
    }
}