namespace TP4
{
    partial class Entrada_Datos
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
            this.label5 = new System.Windows.Forms.Label();
            this.txt_N = new System.Windows.Forms.TextBox();
            this.txt_desde = new System.Windows.Forms.TextBox();
            this.txt_hasta = new System.Windows.Forms.TextBox();
            this.btn_simular = new System.Windows.Forms.Button();
            this.btn_ver_tabla = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simulación de Montecarlo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Agencia de automoviles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad de semanas a simular (N):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Visualizar desde:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(236, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "hasta:";
            // 
            // txt_N
            // 
            this.txt_N.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_N.Location = new System.Drawing.Point(292, 99);
            this.txt_N.MaxLength = 10;
            this.txt_N.Name = "txt_N";
            this.txt_N.Size = new System.Drawing.Size(87, 29);
            this.txt_N.TabIndex = 0;
            this.txt_N.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_N_KeyPress);
            // 
            // txt_desde
            // 
            this.txt_desde.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_desde.Location = new System.Drawing.Point(143, 138);
            this.txt_desde.MaxLength = 10;
            this.txt_desde.Name = "txt_desde";
            this.txt_desde.Size = new System.Drawing.Size(87, 29);
            this.txt_desde.TabIndex = 1;
            this.txt_desde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_desde_KeyPress);
            // 
            // txt_hasta
            // 
            this.txt_hasta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_hasta.Location = new System.Drawing.Point(292, 138);
            this.txt_hasta.MaxLength = 10;
            this.txt_hasta.Name = "txt_hasta";
            this.txt_hasta.Size = new System.Drawing.Size(87, 29);
            this.txt_hasta.TabIndex = 2;
            this.txt_hasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_hasta_KeyPress);
            // 
            // btn_simular
            // 
            this.btn_simular.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_simular.Location = new System.Drawing.Point(181, 217);
            this.btn_simular.Name = "btn_simular";
            this.btn_simular.Size = new System.Drawing.Size(97, 30);
            this.btn_simular.TabIndex = 3;
            this.btn_simular.Text = "Simular";
            this.btn_simular.UseVisualStyleBackColor = true;
            this.btn_simular.Click += new System.EventHandler(this.btn_simular_Click);
            // 
            // btn_ver_tabla
            // 
            this.btn_ver_tabla.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ver_tabla.Location = new System.Drawing.Point(284, 217);
            this.btn_ver_tabla.Name = "btn_ver_tabla";
            this.btn_ver_tabla.Size = new System.Drawing.Size(97, 30);
            this.btn_ver_tabla.TabIndex = 4;
            this.btn_ver_tabla.Text = "Ver tabla";
            this.btn_ver_tabla.UseVisualStyleBackColor = true;
            this.btn_ver_tabla.Click += new System.EventHandler(this.btn_ver_tabla_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 253);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(367, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // Entrada_Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 288);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_ver_tabla);
            this.Controls.Add(this.btn_simular);
            this.Controls.Add(this.txt_hasta);
            this.Controls.Add(this.txt_desde);
            this.Controls.Add(this.txt_N);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Entrada_Datos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulación de Montecarlo - Grupo 6 -2022";
            this.Load += new System.EventHandler(this.Entrada_Datos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_N;
        private System.Windows.Forms.TextBox txt_desde;
        private System.Windows.Forms.TextBox txt_hasta;
        private System.Windows.Forms.Button btn_simular;
        private System.Windows.Forms.Button btn_ver_tabla;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}