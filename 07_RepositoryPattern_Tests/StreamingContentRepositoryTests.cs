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

        private StreamingContentRepository _repo;
        private StreamingContent _content;
        [TestInitialize]
        public void Arrange()
        {
            _repo = new StreamingContentRepository();
            _content = new StreamingContent("Oceans 8", "do crime?", 100, MaturityRating.NC_17, true, GenreType.Action);
            _repo.AddContentToDirectory(_content);
        }
        [TestMethod]
        public void GetbyTitle_ShouldReturnCorrectContent()
        {
            //Arrange 
            //ACT
            StreamingContent searchResult = _repo.GetContentByTitle("oceans 8");
            //ASSERT 
            Assert.AreEqual(_content, searchResult);
        }

        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            //arrange 
            StreamingContent updatedContent = new StreamingContent("Italian Job", "do crime? in Italy", 100, MaturityRating.NC_17, true, GenreType.Action);
            //ACT 
            bool updateResult = _repo.UpdateExistingContent("oceans 8", updatedContent);
            //ASSERT
            Assert.IsTrue(updateResult);
        }

        [TestMethod]
        public void DeleteExisingContent_ShouldReturnTrue()
        { 
            //arrange
            StreamingContent foundContent = _repo.GetContentByTitle("Oceans 8");
            // ACT
            bool removeResult = _repo.DeleteExistingContent(foundContent);
            //Assert 
            Assert.IsTrue(removeResult);
        }
    }
}



