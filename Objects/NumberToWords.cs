using System;
using System.Collections.Generic;
using System.Text;


namespace NumberToWords
{
  public class Convertor
  {
    Dictionary<int, string> lessThanTwenty = new Dictionary<int,string>()
    {
      {0, "zero"},
      {1, "one"},
      {2, "two"},
      {3, "three"},
      {4, "four"},
      {5, "five"},
      {6, "six"},
      {7, "seven"},
      {8, "eight"},
      {9, "nine"},
      {10, "ten"},
      {11, "eleven"},
      {12, "twelve"},
      {13, "thirteen"},
      {14, "fourteen"},
      {15, "fifteen"},
      {16, "sixteen"},
      {17, "seventeen"},
      {18, "eighteen"},
      {19, "nineteen"}
    };

    Dictionary<int, string> tens = new Dictionary<int,string>()
    {
      {2, "twenty"},
      {3, "thirty"},
      {4, "forty"},
      {5, "fifty"},
      {6, "sixty"},
      {7, "seventy"},
      {8, "eighty"},
      {9, "ninety"}
    };

    private int _num;

    public Convertor(int num)
    {
      _num = num;
    }
    public int GetNum()
    {
      return _num;
    }
    public void SetNum(int newNum)
    {
      _num = newNum;
    }

    // public string Calculate(){
    //   if(_num<1000){
    //     return Translate(_num);
    //   }
    //   else{
    //     return Large();
    //   }
    // }
    // public string Twenty(int i)
    // {
    //   if(i < 20)
    //   {
    //     return lessThanTwenty[i];
    //   }
    //   else
    //   {
    //     return tens[i/10] + " " + lessThanTwenty[i%10];
    //   }
    // }
    // public string Translate(int small)
    // {
    //   if(small<100)
    //   {
    //     return  Twenty(small);
    //   }
    //   else {
    //     return lessThanTwenty[small/100] + " hundred " + Twenty(small%100);
    //   }
    // }
    // public string Large()
    // {
    //   if(_num<=1000000)
    //   {
    //     return Translate(_num/1000) + " thousand " + Translate(_num%1000);
    //   }
    //   else
    //   {
    //     return Translate(_num/1000000) + " million " + Translate(_num%1000000/1000) + " thousand " + Translate(_num%1000);
    //   }
    // }
    public string Calculate()
    {
      return NumberToWords(_num);
    }
    public string NumberToWords(int number)
    {
        if (number == 0)
            return "zero";

        if (number < 0)
            return "minus " + NumberToWords(Math.Abs(number));

        string words = "";

        if ((number / 1000000) > 0)
        {
            words += NumberToWords(number / 1000000) + " million ";
            number %= 1000000;
        }

        if ((number / 1000) > 0)
        {
            words += NumberToWords(number / 1000) + " thousand ";
            number %= 1000;
        }

        if ((number / 100) > 0)
        {
            words += NumberToWords(number / 100) + " hundred ";
            number %= 100;
        }

        if (number > 0)
        {
            if (words != "")
                words += "and ";

            var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (number < 20)
                words += unitsMap[number];
            else
            {
                words += tensMap[number / 10];
                if ((number % 10) > 0)
                    words += "-" + unitsMap[number % 10];
            }
        }

        return words;
    }
  }
}
