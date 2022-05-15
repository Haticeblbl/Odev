using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1.Contrete;
using ClassLibrary1.Enum;

namespace WindowsFormsApp12
{
    public partial class Form2 : Form
    {
        private readonly Oyun _oyun;



        public Form2()
        {
            InitializeComponent();
            _oyun = new Oyun(TutucuPanel, OyunEkranıPanel);
            _oyun.GecenSureDegisti += Oyun_GecenSureDegisti;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Enter:
                    _oyun.Baslat();
                    break;
                case Keys.Right:
                    _oyun.HareketEttir(Yon.sağa);
                    break;
                case Keys.Left:
                    _oyun.HareketEttir(Yon.sola);
                    break;
                case Keys.Down:
                    _oyun.HareketEttir(Yon.aşağı);
                    break;
                case Keys.Space:
                    _oyun.Topla();
                    break;
                case Keys.P:
                    _oyun.Durdur();
                    break; 
            }
        }
        private void Oyun_GecenSureDegisti(object sender, EventArgs e)
        {
            lbsure.Text = $"{_oyun.GecenSure.Minutes}:{_oyun.GecenSure.Seconds.ToString("D2")}";
        }
    }
}
