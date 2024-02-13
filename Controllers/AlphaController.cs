using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AspenDelta.com.Models;

namespace AspenDelta.com.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlphaController : ControllerBase
    {

            //private char[] lower_alpha = new char[26];
            //private char[] upper_alpha = new char[26];
            private char val_alpha = 'a';
            private char[] upper_alpha = new char[26];
            // public char[] upper_alpha { get; set; } = upperAlpha();
            /*  private char[] upperAlpha()
              {
                  var b = 0;
                  char[] upperAlpha = new char[26];
                  for (int i = 65; i < 91; i++)
                  {
                      upperAlpha[b] = (char)i;
                      b++;
                  }
                  return upperAlpha;
              }
            */

            // private int _upperalpha = 7;  // Backing store
            private char[] _upperalpha = new char[26];  // Backing store

            public char[] Upperalpha
            {
                get => _upperalpha;
                set
                {

                    var b = 0;
                    //char[] upperAlphaC = new char[26];
                    for (int i = 65; i < 91; i++)
                    {
                        _upperalpha[b] = (char)i;
                        b++;
                    }
                    //_upperalpha = upperAlphaC;
                    //   if ((value > 0) && (value < 13))
                    //   {
                    //       _upperalpha = value;
                    //   }
                }
            }


            protected virtual void Initialize()
            {
                var b = 0;
                char[] upperAlpha = new char[26];
                for (int i = 65; i < 91; i++)
                {
                    upperAlpha[b] = (char)i;
                    b++;
                }
                // upper_alpha = upperAlpha;

                b = 0;
                char[] lowerAlpha = new char[26];
                for (int i = 97; i < 123; i++)
                {
                    lowerAlpha[b] = (char)i;
                    b++;
                }



                // Console.WriteLine(team["2B"]);
            }


            [HttpGet(Name = "GetAlphaChar")]
            public string GetAlphaChar()
            {
                string result = "";
                /*
                            var b = 0;
                            char[] upperAlpha = new char[26];
                            for (int i = 65; i < 91; i++)
                            {
                                upperAlpha[b] = (char)i;
                                b++;
                            }

                            b = 0;
                            char[] lowerAlpha = new char[26];
                            for (int i = 97; i < 123; i++)
                            {
                                lowerAlpha[b] = (char)i;
                                b++;
                            }
                */
                //upper_alpha = upperAlpha;
                for (int i = 0; i < 26; i++)
                {
                    if ((i % 2) == 0)
                    {

                        //   result += upperAlpha[i];
                        // result += upper_alpha;// upper_alpha[i];
                    }
                    else
                    {

                        // result += lowerAlpha[i];
                        //result += upper_alpha;//lower_alpha[i];
                    }
                }

                result += Upperalpha[6].ToString();

                return result;
                // return this.lower_alpha[5].ToString();
            }

       


    }
}
