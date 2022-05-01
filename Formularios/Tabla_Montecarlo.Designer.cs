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
            this.data_vendedor_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_vendedor_1.Location = new System.Drawing.Point(0, 0);
            this.data_vendedor_1.Name = "data_vendedor_1";
            this.data_vendedor_1.RowTemplate.Height = 25;
            this.data_vendedor_1.Size = new System.Drawing.Size(1193, 661);
            this.data_vendedor_1.TabIndex = 0;
            // 
            // Tabla_Montecarlo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 661);
            this.Controls.Add(this.data_vendedor_1);
            this.Name = "Tabla_Montecarlo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabla_Montecarlo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Tabla_Montecarlo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_vendedor_1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_vendedor_1;
    }
}