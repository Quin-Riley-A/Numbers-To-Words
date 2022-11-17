using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumToWords.Models;

namespace NumToWords.Tests
{
  [TestClass]
  public class NumToWordsTests
  {
    [TestMethod]
    public void ConvertConstructor_CreatesInstanceOfNumToWords_NumToWords()
    {
      NumConvert numConvertObj = new NumConvert();
      Assert.AreEqual(typeof(NumConvert), numConvertObj.GetType());
    }
  }
}