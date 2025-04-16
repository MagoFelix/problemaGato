using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace problema_gato
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int inicio = 0;
            int fin = 0;
            int salida = 0;
            int contador = 0;
            inicio = Convert.ToInt32(txtIni.Text);
            fin = Convert.ToInt32(txtFin.Text);
            if (inicio > 0 && fin > 0) 
            {
                if (fin > inicio)
                {
                    while ( inicio < fin )
                    {
                        if ((inicio + 1) <= fin && contador == 0)
                        {
                            inicio = inicio +1;
                            contador = contador + 1;
                        }
                        else if ((inicio) <= fin && fin > 3)
                        {
                            inicio = inicio + 3;
                            contador = contador + 1;
                        }
                        else 
                        {
                            break;
                        }
                    }
                   
                   
                }
                else if(fin == inicio){
                    salida = 1;
                }
                lblSalida.Text = "Salida: "+Convert.ToString(contador);
            }
        }

        
    }
}
