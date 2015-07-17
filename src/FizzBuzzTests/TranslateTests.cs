using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzLibrary;
using NUnit.Framework;
using Should;

namespace FizzBuzzTests
{
    
    public class TranslateTests
    {
        [Test]
        public void Should_Translate_1_as_1()
        {
            var fizzbuzz = new FizzBuzz();
            fizzbuzz.Translate("1").ShouldEqual("1");
        }
    }
}
