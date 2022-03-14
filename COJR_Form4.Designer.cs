
namespace COJR_Prueba
{
    partial class COJR_Form4
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
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvImpar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(267, 86);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(127, 46);
            this.btnMostrar.TabIndex = 0;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de Celulares que tienen el precio impar";
            // 
            // dgvImpar
            // 
            this.dgvImpar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImpar.Location = new System.Drawing.Point(69, 149);
            this.dgvImpar.Name = "dgvImpar";
            this.dgvImpar.RowHeadersWidth = 51;
            this.dgvImpar.RowTemplate.Height = 24;
            this.dgvImpar.Size = new System.Drawing.Size(556, 181);
            this.dgvImpar.TabIndex = 2;
            // 
            // COJR_Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 354);
            this.Controls.Add(this.dgvImpar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrar);
            this.Name = "COJR_Form4";
            this.Text = "COJR_Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvImpar;
    }
}