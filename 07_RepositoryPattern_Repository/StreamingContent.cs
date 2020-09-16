using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    public enum GenreType
    {
        Horror = 1,
        RomCom,
        Fantasy,
        SciFi,
        Drama,
        Bromance,
        Action,
        Documentary,
        Thriller
    }
    public class StreamingContent
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public float StarRating { get; set; }
        public string MaturityRatin { get; set; }
        public bool IsFamilyFriendly { get; set; }
        public GenreType TypeOfGenre { get; set; }

        public StreamingContent() { }
        public StreamingContent(string title,string description,float starRating,string mRating,bool famFriendly, GenreType tOG)
        {
            Title = title;
            Description = description;
            StarRating = starRating;
            MaturityRatin = mRating;
            IsFamilyFriendly = famFriendly;
            TypeOfGenre = tOG;
        }

    }
}
