using NUnit.Framework;
using Enanos;
using Magos;
using Elfos;
using ItemsDeAtaque;
using ItemsDeDefensa;

namespace TestsMago
{
    [TestFixture]
    public class TestsDeMago
    {
        [SetUp]
        public void SetUp()
        {
            Enano p1 = new Enano("Jorginho", 100, 10, 5);
            Mago p2 = new Mago("Georghino", 100, 7, 4);
            Mago p3 = new Mago("Dainamo", 100, 6, 3);
            Elfo p4 = new Elfo("Pablinho", 100, 7, 5);
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

            LibrodeHechizos libro1 = new LibrodeHechizos("Rayos", 8);
            
            p2.AddLibro(libro1);
            p2.EquipOffEquip(off2);
            p2.EquipDeffEquip(deff1);
            p2.EquipDeffEquip(deff3);
            p2.EquipDeffEquuip(deff7);

            p3.AddLibro(libro1);
            p3.EquipOffEquip(off3);
            p2.EquipDeffEquip(deff3);
            p3.EquipDeffEquip(deff5);
            p3.EquipDeffEquip(deff1);

            p4.EquipOffEquip(off2);
            p4.EquipDeffEquip(deff6);
            p4.EquipDeffEquip(deff7);
        }
        
        [TestCase]

        public void IsGetAttackValueRight()
        {
            Assert.AreEqual(p2.GetAttackValue(), 22);
        }
        [TestCase]
        public void IsGetDeffValueRight()
        {
            Assert.AreEqual(p2.GetDeffValue(), 8);
        }
        [TestCase]
        public void IsAtacarEnanoRight()
        {
            Assert.AreEqual(p2.AtacarEnano(p1), $"El jugador {p1.Name} recibe 14 puntos de daño");
        }
        public void IsAtacarMagoRight()
        {
            Assert.AreEqual(p2.AtacarMago(p3), $"El jugador {p3.Name} recibe 12 puntos de daño");
        }
        public void IsAtacarElfoRight()
        {
            Assert.AreEqual(p2.AtacarElfo(p4), $"El jugador {p4.Nickname} recibe 8 puntos de daño");
        }
    }
}
