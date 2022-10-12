using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio11_Biblioteca;
using System;

namespace Ejercicio11_EnClase01
{
    [TestClass]
    public class PersonaDNI_Test
    {
        /// <summary>
        /// Comprobar que el DNI en formato texto NO pueda tener:
        /// Coma
        /// Letras
        /// Arroja DniInvalidoException
        /// </summary>
        [TestMethod]
        public void DNI_Invalido_Texto()
        {
            //Arrange
            string dniComa = "30.999,999";
            string dniTexto = "30a00123";

            //Act y Assert
            try
            {
                Persona persona = new Persona("Juan", "Lopez", dniComa, ENacionalidad.Argentina);
                Assert.Fail("Sin excepción para DNI inválido: {0}.", dniComa);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(DniInvalidoException));
            }

            //Act y Assert
            try
            {
                Persona persona = new Persona("Juan", "Lopez", dniTexto, ENacionalidad.Argentina);
                Assert.Fail("Sin excepción para DNI inválido: {0}.", dniTexto);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(DniInvalidoException));
            }

        }

        /// <summary>
        /// Comprobar que el DNI no pueda ser menor a 1
        /// Arroja NacionalidadInvalidaException
        /// </summary>
        [TestMethod]
        public void DNI_Invalido_Bajo()
        {
            //Arrange
            Persona ejemplo = new Persona("Juan", "Perez", ENacionalidad.Argentina);

            //Act y Assert
            try
            {
                ejemplo.DNI = 0;
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(NacionalidadInvalidaException));
            }
        }

        /// <summary>
        /// Comprobar que el DNI no pueda ser mayor a 99.999.999
        /// </summary>
        [TestMethod]
        public void DNI_Invalido_Alto()
        {
            //Arrange
            Persona ejemplo = new Persona("Juan", "Perez", ENacionalidad.Argentina);

            //Act
            try
            {
                ejemplo.DNI = 10000000;
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(NacionalidadInvalidaException));
            }

            //Assert

        }

        /// <summary>
        /// Comprobar los rangos de DNI para Argentinos
        /// </summary>
        [TestMethod]
        public void DNI_Validos_Argentino()
        {
            //Arrange
            int dniPrimero = 1;
            int dniMedio = new Random().Next(1, 89999999);
            int dniUltimo = 89999999;
            string dniString = "89.999.999";
            Persona persona = new Persona("Juan", "Lopez", dniPrimero, ENacionalidad.Argentina);

            //Act y Assert

            Assert.AreEqual(persona.DNI, dniPrimero);

            //Act y Assert

            persona.DNI = dniMedio;
            Assert.AreEqual(persona.DNI, dniMedio);

            //Act y Assert

            persona.DNI = dniUltimo;
            Assert.AreEqual(persona.DNI, dniUltimo);

            //Act y Assert

            persona.StringToDNI = dniString;
            Assert.AreEqual(persona.DNI, dniUltimo);

        }

        /// <summary>
        /// Comprobar los rangos de DNI para Extranjeros
        /// </summary>
        [TestMethod]
        public void DNI_Validos_Extranjeros()
        {
            //Arrange
            int dniPrimero = 90000000;
            int dniMedio = new Random().Next(90000000, 100000000);
            int dniUltimo = 99999999;
            string dniString = "99.999.999";
            Persona persona = new Persona("Juan", "Lopez", dniPrimero, ENacionalidad.Extranjera);

            //Act y Assert

            Assert.AreEqual(persona.DNI, dniPrimero);

            //Act y Assert

            persona.DNI = dniMedio;
            Assert.AreEqual(persona.DNI, dniMedio);

            //Act y Assert

            persona.DNI = dniUltimo;
            Assert.AreEqual(persona.DNI, dniUltimo);

            //Act y Assert

            persona.StringToDNI = dniString;
            Assert.AreEqual(persona.DNI, dniUltimo);
        }
    }
}
