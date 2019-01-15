using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcul
{
    public partial class Form1 : Form
    {
        CancellationTokenSource _cancelCalculAsync = new CancellationTokenSource();
        Calcul Calc = new Calcul();
        public static long Compteur = 1000;
        public Form1()
        {
            InitializeComponent();
            Calc.MessageDebut += Calc_MessageDebut;
            Calc.MessageFin += Calc_MessageFin;
            Calc.ReturnCompteur += Calc_ReturnCompteur;
        }

        private void Calc_ReturnCompteur(object sender, ReturnCompteurEventArgs e)
        {
            textBox1.Text =Convert.ToString( e.returnCompteur);
        }
        private void Calc_MessageDebut(object sender, DebutCalculEventsArgs e)
        {
            labelMessage.Text = e.MessageDebut;
        }
        private void Calc_MessageFin(object sender, FinCalculEventsArgs e)
        {
            labelMessage.Text = e.MessageFin;
        }
        private void buttonCalcul_Click(object sender, EventArgs e)
        {
            Calc.AfficheMessageDebut();
           textBox1.Text =Convert.ToString( Calc.FonctionCalcul(Compteur,null ,_cancelCalculAsync.Token));
            Calc.AfficheMessageFin();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private async void buttonCalculAsync_Click(object sender, EventArgs e)
        {
            Calc.AfficheMessageDebut();
            TaskScheduler scheduler = TaskScheduler.FromCurrentSynchronizationContext();
            textBox1.Text = Convert.ToString( await Calc.FonctionCalculAsync(Compteur));
            labelMessage.Text = Convert.ToString(Compteur);
            Calc.AfficheMessageFin();
        }

        private void btStopAsync_Click(object sender, EventArgs e)
        {
            Calc.StopCalculAsync();
        }
    }
}
