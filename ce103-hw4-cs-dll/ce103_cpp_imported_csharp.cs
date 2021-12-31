using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ce103_hw4_cs_dll
{
    public class ce103_cpp_imported_csharp
    {
        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ce103_fibonacciNumber_cpp(int fiIndex);

        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ce103_strrev_cpp( char[] fiStr);

        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ce103_strlen_cpp(string fiStr);

        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ce103_strcat_cpp(char[] fiDest, char[] fiSrc);

        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ce103_strcmp_cpp(string fiLhs, string fiRhs);

        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ce103_strcpy_cpp(char[] foDestination, char[] fiSource);

        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ce103_hex2bin_cpp(string fiHex, int fiHexLen, byte[] foBin);

        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ce103_bin2hex_cpp([In] byte[] fiBin, int fiBinLen, [Out] char[] foHex);


        /**
        *
        *	  @name   fibonacciNumber (ce103_fibonacciNumber_cs_imported)
        *
        *	  @brief Fibonacci Number Calculator
        *
        *	  Calculates the fibonacci number in the given index and return as output
        *
        *	  @param  [in] fiIndex [\b int]  index of fibonacci number in the serie
        *
        *	  @retval [\b int] ce103_fibonacciNumber_cpp
        **/
        public int ce103_fibonacciNumber_csharp_imported(int fiIndex)
        {
            return ce103_fibonacciNumber_cpp(fiIndex);
        }

       

        private static string pointertostring(IntPtr pointer) 
        {
            if (pointer == IntPtr.Zero)
                return "";
            int len = 0;
            while (System.Runtime.InteropServices.Marshal.ReadByte(pointer, len) != 0)
                len++;
            if (len == 0)
                return "";
            byte[] array = new byte[len];
            System.Runtime.InteropServices.Marshal.Copy(pointer, array, 0, len);
            return System.Text.Encoding.UTF8.GetString(array);
        }
        /**
           @name   strrev (ce103_strrev_cs_imported)

           @brief \b Reverse string

           Reverse given string

           @param [in] fiStr [\b string] The given string which is needed to be reversed.

           @retval [\b string] ce103_strrev_cpp
        **/

        public string ce103_strrev_csharp_imported(string fiStr)
        {

            var d = fiStr.ToCharArray();
            var e = new char[fiStr.Length+1];
            for (int i = 0; i < d.Length; i++)
            {
                e[i] = d[i];
            }
            e[fiStr.Length] = '\0';
            var x = ce103_strrev_cpp(e); 
            return pointertostring(x);
        }

        /**
	        @name   strlen (ce103_strlen_cs_imported)

	        @brief \b Get string length

            Get length of a string

	        Returns the length of the C sharp string str.

	        @param [in] fiStr [\b string] given string

	        @retval [\b int] ce103_strlen_cpp
        **/
        public int ce103_strlen_csharp_imported(string fiStr)
        {
            return ce103_strlen_cpp(fiStr);
        }

        /**
            @name   strcat (ce103_strcat_cs_imported)

            @brief \b Concatenate strings

            Concatenate two strings

            @param  [in] fiDest [\b string] will be appended string

            @param  [in] fiSrc  [\b string] will be copy from this

            @retval [\b string] ce103_strcat_cpp
        **/
        public string ce103_strcat_csharp_imported(string fiDest, string fiSrc)
        {
            var d = fiDest.ToCharArray();
            var e = new char[fiDest.Length + 1];
            for (int i = 0; i < d.Length; i++)
            {
                e[i] = d[i];
            }
            e[fiDest.Length] = '\0';

            var c = fiSrc.ToCharArray();
            var w = new char[fiSrc.Length + 1];
            for (int i = 0; i <c.Length; i++)
            {
                w[i] = c[i];
            }
            w[fiSrc.Length] = '\0';
            var x = ce103_strcat_cpp(e,w);
            return pointertostring(x);
        }

        /**
            @name   strcmp (ce103_strcmp_cs_imported)

            @brief  \b Compare two strings

            Compare two strings

            @param  [in] fiLhs [\b string] string to compare

            @param  [in] fiRhs [\b string] string to compare

            @retval [\b int] ce103_strcmp_cpp
        **/
        public int ce103_strcmp_csharp_imported(string fiLhs, string fiRhs)
        {
            return ce103_strcmp_cpp(fiLhs, fiRhs);
        }

        /**
            @name  strcpy (ce103_strcpy_cs_imported)

            @brief \b Copy string

            Copy string to another

            @param [out] foDestination	[\b string] destination string to copy

            @param [in]  fiSource		[\b string]	C sharp string to be copied.

            @retval [\b string] ce103_strcpy_cpp
        **/
        public string ce103_strcpy_csharp_imported(string foDestination, string fiSource)
        {
            var d = foDestination.ToCharArray();
            var e = new char[foDestination.Length + 1];
            for (int i = 0; i < d.Length; i++)
            {
                e[i] = d[i];
            }
            e[foDestination.Length] = '\0';
            var f = fiSource.ToCharArray();
            var w = new char[fiSource.Length + 1];
            for (int i = 0; i < f.Length; i++)
            {
                w[i] = f[i];
            }
            w[fiSource.Length] = '\0';
            var x = ce103_strcpy_cpp(e, w);
            return pointertostring(x);
        }

        /**
         * @name    hex2bin (ce103_hex2bin_cs_imported)
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
        public void ce103_hex2bin_csharp_imported(string fiHex, int fiHexLen, byte[] foBin)
        {
            ce103_hex2bin_cpp(fiHex, fiHexLen, foBin);
        }

        /**
        * @name    bin2hex (ce103_bin2hex_cs_imported)
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
        public void ce103_bin2hex_csharp_imported([In] byte[] fiBin, int fiBinLen, [Out] char[] foHex)
        {
            ce103_bin2hex_cpp(fiBin, fiBinLen, foHex);
        }
    }
}
