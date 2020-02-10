using System;

namespace Base64Decoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Enter Text to be Decoded : ");
            String s = Console.ReadLine();
            p.Decode(s);
        }





        private void Decode(String txt)
        {

            

            try
            {
                string str = txt.Trim();

                string decoded = String.Empty;

                int strlen = str.Length; 
                int arrsize4ch = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(strlen) / 4)); 
                int cnt4ch = 0; 
                string[] arr4ch = new string[arrsize4ch];
                string fourchars = String.Empty;
                int i = 0, index4ch = 0, index8b = 0;

                for (i = 0; i < strlen; ++i)
                {
                    ++cnt4ch;

                    fourchars += GetBase64(str[i]); 

                    if (cnt4ch == 4)
                    {
                        arr4ch[index4ch] = fourchars;
                        fourchars = String.Empty;
                        cnt4ch = 0;
                        ++index4ch; 
                    }
                }

                if (i == strlen && cnt4ch > 0)
                {
                    arr4ch[index4ch] = fourchars;
                    fourchars = String.Empty;
                    cnt4ch = 0;
                }

                foreach (string s4 in arr4ch)
                {
                    int sLen = s4.Length;
                    int arrsize8b = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(sLen) / 8)); 
                    int cnt8b = 0;
                    string[] arr8b = new string[arrsize8b];
                    string eightbits = String.Empty;

                    for (i = 0, index8b = 0; i < sLen; ++i)
                    {
                        ++cnt8b;

                        eightbits += s4[i];

                        if (cnt8b == 8)
                        {
                            arr8b[index8b] = eightbits;
                            eightbits = String.Empty;
                            cnt8b = 0;
                            ++index8b;
                        }
                    }

                    foreach (string s8 in arr8b)
                    {
                        if (s8 != null)
                            decoded += GetASCII(s8);
                    }
                }

                txt = decoded.Trim();
                Console.WriteLine("Decoded Text : "+txt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private string GetBinary(int dec)
        {
            string binary = String.Empty;
            string temp = String.Empty;

            int cnt = 0, rem = 0;

            for (; dec != 0; ++cnt)
            {
                rem = dec % 2;
                dec = dec / 2;
                temp += rem;
            }
            for (; temp.Length <= 5;)
            {
                temp += "0";
            }

            for (int i = temp.Length - 1; i >= 0; --i)
            {
                binary += temp[i];
            }

            return binary;
        }

        private string GetBase64(char ch)
        {
            string base64binary = String.Empty;

            switch (ch)
            {
                case 'A':
                    base64binary = GetBinary(0);
                    break;
                case 'B':
                    base64binary = GetBinary(1);
                    break;
                case 'C':
                    base64binary = GetBinary(2);
                    break;
                case 'D':
                    base64binary = GetBinary(3);
                    break;
                case 'E':
                    base64binary = GetBinary(4);
                    break;
                case 'F':
                    base64binary = GetBinary(5);
                    break;
                case 'G':
                    base64binary = GetBinary(6);
                    break;
                case 'H':
                    base64binary = GetBinary(7);
                    break;
                case 'I':
                    base64binary = GetBinary(8);
                    break;
                case 'J':
                    base64binary = GetBinary(9);
                    break;
                case 'K':
                    base64binary = GetBinary(10);
                    break;
                case 'L':
                    base64binary = GetBinary(11);
                    break;
                case 'M':
                    base64binary = GetBinary(12);
                    break;
                case 'N':
                    base64binary = GetBinary(13);
                    break;
                case 'O':
                    base64binary = GetBinary(14);
                    break;
                case 'P':
                    base64binary = GetBinary(15);
                    break;
                case 'Q':
                    base64binary = GetBinary(16);
                    break;
                case 'R':
                    base64binary = GetBinary(17);
                    break;
                case 'S':
                    base64binary = GetBinary(18);
                    break;
                case 'T':
                    base64binary = GetBinary(19);
                    break;
                case 'U':
                    base64binary = GetBinary(20);
                    break;
                case 'V':
                    base64binary = GetBinary(21);
                    break;
                case 'W':
                    base64binary = GetBinary(22);
                    break;
                case 'X':
                    base64binary = GetBinary(23);
                    break;
                case 'Y':
                    base64binary = GetBinary(24);
                    break;
                case 'Z':
                    base64binary = GetBinary(25);
                    break;
                case 'a':
                    base64binary = GetBinary(26);
                    break;
                case 'b':
                    base64binary = GetBinary(27);
                    break;
                case 'c':
                    base64binary = GetBinary(28);
                    break;
                case 'd':
                    base64binary = GetBinary(29);
                    break;
                case 'e':
                    base64binary = GetBinary(30);
                    break;
                case 'f':
                    base64binary = GetBinary(31);
                    break;
                case 'g':
                    base64binary = GetBinary(32);
                    break;
                case 'h':
                    base64binary = GetBinary(33);
                    break;
                case 'i':
                    base64binary = GetBinary(34);
                    break;
                case 'j':
                    base64binary = GetBinary(35);
                    break;
                case 'k':
                    base64binary = GetBinary(36);
                    break;
                case 'l':
                    base64binary = GetBinary(37);
                    break;
                case 'm':
                    base64binary = GetBinary(38);
                    break;
                case 'n':
                    base64binary = GetBinary(39);
                    break;
                case 'o':
                    base64binary = GetBinary(40);
                    break;
                case 'p':
                    base64binary = GetBinary(41);
                    break;
                case 'q':
                    base64binary = GetBinary(42);
                    break;
                case 'r':
                    base64binary = GetBinary(43);
                    break;
                case 's':
                    base64binary = GetBinary(44);
                    break;
                case 't':
                    base64binary = GetBinary(45);
                    break;
                case 'u':
                    base64binary = GetBinary(46);
                    break;
                case 'v':
                    base64binary = GetBinary(47);
                    break;
                case 'w':
                    base64binary = GetBinary(48);
                    break;
                case 'x':
                    base64binary = GetBinary(49);
                    break;
                case 'y':
                    base64binary = GetBinary(50);
                    break;
                case 'z':
                    base64binary = GetBinary(51);
                    break;
                case '0':
                    base64binary = GetBinary(52);
                    break;
                case '1':
                    base64binary = GetBinary(53);
                    break;
                case '2':
                    base64binary = GetBinary(54);
                    break;
                case '3':
                    base64binary = GetBinary(55);
                    break;
                case '4':
                    base64binary = GetBinary(56);
                    break;
                case '5':
                    base64binary = GetBinary(57);
                    break;
                case '6':
                    base64binary = GetBinary(58);
                    break;
                case '7':
                    base64binary = GetBinary(59);
                    break;
                case '8':
                    base64binary = GetBinary(60);
                    break;
                case '9':
                    base64binary = GetBinary(61);
                    break;
                case '+':
                    base64binary = GetBinary(62);
                    break;
                case '/':
                    base64binary = GetBinary(63);
                    break;
            }
            return base64binary;
        }

        private char GetASCII(string bin)
        {
            string base64 = String.Empty;
            int dec = 0;

            for (int i = 0, j = (bin.Length - 1); i < bin.Length; ++i, --j)
            {
                dec += Convert.ToInt32(bin[j].ToString()) * Convert.ToInt32(Math.Pow(2, i));
            }

            char ASCII = (char)dec;

            return ASCII;
        }
    }
}
