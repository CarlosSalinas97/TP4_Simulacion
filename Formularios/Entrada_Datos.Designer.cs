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
            this.btn_ver_tabla_vendedor1 = new System.Windows.Forms.Button();
            this.btn_ver_tabla_vendedor2 = new System.Windows.Forms.Button();
            this.btn_ver_tabla_vendedor3 = new System.Windows.Forms.Button();
            this.btn_ver_tabla_vendedor4 = new System.Windows.Forms.Button();
            this.lbl_vendedor1 = new System.Windows.Forms.Label();
            this.lbl_vendedor2 = new System.Windows.Forms.Label();
            this.lbl_vendedor3 = new System.Windows.Forms.Label();
            this.lbl_vendedor4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.btn_simular.Location = new System.Drawing.Point(155, 187);
            this.btn_simular.Name = "btn_simular";
            this.btn_simular.Size = new System.Drawing.Size(173, 30);
            this.btn_simular.TabIndex = 3;
            this.btn_simular.Text = "Simular";
            this.btn_simular.UseVisualStyleBackColor = true;
            this.btn_simular.Click += new System.EventHandler(this.btn_simular_Click);
            // 
            // btn_ver_tabla
            // 
            this.btn_ver_tabla.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ver_tabla.Location = new System.Drawing.Point(334, 187);
            this.btn_ver_tabla.Name = "btn_ver_tabla";
            this.btn_ver_tabla.Size = new System.Drawing.Size(173, 30);
            this.btn_ver_tabla.TabIndex = 4;
            this.btn_ver_tabla.Text = "Ver tablas";
            this.btn_ver_tabla.UseVisualStyleBackColor = true;
            this.btn_ver_tabla.Click += new System.EventHandler(this.btn_ver_tabla_Click);
            // 
            // btn_ver_tabla_vendedor1
            // 
            this.btn_ver_tabla_vendedor1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ver_tabla_vendedor1.Location = new System.Drawing.Point(334, 223);
            this.btn_ver_tabla_vendedor1.Name = "btn_ver_tabla_vendedor1";
            this.btn_ver_tabla_vendedor1.Size = new System.Drawing.Size(173, 30);
            this.btn_ver_tabla_vendedor1.TabIndex = 5;
            this.btn_ver_tabla_vendedor1.Text = "Ver tabla vendedor 1";
            this.btn_ver_tabla_vendedor1.UseVisualStyleBackColor = true;
            this.btn_ver_tabla_vendedor1.Click += new System.EventHandler(this.btn_ver_tabla_vendedor1_Click);
            // 
            // btn_ver_tabla_vendedor2
            // 
            this.btn_ver_tabla_vendedor2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ver_tabla_vendedor2.Location = new System.Drawing.Point(334, 259);
            this.btn_ver_tabla_vendedor2.Name = "btn_ver_tabla_vendedor2";
            this.btn_ver_tabla_vendedor2.Size = new System.Drawing.Size(173, 30);
            this.btn_ver_tabla_vendedor2.TabIndex = 6;
            this.btn_ver_tabla_vendedor2.Text = "Ver tabla vendedor 2";
            this.btn_ver_tabla_vendedor2.UseVisualStyleBackColor = true;
            this.btn_ver_tabla_vendedor2.Click += new System.EventHandler(this.btn_ver_tabla_vendedor2_Click);
            // 
            // btn_ver_tabla_vendedor3
            // 
            this.btn_ver_tabla_vendedor3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ver_tabla_vendedor3.Location = new System.Drawing.Point(334, 295);
            this.btn_ver_tabla_vendedor3.Name = "btn_ver_tabla_vendedor3";
            this.btn_ver_tabla_vendedor3.Size = new System.Drawing.Size(173, 30);
            this.btn_ver_tabla_vendedor3.TabIndex = 7;
            this.btn_ver_tabla_vendedor3.Text = "Ver tabla vendedor 3";
            this.btn_ver_tabla_vendedor3.UseVisualStyleBackColor = true;
            this.btn_ver_tabla_vendedor3.Click += new System.EventHandler(this.btn_ver_tabla_vendedor3_Click);
            // 
            // btn_ver_tabla_vendedor4
            // 
            this.btn_ver_tabla_vendedor4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ver_tabla_vendedor4.Location = new System.Drawing.Point(334, 331);
            this.btn_ver_tabla_vendedor4.Name = "btn_ver_tabla_vendedor4";
            this.btn_ver_tabla_vendedor4.Size = new System.Drawing.Size(173, 30);
            this.btn_ver_tabla_vendedor4.TabIndex = 8;
            this.btn_ver_tabla_vendedor4.Text = "Ver tabla vendedor 4";
            this.btn_ver_tabla_vendedor4.UseVisualStyleBackColor = true;
            this.btn_ver_tabla_vendedor4.Click += new System.EventHandler(this.btn_ver_tabla_vendedor4_Click);
            // 
            // lbl_vendedor1
            // 
            this.lbl_vendedor1.AutoSize = true;
            this.lbl_vendedor1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_vendedor1.Location = new System.Drawing.Point(12, 228);
            this.lbl_vendedor1.Name = "lbl_vendedor1";
            this.lbl_vendedor1.Size = new System.Drawing.Size(0, 21);
            this.lbl_vendedor1.TabIndex = 10;
            // 
            // lbl_vendedor2
            // 
            this.lbl_vendedor2.AutoSize = true;
            this.lbl_vendedor2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_vendedor2.Location = new System.Drawing.Point(12, 264);
            this.lbl_vendedor2.Name = "lbl_vendedor2";
            this.lbl_vendedor2.Size = new System.Drawing.Size(0, 21);
            this.lbl_vendedor2.TabIndex = 11;
            // 
            // lbl_vendedor3
            // 
            this.lbl_vendedor3.AutoSize = true;
            this.lbl_vendedor3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_vendedor3.Location = new System.Drawing.Point(12, 300);
            this.lbl_vendedor3.Name = "lbl_vendedor3";
            this.lbl_vendedor3.Size = new System.Drawing.Size(0, 21);
            this.lbl_vendedor3.TabIndex = 12;
            // 
            // lbl_vendedor4
            // 
            this.lbl_vendedor4.AutoSize = true;
            this.lbl_vendedor4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_vendedor4.Location = new System.Drawing.Point(12, 336);
            this.lbl_vendedor4.Name = "lbl_vendedor4";
            this.lbl_vendedor4.Size = new System.Drawing.Size(0, 21);
            this.lbl_vendedor4.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 30);
            this.button1.TabIndex = 14;
            this.button1.Text = "Editar prob.";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Entrada_Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 373);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_vendedor4);
            this.Controls.Add(this.lbl_vendedor3);
            this.Controls.Add(this.lbl_vendedor2);
            this.Controls.Add(this.lbl_vendedor1);
            this.Controls.Add(this.btn_ver_tabla_vendedor4);
            this.Controls.Add(this.btn_ver_tabla_vendedor3);
            this.Controls.Add(this.btn_ver_tabla_vendedor2);
            this.Controls.Add(this.btn_ver_tabla_vendedor1);
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
        private System.Windows.Forms.Button btn_ver_tabla_vendedor1;
        private System.Windows.Forms.Button btn_ver_tabla_vendedor2;
        private System.Windows.Forms.Button btn_ver_tabla_vendedor3;
        private System.Windows.Forms.Button btn_ver_tabla_vendedor4;
        private System.Windows.Forms.Label lbl_vendedor1;
        private System.Windows.Forms.Label lbl_vendedor2;
        private System.Windows.Forms.Label lbl_vendedor3;
        private System.Windows.Forms.Label lbl_vendedor4;
        private System.Windows.Forms.Button button1;
    }
}