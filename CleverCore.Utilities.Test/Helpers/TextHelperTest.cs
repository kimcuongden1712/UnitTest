using CleverCore.Utilities.Helpers;
using Xunit;

namespace CleverCore.Utilities.Test.Helpers
{
    public class TextHelperTest
    {
        [Theory]
        [InlineData("TEDU - Học lập trình trực tuyến - TEDU.COM.VN")]
        [InlineData("TEDU -- Học lập trình trực tuyến - TEDU.COM.VN")]
        [InlineData("TEDU - Học lập trình  trực tuyến - TEDU.COM.VN?")]
        public void ToUnsignString_UpperCaseInput_LowerCaseOutput(string input)
        {
            var text = TextHelper.ToUnsignString(input);
            Assert.Equal("tedu-hoc-lap-trinh-truc-tuyen-tedu-com-vn", text);
        }

        [Fact]
        public void ToString_IntegerInput_ShowTextOutput()
        {
            var result = TextHelper.ToString(120);
            Assert.Equal("một trăm hai mươi đồng chẵn", result);
        }

        [Fact]
        public void ToString_ZeroInput_ShowTextOutput()
        {
            var result = TextHelper.ToString(0M);
            Assert.Equal("không đồng chẵn", result);
        }

        [Fact]
        public void ToString_NegativeInput_ShowTextOutput()
        {
            var result = TextHelper.ToString(-12);
            Assert.Equal("Âm mười hai đồng chẵn", result);
        }
    }
}
