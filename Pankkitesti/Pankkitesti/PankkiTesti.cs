using Pankki;
namespace Pankkitesti
{
    [TestClass]
    public class PankkitiliTesti
    {
        [TestMethod]
        public void Otto_OikeallaSummalla_PaivitaSaldo()
        {
            //Alkuvalmistelut
            double alkusaldo = 11.99;
            double ottoSumma = 4.55;
            double oletettu = 7.44;
            Pankki.Pankkitili tili = new Pankki.Pankkitili("Jaakko Tarvainen", alkusaldo);

            //toiminta
            tili.Otto(ottoSumma);

            //oletettu tulos
            double todellinen = tili.Saldo;
            Assert.AreEqual(oletettu, todellinen, 0.001, "Tililt� otto ei onnistunut!");
        }
    }
}