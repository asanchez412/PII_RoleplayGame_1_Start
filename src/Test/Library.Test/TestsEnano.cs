using NUnit.Framework;
using Enanos;
using Magos;
using Elfos;
using ItemsDeAtaque;
using ItemsDeDefensa;

namespace TestsEnano
{
    [TestFixture]
    public class TestsDeEnano
    {
        [SetUp]
        public void Init()
        {
            Enano p1 = new Enano("Jorginho",10,100,5);
            Enano p2 = new Enano("Pepinho",8,100,6);
            ItemAtaque off1 = new ItemAtaque("Hacha","Hacha de dos mertros", 8);
            ItemAtaque off2 = new ItemAtaque("Espada","Espada de dos manos", 7);
            ItemAtaque off3 = new ItemAtaque("Cuchillo","Rápido y letal", 5);
            ItemDefensa deff1 = new ItemDefensa("Casco de bronce","El mejor y más exclusivo", 3);
            ItemDefensa deff2 = new ItemDefensa("Coraza de madera","Rudimentaria defensa", 3);
            ItemDefensa deff3 = new ItemDefensa("Botas de cuero","Hechas a medida", 2);
            ItemDefensa deff4 = new ItemDefensa("Hombreras de metal","Fieles a su dueño", 3);
            ItemDefensa deff5 = new ItemDefensa("Coraza de metal","Duradera", 3);
            ItemDefensa deff6 = new ItemDefensa("Coraza de metal de alta calidad","La mejor coraza", 7);
            ItemDefensa deff7 = new ItemDefensa("Pantalones de cuero","Ligeros", 3);
            p1.EquipOffEquip(off1);
            p1.EquipOffEquip(off3);
            p1.EquipDeffEquip(deff1);
            p1.EquipDeffEquip(deff6);
            p1.EquipDeffEquip(deff3);
            p1.EquipDeffEquip(deff7);

            p2.EquipOffEquip(off2);
            p2.EquipDeffEquip(deff5);

        }
        [TestCase]

        public void IsGetAttackValueRight()
        {
            Assert.AreEqual(p1.GetAttackValue(), 23);
        }
        [TestCase]
        public void IsGetDeffValueRight()
        {
            Assert.AreEqual(p1.GetDeffValue(), 21);
        }
        [TestCase]
        public void IsAtacarEnanoRight()
        {
            Assert.AreEqual(p1.AtacarEnano(p2), $"El jugador {p2.Name} recibe 14 puntos de daño");
        }
    }
}
