using NUnit.Framework;
using Enanos;
using Magos;
using Elfos;
using ItemsDeAtaque;
using ItemsDeDefensa;

namespace TestsElfo
{
    public class TestsDeElfo
    {
        [SetUp]
        public void Setup()
        {
            Elfo p1 = new Elfo("Pablinho", 100, 7, 5);
            Enano p2 = new Enano("Jorginho", 100, 10, 5);
            Mago p3 = new Mago("Dainamo", 100, 6, 3);
            Elfo p4 = new Elfo("Ronaldinho", 100, 10, 4);
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
            p1.EquipOffEquip(off2);
            p1.EquipDeffEquip(deff6);
            p1.EquipDeffEquip(deff7);

            p2.EquipOffEquip(off2);
            p2.EquipDeffEquip(deff5);

            LibrodeHechizos libro1 = new LibrodeHechizos("Rayos", 8);
            p3.AddLibro(libro1);
            p3.EquipOffEquip(off3);
            p3.EquipDeffEquip(deff5);
            p3.EquipDeffEquip(deff1);

            p4.EquipOffEquip(off2);
            p4.EquipDeffEquip(deff6);
            p4.EquipDeffEquip(deff7);
        }
        [Test]
        public void IsGetAttackValueRight()
        {
            Assert.AreEqual(p1.GetAttackValue(), 22);
        }
        [Test]
        public void IsGetDeffValueRight()
        {
            Assert.AreEqual(p1.GetDeffValue(), 15);
        }
        [Test]
        public void IsAtacarEnanoRight()
        {
            Assert.AreEqual(p1.AtacarEnano(p2), $"El jugador {p2.Name} recibe 14 puntos de daño");
        }
        [Test]
        public void IsAtacarMagoRight()
        {
            Assert.AreEqual(p1.AtacarMago(p3), $"El jugador {p3.Name} recibe 13 puntos de daño");
        }
        [Test]
        public void IsAtacarElfoRight()
        {
            Assert.AreEqual(p1.AtacarElfo(p4), $"El jugador {p4.Nickname} recibe 8 puntos de daño");
        }
    }
}
