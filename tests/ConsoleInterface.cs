using System;
using NUnit.Framework;
using csharp2048;
using System.IO;

namespace Tests
{
    public class ConsoleInterfaceTest
    {
        private ConsoleInterface _consoleUserInterface;
        
        [SetUp]
        public void Setup()
        {
            _consoleUserInterface = new ConsoleInterface();
        }
        
        [Test]
        public void OutputsMessageToConsole()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            var message = "test";
            _consoleUserInterface.Output(message);
            var actual = stringWriter.ToString().Replace(Environment.NewLine, "");
            
            Assert.AreEqual(message, actual);
        }
        
        [Test]
        public void ReadsUserInput()
        {
            var inputString = "1";
            var stringReader = new StringReader(inputString);
            Console.SetIn(stringReader);
            var actual = _consoleUserInterface.ReadInput();

            Assert.AreEqual(inputString, actual);
        } 
    }
}