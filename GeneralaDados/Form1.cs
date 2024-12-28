using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeneralaDados.Properties; //Sirve para agregar una ruta dentro de nuestro proyecto para acortar la ruta de los picture box
using System.Media; 

namespace GeneralaDados
{
    public partial class frmGenerala : Form
    {
        public frmGenerala()
        {
            InitializeComponent();
        }
        Random R = new Random(); //Declaro el objeto generador de elementos random
        SoundPlayer S = new SoundPlayer(); //Declaro el objeto generador de elementos con sonido

        private void btnJugar_Click(object sender, EventArgs e)
        {
            Int32 Dado1 = R.Next(1, 7); // Declaro las variables y les asigno un valor random comprendido entre 1 y 6 
            Int32 Dado2 = R.Next(1, 7);
            Int32 Dado3 = R.Next(1, 7);
            Int32 Dado4 = R.Next(1, 7);
            Int32 Dado5 = R.Next(1, 7);

            TirarDados(Dado1, pctDado1); //Procediemiento tirar dados con su variable para el numero y la pct para la imagen
            TirarDados(Dado2, pctDado2);
            TirarDados(Dado3, pctDado3);
            TirarDados(Dado4, pctDado4);
            TirarDados(Dado5, pctDado5);


            //Preguntamos que juego se obtuvo         
            if (Dado1 == Dado2 && Dado2 == Dado3 && Dado3 == Dado4 && Dado4 == Dado5)  //Generala son 5 dados iguales
            {
                lblResultado.Text = "Generala!!!";   
                btnJugar.Enabled = false; //Desactivamos el boton comando porque ganamos el juego
                S.SoundLocation = "Ganaste.wav";
                S.Play();
            }
            else 
            {
                if (Dado1 == Dado2 && Dado2 == Dado3 && Dado3 == Dado4) 
                {
                    lblResultado.Text = "Poker";
                    btnJugar.Enabled = false;
                    btnVolver.Enabled = true;
                    S.SoundLocation = "Ganaste.wav";
                    S.Play();
                }
                if (Dado1 == Dado2 && Dado2 == Dado3 && Dado3 == Dado5)
                {
                    lblResultado.Text = "Poker";
                    btnJugar.Enabled = false;
                    btnVolver.Enabled = true;
                }
                if (Dado1 == Dado2 && Dado2 == Dado4 && Dado4 == Dado5)
                {
                    lblResultado.Text = "Poker";
                    btnJugar.Enabled = false;
                    btnVolver.Enabled = true;
                    S.SoundLocation = "Ganaste.wav";
                    S.Play();
                }
                if (Dado1 == Dado3 && Dado3 == Dado4 && Dado4 == Dado5)
                {
                    lblResultado.Text = "Poker";
                    btnJugar.Enabled = false;
                    btnVolver.Enabled = true;
                    S.SoundLocation = "Ganaste.wav";
                    S.Play();
                }
                if (Dado2 == Dado3 && Dado3 == Dado4 && Dado4 == Dado5)
                {
                    lblResultado.Text = "Poker";
                    btnJugar.Enabled = false;
                    btnVolver.Enabled = true;
                    S.SoundLocation = "Ganaste.wav";
                    S.Play();
                }
                else 
                {
                    Int32 SUMA = Dado1 + Dado2 + Dado3 + Dado4 + Dado5;
                    if ( (Dado1 != Dado2 && Dado1 != Dado3 && Dado1 != Dado4 && Dado1 != Dado5 && Dado2 != Dado3 && Dado2 != Dado4 &&
                        Dado2 != Dado5 && Dado3 != Dado4 && Dado3 != Dado5 && Dado4 != Dado5) && (SUMA == 15 || SUMA == 20 ) ) 
                    {
                        btnJugar.Enabled = false; 
                        btnVolver.Enabled = true; 
                        lblResultado.Text = "Escalera!!!";
                        S.SoundLocation = "Ganaste.wav";
                        S.Play();
                    }
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            btnJugar.Enabled = true; //Volvemos a habilitar el boton "Tirar Dados"
            btnVolver.Enabled = false; //Deshabilitamos el boton volver a jugar
            lblResultado.Text = " ";  //Deja limpia la etiqueta que muestra el resultado
            
        }

        private void TirarDados(Int32 N, PictureBox IMG) //Procedimiento para tirar los dados, se declara la variable "n" 
        {                                                // y la variable IMG para las imagenes de cada dado
            switch (N)
            {
                case 1:
                    IMG.Image = GeneralaDados.Properties.Resources.dado1;
                    break;
                case 2:
                    IMG.Image = GeneralaDados.Properties.Resources.dado2;
                    break;
                case 3:
                    IMG.Image = GeneralaDados.Properties.Resources.dado3;
                    break;
                case 4:
                    IMG.Image = GeneralaDados.Properties.Resources.dado4;
                    break;
                case 5:
                    IMG.Image = GeneralaDados.Properties.Resources.dado5;
                    break;
                case 6:
                    IMG.Image = GeneralaDados.Properties.Resources.dado6;
                    break;
            }
        }
    }
}
