using System;

namespace Leetspeak.Objects
{
  public class LeetspeakTranslator
  {

    public string Translate(string userInput)
    {
      string output = userInput.Replace("e", "3");
      output = output.Replace("o", "0");

      Console.WriteLine(output);
      return output;

      // if (userInput.Contains("e"))
      // {
      //   string output = userInput.Replace("e", "3");
      //
      // }
      // else
      // {
      //   return "did not contain e or o";
      // }



      }
    }
  }
