namespace Patterns
{
    partial class AbstractFactoryForm
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
            this.btnTerroristTeam = new System.Windows.Forms.Button();
            this.btnCounterTerroristTeam = new System.Windows.Forms.Button();
            this.btnBuyRiffle = new System.Windows.Forms.Button();
            this.btnBuyPistol = new System.Windows.Forms.Button();
            this.btnBuyKnife = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnFire = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTerroristTeam
            // 
            this.btnTerroristTeam.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTerroristTeam.Location = new System.Drawing.Point(131, 47);
            this.btnTerroristTeam.Name = "btnTerroristTeam";
            this.btnTerroristTeam.Size = new System.Drawing.Size(200, 80);
            this.btnTerroristTeam.TabIndex = 4;
            this.btnTerroristTeam.Text = "За терорристов";
            this.btnTerroristTeam.UseVisualStyleBackColor = false;
            this.btnTerroristTeam.Click += new System.EventHandler(this.BtnTerroristTeam_Click);
            // 
            // btnCounterTerroristTeam
            // 
            this.btnCounterTerroristTeam.Location = new System.Drawing.Point(337, 47);
            this.btnCounterTerroristTeam.Name = "btnCounterTerroristTeam";
            this.btnCounterTerroristTeam.Size = new System.Drawing.Size(200, 80);
            this.btnCounterTerroristTeam.TabIndex = 5;
            this.btnCounterTerroristTeam.Text = "За спецназ";
            this.btnCounterTerroristTeam.UseVisualStyleBackColor = true;
            this.btnCounterTerroristTeam.Click += new System.EventHandler(this.BtnCounterTerroristTeam_Click);
            // 
            // btnBuyRiffle
            // 
            this.btnBuyRiffle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuyRiffle.Location = new System.Drawing.Point(35, 116);
            this.btnBuyRiffle.Name = "btnBuyRiffle";
            this.btnBuyRiffle.Size = new System.Drawing.Size(178, 80);
            this.btnBuyRiffle.TabIndex = 6;
            this.btnBuyRiffle.Text = "Автомат";
            this.btnBuyRiffle.UseVisualStyleBackColor = false;
            this.btnBuyRiffle.Click += new System.EventHandler(this.BtnBuyRiffle_Click);
            // 
            // btnBuyPistol
            // 
            this.btnBuyPistol.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuyPistol.Location = new System.Drawing.Point(219, 116);
            this.btnBuyPistol.Name = "btnBuyPistol";
            this.btnBuyPistol.Size = new System.Drawing.Size(178, 80);
            this.btnBuyPistol.TabIndex = 7;
            this.btnBuyPistol.Text = "Пистолет";
            this.btnBuyPistol.UseVisualStyleBackColor = false;
            this.btnBuyPistol.Click += new System.EventHandler(this.BtnBuyPistol_Click);
            // 
            // btnBuyKnife
            // 
            this.btnBuyKnife.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuyKnife.Location = new System.Drawing.Point(403, 116);
            this.btnBuyKnife.Name = "btnBuyKnife";
            this.btnBuyKnife.Size = new System.Drawing.Size(180, 80);
            this.btnBuyKnife.TabIndex = 8;
            this.btnBuyKnife.Text = "Нож";
            this.btnBuyKnife.UseVisualStyleBackColor = false;
            this.btnBuyKnife.Click += new System.EventHandler(this.BtnBuyKnife_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBuyRiffle);
            this.panel1.Controls.Add(this.btnBuyKnife);
            this.panel1.Controls.Add(this.btnBuyPistol);
            this.panel1.Location = new System.Drawing.Point(31, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 293);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(187, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Магазин выбранной команды";
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(347, 510);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(120, 120);
            this.btnReload.TabIndex = 24;
            this.btnReload.Text = "Перезарядка";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnFire
            // 
            this.btnFire.Location = new System.Drawing.Point(211, 510);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(120, 120);
            this.btnFire.TabIndex = 22;
            this.btnFire.Text = "Огонь!";
            this.btnFire.UseVisualStyleBackColor = true;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // AbstractFactoryForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(702, 673);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCounterTerroristTeam);
            this.Controls.Add(this.btnTerroristTeam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "AbstractFactoryForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AbstractFactoryForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTerroristTeam;
        private System.Windows.Forms.Button btnCounterTerroristTeam;
        private System.Windows.Forms.Button btnBuyRiffle;
        private System.Windows.Forms.Button btnBuyPistol;
        private System.Windows.Forms.Button btnBuyKnife;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnFire;
    }
}