using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ce103_hw4_cs_dll;
using System.Text;

namespace ce103_hw4_test
{
    [TestClass]
    public class ce103_hw4_unit_test
    {
        [TestMethod]
        public void ce103_fibonacciNumber_csharp_test_1()
        {
            ce103_hw4_csharp_code fibo = new ce103_hw4_csharp_code();
            int result = fibo.ce103_fibonacciNumber_csharp(1);
            Assert.AreEqual(result, 0);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_csharp_test_2()
        {
            ce103_hw4_csharp_code fibo = new ce103_hw4_csharp_code();
            int result = fibo.ce103_fibonacciNumber_csharp(19);
            Assert.AreEqual(result, 2584);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_csharp_test_3()
        {
            ce103_hw4_csharp_code fibo = new ce103_hw4_csharp_code();
            int result = fibo.ce103_fibonacciNumber_csharp(22);
            Assert.AreEqual(result, 10946);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_imported_csharp_test_1()
        {
            ce103_cpp_imported_csharp fibo = new ce103_cpp_imported_csharp();
            int result = fibo.ce103_fibonacciNumber_csharp_imported(1);
            Assert.AreEqual(result, 0);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_imported_csharp_test_2()
        {
            ce103_cpp_imported_csharp fibo = new ce103_cpp_imported_csharp();
            int result = fibo.ce103_fibonacciNumber_csharp_imported(19);
            Assert.AreEqual(result, 2584);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_imported_csharp_test_3()
        {
            ce103_cpp_imported_csharp fibo = new ce103_cpp_imported_csharp();
            int result = fibo.ce103_fibonacciNumber_csharp_imported(1);
            Assert.AreEqual(result, 0);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_cpp_imported_csharp_test_1()
        {
            ce103_hw4_csharp_code fibo = new ce103_hw4_csharp_code();
            int result = fibo.ce103_fibonacciNumber_csharp(1);
            ce103_cpp_imported_csharp fiboo = new ce103_cpp_imported_csharp();
            int result2 = fiboo.ce103_fibonacciNumber_csharp_imported(1);
            Assert.AreEqual(result, result2);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_cpp_imported_csharp_test_2()
        {
            ce103_hw4_csharp_code fibo = new ce103_hw4_csharp_code();
            int result = fibo.ce103_fibonacciNumber_csharp(19);
            ce103_cpp_imported_csharp fiboo = new ce103_cpp_imported_csharp();
            int result2 = fiboo.ce103_fibonacciNumber_csharp_imported(19);
            Assert.AreEqual(result, result2);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_cpp_imported_csharp_test_3()
        {
            ce103_hw4_csharp_code fibo = new ce103_hw4_csharp_code();
            int result = fibo.ce103_fibonacciNumber_csharp(22);
            ce103_cpp_imported_csharp fiboo = new ce103_cpp_imported_csharp();
            int result2 = fiboo.ce103_fibonacciNumber_csharp_imported(22);
            Assert.AreEqual(result, result2);
        }
        [TestMethod]
        public void ce103_strrev_csharp_test_1()
        {
            ce103_hw4_csharp_code strrev = new ce103_hw4_csharp_code();
            Assert.AreEqual(strrev.ce103_strrev_csharp("Alper"), "replA");
        }
  
        [TestMethod]
        public void ce103_strrev_csharp_test_2()
        {
            ce103_hw4_csharp_code strrev = new ce103_hw4_csharp_code();
            Assert.AreEqual(strrev.ce103_strrev_csharp("Hello"), "olleH");
        }
        [TestMethod]
        public void ce103_strrev_csharp_test_3()
        {
            ce103_hw4_csharp_code strrev = new ce103_hw4_csharp_code();
            Assert.AreEqual(strrev.ce103_strrev_csharp("Hello Alper"), "replA olleH");         
        }
        [TestMethod]
        public void ce103_strrev_imported_csharp_test_1()
        {
            ce103_cpp_imported_csharp strrev = new ce103_cpp_imported_csharp();
            Assert.AreEqual(strrev.ce103_strrev_csharp_imported("Alper"), "replA");
        }
        [TestMethod]
        public void ce103_strrev_imported_csharp_test_2()
        {
            ce103_cpp_imported_csharp strrev = new ce103_cpp_imported_csharp();
            Assert.AreEqual(strrev.ce103_strrev_csharp_imported("Hello"), "olleH");
        }
        [TestMethod]
        public void ce103_strrev_imported_csharp_test_3()
        {
            ce103_cpp_imported_csharp strrev = new ce103_cpp_imported_csharp();
            Assert.AreEqual(strrev.ce103_strrev_csharp_imported("Hello Alper"), "replA olleH");
        }
        [TestMethod]
        public void ce103_strrev_cpp_imported_csharp_test_1()
        {
            ce103_hw4_csharp_code strrev = new ce103_hw4_csharp_code();
            ce103_cpp_imported_csharp Strrev = new ce103_cpp_imported_csharp();
            Assert.AreEqual(strrev.ce103_strrev_csharp("Alper"), "replA", Strrev.ce103_strrev_csharp_imported("Alper"), "replA");
        }
        [TestMethod]
        public void ce103_strrev_cpp_imported_csharp_test_2()
        {
            ce103_hw4_csharp_code strrev = new ce103_hw4_csharp_code();
            ce103_cpp_imported_csharp Strrev = new ce103_cpp_imported_csharp();
            Assert.AreEqual(strrev.ce103_strrev_csharp("Hello"), "olleH", Strrev.ce103_strrev_csharp_imported("New World"), "dlrow weN");
        }
        [TestMethod]
        public void ce103_strrev_cpp_imported_csharp_test_3()
        {
            ce103_hw4_csharp_code strrev = new ce103_hw4_csharp_code();
            ce103_cpp_imported_csharp Strrev = new ce103_cpp_imported_csharp();
            Assert.AreEqual(strrev.ce103_strrev_csharp("Hello Alper"), "replA olleH", Strrev.ce103_strrev_csharp_imported("HelloWorld"), "dlroWolleH");
        }
        [TestMethod]
        public void ce103_strlen_csharp_test_1()
        {
            ce103_hw4_csharp_code strlen = new ce103_hw4_csharp_code();
            Assert.AreEqual(strlen.ce103_strlen_csharp("Alper"), 5);
        }

        [TestMethod]
        public void ce103_strlen_csharp_test_2()
        {
            ce103_hw4_csharp_code strlen = new ce103_hw4_csharp_code();
            Assert.AreEqual(strlen.ce103_strlen_csharp("Alper Sahin"), 11);
        }
    
        [TestMethod]
        public void ce103_strlen_csharp_test_3()
        {
            ce103_hw4_csharp_code strlen = new ce103_hw4_csharp_code();
            Assert.AreEqual(strlen.ce103_strlen_csharp("Hello Sir"), 9);
        }
        [TestMethod]
        public void ce103_strlen_imported_csharp_test_1()
        {
            ce103_cpp_imported_csharp strlen = new ce103_cpp_imported_csharp();
            Assert.AreEqual(strlen.ce103_strlen_csharp_imported("Alper"), 5);
        }
        [TestMethod]
        public void ce103_strlen_imported_csharp_test_2()
        {
            ce103_cpp_imported_csharp strlen = new ce103_cpp_imported_csharp();
            Assert.AreEqual(strlen.ce103_strlen_csharp_imported("Alper Sahin"), 11);
        }
        [TestMethod]
        public void ce103_strlen_imported_csharp_test_3()
        {
            ce103_cpp_imported_csharp strlen = new ce103_cpp_imported_csharp();
            Assert.AreEqual(strlen.ce103_strlen_csharp_imported("Hello Sir"), 9);
        }
        [TestMethod]
        public void ce103_strlen_cpp_imported_csharp_test_1()
        {
            ce103_hw4_csharp_code strlen = new ce103_hw4_csharp_code();
            ce103_cpp_imported_csharp Strlen = new ce103_cpp_imported_csharp();
            Assert.AreEqual(strlen.ce103_strlen_csharp("Alper"), 5, Strlen.ce103_strlen_csharp_imported("Alper"));
        }
        [TestMethod]
        public void ce103_strlen_cpp_imported_csharp_test_2()
        {
            ce103_hw4_csharp_code strlen = new ce103_hw4_csharp_code();
            ce103_cpp_imported_csharp Strlen = new ce103_cpp_imported_csharp();
            Assert.AreEqual(strlen.ce103_strlen_csharp("Alper Sahin"), 11, Strlen.ce103_strlen_csharp_imported("Alper Sahin"));
        }
        [TestMethod]
        public void ce103_strlen_cpp_imported_csharp_test_3()
        {
            ce103_hw4_csharp_code strlen = new ce103_hw4_csharp_code();
            ce103_cpp_imported_csharp Strlen = new ce103_cpp_imported_csharp();
            Assert.AreEqual(strlen.ce103_strlen_csharp("Hello Sir"), 9, Strlen.ce103_strlen_csharp_imported("Hello Sir"));
        }
        [TestMethod]
        public void ce103_strcat_csharp_test_1()
        {
            ce103_hw4_csharp_code strcat = new ce103_hw4_csharp_code();
            Assert.AreEqual(strcat.ce103_strcat_csharp("Hello","Sir"),"HelloSir");
        }
  
        [TestMethod]
        public void ce103_strcat_csharp_test_2()
        {
            ce103_hw4_csharp_code strcat = new ce103_hw4_csharp_code();
            Assert.AreEqual(strcat.ce103_strcat_csharp("What","are"),"Whatare");
        }
 
        [TestMethod]
        public void ce103_strcat_csharp_test_3()
        {
            ce103_hw4_csharp_code strcat = new ce103_hw4_csharp_code();
            Assert.AreEqual(strcat.ce103_strcat_csharp("you","doing"),"youdoing");
        }
        [TestMethod]
        public void ce103_strcat_imported_csharp_test_1()
        {
            ce103_cpp_imported_csharp strcat = new ce103_cpp_imported_csharp();
            Assert.AreEqual(strcat.ce103_strcat_csharp_imported("Hello", "Sir"), "HelloSir");
        }
        [TestMethod]
        public void ce103_strcat_imported_csharp_test_2()
        {
            ce103_cpp_imported_csharp strcat = new ce103_cpp_imported_csharp();
            Assert.AreEqual(strcat.ce103_strcat_csharp_imported("What", "are"), "Whatare");
        }
        [TestMethod]
        public void ce103_strcat_imported_csharp_test_3()
        {
            ce103_cpp_imported_csharp strcat = new ce103_cpp_imported_csharp();
            Assert.AreEqual(strcat.ce103_strcat_csharp_imported("you", "doing"), "youdoing");
        }
        [TestMethod]
        public void ce103_strcat_cpp_imported_csharp_test_1()
        {
            ce103_hw4_csharp_code strcat = new ce103_hw4_csharp_code();
            ce103_cpp_imported_csharp Strcat = new ce103_cpp_imported_csharp();
            Assert.AreEqual(strcat.ce103_strcat_csharp("Hello", "Sir"), "HelloSir", Strcat.ce103_strcat_csharp_imported("Hello", "Sir"), "HelloSir");
        }
        [TestMethod]
        public void ce103_strcat_cpp_imported_csharp_test_2()
        {
            ce103_hw4_csharp_code strcat = new ce103_hw4_csharp_code();
            ce103_cpp_imported_csharp Strcat = new ce103_cpp_imported_csharp();
            Assert.AreEqual(strcat.ce103_strcat_csharp("What", "are"), "Whatare", Strcat.ce103_strcat_csharp_imported("What", "are"), "Whatare");
        }
        [TestMethod]
        public void ce103_strcat_cpp_imported_csharp_test_3()
        {
            ce103_hw4_csharp_code strcat = new ce103_hw4_csharp_code();
            ce103_cpp_imported_csharp Strcat = new ce103_cpp_imported_csharp();
            Assert.AreEqual(strcat.ce103_strcat_csharp("you", "doing"), "youdoing", Strcat.ce103_strcat_csharp_imported("you", "doing"), "youdoing");
        }
        [TestMethod]
        public void ce103_strcmp_csharp_test_1()
        {
            ce103_hw4_csharp_code strcmp = new ce103_hw4_csharp_code();
            Assert.AreEqual(strcmp.ce103_strcmp_csharp("Computer", "Computer"), 0);
        }
 
        [TestMethod]
        public void ce103_strcmp_csharp_test_2()
        {
            ce103_hw4_csharp_code strcmp = new ce103_hw4_csharp_code();
            Assert.AreNotEqual(strcmp.ce103_strcmp_csharp("Hello", "Sir"), 0);
        }

        [TestMethod]
        public void ce103_strcmp_csharp_test_3()
        {
            ce103_hw4_csharp_code strcmp = new ce103_hw4_csharp_code();
            Assert.AreNotEqual(strcmp.ce103_strcmp_csharp("Hello", "World"), 0);
        }
        [TestMethod]
        public void ce103_strcmp_imported_csharp_test_1()
        {
            ce103_cpp_imported_csharp strcmp = new ce103_cpp_imported_csharp();
            Assert.AreEqual(strcmp.ce103_strcmp_csharp_imported("Computer", "Computer"), 0);
        }
        [TestMethod]
        public void ce103_strcmp_imported_csharp_test_2()
        {
            ce103_cpp_imported_csharp strcmp = new ce103_cpp_imported_csharp();
            Assert.AreNotEqual(strcmp.ce103_strcmp_csharp_imported("Hello", "Sir"), 0);
        }
        [TestMethod]
        public void ce103_strcmp_imported_csharp_test_3()
        {
            ce103_cpp_imported_csharp strcmp = new ce103_cpp_imported_csharp();
            Assert.AreNotEqual(strcmp.ce103_strcmp_csharp_imported("Hello", "World"), 0);
        }
        [TestMethod]
        public void ce103_strcmp_cpp_imported_csharp_test_1()
        {
            ce103_hw4_csharp_code strcmp = new ce103_hw4_csharp_code();
            ce103_cpp_imported_csharp Strcmp = new ce103_cpp_imported_csharp();
            Assert.AreEqual(strcmp.ce103_strcmp_csharp("Computer", "Computer"), 0, Strcmp.ce103_strcmp_csharp_imported("Computer", "Computer"));
        }
        [TestMethod]
        public void ce103_strcmp_cpp_imported_csharp_test_2()
        {
            ce103_hw4_csharp_code strcmp = new ce103_hw4_csharp_code();
            ce103_cpp_imported_csharp Strcmp = new ce103_cpp_imported_csharp();
            Assert.AreNotEqual(strcmp.ce103_strcmp_csharp("Hello", "Sir"), 0, Strcmp.ce103_strcmp_csharp_imported("Computer", "Engineering"));
        }
        [TestMethod]
        public void ce103_strcmp_cpp_imported_csharp_test_3()
        {
            ce103_hw4_csharp_code strcmp = new ce103_hw4_csharp_code();
            ce103_cpp_imported_csharp Strcmp = new ce103_cpp_imported_csharp();
            Assert.AreNotEqual(strcmp.ce103_strcmp_csharp("Hello", "World"), 0, Strcmp.ce103_strcmp_csharp_imported("Hello", "World"));
        }
        [TestMethod]
        public void ce103_strcpy_csharp_test_1()
        {
            ce103_hw4_csharp_code strcpy = new ce103_hw4_csharp_code();
            Assert.AreEqual(strcpy.ce103_strcpy_csharp("Alper", "Sahin"), "Sahin");
        }
        [TestMethod]
        public void ce103_strcpy_csharp_test_2()
        {
            ce103_hw4_csharp_code strcpy = new ce103_hw4_csharp_code();
            Assert.AreEqual(strcpy.ce103_strcpy_csharp("Quantum", "Computer"), "Computer");
        }
        [TestMethod]
        public void ce103_strcpy_csharp_test_3()
        {
            ce103_hw4_csharp_code strcpy = new ce103_hw4_csharp_code();
            Assert.AreEqual(strcpy.ce103_strcpy_csharp("Cyber", "Security"), "Security");
        }       
        [TestMethod]
        public void ce103_strcpy_imported_csharp_test_1()
        {
            ce103_cpp_imported_csharp strcpy = new ce103_cpp_imported_csharp();
            Assert.AreEqual(strcpy.ce103_strcpy_csharp_imported("Alper", "Sahin"), "Sahin");
        }
        [TestMethod]
        public void ce103_strcpy_imported_csharp_test_2()
        {
            ce103_cpp_imported_csharp strcpy = new ce103_cpp_imported_csharp();
            Assert.AreEqual(strcpy.ce103_strcpy_csharp_imported("Quantum", "Computer"), "Computer");
        }
        [TestMethod]
        public void ce103_strcpy_imported_csharp_test_3()
        {
            ce103_cpp_imported_csharp strcpy = new ce103_cpp_imported_csharp();
            Assert.AreEqual(strcpy.ce103_strcpy_csharp_imported("Cyber", "Security"), "Security");
        }
        [TestMethod]
        public void ce103_strcpy_cpp_imported_csharp_test_1()
        {
            ce103_hw4_csharp_code strcpy = new ce103_hw4_csharp_code();
            ce103_cpp_imported_csharp Strcpy = new ce103_cpp_imported_csharp();
            Assert.AreEqual(strcpy.ce103_strcpy_csharp("Alper", "Sahin"), "Sahin", Strcpy.ce103_strcpy_csharp_imported("Computer", "Hi"), "Hi");
        }
        [TestMethod]
        public void ce103_strcpy_cpp_imported_csharp_test_2()
        {
            ce103_hw4_csharp_code strcpy = new ce103_hw4_csharp_code();
            ce103_cpp_imported_csharp Strcpy = new ce103_cpp_imported_csharp();
            Assert.AreEqual(strcpy.ce103_strcpy_csharp("Quantum", "Computer"), "Computer", Strcpy.ce103_strcpy_csharp_imported("Quantum", "Computer"), "Computer");
        }
        [TestMethod]
        public void ce103_strcpy_cpp_imported_csharp_test_3()
        {
            ce103_hw4_csharp_code strcpy = new ce103_hw4_csharp_code();
            ce103_cpp_imported_csharp Strcpy = new ce103_cpp_imported_csharp();
            Assert.AreEqual(strcpy.ce103_strcpy_csharp("Cyber", "Security"), "Security", Strcpy.ce103_strcpy_csharp_imported("Cyber", "Security"), "Security");
        }
        [TestMethod]
        public void ce103_bin2hex_csharp_test1()
        {
            ce103_hw4_csharp_code bin2hex = new ce103_hw4_csharp_code();
            byte[] bin = { 0xAB, 0xBC, 0xCD, 0xDE, 0xEF, 0x14 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { 'A', 'B', 'B', 'C', 'C', 'D', 'D', 'E', 'E', 'F', '1', '4' };
            bin2hex.ce103_bin2hex_csharp(bin, bin.Length, hexstring2);
            CollectionAssert.AreEqual(hexstring, hexstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_csharp_test2()
        {
            ce103_hw4_csharp_code bin2hex = new ce103_hw4_csharp_code();
            byte[] bin = { 0xAA, 0xAA, 0xAA, 0xAA, 0xAA };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A' };
            bin2hex.ce103_bin2hex_csharp(bin, bin.Length, hexstring2);
            CollectionAssert.AreEqual(hexstring, hexstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_csharp_test3()
        {
            ce103_hw4_csharp_code bin2hex = new ce103_hw4_csharp_code();
            byte[] bin = { 0xEB, 0xEB, 0xEB, 0x12, 0x12, 0x41, 0x66, 0xFB };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { 'E', 'B', 'E', 'B', 'E', 'B', '1', '2', '1', '2', '4', '1', '6', '6', 'F', 'B' };
            bin2hex.ce103_bin2hex_csharp(bin, bin.Length, hexstring2);
            CollectionAssert.AreEqual(hexstring, hexstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_imported_csharp_test1()
        {
            ce103_cpp_imported_csharp imported = new ce103_cpp_imported_csharp();
            byte[] bin = { 0xAB, 0xBC, 0xCD, 0xDE, 0xEF, 0x14 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { 'A', 'B', 'B', 'C', 'C', 'D', 'D', 'E', 'E', 'F', '1', '4' };
            imported.ce103_bin2hex_csharp_imported(bin, bin.Length, hexstring2);
            CollectionAssert.AreEqual(hexstring, hexstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_imported_csharp_test2()
        {
            ce103_cpp_imported_csharp imported = new ce103_cpp_imported_csharp();
            byte[] bin = { 0xAA, 0xAA, 0xAA, 0xAA, 0xAA };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A' };
            imported.ce103_bin2hex_csharp_imported(bin, bin.Length, hexstring2);
            CollectionAssert.AreEqual(hexstring, hexstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_imported_csharp_test3()
        {
            ce103_cpp_imported_csharp imported = new ce103_cpp_imported_csharp();
            byte[] bin = { 0xEB, 0xEB, 0xEB, 0x12, 0x12, 0x41, 0x66, 0xFB };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { 'E', 'B', 'E', 'B', 'E', 'B', '1', '2', '1', '2', '4', '1', '6', '6', 'F', 'B' };
            imported.ce103_bin2hex_csharp_imported(bin, bin.Length, hexstring2);
            CollectionAssert.AreEqual(hexstring, hexstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_cpp_imported_csharp_test1()
        {
            ce103_hw4_csharp_code bin2hex = new ce103_hw4_csharp_code();
            ce103_cpp_imported_csharp imported = new ce103_cpp_imported_csharp();
            byte[] bin = { 0xAB, 0xBC, 0xCD, 0xDE, 0xEF, 0x14 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring1 = new char[bin.Length * 2];
            bin2hex.ce103_bin2hex_csharp(bin, bin.Length, hexstring1);
            imported.ce103_bin2hex_csharp_imported(bin, bin.Length, hexstring2);
            CollectionAssert.AreEqual(hexstring1, hexstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_cpp_imported_csharp_test2()
        {
            ce103_hw4_csharp_code bin2hex = new ce103_hw4_csharp_code();
            ce103_cpp_imported_csharp imported = new ce103_cpp_imported_csharp();
            byte[] bin = { 0xAA, 0xAA, 0xAA, 0xAA, 0xAA };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring1 = new char[bin.Length * 2];
            bin2hex.ce103_bin2hex_csharp(bin, bin.Length, hexstring1);
            imported.ce103_bin2hex_csharp_imported(bin, bin.Length, hexstring2);
            CollectionAssert.AreEqual(hexstring1, hexstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_cpp_imported_csharp_test3()
        {
            ce103_hw4_csharp_code bin2hex = new ce103_hw4_csharp_code();
            ce103_cpp_imported_csharp imported = new ce103_cpp_imported_csharp();
            byte[] bin = { 0xEB, 0xEB, 0xEB, 0x12, 0x12, 0x41, 0x66, 0xFB };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring1 = new char[bin.Length * 2];
            bin2hex.ce103_bin2hex_csharp(bin, bin.Length, hexstring1);
            imported.ce103_bin2hex_csharp_imported(bin, bin.Length, hexstring2);
            CollectionAssert.AreEqual(hexstring1, hexstring2);
        }
        [TestMethod]
        public void ce103_hex2bin_csharp_test1()
        {
            ce103_hw4_csharp_code hex2bin = new ce103_hw4_csharp_code();
            string hexstring = "1010101010101010";
            byte[] expectedArr = { 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_csharp(hexstring, hexstring.Length, hexArr);
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }
        [TestMethod]
        public void ce103_hex2bin_csharp_test2()
        {
            ce103_hw4_csharp_code hex2bin = new ce103_hw4_csharp_code();
            string hexstring = "ABABABA414141414";
            byte[] expectedArr = { 0xAB, 0xAB, 0xAB, 0xA4, 0x14, 0x14, 0x14, 0x14 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_csharp(hexstring, hexstring.Length, hexArr);
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }
        [TestMethod]
        public void ce103_hex2bin_csharp_test3()
        {
            ce103_hw4_csharp_code hex2bin = new ce103_hw4_csharp_code();
            string hexstring = "ABABABABABABABAB";
            byte[] expectedArr = { 0xAB, 0xAB, 0xAB, 0xAB, 0xAB, 0xAB, 0xAB, 0xAB };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_csharp(hexstring, hexstring.Length, hexArr);
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }
        [TestMethod]
        public void ce103_hex2bin_imported_csharp_test1()
        {
            ce103_cpp_imported_csharp hex2bin = new ce103_cpp_imported_csharp();
            string hexstring = "1010101010101010";
            byte[] expectedArr = { 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_csharp_imported(hexstring, hexstring.Length, hexArr);
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }
        [TestMethod]
        public void ce103_hex2bin_imported_csharp_test2()
        {
            ce103_cpp_imported_csharp hex2bin = new ce103_cpp_imported_csharp();
            string hexstring = "ABABABA414141414";
            byte[] expectedArr = { 0xAB, 0xAB, 0xAB, 0xA4, 0x14, 0x14, 0x14, 0x14 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_csharp_imported(hexstring, hexstring.Length, hexArr);
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }
        [TestMethod]
        public void ce103_hex2bin_imported_csharp_test3()
        {
            ce103_cpp_imported_csharp hex2bin = new ce103_cpp_imported_csharp();
            string hexstring = "ABABABABABABABAB";
            byte[] expectedArr = { 0xAB, 0xAB, 0xAB, 0xAB, 0xAB, 0xAB, 0xAB, 0xAB };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_csharp_imported(hexstring, hexstring.Length, hexArr);
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }
        [TestMethod]
        public void ce103_hex2bin_cpp_imported_csharp_test1()
        {
            ce103_cpp_imported_csharp imported = new ce103_cpp_imported_csharp();
            ce103_hw4_csharp_code hex2bin = new ce103_hw4_csharp_code();
            string hexstring = "ACACACACAC";
            byte[] hexArr = new byte[hexstring.Length / 2];
            imported.ce103_hex2bin_csharp_imported(hexstring, hexstring.Length, hexArr);
            byte[] hexArr2 = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_csharp(hexstring, hexstring.Length, hexArr2);
            CollectionAssert.AreEqual(hexArr, hexArr2);
        }
        [TestMethod]
        public void ce103_hex2bin_cpp_imported_csharp_test2()
        {
            ce103_cpp_imported_csharp imported = new ce103_cpp_imported_csharp();
            ce103_hw4_csharp_code hex2bin = new ce103_hw4_csharp_code();
            string hexstring = "DADADADADA";
            byte[] expectedArr = { 0xAB, 0xDA, 0xBD};
            byte[] hexArr = new byte[hexstring.Length / 2];
            imported.ce103_hex2bin_csharp_imported(hexstring, hexstring.Length, hexArr);
            byte[] hexArr2 = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_csharp(hexstring, hexstring.Length, hexArr2);
            CollectionAssert.AreEqual(hexArr, hexArr2);
        }
        [TestMethod]
        public void ce103_hex2bin_cpp_imported_csharp_test3()
        {
            ce103_cpp_imported_csharp imported = new ce103_cpp_imported_csharp();
            ce103_hw4_csharp_code hex2bin = new ce103_hw4_csharp_code();
            string hexstring = "98AD451236FDDD";
            byte[] expectedArr = { 0x98, 0xAD, 0x45, 0x12, 0x36, 0xFD, 0xDD };
            byte[] hexArr = new byte[hexstring.Length / 2];
            imported.ce103_hex2bin_csharp_imported(hexstring, hexstring.Length, hexArr);
            byte[] hexArr2 = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_csharp(hexstring, hexstring.Length, hexArr2);
            CollectionAssert.AreEqual(hexArr, hexArr2);
        }
    }
}
