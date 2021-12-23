using NUnit.Framework;
using System.Collections;

namespace TestProject1
{
    public class TestDataClass
    {
        public static IEnumerable PhoneTestData
        {
            get
            {
                yield return new TestCaseData("dsfdsfgdfgh");
                yield return new TestCaseData("ds131313");
                yield return new TestCaseData("#######");
                yield return new TestCaseData("#######");
                yield return new TestCaseData(" ");
            }
        }

        public static IEnumerable JsInjectionTestData
        {
            get
            {
                yield return new TestCaseData("alert(\"foo\");");
                yield return new TestCaseData("\\`-alert(\"foo\")-\\`;");
                yield return new TestCaseData("\\\\`-alert(\"foo\")//\\`;");
            }
        }

        public static IEnumerable DateTestData
        {
            get
            {
                yield return new TestCaseData("2021\\11\\31");
                yield return new TestCaseData("2021/11/31");
                yield return new TestCaseData("2021.11.31");
                yield return new TestCaseData("2021:11:30");
                yield return new TestCaseData("2021\\11\\30");
                yield return new TestCaseData("21.11.30");
            }
        }
    }
}
