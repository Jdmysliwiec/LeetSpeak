using System;

namespace Leetspeak.Objects
{
  public class LeetspeakTranslator
  {

    public string Translate(string userInput)
    {
      if (userInput.Contains("e"))
      {
        string output = userInput.Replace("e", "3");
        Console.WriteLine(output);
        return output;
      }
      else
      {
        return "did not contain e";
      }

      }
    }
  }
