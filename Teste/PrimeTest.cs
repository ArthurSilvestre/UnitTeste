using Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Teste {

    [TestClass]
    public class PrimeTest {

        private readonly PrimeService _primeService;

        public PrimeTest() {
            _primeService = new PrimeService();
        }

        [DataTestMethod]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(4)]
        public void IsPrime(int value) {

            var result = _primeService.IsPrime(value);

            Assert.IsTrue(result, value + " não é primo");

        }

    }

}
