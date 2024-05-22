namespace Patterns.Forms
{
    partial class FactoryMethodAndAdapter
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
            this.btnFire = new System.Windows.Forms.Button();
            this.btnScope = new System.Windows.Forms.Button();
            this.btnGetAwp = new System.Windows.Forms.Button();
            this.btnGetLegacyAug = new System.Windows.Forms.Button();
            this.btnGetAK47 = new System.Windows.Forms.Button();
            this.btnGetTerroristKnife = new System.Windows.Forms.Button();
            this.btnTempGetLegacyAug = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnGetDeagle = new System.Windows.Forms.Button();
            this.btnGetUSPS = new System.Windows.Forms.Button();
            this.btnGetKarambit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFire
            // 
            this.btnFire.Location = new System.Drawing.Point(145, 434);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(120, 120);
            this.btnFire.TabIndex = 14;
            this.btnFire.Text = "Огонь!";
            this.btnFire.UseVisualStyleBackColor = true;
            this.btnFire.Click += new System.EventHandler(this.BtnFire_Click);
            // 
            // btnScope
            // 
            this.btnScope.Location = new System.Drawing.Point(428, 434);
            this.btnScope.Name = "btnScope";
            this.btnScope.Size = new System.Drawing.Size(120, 120);
            this.btnScope.TabIndex = 15;
            this.btnScope.Text = "Войти в прицел";
            this.btnScope.UseVisualStyleBackColor = true;
            this.btnScope.Click += new System.EventHandler(this.BtnScope_Click);
            // 
            // btnGetAwp
            // 
            this.btnGetAwp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGetAwp.Location = new System.Drawing.Point(467, 66);
            this.btnGetAwp.Name = "btnGetAwp";
            this.btnGetAwp.Size = new System.Drawing.Size(178, 80);
            this.btnGetAwp.TabIndex = 16;
            this.btnGetAwp.Text = "AWP";
            this.btnGetAwp.UseVisualStyleBackColor = false;
            this.btnGetAwp.Click += new System.EventHandler(this.BtnGetAwp_Click);
            // 
            // btnGetLegacyAug
            // 
            this.btnGetLegacyAug.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGetLegacyAug.Location = new System.Drawing.Point(73, 66);
            this.btnGetLegacyAug.Name = "btnGetLegacyAug";
            this.btnGetLegacyAug.Size = new System.Drawing.Size(178, 80);
            this.btnGetLegacyAug.TabIndex = 17;
            this.btnGetLegacyAug.Text = "Aug (Legacy adapter)";
            this.btnGetLegacyAug.UseVisualStyleBackColor = false;
            this.btnGetLegacyAug.Click += new System.EventHandler(this.BtnGetLegacyAug_Click);
            // 
            // btnGetAK47
            // 
            this.btnGetAK47.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGetAK47.Location = new System.Drawing.Point(73, 165);
            this.btnGetAK47.Name = "btnGetAK47";
            this.btnGetAK47.Size = new System.Drawing.Size(178, 80);
            this.btnGetAK47.TabIndex = 18;
            this.btnGetAK47.Text = "AK-47";
            this.btnGetAK47.UseVisualStyleBackColor = false;
            this.btnGetAK47.Click += new System.EventHandler(this.btnGetAK47_Click);
            // 
            // btnGetTerroristKnife
            // 
            this.btnGetTerroristKnife.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGetTerroristKnife.Location = new System.Drawing.Point(73, 267);
            this.btnGetTerroristKnife.Name = "btnGetTerroristKnife";
            this.btnGetTerroristKnife.Size = new System.Drawing.Size(178, 80);
            this.btnGetTerroristKnife.TabIndex = 19;
            this.btnGetTerroristKnife.Text = "Terr Knife";
            this.btnGetTerroristKnife.UseVisualStyleBackColor = false;
            this.btnGetTerroristKnife.Click += new System.EventHandler(this.btnGetTerroristKnife_Click);
            // 
            // btnTempGetLegacyAug
            // 
            this.btnTempGetLegacyAug.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTempGetLegacyAug.Location = new System.Drawing.Point(272, 66);
            this.btnTempGetLegacyAug.Name = "btnTempGetLegacyAug";
            this.btnTempGetLegacyAug.Size = new System.Drawing.Size(178, 80);
            this.btnTempGetLegacyAug.TabIndex = 20;
            this.btnTempGetLegacyAug.Text = "Legacy Aug \r\n(читать комментарий!!)";
            this.btnTempGetLegacyAug.UseVisualStyleBackColor = false;
            this.btnTempGetLegacyAug.Click += new System.EventHandler(this.TempForExample_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(286, 434);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(120, 120);
            this.btnReload.TabIndex = 21;
            this.btnReload.Text = "Перезарядка";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.BtnReload_Click);
            // 
            // btnGetDeagle
            // 
            this.btnGetDeagle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGetDeagle.Location = new System.Drawing.Point(272, 165);
            this.btnGetDeagle.Name = "btnGetDeagle";
            this.btnGetDeagle.Size = new System.Drawing.Size(178, 80);
            this.btnGetDeagle.TabIndex = 22;
            this.btnGetDeagle.Text = "Deagle";
            this.btnGetDeagle.UseVisualStyleBackColor = false;
            this.btnGetDeagle.Click += new System.EventHandler(this.BtnGetDeagle_Click);
            // 
            // btnGetUSPS
            // 
            this.btnGetUSPS.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGetUSPS.Location = new System.Drawing.Point(467, 165);
            this.btnGetUSPS.Name = "btnGetUSPS";
            this.btnGetUSPS.Size = new System.Drawing.Size(178, 80);
            this.btnGetUSPS.TabIndex = 23;
            this.btnGetUSPS.Text = "USP-S";
            this.btnGetUSPS.UseVisualStyleBackColor = false;
            this.btnGetUSPS.Click += new System.EventHandler(this.BtnGetUSPS_Click);
            // 
            // btnGetKarambit
            // 
            this.btnGetKarambit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGetKarambit.Location = new System.Drawing.Point(272, 267);
            this.btnGetKarambit.Name = "btnGetKarambit";
            this.btnGetKarambit.Size = new System.Drawing.Size(178, 80);
            this.btnGetKarambit.TabIndex = 24;
            this.btnGetKarambit.Text = "Karambit";
            this.btnGetKarambit.UseVisualStyleBackColor = false;
            this.btnGetKarambit.Click += new System.EventHandler(this.BtnGetKarambit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(282, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Магазин оружия";
            // 
            // AdapterForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(702, 673);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetKarambit);
            this.Controls.Add(this.btnGetUSPS);
            this.Controls.Add(this.btnGetDeagle);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnTempGetLegacyAug);
            this.Controls.Add(this.btnGetTerroristKnife);
            this.Controls.Add(this.btnGetAK47);
            this.Controls.Add(this.btnGetLegacyAug);
            this.Controls.Add(this.btnGetAwp);
            this.Controls.Add(this.btnScope);
            this.Controls.Add(this.btnFire);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "AdapterForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Фабричный метод + адаптер + интерфейс + upcast ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Button btnScope;
        private System.Windows.Forms.Button btnGetAwp;
        private System.Windows.Forms.Button btnGetLegacyAug;
        private System.Windows.Forms.Button btnGetAK47;
        private System.Windows.Forms.Button btnGetTerroristKnife;
        private System.Windows.Forms.Button btnTempGetLegacyAug;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnGetDeagle;
        private System.Windows.Forms.Button btnGetUSPS;
        private System.Windows.Forms.Button btnGetKarambit;
        private System.Windows.Forms.Label label1;
    }
}