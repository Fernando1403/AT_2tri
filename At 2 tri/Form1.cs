using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At_2_tri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncal_Click(object sender, EventArgs e)
        {
            double altura, peso;

            altura = Convert.ToDouble(txtalt.Text);
            peso = Convert.ToDouble(txtkg.Text);

            //Ponte do Limão: Limite de altura: 5 metros, Limite de peso: 2500kg (Dados não reais, usados como base)
            //Ponte dos Remédios: Limite de altura: 3.8 metros, Limite de peso: 2000kg (Dados não reais, usados como base)
            //Ponte Aricanduva: Limite de altura: 4.5 metros, Limite de peso: 1750kg (Dados não reais, usados como base)
            // Ponte Freguesia do Ó: Limite de altura: 3.3 metros, Limite de peso: 2200kg (Dados não reais, usados como base)
            // Ponte Vila Guilherme: Limite de altura: 4.1 metros, Limite de peso: 1500kg (Dados não reais, usados como base)

            if (altura > 5 || peso > 2500) 
            { 
                MessageBox.Show("Você não poderá passar por nenhumas das pontes."); 
            } 
            else if (altura > 4.5 && altura <= 5 && peso <= 2500 && peso > 2200) 
            { 
                MessageBox.Show("Você poderá passar na Ponte do Limão."); 
            } 
            else if (altura <= 3.3 && peso < 2500 && peso > 2000) 
            { 
                MessageBox.Show("Você poderá passar na Ponte do Limão e na Ponte Freguesia Ó."); 
            } 
            else if (altura <= 3.3 && peso < 2500 && peso > 1750) 
            { 
                MessageBox.Show("Você poderá passar na Ponte do Limão, na Ponte Freguesia Ó e na Ponte dos Remédios."); 
            }
            else if (altura <= 3.3 && peso < 2500 && peso > 1500) 
            { 
                MessageBox.Show("Você poderá passar na Ponte do Limão, na Ponte Freguesia Ó, na Ponte dos Remédios e na Ponte Aricanduva."); 
            } 
            else if (altura < 5 && altura > 4.1 && peso <= 1750) 
            { 
                MessageBox.Show("Você poderá passar na Ponte do Limão e na Ponte Aricanduva."); 
            }
            else if (altura < 5 && altura > 3.8 && peso <= 1500) 
            { 
                MessageBox.Show("Você poderá passar na Ponte do Limão, na Ponte Aricanduva e na Ponte Vila Guilherme."); 
            }
            else if (altura < 5 && altura > 3.3 && peso <= 1500)
            { 
                MessageBox.Show("Você poderá passar na Ponte do Limão, na Ponte Aricanduva, na Ponte Vila Guilherme e na Ponte dos Remédios."); 
            } 
            else if (altura <= 3.3 && peso <= 1500) 
            { 
                MessageBox.Show("Você poderá passar em todas as pontes."); 
            }
            else if (altura <= 5 && altura > 3.3 && peso <= 2500 && peso > 1750)
            {
                MessageBox.Show("Você poderá passar na Ponte do Limão e na Ponte dos Remédios.");
            }
            else
            {
                MessageBox.Show("Você poderá passar na Ponte do Limão, na Ponte dos Remédios e na Ponte Aricanduva.");
            }
        }
    }
}
