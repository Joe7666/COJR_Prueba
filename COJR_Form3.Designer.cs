﻿
namespace COJR_Prueba
{
    partial class COJR_Form3
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
            this.btnVerificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxtCadena = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCadena = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadena)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(228, 144);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(93, 42);
            this.btnVerificar.TabIndex = 0;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ver si la cadena termina con una ingresada";
            // 
            // mtxtCadena
            // 
            this.mtxtCadena.Location = new System.Drawing.Point(338, 85);
            this.mtxtCadena.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.mtxtCadena.Name = "mtxtCadena";
            this.mtxtCadena.Size = new System.Drawing.Size(175, 22);
            this.mtxtCadena.TabIndex = 2;
            this.mtxtCadena.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingresar cadena:";
            // 
            // dgvCadena
            // 
            this.dgvCadena.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadena.Location = new System.Drawing.Point(135, 192);
            this.dgvCadena.Name = "dgvCadena";
            this.dgvCadena.RowHeadersWidth = 51;
            this.dgvCadena.RowTemplate.Height = 24;
            this.dgvCadena.Size = new System.Drawing.Size(557, 199);
            this.dgvCadena.TabIndex = 4;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(410, 144);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(103, 42);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // COJR_Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dgvCadena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtxtCadena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerificar);
            this.Name = "COJR_Form3";
            this.Text = "COJR_Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxtCadena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCadena;
        private System.Windows.Forms.Button btnLimpiar;
    }
}