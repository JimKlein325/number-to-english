using Xunit;
using System;

namespace NumberToWords
{
  public class ConvertorTest : IDisposable
  {
    [Fact]
    public void Numbers_less_than20()
    {
      //Arrange
      Convertor con = new Convertor(15);
      //Act
      string result = con.Calculate();
      //Assert
      Assert.Equal("fifteen", result);
    }
    [Fact]
    public void Numbers_less_than100()
    {
      //Arrange
      Convertor con = new Convertor(55);
      //Act
      string result = con.Calculate();
      //Assert
      Assert.Equal("fifty five", result);
    }
    [Fact]
    public void Numbers_less_than1000()
    {
      //Arrange
      Convertor con = new Convertor(556);
      //Act
      string result = con.Calculate();
      //Assert
      Assert.Equal("five hundred fifty six", result);
    }
    [Fact]
    public void Numbers_less_than_million()
    {
      //Arrange
      Convertor con = new Convertor(55688);
      //Act
      string result = con.Calculate();
      //Assert
      Assert.Equal("fifty five thousand six hundred eighty eight", result);
    }
    [Fact]
    public void Numbers_less_than_trillion()
    {
      //Arrange
      Convertor con = new Convertor(99999333);
      //Act
      string result = con.Calculate();
      //Assert
      Assert.Equal("ninety nine million nine hundred ninety nine thousand three hundred thirty three", result);
    }
    [Fact]
    public void Numbers_thousand()
    {
      //Arrange
      Convertor con = new Convertor(100);
      //Act
      string result = con.Calculate();
      //Assert
      Assert.Equal("ninety nine million nine hundred ninety nine thousand three hundred thirty three", result);
    }

    public void Dispose()
    {

    }
  }
}
