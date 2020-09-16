using System;
using System.Collections.Generic;
using _07_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentRepositoryTests
    {
        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBoolean()
        {
            // Arrange 
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repository = new StreamingContentRepository();

            //ACT 
            bool addResult = repository.AddContentToDirectory(content);

            // ASSERT 
            Assert.IsTrue(addResult);
        }

        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollection()
        {
            //Arrange 
            StreamingContent newObject = new StreamingContent();
            StreamingContentRepository repo = new StreamingContentRepository();


            repo.AddContentToDirectory(newObject);

            //ACT 
            List<StreamingContent> listOfContents = repo.GetContents();

            //ASSERT 
            bool directoryHasContent = listOfContents.Contains(newObject);
            Assert.IsTrue(directoryHasContent);
        }
    }
}



