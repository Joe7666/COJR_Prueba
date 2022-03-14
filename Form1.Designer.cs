
namespace COJR_Prueba
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mtxtCodigo = new System.Windows.Forms.MaskedTextBox();
            this.mtxtMarca = new System.Windows.Forms.MaskedTextBox();
            this.mtxtModelo = new System.Windows.Forms.MaskedTextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCadena = new System.Windows.Forms.Button();
            this.btnImpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(76, 294);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(94, 43);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Modelo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(112, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Precio:";
            // 
            // mtxtCodigo
            // 
            this.mtxtCodigo.Location = new System.Drawing.Point(187, 62);
            this.mtxtCodigo.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLL";
            this.mtxtCodigo.Name = "mtxtCodigo";
            this.mtxtCodigo.Size = new System.Drawing.Size(142, 22);
            this.mtxtCodigo.TabIndex = 5;
            // 
            // mtxtMarca
            // 
            this.mtxtMarca.Location = new System.Drawing.Point(187, 120);
            this.mtxtMarca.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.mtxtMarca.Name = "mtxtMarca";
            this.mtxtMarca.Size = new System.Drawing.Size(142, 22);
            this.mtxtMarca.TabIndex = 6;
            this.mtxtMarca.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // mtxtModelo
            // 
            this.mtxtModelo.Location = new System.Drawing.Point(187, 171);
            this.mtxtModelo.Mask = "LLLLLLLLLLLLLLLLLLLLLLL";
            this.mtxtModelo.Name = "mtxtModelo";
            this.mtxtModelo.Size = new System.Drawing.Size(142, 22);
            this.mtxtModelo.TabIndex = 7;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(187, 227);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(142, 22);
            this.txtPrecio.TabIndex = 8;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(232, 294);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(88, 43);
            this.btnMostrar.TabIndex = 9;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(383, 294);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(85, 43);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCadena
            // 
            this.btnCadena.Location = new System.Drawing.Point(138, 368);
            this.btnCadena.Name = "btnCadena";
            this.btnCadena.Size = new System.Drawing.Size(93, 51);
            this.btnCadena.TabIndex = 11;
            this.btnCadena.Text = "Comprobar Cadena";
            this.btnCadena.UseVisualStyleBackColor = true;
            this.btnCadena.Click += new System.EventHandler(this.btnCadena_Click);
            // 
            // btnImpar
            // 
            this.btnImpar.Location = new System.Drawing.Point(302, 368);
            this.btnImpar.Name = "btnImpar";
            this.btnImpar.Size = new System.Drawing.Size(92, 51);
            this.btnImpar.TabIndex = 12;
            this.btnImpar.Text = "Precio Impares";
            this.btnImpar.UseVisualStyleBackColor = true;
            this.btnImpar.Click += new System.EventHandler(this.btnImpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.btnImpar);
            this.Controls.Add(this.btnCadena);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.mtxtModelo);
            this.Controls.Add(this.mtxtMarca);
            this.Controls.Add(this.mtxtCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtxtCodigo;
        private System.Windows.Forms.MaskedTextBox mtxtMarca;
        private System.Windows.Forms.MaskedTextBox mtxtModelo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCadena;
        private System.Windows.Forms.Button btnImpar;
    }
}

