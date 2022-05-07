using Xunit;
using procesador;
using System;

namespace ProcesadorTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("hola que tal", 3)]
        [InlineData("hola", 1)]
        // [InlineData(" ", 0)]
        // [InlineData("", 0)]
        [InlineData("1 } *** \n", 4)]
        public void ContarPalabras_Texto_Exito(string texto, int resultadoEsperado)
        {
            //Arrange
            var sut = new Procesador();

            //Act
            int resultado = sut.ContarPalabras(texto);

            //Assert
            Assert.Equal(resultado, resultadoEsperado);
        }

        [Theory]
        [InlineData("hola que tal.", 3)]
        [InlineData("Pepe juega. Al lol.", 2)]
        [InlineData(".", 0)]
        [InlineData("Pepe juega mucho. Al lol", 2)]
        [InlineData("Pepe juega mucho", 3)]
        public void ContarPalabras_Frase_Exito(string texto, int resultadoEsperado)
        {
            //Arrange
            var sut = new Procesador();

            //Act
            int resultado = sut.ContarPalabras(texto);

            //Assert
            Assert.Equal(resultado, resultadoEsperado);
        }

        [Theory]
        [InlineData("hola que tal.", 3)]
        [InlineData("Pepe juega. Al lol.", 2)]
        [InlineData(".", 0)]
        [InlineData("Pepe juega mucho. Al lol", 3)]
        [InlineData("Pepe juega mucho", 3)]
        public void ContarPalabras_FraseLarga_Exito(string texto, int resultadoEsperado)
        {
            //Arrange
            var sut = new Procesador();

            //Act
            int resultado = sut.ContarPalabras(texto);

            //Assert
            Assert.Equal(resultado, resultadoEsperado);
        }

        [Theory]
        [InlineData(" ")]
        [InlineData("")]
        public void ContarPalabras_Excepción_Exito(string texto)
        {
            //Arrange
            var sut = new Procesador();

            //Act
            var exception = Assert.Throws<Exception>(() => sut.ContarPalabras(texto));

            //Assert
            Assert.Equal("No existe ninguna palabra", exception.Message);
        }
    }
}