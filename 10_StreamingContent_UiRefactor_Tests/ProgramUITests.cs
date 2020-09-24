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
        [TestMethod]
        public void AddToList_ShouldSeeItemInList()
        {
            //arrange 
            var customDesc = "This is my custom thoughts on this movie";
            var commandList = new List<string>
            {
                "3",
                "This is the title",
                customDesc,
                "42",
                "3",
                "4",
                "1",
                "6"
            };
            var mockConsole = new MockConsole(commandList);
            var ui = new ProgramUI(mockConsole);
            //ACT
            ui.Run();
            Console.WriteLine(mockConsole.Output);
            //Assert
            Assert.IsTrue(mockConsole.Output.Contains(customDesc));
        }
        [TestMethod]
        public void RemoveFromList_ShouldSeeRemovedMessage()
        {
            // Arrange 
            var commandList = new List<string> { "4", "3", "6" };
            var fakeConsole = new MockConsole(commandList);
            var ui = new ProgramUI(fakeConsole);
            // ACT 
            ui.Run();
            Console.WriteLine(fakeConsole.Output);
            //ASSERT
            Assert.IsTrue(fakeConsole.Output.Contains("Another Movie successfully removed!"));
        }
    }
}
