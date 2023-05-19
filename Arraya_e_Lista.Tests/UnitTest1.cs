namespace Arraya_e_Lista.Tests;
using Arraya_e_Lista;
class Test
{
    Calculadora _calculadora; 
    [SetUp]
    public void Setup()
    {
        _calculadora = new Calculadora();
    }
    [Test]
    public void Test1()
    {
        List<int> numeros = new List<int> {1, 2, 3, 4, 5};
        int retornosoma=_calculadora.Soma(numeros);
        Assert.AreEqual(retornosoma,15);
    }
}