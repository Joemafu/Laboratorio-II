
namespace Ejercicio06_EnClase04
{
    partial class frmPrincipal
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
            this.grpIngresar = new System.Windows.Forms.GroupBox();
            this.txtIngresar = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.grpOrdenar = new System.Windows.Forms.GroupBox();
            this.rBtnDescendente = new System.Windows.Forms.RadioButton();
            this.rBtnAscendente = new System.Windows.Forms.RadioButton();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.grpListar = new System.Windows.Forms.GroupBox();
            this.lstListar = new System.Windows.Forms.ListBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.grpIngresar.SuspendLayout();
            this.grpOrdenar.SuspendLayout();
            this.grpListar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpIngresar
            // 
            this.grpIngresar.Controls.Add(this.txtIngresar);
            this.grpIngresar.Controls.Add(this.btnIngresar);
            this.grpIngresar.Location = new System.Drawing.Point(25, 12);
            this.grpIngresar.Name = "grpIngresar";
            this.grpIngresar.Size = new System.Drawing.Size(272, 94);
            this.grpIngresar.TabIndex = 0;
            this.grpIngresar.TabStop = false;
            this.grpIngresar.Text = "Ingrese un nuevo número";
            // 
            // txtIngresar
            // 
            this.txtIngresar.Location = new System.Drawing.Point(6, 41);
            this.txtIngresar.Name = "txtIngresar";
            this.txtIngresar.Size = new System.Drawing.Size(168, 23);
            this.txtIngresar.TabIndex = 0;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(180, 40);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Agregar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // grpOrdenar
            // 
            this.grpOrdenar.Controls.Add(this.rBtnDescendente);
            this.grpOrdenar.Controls.Add(this.rBtnAscendente);
            this.grpOrdenar.Controls.Add(this.btnOrdenar);
            this.grpOrdenar.Location = new System.Drawing.Point(25, 112);
            this.grpOrdenar.Name = "grpOrdenar";
            this.grpOrdenar.Size = new System.Drawing.Size(268, 111);
            this.grpOrdenar.TabIndex = 0;
            this.grpOrdenar.TabStop = false;
            this.grpOrdenar.Text = "Orden";
            // 
            // rBtnDescendente
            // 
            this.rBtnDescendente.AutoSize = true;
            this.rBtnDescendente.Location = new System.Drawing.Point(33, 67);
            this.rBtnDescendente.Name = "rBtnDescendente";
            this.rBtnDescendente.Size = new System.Drawing.Size(93, 19);
            this.rBtnDescendente.TabIndex = 6;
            this.rBtnDescendente.TabStop = true;
            this.rBtnDescendente.Text = "Descendente";
            this.rBtnDescendente.UseVisualStyleBackColor = true;
            // 
            // rBtnAscendente
            // 
            this.rBtnAscendente.AutoSize = true;
            this.rBtnAscendente.Location = new System.Drawing.Point(33, 32);
            this.rBtnAscendente.Name = "rBtnAscendente";
            this.rBtnAscendente.Size = new System.Drawing.Size(87, 19);
            this.rBtnAscendente.TabIndex = 5;
            this.rBtnAscendente.TabStop = true;
            this.rBtnAscendente.Text = "Ascendente";
            this.rBtnAscendente.UseVisualStyleBackColor = true;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(180, 46);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 3;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // grpListar
            // 
            this.grpListar.Controls.Add(this.lstListar);
            this.grpListar.Location = new System.Drawing.Point(303, 12);
            this.grpListar.Name = "grpListar";
            this.grpListar.Size = new System.Drawing.Size(268, 278);
            this.grpListar.TabIndex = 0;
            this.grpListar.TabStop = false;
            this.grpListar.Text = "Lista de números";
            // 
            // lstListar
            // 
            this.lstListar.FormattingEnabled = true;
            this.lstListar.ItemHeight = 15;
            this.lstListar.Location = new System.Drawing.Point(6, 19);
            this.lstListar.Name = "lstListar";
            this.lstListar.Size = new System.Drawing.Size(256, 244);
            this.lstListar.TabIndex = 1;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(25, 238);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(268, 52);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 300);
            this.Controls.Add(this.grpOrdenar);
            this.Controls.Add(this.grpListar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.grpIngresar);
            this.Name = "frmPrincipal";
            this.Text = "Ordenamiento";
            this.grpIngresar.ResumeLayout(false);
            this.grpIngresar.PerformLayout();
            this.grpOrdenar.ResumeLayout(false);
            this.grpOrdenar.PerformLayout();
            this.grpListar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpIngresar;
        private System.Windows.Forms.TextBox txtIngresar;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.GroupBox grpOrdenar;
        private System.Windows.Forms.RadioButton rBtnDescendente;
        private System.Windows.Forms.RadioButton rBtnAscendente;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.GroupBox grpListar;
        private System.Windows.Forms.ListBox lstListar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

