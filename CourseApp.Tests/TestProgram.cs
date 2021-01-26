using System;
using Xunit;

namespace CourseApp.Tests
{
    public class TestProgram
    {
        [Fact]
        public void TestCommas()
        {
            string s = ",,, ;;; .. qwe rty";
            string exp = "rty qwe .. ;;; ,,,";
            Assert.Equal(exp, Program.ReversedString(s));
        }

        [Fact]
        public void TestNumbers()
        {
            string s = "123 4 5 test";
            string exp = "test 5 4 123";
            Assert.Equal(exp, Program.ReversedString(s));
        }

        [Fact]
        public void TestString()
        {
            string s = "Better late than never";
            string exp = "never than late Better";
            Assert.Equal(exp, Program.ReversedString(s));
        }

        [Fact]
        public void TestRussian()
        {
            string s = "Все хорошо, что хорошо кончается.";
            string exp = "кончается. хорошо что хорошо, Все";
            Assert.Equal(exp, Program.ReversedString(s));
        }
    }
}
