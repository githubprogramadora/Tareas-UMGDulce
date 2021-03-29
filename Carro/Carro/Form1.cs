using Carro.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carro
{
    public partial class Form1 : Form
    {
        private string ruta = "";

        bool Play = false;
        string[] ArchivosPM3;
        string[] rutasArchivosPM3;


        ClsAutomotor carrito;
        public Form1()
        {
            InitializeComponent();
        }

        private void botonuno_Click(object sender, EventArgs e)
        {
            carrito = new ClsAutomotor("Meches", 130); 
            carrito.color = "Negro";



            MessageBox.Show($"El carro {carrito.marca} llega a {carrito.vel_max} KPH");

        }

        private void buttonEncender_Click(object sender, EventArgs e)
        {
           
                
                Estado.Text = $" el carro {carrito.marca} :{carrito.encender()}";
            
             
        }

        private void buttonAcelerar_Click(object sender, EventArgs e)
        {
            if (carrito == null)
            {
                MessageBox.Show("Crea el carro primero");

            }
            else
            {
                labelEstadoVelocidad.Text = carrito.Acelerar();
            }
            
           
        }

        private void buttonBMW_Click(object sender, EventArgs e)
        {
            carrito = new ClsAutomotor("BMW", 200, "NEGRO");

            MessageBox.Show($"El carro {carrito.marca} llega a {carrito.vel_max} KPH");
        }

        private void bouttonAltoTotal_Click(object sender, EventArgs e)
        {
            labelEstadoVelocidad.Text = carrito.DetenerMarcha();
        }

        private void labelEstadoVelocidad_Click(object sender, EventArgs e)
        {
            labelEstadoVelocidad.Text = carrito.DetenerMarcha(); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog CajaBusquedaArchivos = new OpenFileDialog();

            CajaBusquedaArchivos.Multiselect = true;

            if (CajaBusquedaArchivos.ShowDialog() == System.Windows.Forms.DialogResult.OK)

                ArchivosPM3 = CajaBusquedaArchivos.SafeFileNames;
            rutasArchivosPM3 = CajaBusquedaArchivos.FileNames;
            foreach (var ArchivosMP3 in ArchivosPM3)
            {
                lstCanciones.Items.Add(ArchivosMP3);
            }
            Reproductor.URL = rutasArchivosPM3[0];
            lstCanciones.SelectedIndex = 0;

        }

        private void lstCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reproductor.URL = rutasArchivosPM3[lstCanciones.SelectedIndex];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelEstadoVelocidad.Text = carrito.MasLento();
        }
    }
 }

