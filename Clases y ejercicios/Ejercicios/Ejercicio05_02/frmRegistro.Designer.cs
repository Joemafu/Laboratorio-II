
namespace Ejercicio05_02
{
    partial class frmRegistro
    {
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
            this.grpDetalles = new System.Windows.Forms.GroupBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.nbrEdad = new System.Windows.Forms.NumericUpDown();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.grpGenero = new System.Windows.Forms.GroupBox();
            this.rBtnNoBinario = new System.Windows.Forms.RadioButton();
            this.rBtnFemenino = new System.Windows.Forms.RadioButton();
            this.rBtnMasculino = new System.Windows.Forms.RadioButton();
            this.grpCursos = new System.Windows.Forms.GroupBox();
            this.chkJS = new System.Windows.Forms.CheckBox();
            this.chkCPP = new System.Windows.Forms.CheckBox();
            this.chkCS = new System.Windows.Forms.CheckBox();
            this.lstPais = new System.Windows.Forms.ListBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblPais = new System.Windows.Forms.Label();
            this.grpDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbrEdad)).BeginInit();
            this.grpGenero.SuspendLayout();
            this.grpCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDetalles
            // 
            this.grpDetalles.Controls.Add(this.lblEdad);
            this.grpDetalles.Controls.Add(this.lblDireccion);
            this.grpDetalles.Controls.Add(this.lblNombre);
            this.grpDetalles.Controls.Add(this.nbrEdad);
            this.grpDetalles.Controls.Add(this.txtDireccion);
            this.grpDetalles.Controls.Add(this.txtNombre);
            this.grpDetalles.Location = new System.Drawing.Point(12, 18);
            this.grpDetalles.Name = "grpDetalles";
            this.grpDetalles.Size = new System.Drawing.Size(181, 153);
            this.grpDetalles.TabIndex = 0;
            this.grpDetalles.TabStop = false;
            this.grpDetalles.Text = "Detalles del usuario";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(6, 102);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(33, 15);
            this.lblEdad.TabIndex = 5;
            this.lblEdad.Text = "Edad";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(6, 74);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 15);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 43);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // nbrEdad
            // 
            this.nbrEdad.Location = new System.Drawing.Point(69, 100);
            this.nbrEdad.Name = "nbrEdad";
            this.nbrEdad.Size = new System.Drawing.Size(100, 23);
            this.nbrEdad.TabIndex = 2;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(69, 71);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 23);
            this.txtDireccion.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(69, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 0;
            // 
            // grpGenero
            // 
            this.grpGenero.Controls.Add(this.rBtnNoBinario);
            this.grpGenero.Controls.Add(this.rBtnFemenino);
            this.grpGenero.Controls.Add(this.rBtnMasculino);
            this.grpGenero.Location = new System.Drawing.Point(199, 18);
            this.grpGenero.Name = "grpGenero";
            this.grpGenero.Size = new System.Drawing.Size(139, 106);
            this.grpGenero.TabIndex = 1;
            this.grpGenero.TabStop = false;
            this.grpGenero.Text = "Género";
            // 
            // rBtnNoBinario
            // 
            this.rBtnNoBinario.AutoSize = true;
            this.rBtnNoBinario.Location = new System.Drawing.Point(24, 74);
            this.rBtnNoBinario.Name = "rBtnNoBinario";
            this.rBtnNoBinario.Size = new System.Drawing.Size(81, 19);
            this.rBtnNoBinario.TabIndex = 2;
            this.rBtnNoBinario.TabStop = true;
            this.rBtnNoBinario.Text = "No binario";
            this.rBtnNoBinario.UseVisualStyleBackColor = true;
            // 
            // rBtnFemenino
            // 
            this.rBtnFemenino.AutoSize = true;
            this.rBtnFemenino.Location = new System.Drawing.Point(24, 49);
            this.rBtnFemenino.Name = "rBtnFemenino";
            this.rBtnFemenino.Size = new System.Drawing.Size(78, 19);
            this.rBtnFemenino.TabIndex = 1;
            this.rBtnFemenino.TabStop = true;
            this.rBtnFemenino.Text = "Femenino";
            this.rBtnFemenino.UseVisualStyleBackColor = true;
            // 
            // rBtnMasculino
            // 
            this.rBtnMasculino.AutoSize = true;
            this.rBtnMasculino.Location = new System.Drawing.Point(24, 23);
            this.rBtnMasculino.Name = "rBtnMasculino";
            this.rBtnMasculino.Size = new System.Drawing.Size(80, 19);
            this.rBtnMasculino.TabIndex = 0;
            this.rBtnMasculino.TabStop = true;
            this.rBtnMasculino.Text = "Masculino";
            this.rBtnMasculino.UseVisualStyleBackColor = true;
            // 
            // grpCursos
            // 
            this.grpCursos.Controls.Add(this.chkJS);
            this.grpCursos.Controls.Add(this.chkCPP);
            this.grpCursos.Controls.Add(this.chkCS);
            this.grpCursos.Location = new System.Drawing.Point(199, 130);
            this.grpCursos.Name = "grpCursos";
            this.grpCursos.Size = new System.Drawing.Size(139, 109);
            this.grpCursos.TabIndex = 2;
            this.grpCursos.TabStop = false;
            this.grpCursos.Text = "Cursos";
            // 
            // chkJS
            // 
            this.chkJS.AutoSize = true;
            this.chkJS.Location = new System.Drawing.Point(24, 72);
            this.chkJS.Name = "chkJS";
            this.chkJS.Size = new System.Drawing.Size(78, 19);
            this.chkJS.TabIndex = 2;
            this.chkJS.Text = "JavaScript";
            this.chkJS.UseVisualStyleBackColor = true;
            // 
            // chkCPP
            // 
            this.chkCPP.AutoSize = true;
            this.chkCPP.Location = new System.Drawing.Point(24, 47);
            this.chkCPP.Name = "chkCPP";
            this.chkCPP.Size = new System.Drawing.Size(50, 19);
            this.chkCPP.TabIndex = 1;
            this.chkCPP.Text = "C++";
            this.chkCPP.UseVisualStyleBackColor = true;
            // 
            // chkCS
            // 
            this.chkCS.AutoSize = true;
            this.chkCS.Location = new System.Drawing.Point(24, 22);
            this.chkCS.Name = "chkCS";
            this.chkCS.Size = new System.Drawing.Size(41, 19);
            this.chkCS.TabIndex = 0;
            this.chkCS.Text = "C#";
            this.chkCS.UseVisualStyleBackColor = true;
            // 
            // lstPais
            // 
            this.lstPais.FormattingEnabled = true;
            this.lstPais.ItemHeight = 15;
            this.lstPais.Location = new System.Drawing.Point(12, 195);
            this.lstPais.Name = "lstPais";
            this.lstPais.Size = new System.Drawing.Size(181, 109);
            this.lstPais.TabIndex = 3;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(223, 254);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(94, 35);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(12, 177);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(28, 15);
            this.lblPais.TabIndex = 5;
            this.lblPais.Text = "País";
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 315);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lstPais);
            this.Controls.Add(this.grpCursos);
            this.Controls.Add(this.grpGenero);
            this.Controls.Add(this.grpDetalles);
            this.Name = "frmRegistro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpDetalles.ResumeLayout(false);
            this.grpDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbrEdad)).EndInit();
            this.grpGenero.ResumeLayout(false);
            this.grpGenero.PerformLayout();
            this.grpCursos.ResumeLayout(false);
            this.grpCursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDetalles;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.NumericUpDown nbrEdad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox grpGenero;
        private System.Windows.Forms.RadioButton rBtnNoBinario;
        private System.Windows.Forms.RadioButton rBtnFemenino;
        private System.Windows.Forms.RadioButton rBtnMasculino;
        private System.Windows.Forms.GroupBox grpCursos;
        private System.Windows.Forms.CheckBox chkJS;
        private System.Windows.Forms.CheckBox chkCPP;
        private System.Windows.Forms.CheckBox chkCS;
        private System.Windows.Forms.ListBox lstPais;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblPais;
    }
}

