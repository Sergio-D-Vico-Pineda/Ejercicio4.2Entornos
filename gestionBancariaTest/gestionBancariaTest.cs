using Microsoft.VisualStudio.TestTools.UnitTesting;
using gestionBancariaApp;
using System;

namespace gestionBancariaTest
{
    [TestClass]
    public class gestionBancariaTest
    {
        [TestMethod]
        public void ValidarMetodoIngreso()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = 500;
            double saldoActual = 0;
            double saldoEsperado = 1500;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            // Método a probar
            cuenta.realizarIngreso(ingreso);
            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }

        [TestMethod]
        public void ValidarMetodoReintegro()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double reintegro = 500;
            double saldoActual = 0;
            double saldoEsperado = 500;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            // Método a probar
            cuenta.realizarReintegro(reintegro);
            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        } 

        //-------------------------------------------------------------------------------------------//

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ValidarMetodoIngreso1()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = -500;
            double saldoActual = 0;
            double saldoEsperado = 1500;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            cuenta.realizarIngreso(ingreso);
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ValidarMetodoReintegro1()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double reintegro = -500;
            double saldoActual = 0;
            double saldoEsperado = 500;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            cuenta.realizarReintegro(reintegro);
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }

         //-------------------------------------------------------------------------------------------//

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ValidarMetodoIngreso2()
        {
            double saldoInicial = 1000;
            double ingreso = -100;
            double saldoActual = 0;
            double saldoEsperado = 1500;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            cuenta.realizarIngreso(ingreso);
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ValidarMetodoReintegro2()
        {
            double saldoInicial = 1000;
            double reintegro = 1500;
            double saldoActual = 0;
            double saldoEsperado = 500;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            cuenta.realizarReintegro(reintegro);
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }

    }
  

}
