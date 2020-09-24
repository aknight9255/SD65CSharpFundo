using System;
using System.Collections.Generic;
using _08_StreamingContent_Console.UI;
using _10_StreamingContent_UIRefactor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _10_StreamingContent_UiRefactor_Tests
{
    [TestClass]
    public class ProgramUITests
    {
        [TestMethod]
        public void GetList_OutPutShouldContainList()
        {
            //Arrange 
            List<string> commandList = new List<string> { "1", "6" };
            MockConsole console = new MockConsole(commandList);
            ProgramUI program = new ProgramUI(console);
            //ACT 
            program.Run();
            Console.WriteLine(console.Output);

            //ASSERT
            Assert.IsTrue(console.Output.Contains("Your driver for the night is a baby"));
        }
    }
}
