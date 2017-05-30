using Xunit;
namespace Leetspeak.Objects
{
  public class LeetspeakTest
  {
    [Fact]
    public void Translate_InputE_ReturnsThree()
    {
      LeetspeakTranslator newString = new LeetspeakTranslator();
      Assert.Equal("R3d", newString.Translate("Red"));
    }
    [Fact]
    public void Translate_InputO_ReturnsZero()
    {
      LeetspeakTranslator newString = new LeetspeakTranslator();
      Assert.Equal("3pic0dus", newString.Translate("epicodus"));
    }
  }
}

// 3picodus
// epic0dus
