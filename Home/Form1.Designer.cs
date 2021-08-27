
namespace Home
{
    partial class Form1
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblFechaN = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblNIT = new System.Windows.Forms.Label();
            this.lblNumid = new System.Windows.Forms.Label();
            this.lblContra = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNumID = new System.Windows.Forms.TextBox();
            this.grpEstrato = new System.Windows.Forms.GroupBox();
            this.rbE1 = new System.Windows.Forms.RadioButton();
            this.rbE2 = new System.Windows.Forms.RadioButton();
            this.rbE3 = new System.Windows.Forms.RadioButton();
            this.rbE4 = new System.Windows.Forms.RadioButton();
            this.rbE5 = new System.Windows.Forms.RadioButton();
            this.dtpFechaN = new System.Windows.Forms.DateTimePicker();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.cmbID = new System.Windows.Forms.ComboBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.rtbGuardado = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.grpEstrato.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHeader.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblHeader.Location = new System.Drawing.Point(13, 9);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(387, 24);
            this.lblHeader.TabIndex = 6;
            this.lblHeader.Text = "Ingrese su información de registro:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(14, 57);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(94, 18);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre(s):";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(168, 57);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(81, 18);
            this.lblApellidos.TabIndex = 8;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(319, 57);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 18);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "E-mail";
            // 
            // lblFechaN
            // 
            this.lblFechaN.AutoSize = true;
            this.lblFechaN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaN.Location = new System.Drawing.Point(14, 140);
            this.lblFechaN.Name = "lblFechaN";
            this.lblFechaN.Size = new System.Drawing.Size(172, 18);
            this.lblFechaN.TabIndex = 10;
            this.lblFechaN.Text = "Fecha de Nacimiento:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(239, 140);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(69, 18);
            this.lblGenero.TabIndex = 11;
            this.lblGenero.Text = "Género:";
            // 
            // lblNIT
            // 
            this.lblNIT.AutoSize = true;
            this.lblNIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIT.Location = new System.Drawing.Point(387, 140);
            this.lblNIT.Name = "lblNIT";
            this.lblNIT.Size = new System.Drawing.Size(34, 18);
            this.lblNIT.TabIndex = 12;
            this.lblNIT.Text = "NIT";
            // 
            // lblNumid
            // 
            this.lblNumid.AutoSize = true;
            this.lblNumid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumid.Location = new System.Drawing.Point(543, 130);
            this.lblNumid.Name = "lblNumid";
            this.lblNumid.Size = new System.Drawing.Size(73, 18);
            this.lblNumid.TabIndex = 13;
            this.lblNumid.Text = "Número:";
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContra.Location = new System.Drawing.Point(188, 233);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(100, 18);
            this.lblContra.TabIndex = 14;
            this.lblContra.Text = "Contraseña:";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(17, 88);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(129, 21);
            this.txtNombres.TabIndex = 15;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(171, 88);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(137, 21);
            this.txtApellidos.TabIndex = 16;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(322, 88);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(324, 21);
            this.txtEmail.TabIndex = 17;
            // 
            // txtNumID
            // 
            this.txtNumID.Location = new System.Drawing.Point(546, 170);
            this.txtNumID.Name = "txtNumID";
            this.txtNumID.Size = new System.Drawing.Size(131, 21);
            this.txtNumID.TabIndex = 18;
            // 
            // grpEstrato
            // 
            this.grpEstrato.Controls.Add(this.rbE5);
            this.grpEstrato.Controls.Add(this.rbE4);
            this.grpEstrato.Controls.Add(this.rbE3);
            this.grpEstrato.Controls.Add(this.rbE2);
            this.grpEstrato.Controls.Add(this.rbE1);
            this.grpEstrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEstrato.Location = new System.Drawing.Point(12, 233);
            this.grpEstrato.Name = "grpEstrato";
            this.grpEstrato.Size = new System.Drawing.Size(125, 160);
            this.grpEstrato.TabIndex = 19;
            this.grpEstrato.TabStop = false;
            this.grpEstrato.Text = "Estrato:";
            // 
            // rbE1
            // 
            this.rbE1.AutoSize = true;
            this.rbE1.Location = new System.Drawing.Point(7, 21);
            this.rbE1.Name = "rbE1";
            this.rbE1.Size = new System.Drawing.Size(82, 19);
            this.rbE1.TabIndex = 0;
            this.rbE1.TabStop = true;
            this.rbE1.Text = "Estrato 1";
            this.rbE1.UseVisualStyleBackColor = true;
            // 
            // rbE2
            // 
            this.rbE2.AutoSize = true;
            this.rbE2.Location = new System.Drawing.Point(7, 47);
            this.rbE2.Name = "rbE2";
            this.rbE2.Size = new System.Drawing.Size(82, 19);
            this.rbE2.TabIndex = 1;
            this.rbE2.TabStop = true;
            this.rbE2.Text = "Estrato 2";
            this.rbE2.UseVisualStyleBackColor = true;
            // 
            // rbE3
            // 
            this.rbE3.AutoSize = true;
            this.rbE3.Location = new System.Drawing.Point(7, 72);
            this.rbE3.Name = "rbE3";
            this.rbE3.Size = new System.Drawing.Size(82, 19);
            this.rbE3.TabIndex = 2;
            this.rbE3.TabStop = true;
            this.rbE3.Text = "Estrato 3";
            this.rbE3.UseVisualStyleBackColor = true;
            // 
            // rbE4
            // 
            this.rbE4.AutoSize = true;
            this.rbE4.Location = new System.Drawing.Point(7, 98);
            this.rbE4.Name = "rbE4";
            this.rbE4.Size = new System.Drawing.Size(82, 19);
            this.rbE4.TabIndex = 3;
            this.rbE4.TabStop = true;
            this.rbE4.Text = "Estrato 4";
            this.rbE4.UseVisualStyleBackColor = true;
            // 
            // rbE5
            // 
            this.rbE5.AutoSize = true;
            this.rbE5.Location = new System.Drawing.Point(7, 124);
            this.rbE5.Name = "rbE5";
            this.rbE5.Size = new System.Drawing.Size(82, 19);
            this.rbE5.TabIndex = 4;
            this.rbE5.TabStop = true;
            this.rbE5.Text = "Estrato 5";
            this.rbE5.UseVisualStyleBackColor = true;
            // 
            // dtpFechaN
            // 
            this.dtpFechaN.Location = new System.Drawing.Point(17, 172);
            this.dtpFechaN.Name = "dtpFechaN";
            this.dtpFechaN.Size = new System.Drawing.Size(200, 21);
            this.dtpFechaN.TabIndex = 20;
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Hombre",
            "Mujer",
            "Prefiero no decirlo"});
            this.cmbGenero.Location = new System.Drawing.Point(242, 170);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(121, 23);
            this.cmbGenero.TabIndex = 21;
            this.cmbGenero.Text = "Género";
            // 
            // cmbID
            // 
            this.cmbID.FormattingEnabled = true;
            this.cmbID.Items.AddRange(new object[] {
            "C.C",
            "T.I"});
            this.cmbID.Location = new System.Drawing.Point(390, 172);
            this.cmbID.Name = "cmbID";
            this.cmbID.Size = new System.Drawing.Size(121, 23);
            this.cmbID.TabIndex = 22;
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(191, 267);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(305, 21);
            this.txtContra.TabIndex = 23;
            // 
            // rtbGuardado
            // 
            this.rtbGuardado.Location = new System.Drawing.Point(191, 305);
            this.rtbGuardado.Name = "rtbGuardado";
            this.rtbGuardado.Size = new System.Drawing.Size(455, 187);
            this.rtbGuardado.TabIndex = 24;
            this.rtbGuardado.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(314, 520);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(468, 520);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 26;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 599);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtbGuardado);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.cmbID);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.dtpFechaN);
            this.Controls.Add(this.grpEstrato);
            this.Controls.Add(this.txtNumID);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.lblNumid);
            this.Controls.Add(this.lblNIT);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblFechaN);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpEstrato.ResumeLayout(false);
            this.grpEstrato.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblFechaN;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblNIT;
        private System.Windows.Forms.Label lblNumid;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNumID;
        private System.Windows.Forms.GroupBox grpEstrato;
        private System.Windows.Forms.RadioButton rbE5;
        private System.Windows.Forms.RadioButton rbE4;
        private System.Windows.Forms.RadioButton rbE3;
        private System.Windows.Forms.RadioButton rbE2;
        private System.Windows.Forms.RadioButton rbE1;
        private System.Windows.Forms.DateTimePicker dtpFechaN;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.ComboBox cmbID;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.RichTextBox rtbGuardado;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReport;
    }
}

