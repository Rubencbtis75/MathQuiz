using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class Form1 : Form
    {
        // Crea un objeto aleatorio llamado aleatorizador
        // para generar numeros aleatorios.
        Random randomizer = new Random();

        // Estas variables enteras almacenan los numeros
        // para el problema de la suma. 
        int addend1;
        int addend2;

        // Estas variables enteras almacenan los numeros 
        // para el problema de la resta. 
        int minuend;
        int subtrahend;

        // Estas variables enteras almacenan los numeros
        // para el problema de la multiplicacion. 
        int multiplicand;
        int multiplier;

        // Estas variables enteras almacenan los numeros
        // para el problema de la division. 
        int dividend;
        int divisor;
        // Esta variable entera realiza un sigumiento de el 
        // tiempo restante.
        int timeLeft;
        public void StartTheQuiz()
        {
            // Completa el problema de suma.
            // Genera dos numeros aleatorios para sumar.
            // Almacena los valores en las variables 'sumando1' y 'sumando2'.
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            // Convierte los dos numeros generados aleatoriamente
            // en cadenas para que se puedan mostrar
            // en losm controles de etiquetas.
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            // 'sumar'. Es el nombre del control NumericUpDown
            // Este paso asegura que su valor sea cero antes
            // agregandole cualquier valor.
            sumar.Value = 0;

            // Completa el problema de resta.
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;

            // Completa el problema de la multiplicacion.
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;

            // Completa el problema de la division.
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quotient.Value = 0;

            // Iniciar el cronometro.
            timeLeft = 30;
            timeLabel.Text = "30 segundos";
            timer1.Start();

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StarButtonn_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            StarButtonn.Enabled = false;
        }
        private bool CheckTheAnswer()
        { // Verefica las respuestas para ver sin el usuario hizo todo bien.
            //Veradero si la respuesta es correcta,falso en caso contrario
            if ((addend1 + addend2 == sumar.Value)
                && (minuend - subtrahend == difference.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotient.Value))
                return true;
            else
                return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                // Si CheckTheAnswer() devuelve verdadero  , entonces el usuario
                // acerte la respuesta detener el cronometro  
                // y mostra un  MessageBox.
                timer1.Stop();
                MessageBox.Show("Has acertado todas las respuestas!",
                                "Felizidades!");

                StarButtonn.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                // Si CheckTheAnswer() Devuelve falso,sigue contando
                // abajo. Disminuya el tiempo restante en un segundo y
                // mostrar el nuevo tiempo restante actualizado el 
                // Etiqueta del tiempo restante.
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " segundos";
                if (timeLeft <= 5)
                {
                    timeLabel.BackColor = Color.Red;
                }
                    

            }
            else
            {
                // si al usuari se le acabo el tiempo,detiene el cronometro,muestar
                // un cuadro de mensaje y complete la respuesta.
                timer1.Stop();
                timeLabel.Text = "Se acabo el tiempo!";
                MessageBox.Show("No terminaste a tiempo.", "Lo Siento!");
                sumar.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                StarButtonn.Enabled = true;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            // Seleccione la respuesta completa en el control NumericUpDown.
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
       }

        private void minusRightLabel_Click(object sender, EventArgs e)
        {

        }

        private void dividedRightLabel_Click(object sender, EventArgs e)
        {

        }
    }
}


