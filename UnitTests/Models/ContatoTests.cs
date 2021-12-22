using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ExamplesDotnetFramework.Models;

namespace UnitTests
{
    [TestClass]
    public class ContatoTests
    {
        [TestMethod]
        public void GetNome_NomeEqualFulano_ReturnsTrue()
        {
            // Arrange
            var fulano = new Contato {
                codigo = 1,
                nome = "Fulano",
                telefone = "(11) 99999-9999",
                dataNascimento = new DateTime(1985,06,03)
            };

            // Act
            var expected = "Fulano";
            var actual = fulano.nome;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
