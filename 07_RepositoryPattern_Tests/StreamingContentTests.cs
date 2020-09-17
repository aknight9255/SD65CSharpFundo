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
            Movie newMovie = new Movie("Venom", "The best romance movie of our age", 9005, "pg-13", true, GenreType.RomCom, 132);

        }
    }
}
