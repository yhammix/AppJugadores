namespace Jugadores
{
    partial class Form1
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
            dgvJugadores = new DataGridView();
            pbxJugador = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvJugadores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxJugador).BeginInit();
            SuspendLayout();
            // 
            // dgvJugadores
            // 
            dgvJugadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJugadores.Location = new Point(24, 50);
            dgvJugadores.Name = "dgvJugadores";
            dgvJugadores.Size = new Size(531, 298);
            dgvJugadores.TabIndex = 0;
            dgvJugadores.SelectionChanged += dgvJugadores_SelectionChanged;
            // 
            // pbxJugador
            // 
            pbxJugador.Location = new Point(561, 71);
            pbxJugador.Name = "pbxJugador";
            pbxJugador.Size = new Size(224, 220);
            pbxJugador.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxJugador.TabIndex = 1;
            pbxJugador.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 450);
            Controls.Add(pbxJugador);
            Controls.Add(dgvJugadores);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvJugadores).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxJugador).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvJugadores;
        private PictureBox pbxJugador;
    }
}
