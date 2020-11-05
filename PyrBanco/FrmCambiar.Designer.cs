namespace PyrBanco
{
    partial class FrmCambiar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCambiar));
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnCambiar = new System.Windows.Forms.Button();
            this.PtbInterfaz = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblContraseña = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtContraeñaAnterior = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtContra_Nueva = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCorfimar_Contra = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbInterfaz)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.TxtCorfimar_Contra);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.TxtContra_Nueva);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.TxtContraeñaAnterior);
            this.panel3.Controls.Add(this.LblContraseña);
            this.panel3.Controls.Add(this.LblUsuario);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.BtnCambiar);
            this.panel3.Controls.Add(this.PtbInterfaz);
            this.panel3.Location = new System.Drawing.Point(1, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(299, 487);
            this.panel3.TabIndex = 64;
            // 
            // BtnCambiar
            // 
            this.BtnCambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCambiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCambiar.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnCambiar.Location = new System.Drawing.Point(26, 412);
            this.BtnCambiar.Name = "BtnCambiar";
            this.BtnCambiar.Size = new System.Drawing.Size(244, 40);
            this.BtnCambiar.TabIndex = 17;
            this.BtnCambiar.Text = "&Cambiar Contraseña";
            this.BtnCambiar.UseVisualStyleBackColor = true;
            this.BtnCambiar.Click += new System.EventHandler(this.BtnCambiar_Click);
            // 
            // PtbInterfaz
            // 
            this.PtbInterfaz.Image = ((System.Drawing.Image)(resources.GetObject("PtbInterfaz.Image")));
            this.PtbInterfaz.Location = new System.Drawing.Point(26, 0);
            this.PtbInterfaz.Name = "PtbInterfaz";
            this.PtbInterfaz.Size = new System.Drawing.Size(244, 122);
            this.PtbInterfaz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbInterfaz.TabIndex = 8;
            this.PtbInterfaz.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(23, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Usuario:";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblUsuario.Location = new System.Drawing.Point(95, 136);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(66, 18);
            this.LblUsuario.TabIndex = 21;
            this.LblUsuario.Text = "Usuario:";
            // 
            // LblContraseña
            // 
            this.LblContraseña.AutoSize = true;
            this.LblContraseña.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContraseña.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblContraseña.Location = new System.Drawing.Point(23, 163);
            this.LblContraseña.Name = "LblContraseña";
            this.LblContraseña.Size = new System.Drawing.Size(89, 18);
            this.LblContraseña.TabIndex = 22;
            this.LblContraseña.Text = "Contraseña";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(26, 196);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 33);
            this.panel2.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(26, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Contraseña Anterior";
            // 
            // TxtContraeñaAnterior
            // 
            this.TxtContraeñaAnterior.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContraeñaAnterior.Location = new System.Drawing.Point(26, 229);
            this.TxtContraeñaAnterior.Name = "TxtContraeñaAnterior";
            this.TxtContraeñaAnterior.Size = new System.Drawing.Size(244, 26);
            this.TxtContraeñaAnterior.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(26, 261);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 33);
            this.panel1.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(26, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña Nueva";
            // 
            // TxtContra_Nueva
            // 
            this.TxtContra_Nueva.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContra_Nueva.Location = new System.Drawing.Point(26, 294);
            this.TxtContra_Nueva.Name = "TxtContra_Nueva";
            this.TxtContra_Nueva.Size = new System.Drawing.Size(244, 26);
            this.TxtContra_Nueva.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Navy;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(26, 326);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(244, 33);
            this.panel4.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(26, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Confirmar Contraseña";
            // 
            // TxtCorfimar_Contra
            // 
            this.TxtCorfimar_Contra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCorfimar_Contra.Location = new System.Drawing.Point(26, 359);
            this.TxtCorfimar_Contra.Name = "TxtCorfimar_Contra";
            this.TxtCorfimar_Contra.Size = new System.Drawing.Size(244, 26);
            this.TxtCorfimar_Contra.TabIndex = 3;
            // 
            // FrmCambiar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(299, 500);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCambiar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCambiar";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbInterfaz)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnCambiar;
        private System.Windows.Forms.PictureBox PtbInterfaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtCorfimar_Contra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtContra_Nueva;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtContraeñaAnterior;
        public System.Windows.Forms.Label LblContraseña;
        public System.Windows.Forms.Label LblUsuario;
    }
}