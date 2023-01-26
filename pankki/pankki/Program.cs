using Pankki;

namespace Pankki
{
    public class Pankkitili
    {
        private readonly string m_asiakkaanNimi;
        private double m_saldo;

        public Pankkitili() { }

        public Pankkitili(string asiakkaanNimi, double saldo)
        {
            m_asiakkaanNimi = asiakkaanNimi;
            m_saldo = saldo;
        }

        public string AsiakkaanNimi
        {
            get { return m_asiakkaanNimi; }
        }

        public double Saldo
        {
            get { return m_saldo; }
        }

        public void Otto(double summa)
        {
            if (summa > m_saldo)
            {
                throw new ArgumentOutOfRangeException("summa");
            }
            if (summa < 0)
            {
                throw new ArgumentOutOfRangeException("summa");
            }
            m_saldo -= summa;
        }

        public void Pano(double summa)
        {
            if (summa < 0)
            {
                throw new ArgumentOutOfRangeException("summa");
            }
            m_saldo += summa;
        }

        public static void Main ()
        {
            Pankkitili pt = new Pankkitili("Petri Nurmi", 1200);
            pt.Pano(500);
            pt.Otto(400);
            Console.WriteLine("Saldosi on {0}", pt.Saldo);
        }

    }


}

