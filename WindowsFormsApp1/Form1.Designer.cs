namespace WindowsFormsApp1
{
    partial class frmExemplo1
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
            this.cmdRun = new System.Windows.Forms.Button();
            this.nome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdRun
            // 
            this.cmdRun.Location = new System.Drawing.Point(317, 97);
            this.cmdRun.Name = "cmdRun";
            this.cmdRun.Size = new System.Drawing.Size(102, 20);
            this.cmdRun.TabIndex = 0;
            this.cmdRun.Text = "&Rolar Dado";
            this.cmdRun.UseVisualStyleBackColor = true;
            this.cmdRun.Click += new System.EventHandler(this.cmdRun_Click);
            this.cmdRun.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cmdRun_MouseMove);
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(245, 178);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(33, 13);
            this.nome.TabIndex = 1;
            this.nome.Text = "Dado";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(129, 97);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(148, 20);
            this.txtNome.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(61, 22);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // frmExemplo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.cmdRun);
            this.Name = "frmExemplo1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmExemplo1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdRun;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

