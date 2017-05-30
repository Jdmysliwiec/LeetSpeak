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
    public void Translate_InputT_ReturnSeven()
    {
      LeetspeakTranslator newString = new LeetspeakTranslator();
      Assert.Equal("l3773r", newString.Translate("letter"));
    }
    // [Fact]
    // public void Translate_InputS_ReturnsZ()
    // {
    //   LeetspeakTranslator newString = new LeetspeakTranslator();
    //   Assert.Equal("s3pic0duz", newString.Translate("sepicodus"));
    // }
  }
}

// 3picodus
// epic0dus
