using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    public class StreamingRepositorycs : StreamingContentRepository
    {
        public Show GetShowByTitle(string title)
        {
            foreach(StreamingContent content in _contentDirectory)
            {
                if(content.Title.ToLower() == title.ToLower() && content.GetType() == typeof(Show))
                {
                    return (Show)content;
                }
            }
            return null;
        }
        public Movie GetMovieByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower() && content.GetType() == typeof(Movie))
                {
                    return (Movie)content;
                }
            }
            return null;
        }

        public List<Show> GetAllShows()
        {
            // Make a space to save all shows
            List<Show> allShows = new List<Show>();
            //pull one item and see if it is a show 
            //make sure to save that off to the side 
            foreach(StreamingContent content in _contentDirectory)
            {
                if(content is Show)
                {
                    allShows.Add((Show)content);
                }
            }
            // return that list 
            return allShows;
        }

        //Write GetAllMovies
        //GetByOtherParameters ex GetAllFamilyFriendlyMovies
        // Get Shows with over x episode



    }
}
