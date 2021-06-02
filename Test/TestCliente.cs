using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;


namespace Prototipo.Test
{
     public class TestCliente
    {
        [TestMethod]

        public void TestMethod1()

        {
            Mock<Conexion> mock = new Mock<Conexion>();

            Conexion conect = new Conexion(mock.Object);

            int id = 123;
            string nombre = "aaaa";
            string domicilio = "aaaa"; 
            string telefono = "aaaa";
            string correo = "aaaa";
            string RFC_t = "aaaa";
            string CURP_t = "aaaa";
            string F_in = "aaaa";
            string F_fi = "aaaaa";


            mock.Setup(a => a.Insertar_Cl(id, nombre, domicilio, telefono, correo, RFC_t, CURP_t)).Returns("Se agregó correctamente");
            mock.Setup(a => a.Insertar_Ss(id, F_in, F_fi)).Returns("Se agregó correctamente");
            mock.Setup(a => a.Insertar_Sd(id, F_in, F_fi)).Returns("Se agregó correctamente");

            mock.Verify(a => a.Registrado_cl(1));
            mock.Verify(a => a.Registrado_Ss(1));
            mock.Verify(a => a.Registrado_Sd(1));
        }
    }
}