using Xunit;
namespace Leetspeak.Objects
{
  public class LeetspeakTest
  {
    [Fact]
    public void Translate_InputE_ReturnsThree()
    {
      LeetspeakTranslator newString = new LeetspeakTranslator();
      Assert.Equal("3", newString.Translate("e"));
    }
  }
}
