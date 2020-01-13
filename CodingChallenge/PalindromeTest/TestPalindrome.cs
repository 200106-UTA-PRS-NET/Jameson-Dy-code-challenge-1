using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeLib;

namespace PalindromeTest
{
    [TestClass]
    public class TestPalindrome
    {
        Palindrome p = new Palindrome();

        [TestMethod]
        public void TestIsPalindromeTrue()
        {
            string[] truePalindromes = {    "nurses run",
                                            "racecaR",
                                             "1221",
                                            "never odd, or even." };
            bool allPalindromes = true;
            foreach (string s in truePalindromes)
            {
                if (!p.IsPalindrome(s))
                    allPalindromes = false;
            }
            bool actual = allPalindromes;

            bool expected = true;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestIsPalindromeFalse()
        {
            string[] falsePalindromes = {"one two one","123abccba123"};
            bool allPalindromes = true;
            foreach (string s in falsePalindromes)
            {
                if (!p.IsPalindrome(s))
                    allPalindromes = false;
            }
            bool actual = allPalindromes;

            bool expected = false;
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void TestInstanceType()
        {
            bool actual = p.IsPalindrome("one two one");
            Assert.IsInstanceOfType(actual, typeof(bool));
        }
    }
}
