namespace TP4.Formularios
{
    partial class Probabilidades
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.data_prob_delujo = new System.Windows.Forms.DataGridView();
            this.data_prob_med = new System.Windows.Forms.DataGridView();
            this.data_prob_tipo = new System.Windows.Forms.DataGridView();
            this.data_prob_cant = new System.Windows.Forms.DataGridView();
            this.btn_aplicar = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_prob_delujo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_prob_med)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_prob_tipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_prob_cant)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número autos vendidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(531, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de auto vendido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(531, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Comisión de autos medianos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Comisión de autos de lujo";
            // 
            // data_prob_delujo
            // 
            this.data_prob_delujo.ColumnHeadersHeight = 40;
            this.data_prob_delujo.Location = new System.Drawing.Point(12, 337);
            this.data_prob_delujo.Name = "data_prob_delujo";
            this.data_prob_delujo.RowTemplate.Height = 25;
            this.data_prob_delujo.Size = new System.Drawing.Size(450, 240);
            this.data_prob_delujo.TabIndex = 2;
            // 
            // data_prob_med
            // 
            this.data_prob_med.ColumnHeadersHeight = 40;
            this.data_prob_med.Location = new System.Drawing.Point(531, 337);
            this.data_prob_med.Name = "data_prob_med";
            this.data_prob_med.RowTemplate.Height = 25;
            this.data_prob_med.Size = new System.Drawing.Size(450, 240);
            this.data_prob_med.TabIndex = 3;
            // 
            // data_prob_tipo
            // 
            this.data_prob_tipo.ColumnHeadersHeight = 40;
            this.data_prob_tipo.Location = new System.Drawing.Point(531, 33);
            this.data_prob_tipo.Name = "data_prob_tipo";
            this.data_prob_tipo.RowTemplate.Height = 25;
            this.data_prob_tipo.Size = new System.Drawing.Size(450, 240);
            this.data_prob_tipo.TabIndex = 1;
            // 
            // data_prob_cant
            // 
            this.data_prob_cant.ColumnHeadersHeight = 40;
            this.data_prob_cant.Location = new System.Drawing.Point(12, 33);
            this.data_prob_cant.Name = "data_prob_cant";
            this.data_prob_cant.RowTemplate.Height = 25;
            this.data_prob_cant.Size = new System.Drawing.Size(450, 240);
            this.data_prob_cant.TabIndex = 0;
            // 
            // btn_aplicar
            // 
            this.btn_aplicar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_aplicar.Location = new System.Drawing.Point(506, 594);
            this.btn_aplicar.Name = "btn_aplicar";
            this.btn_aplicar.Size = new System.Drawing.Size(137, 30);
            this.btn_aplicar.TabIndex = 4;
            this.btn_aplicar.Text = "Aplicar";
            this.btn_aplicar.UseVisualStyleBackColor = true;
            this.btn_aplicar.Click += new System.EventHandler(this.btn_aplicar_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_volver.Location = new System.Drawing.Point(350, 594);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(137, 30);
            this.btn_volver.TabIndex = 5;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // Probabilidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 636);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_aplicar);
            this.Controls.Add(this.data_prob_cant);
            this.Controls.Add(this.data_prob_tipo);
            this.Controls.Add(this.data_prob_med);
            this.Controls.Add(this.data_prob_delujo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Probabilidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Probabilidades";
            this.Load += new System.EventHandler(this.Probabilidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_prob_delujo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_prob_med)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_prob_tipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_prob_cant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView data_prob_delujo;
        private System.Windows.Forms.DataGridView data_prob_med;
        private System.Windows.Forms.DataGridView data_prob_tipo;
        private System.Windows.Forms.DataGridView data_prob_cant;
        private System.Windows.Forms.Button btn_aplicar;
        private System.Windows.Forms.Button btn_volver;
    }
}