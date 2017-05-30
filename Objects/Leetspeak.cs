using System;

namespace Leetspeak.Objects
{
  public class LeetspeakTranslator
  {

    public string Translate(string userInput)
    {
      string output = userInput.Replace("e", "3");
      output = output.Replace("o", "0");
      output = output.Replace("I", "1");
      output = output.Replace("t", "7");
      Console.WriteLine(output);
      return output;


      }
    }
  }
