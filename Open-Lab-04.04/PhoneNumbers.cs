using System;

namespace Open_Lab_04._04
{
    public class PhoneNumbers
    {
        public string FormatPhoneNumber(int[] numbers)
        {
            string d = "";
            string e = "";
            string f = "";
            for (int a = 0; a < 3; a++)
            {
                d = d + numbers[a];
            }
            for (int b = 3; b < 6; b++)
            {
                e = e + numbers[b];
            }
            for (int c = 6; c < 10; c++)
            {
                f = f + numbers[c];
            }
            return ($"({d}) {e}-{f}");
        }
    }
}
