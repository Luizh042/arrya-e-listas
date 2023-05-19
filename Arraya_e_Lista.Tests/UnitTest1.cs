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
    [Test]
    public void TestMedia()
    {
        List<int> numeros = new List<int> {1, 2, 3, 4, 5};
        int quantidade=5;
        double retornomedia=_calculadora.Media(numeros,quantidade);
        Assert.AreEqual(retornomedia, 3);
    }
     [Test]
    public void TestMedia6Numeros()
    {
        List<int> numeros = new List<int> {1, 2, 3, 4, 5, 6};
        int quantidade=6;
        double retornomedia=_calculadora.Media(numeros,quantidade);
        Assert.AreEqual(retornomedia, 3.5);
    }
      [Test]
    public void TestMedia12Numeros()
    {
        List<int> numeros = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
        int quantidade=12;
        double  test = (1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 + 11 + 12);
        double testmedia = test/quantidade;
        double retornomedia=_calculadora.Media(numeros,quantidade);
        Assert.AreEqual(retornomedia, testmedia);
    }
     [Test]
    public void TestMedia24Numeros()
    {
        List<int> numeros = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
        int quantidade=24;
        double  test = _calculadora.Soma(numeros);
        double testmedia = test/quantidade;
        double retornomedia=_calculadora.Media(numeros,quantidade);
        Assert.AreEqual(retornomedia, testmedia);
    }
     [Test]
    public void TestMedia48Numeros()
    {
        List<int> numeros = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 1, 2, 3, 4, 5, 6, 7,2,4,5,6,7,7,7,7,7,6,6,5,4,6,5,4,32,5,3,5,4,3,5, 8, 9, 10, 11, 12, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
        int quantidade=100;
        double  test = _calculadora.Soma(numeros);
        double testmedia = test/quantidade;
        double retornomedia=_calculadora.Media(numeros,quantidade);
        Assert.AreEqual(retornomedia,testmedia, 0.01,"");
        Console.WriteLine("1" + retornomedia);
        Console.WriteLine("2" + testmedia);
    }
}   