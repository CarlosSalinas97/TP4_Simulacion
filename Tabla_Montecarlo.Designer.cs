namespace TP4
{
    partial class Tabla_Montecarlo
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
            this.data_vendedor_1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_vendedor_1)).BeginInit();
            this.SuspendLayout();
            // 
            // data_vendedor_1
            // 
            this.data_vendedor_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_vendedor_1.Location = new System.Drawing.Point(83, 88);
            this.data_vendedor_1.Name = "data_vendedor_1";
            this.data_vendedor_1.RowTemplate.Height = 25;
            this.data_vendedor_1.Size = new System.Drawing.Size(476, 147);
            this.data_vendedor_1.TabIndex = 0;
            // 
            // Tabla_Montecarlo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.data_vendedor_1);
            this.Name = "Tabla_Montecarlo";
            this.Text = "Tabla_Montecarlo";
            this.Load += new System.EventHandler(this.Tabla_Montecarlo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_vendedor_1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_vendedor_1;
    }
}