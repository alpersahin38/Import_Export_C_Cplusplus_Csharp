using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ce103_hw4_cs_dll
{
    public class ce103_hw4_csharp_code
    {
        /**************************
        * Copyleft (L) 2021 CENG - All Rights Not Reserved
        * You may use, distribute and modify this code.
        **************************/

        /**
       * @file ce103-hw4-cs-dll
       * @author Alper Şahin
       * @date 03 October 2021
       *
       * @brief <b> HW-4 Functions </b>
       *
       * HW-4 Sample Lib Functions
       *
       * @see http://bilgisayar.mmf.erdogan.edu.tr/en/
       *
       */

        /**
	    * @name   fibonacciNumber (ce103_fibonacciNumber_cs)
	    *
	    * @brief Fibonacci Number Calculator
	    *
	    * Calculates the fibonacci number in the given index and return as output
	    *
	    * @param  [in] fiIndex [\b int]  index of fibonacci number in the serie
	    *
	    * @retval [\b int] calculated fibonacci number
	    **/
        public int ce103_fibonacciNumber_csharp(int fiIndex)
        {
            //First, let's define our integers.
            //This if statement implicitly checks "is not 0", so we reverse that to mean "is 0".
            fiIndex = fiIndex - 1;
            int n1 = 0, n2 = 1, nextnumber = 0;
            int result;
            if (fiIndex <= 0)
            {
                return 0;
                // if index is lower than 1 function will return 0
            }
            for (int i = 1; i <= fiIndex; ++i)
            {
                //I used "for" because there are repetitive processes here.
                n1 = n2;
                n2 = nextnumber;
                nextnumber = n1 + n2;
                result = nextnumber;
                if (result < 0)
                {
                    return -2;
                }
            }
            result = nextnumber;
            return result;
        }

        /**
		@name   strrev (ce103_strrev_cs)

		@brief \b Reverse String

		Reverse given string

		@param [in] fiStr [\b string] The given string which is needed to be reversed.

		@retval [\b string] This function returns the string after reversing the given string
	    **/
        public string ce103_strrev_csharp(string Input)
        {
            string reverse = "";
            int len;
            len = Input.Length - 1;
            while (len >= 0)
            {
                reverse = reverse + Input[len];
                len--;
            }
            return reverse;

        }

        /**
		@name   strlen (ce103_strlen_cs)
		@brief \b Get string length

		Returns the length of the C# string str.

		@param [in] fiStr [\b string] the null-terminated byte string to be examined

		@retval [\b int] The length of the null-terminated byte string str.
	    **/
        public int ce103_strlen_csharp(string fiStr)
        {
            //We assign an initial value to the string variable.
            //Null characters are used. The variable '0' is the last term defined for the fiStr char.
            int number = 0;
            foreach (char chr in fiStr)
            {
                number++;
            }
            return number;
        }

        /**
		@name   strcat (ce103_strcat_cs)
		@brief \b Concatenate strings

		In this function, we combine 2 randomly entered strings.
        We give one of our strings "fiDest" and the other "fiSrc", that is, a random string.
        The sum of these strings gives us the combined return value of the strings.


		@param  [in] fiDest [\b string] the null-terminated byte string to append to
		@param  [in] fiSrc  [\b string] the null-terminated byte string to copy from

		@retval [\b string] returns a copy of dest
	    **/
        public string ce103_strcat_csharp(string fiDest, string fiSrc)
        {
            //We are assigning the a,i,d,len1,len2 variables.

            string a = string.Empty;
            int i, d, len1, len2;
            len1 = fiDest.Length;
            len2 = fiSrc.Length;
            for (i = 0; i < len1; i++)
            {
                a = a + fiDest[i];
            }
            for (d = 0; d < len2; d++)
            {
                a = a + fiSrc[d];
            }
            return a;
            //declaring the end of the string
        }

        /**
		@name   strcmp (ce103_strcmp_cs)
		@brief  \b Compare two strings

		Compares two null-terminated byte strings lexicographically.

		@param  [in] fiLhs [\b string] the null-terminated byte strings to compare
		@param  [in] fiRhs [\b string] the null-terminated byte strings to compare

		@retval [\b int] Negative value if lhs appears before rhs in lexicographical order.
				Zero if lhs and rhs compare equal.
				Positive value if lhs appears after rhs in lexicographical order.
	    **/
        public int ce103_strcmp_csharp(string fiLhs, string fiRhs)
        {
            int string1 = 0, string2 = 0;
            //Let's say we have two strings.
            //If they are equal, our return value will be equal to 0.
            for (int i = 0; i < (fiLhs.Length > fiRhs.Length ? fiLhs.Length : fiRhs.Length); i++)
            {
                string1 += (i >= fiLhs.Length ? 0 : fiLhs[i]) - (i >= fiRhs.Length ? 0 : fiRhs[i]);
                if (string2 < 0)
                {
                    if (string1 < 0)
                        string2 += string1;
                    if (string1 > 0)
                        string2 += -string1;
                }
                else
                {
                    string2 += string1;
                }
            }
            return string2;
        }

        /**
	    *
		@name  strcpy (ce103_strcpy_cs)
		@brief \b Copy string

		Copies the C# string pointed by source into the array pointed by destination,
		including the terminating null character (and stopping at that point).

		@param [out] foDestination	[\b string] the destination array where the content is to be copied.
		@param [in]  fiSource		[\b string]	C string to be copied.

		@retval [\b string] returns a copy of dest
	    **/
        public string ce103_strcpy_csharp(string foDestination, string fiSource)
        {
            //this function copies the string in the string pointed to by the source.
            //If the copied string and the other string are equal, the function returns the copied string to us.
            char[] destArr = new char[fiSource.Length];
            char[] srcArr = fiSource.ToCharArray();
            for (int i = 0; i < fiSource.Length; i++)
            {
                destArr[i] = srcArr[i];
            }
            string templateDest = new string(destArr);
            foDestination = templateDest;
            return foDestination;
        }
        /**
        * @name    bin2hex (ce103_bin2hex_cs)
        * 
        * @brief   \b Binary to Hexadecimal Conversion
        *
        * Unpacks alpha numeric value, Example: 0x12 0x34 = "1234".
        *
        * @param [in]  fiBin      [\b byte[]]    Binary data to be converted.
        * 
        * @param [in]  fiBinLen   [\b int]	 Binary data length.
        * 
        * @param [out] foHex      [\b char[]]	 Convertion result as ascii. Doubles the binary length.
        **/
        public void ce103_bin2hex_csharp(byte[] fiBin, int fiBinlen, char[] foHex)
        {
            char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            for (int i = 0; i < fiBinlen; i++)
            {
                foHex[i * 2] = arr[fiBin[i] >> 4];
                foHex[i * 2 + 1] = arr[fiBin[i] & 0x0F];
            }
        }

        /**
        * @name    hex2bin (ce103_hex2bin_cs)
        * 
        * @brief   \b Hexadecimal string to byte array Conversion
        * 
        * Convert hex string to byte array
        *
        * @param   [in]  fiHex    [\b string] Ascii hex string.
        * 
        * @param   [in]  fiHexLen [\b int]     Ascii data length.
        * 
        * @param  [out]  foBin    [\b byte[]]   Convertion result as binary.
        **/
        public void ce103_hex2bin_csharp(string fiHex, int fiHexLen, byte[] foBin)
        {
            int[] number = { 0, 0 };
            for (int i = 0; i < fiHexLen; i += 2)
            {
                char[] template = new char[2];
                int hexint = 0;
                for (int j = 0; j < 2; j++)
                {
                    //This function converts hexadecimal to binary system.
                    template[j] = (char)fiHex[i + j];
                    if (j == 0)
                    {
                        if (template[j] >= '0' && template[j] <= '9')
                        {
                            number[j] = template[j] - '0';
                            number[j] *= 16;
                        }
                        else if (template[j] >= 'A' && template[j] <= 'F')
                        {
                            number[j] = template[j] - 'A' + 10;
                            number[j] *= 16;
                        }
                    }
                    else
                    {
                        if (template[j] >= '0' && template[j] <= '9')
                        {
                            number[j] = template[j] - '0';
                        }
                        else if (template[j] >= 'A' && template[j] <= 'F')
                        {
                            number[j] = template[j] - 'A' + 10;
                        }
                    }
                    hexint += number[j];
                }
                foBin[i / 2] = (byte)hexint;
            }
        }
    }
}



