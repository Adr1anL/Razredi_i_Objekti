using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zrakoplov
{
    internal class Zrakoplov
    {
        private string m_Naziv;
        private double m_SnagaMotora;
        private int m_DosegLeta;
        private double m_Brzina;
        private Tocka m_Pozicija;

        public string Naziv { get => m_Naziv; set => m_Naziv = value; }
        public double SnagaMotora { get => m_SnagaMotora; set => m_SnagaMotora = value; }
        public int DosegLeta { get => m_DosegLeta; set => m_DosegLeta = value; }
        public double Brzina { get => m_Brzina; set => m_Brzina = value; }

        public Zrakoplov(string m_Naziv = "", double m_SnagaMotora = 0.0, int m_DosegLeta = 0, double m_Brzina = 0, double m_x = 1, double m_y = 1) {
            this.m_Brzina = m_SnagaMotora * 0.4;
            this.m_Pozicija = new Tocka(m_x, m_y);
            this.m_Naziv = m_Naziv;
            this.m_SnagaMotora = m_SnagaMotora;
            this.m_DosegLeta = m_DosegLeta;
        }

        public double plan_leta(double m_x = 1, double m_y = 1)
        {
            Tocka o_Pozicija = new Tocka(m_x, m_y);

            double udaljenost = m_Pozicija.udaljenost(o_Pozicija);

            return (udaljenost / this.m_Brzina);
        }

        public override string ToString()
        { 
            return ("Naziv: " + m_Naziv + "\nSnaga Motora: " + m_SnagaMotora + "\nDoseg Leta: " + m_DosegLeta + "\nBrzina: " + m_Brzina + "\nPozicija: " + m_Pozicija);
        }
    }
}
