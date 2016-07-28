using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progra4_Guia1
{
    public partial class Form1 : Form
    {
        bool Is1, Is2, Es_op;
        double Num1, Num2, Resultado;
        int Operacion;

        public Form1()
        {
            InitializeComponent();
            Is1 = Is2 = false;
        }

        public void Limpiar_Pantalla() { txtDisplay.Text = ""; } //para limpiar el textbox llamado txtDisplay

        public double Obtener_Valor()
        {
            double Valor = Convert.ToDouble(txtDisplay.Text);
            Limpiar_Pantalla();
            return Valor;
        }

        public void Actualizar_Pantalla(String texto)
        {
            txtDisplay.Text = txtDisplay.Text + texto;
        }

        public double operar(double operador1, double operador2, String signo)
        {
            double resultado = 0.0;
            switch (signo)
            {
                case "+":
                    resultado = operador1 + operador2;
                    break;

                case "-":
                    resultado = operador1 - operador2;
                    break;

                case "*":
                    resultado = operador1 * operador2;
                    break;

                case "/":
                    resultado = operador1 / operador2;
                    break;

                case "Sen":
                    resultado = Math.Sin(operador1);
                    break;

                case "Cos":
                    resultado = Math.Cos(operador1);
                    break;

                case "Tan":
                    resultado = Math.Tan(operador1);
                    break;

                case "Log":
                    resultado = Math.Log10(operador1);
                    break;

                case "Ln":
                    resultado = Math.Log(operador1);
                    break;

                case "x":
                    resultado = Math.Pow(operador1, operador2);
                    break;

                default:
                    break;
            }

            return resultado;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Actualizar_Pantalla("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Actualizar_Pantalla("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Actualizar_Pantalla("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Actualizar_Pantalla("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Actualizar_Pantalla("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Actualizar_Pantalla("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Actualizar_Pantalla("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Actualizar_Pantalla("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Actualizar_Pantalla("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Actualizar_Pantalla("9");
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            Limpiar_Pantalla();
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = Obtener_Valor();
                Is1 = true;                         //Actualizamos el valor de la variable de control
                Operacion = 0;                      //"0" indica la operacion matematica suma
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = Obtener_Valor();
                Is1 = true;                         //Actualizamos el valor de la variable de control
                Operacion = 1;                      //"1" indica la operacion matematica resta
            }
        }

        private void btnPor_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = Obtener_Valor();
                Is1 = true;                         //Actualizamos el valor de la variable de control
                Operacion = 2;                      //"2" indica la operacion matematica multiplicacion
            }
        }

        private void btnEntre_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = Obtener_Valor();
                Is1 = true;                         //Actualizamos el valor de la variable de control
                Operacion = 3;                      //"3" indica la operacion matematica divicion
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                if (Operacion == 0)
                {
                    if (Is1)
                    {
                        Num2 = Obtener_Valor();                     //Para obtener el segundo operando de la operacion suma
                        Actualizar_Pantalla(operar(Num1, Num2, "+").ToString());
                        Is1 = false;
                    }
                    else
                    {
                        MessageBox.Show("seleccione una operacion para realizar");
                    }
                }
                else if (Operacion == 1)
                {
                    if (Is1)
                    {
                        Num2 = Obtener_Valor();                     //Para obtener el segundo operando de la operacion resta
                        Actualizar_Pantalla(operar(Num1, Num2, "-").ToString());
                        Is1 = false;
                    }
                    else
                    {
                        MessageBox.Show("seleccione una operacion para realizar");
                    }
                }
                else if (Operacion == 2)
                {
                    if (Is1)
                    {
                        Num2 = Obtener_Valor();                     //Para obtener el segundo operando de la operacion suma
                        Actualizar_Pantalla(operar(Num1, Num2, "*").ToString());
                        Is1 = false;
                    }
                    else
                    {
                        MessageBox.Show("seleccione una operacion para realizar");
                    }
                }
                else if (Operacion == 3)
                {
                    if (Is1)
                    {
                        Num2 = Obtener_Valor();                     //Para obtener el segundo operando de la operacion suma
                        if (Num2 == 0)
                        {
                            MessageBox.Show("El segundo operando no puede ser 0");
                            Limpiar_Pantalla();
                        }
                        else
                        {
                            Actualizar_Pantalla(operar(Num1, Num2, "/").ToString());
                            Is1 = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("seleccione una operacion para realizar");
                    }
                }
                else if (Operacion == 4)
                {
                    if (Is1)
                    {
                        Actualizar_Pantalla(operar(Num1, 0, "Sen").ToString());
                        Is1 = false;
                    }
                    else
                    {
                        MessageBox.Show("seleccione una operacion para realizar");
                    }
                }
                else if (Operacion == 5)
                {
                    if (Is1)
                    {
                        Actualizar_Pantalla(operar(Num1, 0, "Cos").ToString());
                        Is1 = false;
                    }
                    else
                    {
                        MessageBox.Show("seleccione una operacion para realizar");
                    }
                }
                else if (Operacion == 6)
                {
                    if (Is1)
                    {
                        Actualizar_Pantalla(operar(Num1, 0, "Tan").ToString());
                        Is1 = false;
                    }
                    else
                    {
                        MessageBox.Show("seleccione una operacion para realizar");
                    }
                }
                else if (Operacion == 7)
                {
                    if (Is1)
                    {
                        Actualizar_Pantalla(operar(Num1, 0, "Log").ToString());
                        Is1 = false;
                    }
                    else
                    {
                        MessageBox.Show("seleccione una operacion para realizar");
                    }
                }
                else if (Operacion == 8)
                {
                    if (Is1)
                    {
                        Actualizar_Pantalla(operar(Num1, 0, "Ln").ToString());
                        Is1 = false;
                    }
                    else
                    {
                        MessageBox.Show("seleccione una operacion para realizar");
                    }
                }
                else if (Operacion == 9)
                {
                    if (Is1)
                    {
                        Num2 = Obtener_Valor();                     //Para obtener el segundo operando de la operacion suma
                        Actualizar_Pantalla(operar(Num1, Num2, "x").ToString());
                        Is1 = false;
                    }
                    else
                    {
                        MessageBox.Show("seleccione una operacion para realizar");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Esta operacion requiere dos operandos");
            }
        }

        private void btnSen_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = Obtener_Valor();
                Is1 = true;                         //Actualizamos el valor de la variable de control
                Operacion = 4;                      //"4" indica la operacion matematica Seno
            }
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = Obtener_Valor();
                Is1 = true;                         //Actualizamos el valor de la variable de control
                Operacion = 5;                      //"5" indica la operacion matematica Coseno
            }
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = Obtener_Valor();
                Is1 = true;                         //Actualizamos el valor de la variable de control
                Operacion = 6;                      //"6" indica la operacion matematica Tangente
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = Obtener_Valor();
                Is1 = true;                         //Actualizamos el valor de la variable de control
                Operacion = 7;                      //"7" indica la operacion matematica Logaritmo base 10
            }
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = Obtener_Valor();
                Is1 = true;                         //Actualizamos el valor de la variable de control
                Operacion = 8;                      //"8" indica la operacion matematica Logaritmo natural
            }
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = Obtener_Valor();
                Is1 = true;                         //Actualizamos el valor de la variable de control
                Operacion = 9;                      //"9" indica la operacion matematica potenciacion
            }
        }


    }
}
