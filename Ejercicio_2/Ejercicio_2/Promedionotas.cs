using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class Promedionotas : Form
    {
        public Promedionotas()
        {
            InitializeComponent();
        }

        private async void Calcularbutton1_Click(object sender, EventArgs e)
        {
            decimal nota1 = Convert.ToDecimal(nota1textBox.Text);
            decimal nota2 = Convert.ToDecimal(nota2textBox.Text);
            decimal nota3= Convert.ToDecimal(nota3textBox.Text);
            decimal nota4 = Convert.ToDecimal(nota4textBox.Text);

            decimal promedio = await SumarnotasAsync(nota1, nota2, nota3, nota4);

            MessageBox.Show($"El promedio final es:{promedio}");
        }
        private async Task<decimal> SumarnotasAsync(decimal n1, decimal n2, decimal n3, decimal n4)
        {
            decimal suma = await Task.Run(() =>
            {
                return (n1 + n2 + n3 + n4) / 4;
            });
            return suma;


        }

        private void Limpiarbutton2_Click(object sender, EventArgs e)
        {
          nota1textBox.Clear();
          nota2textBox.Clear();
          nota3textBox.Clear();
          nota4textBox.Clear();
        }

        


    }
}
