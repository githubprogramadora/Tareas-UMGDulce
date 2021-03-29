
namespace Carro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.botonuno = new System.Windows.Forms.Button();
            this.Estado = new System.Windows.Forms.Label();
            this.buttonEncender = new System.Windows.Forms.Button();
            this.buttonAcelerar = new System.Windows.Forms.Button();
            this.labelEstadoVelocidad = new System.Windows.Forms.Label();
            this.buttonBMW = new System.Windows.Forms.Button();
            this.bouttonAltoTotal = new System.Windows.Forms.Button();
            this.Reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.lstCanciones = new System.Windows.Forms.ListBox();
            this.btnAdjuntar = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdjuntar)).BeginInit();
            this.SuspendLayout();
            // 
            // botonuno
            // 
            this.botonuno.Location = new System.Drawing.Point(598, 86);
            this.botonuno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.botonuno.Name = "botonuno";
            this.botonuno.Size = new System.Drawing.Size(150, 35);
            this.botonuno.TabIndex = 0;
            this.botonuno.Text = "Crear carro ";
            this.botonuno.UseVisualStyleBackColor = true;
            this.botonuno.Click += new System.EventHandler(this.botonuno_Click);
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.Location = new System.Drawing.Point(801, 101);
            this.Estado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(51, 20);
            this.Estado.TabIndex = 1;
            this.Estado.Text = "label1";
            // 
            // buttonEncender
            // 
            this.buttonEncender.Location = new System.Drawing.Point(598, 162);
            this.buttonEncender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEncender.Name = "buttonEncender";
            this.buttonEncender.Size = new System.Drawing.Size(150, 35);
            this.buttonEncender.TabIndex = 2;
            this.buttonEncender.Text = "Encender el carro";
            this.buttonEncender.UseVisualStyleBackColor = true;
            this.buttonEncender.Click += new System.EventHandler(this.buttonEncender_Click);
            // 
            // buttonAcelerar
            // 
            this.buttonAcelerar.Location = new System.Drawing.Point(598, 233);
            this.buttonAcelerar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAcelerar.Name = "buttonAcelerar";
            this.buttonAcelerar.Size = new System.Drawing.Size(150, 35);
            this.buttonAcelerar.TabIndex = 3;
            this.buttonAcelerar.Text = "Acelerar";
            this.buttonAcelerar.UseVisualStyleBackColor = true;
            this.buttonAcelerar.Click += new System.EventHandler(this.buttonAcelerar_Click);
            // 
            // labelEstadoVelocidad
            // 
            this.labelEstadoVelocidad.AutoSize = true;
            this.labelEstadoVelocidad.Location = new System.Drawing.Point(801, 177);
            this.labelEstadoVelocidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEstadoVelocidad.Name = "labelEstadoVelocidad";
            this.labelEstadoVelocidad.Size = new System.Drawing.Size(51, 20);
            this.labelEstadoVelocidad.TabIndex = 4;
            this.labelEstadoVelocidad.Text = "label1";
            this.labelEstadoVelocidad.Click += new System.EventHandler(this.labelEstadoVelocidad_Click);
            // 
            // buttonBMW
            // 
            this.buttonBMW.Location = new System.Drawing.Point(598, 19);
            this.buttonBMW.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBMW.Name = "buttonBMW";
            this.buttonBMW.Size = new System.Drawing.Size(150, 35);
            this.buttonBMW.TabIndex = 5;
            this.buttonBMW.Text = "BMW";
            this.buttonBMW.UseVisualStyleBackColor = true;
            this.buttonBMW.Click += new System.EventHandler(this.buttonBMW_Click);
            // 
            // bouttonAltoTotal
            // 
            this.bouttonAltoTotal.Location = new System.Drawing.Point(598, 369);
            this.bouttonAltoTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bouttonAltoTotal.Name = "bouttonAltoTotal";
            this.bouttonAltoTotal.Size = new System.Drawing.Size(150, 35);
            this.bouttonAltoTotal.TabIndex = 6;
            this.bouttonAltoTotal.Text = "AltoTotal";
            this.bouttonAltoTotal.UseVisualStyleBackColor = true;
            this.bouttonAltoTotal.Click += new System.EventHandler(this.bouttonAltoTotal_Click);
            // 
            // Reproductor
            // 
            this.Reproductor.Enabled = true;
            this.Reproductor.Location = new System.Drawing.Point(3, 81);
            this.Reproductor.Name = "Reproductor";
            this.Reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Reproductor.OcxState")));
            this.Reproductor.Size = new System.Drawing.Size(441, 249);
            this.Reproductor.TabIndex = 7;
            // 
            // lstCanciones
            // 
            this.lstCanciones.FormattingEnabled = true;
            this.lstCanciones.ItemHeight = 20;
            this.lstCanciones.Location = new System.Drawing.Point(12, 346);
            this.lstCanciones.Name = "lstCanciones";
            this.lstCanciones.Size = new System.Drawing.Size(294, 244);
            this.lstCanciones.TabIndex = 8;
            this.lstCanciones.SelectedIndexChanged += new System.EventHandler(this.lstCanciones_SelectedIndexChanged);
            // 
            // btnAdjuntar
            // 
            this.btnAdjuntar.Image = global::Carro.Properties.Resources.kisspng_addition_plus_and_minus_signs_clip_art_plus_symbol_5aaeb408b8bc32_0869990215213987927567;
            this.btnAdjuntar.Location = new System.Drawing.Point(12, 12);
            this.btnAdjuntar.Name = "btnAdjuntar";
            this.btnAdjuntar.Size = new System.Drawing.Size(100, 50);
            this.btnAdjuntar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdjuntar.TabIndex = 9;
            this.btnAdjuntar.TabStop = false;
            this.btnAdjuntar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(621, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "Parar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 692);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdjuntar);
            this.Controls.Add(this.lstCanciones);
            this.Controls.Add(this.Reproductor);
            this.Controls.Add(this.bouttonAltoTotal);
            this.Controls.Add(this.buttonBMW);
            this.Controls.Add(this.labelEstadoVelocidad);
            this.Controls.Add(this.buttonAcelerar);
            this.Controls.Add(this.buttonEncender);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.botonuno);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdjuntar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonuno;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.Button buttonEncender;
        private System.Windows.Forms.Button buttonAcelerar;
        private System.Windows.Forms.Label labelEstadoVelocidad;
        private System.Windows.Forms.Button buttonBMW;
        private System.Windows.Forms.Button bouttonAltoTotal;
        private AxWMPLib.AxWindowsMediaPlayer Reproductor;
        private System.Windows.Forms.ListBox lstCanciones;
        private System.Windows.Forms.PictureBox btnAdjuntar;
        private System.Windows.Forms.Button button1;
    }
}

