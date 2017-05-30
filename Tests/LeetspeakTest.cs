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
    [Fact]
    public void Translat_InputI_ReturnOne()
    {
      LeetspeakTranslator newString = new LeetspeakTranslator();
      Assert.Equal("1c3 Cr3am C0n3", newString.Translate("Ice Cream Cone"));
    }
    [Fact]
    public void Translate_Inputt_ReturnSeven()
    {
      LeetspeakTranslator newString = new LeetspeakTranslator();
      Assert.Equal("l3773r", newString.Translate("letter"));
    }
  }
}

// 3picodus
// epic0dus
