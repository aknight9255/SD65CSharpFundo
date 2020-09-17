using System;
using System.Collections.Generic;
using _07_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        [TestMethod]
        public void StreamingContentNotes()
        {
            StreamingContent baseObject = new StreamingContent();
            Movie movieObject = new Movie();
            Show showObject = new Show();
            Episode episodeObject = new Episode();
            //showObject.Episodes = new List<Episode>();
            showObject.Episodes.Add(episodeObject);
            showObject.Episodes.Add(episodeObject);
            showObject.Episodes.Add(episodeObject);
            showObject.Episodes.Add(episodeObject);
            showObject.Episodes.Add(episodeObject);
            showObject.Episodes.Add(episodeObject);

            Movie newMovie = new Movie("Venom", "The best romance movie of our age", 9005, MaturityRating.NC_17, true, GenreType.RomCom, 132);
            
            StreamingRepositorycs repo = new StreamingRepositorycs();
            repo.AddContentToDirectory(showObject);
            List<Show> showsOverTwenty = repo.GetAllShowsOverACertainEpisodeCount(3);

        }

        [DataTestMethod]
        [DataRow(MaturityRating.G,true)]
        [DataRow(MaturityRating.PG, true)]
        [DataRow(MaturityRating.PG_13, false)]
        [DataRow(MaturityRating.MA, false)]
        public void SetMaturityRating_ShouldGetCorrectBool(MaturityRating rating, bool isFamilyFriendly)
        {
            StreamingContent content = new StreamingContent("Insert Title Here", "Description here", 5, rating, true, GenreType.Documentary);
            bool actual = content.IsFamilyFriendly;
            bool expected = isFamilyFriendly;
            Assert.AreEqual(expected, actual);
        }
    }
}
