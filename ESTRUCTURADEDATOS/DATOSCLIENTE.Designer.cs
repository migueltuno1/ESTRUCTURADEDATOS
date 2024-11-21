namespace ESTRUCTURADEDATOS
{
    partial class DATOSCLIENTE
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
            this.label1 = new System.Windows.Forms.Label();
            this.JHON = new System.Windows.Forms.RadioButton();
            this.RODRIGO = new System.Windows.Forms.RadioButton();
            this.DIEGO = new System.Windows.Forms.RadioButton();
            this.JOSE = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(191, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(630, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOCTORES ACTIVOS";
            // 
            // JHON
            // 
            this.JHON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.JHON.AutoSize = true;
            this.JHON.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JHON.Location = new System.Drawing.Point(65, 145);
            this.JHON.Name = "JHON";
            this.JHON.Size = new System.Drawing.Size(1165, 77);
            this.JHON.TabIndex = 1;
            this.JHON.TabStop = true;
            this.JHON.Text = "JHON OSCAR (MEDICINA GENERAL)";
            this.JHON.UseVisualStyleBackColor = true;
            this.JHON.CheckedChanged += new System.EventHandler(this.JHON_CheckedChanged);
            // 
            // RODRIGO
            // 
            this.RODRIGO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.RODRIGO.AutoSize = true;
            this.RODRIGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RODRIGO.Location = new System.Drawing.Point(56, 324);
            this.RODRIGO.Name = "RODRIGO";
            this.RODRIGO.Size = new System.Drawing.Size(1112, 77);
            this.RODRIGO.TabIndex = 2;
            this.RODRIGO.TabStop = true;
            this.RODRIGO.Text = "RODRIGO JORDAN (NEUROLOGO)";
            this.RODRIGO.UseVisualStyleBackColor = true;
            this.RODRIGO.CheckedChanged += new System.EventHandler(this.RODRIGO_CheckedChanged);
            // 
            // DIEGO
            // 
            this.DIEGO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DIEGO.AutoSize = true;
            this.DIEGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIEGO.Location = new System.Drawing.Point(56, 506);
            this.DIEGO.Name = "DIEGO";
            this.DIEGO.Size = new System.Drawing.Size(1185, 77);
            this.DIEGO.TabIndex = 3;
            this.DIEGO.TabStop = true;
            this.DIEGO.Text = "DIEGO ARTEAGA (TRAUMATOLOGO)";
            this.DIEGO.UseVisualStyleBackColor = true;
            this.DIEGO.CheckedChanged += new System.EventHandler(this.DIEGO_CheckedChanged);
            // 
            // JOSE
            // 
            this.JOSE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.JOSE.AutoSize = true;
            this.JOSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JOSE.Location = new System.Drawing.Point(56, 702);
            this.JOSE.Name = "JOSE";
            this.JOSE.Size = new System.Drawing.Size(977, 77);
            this.JOSE.TabIndex = 4;
            this.JOSE.TabStop = true;
            this.JOSE.Text = "JOSE DUMAY ( CARDIOLOGO)";
            this.JOSE.UseVisualStyleBackColor = true;
            this.JOSE.CheckedChanged += new System.EventHandler(this.JOSE_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(56, 874);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(891, 102);
            this.button1.TabIndex = 5;
            this.button1.Text = "PROGRAMAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DATOSCLIENTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1000, 1000);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.JOSE);
            this.Controls.Add(this.DIEGO);
            this.Controls.Add(this.RODRIGO);
            this.Controls.Add(this.JHON);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DATOSCLIENTE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DATOSCLIENTE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton JHON;
        private System.Windows.Forms.RadioButton RODRIGO;
        private System.Windows.Forms.RadioButton DIEGO;
        private System.Windows.Forms.RadioButton JOSE;
        private System.Windows.Forms.Button button1;
    }
}