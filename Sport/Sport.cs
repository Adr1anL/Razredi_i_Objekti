using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazrediiObjekti
{
    internal class Sport
    {
        private String m_Naziv;
        private Boolean m_IgraLiSeLoptom;
        private byte m_BrojIgraca;

        public string Naziv { get => m_Naziv; set => m_Naziv = value; }
        public bool IgraLiSeLoptom { get => m_IgraLiSeLoptom; set => m_IgraLiSeLoptom = value; }
        public byte BrojIgraca { get => m_BrojIgraca; set => m_BrojIgraca = value; }

        public Sport() { }

        public Sport(string m_naziv = "", bool m_igraliseloptom = false, byte m_brojigraca = 0) { }
    }
}
