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
    public enum MaturityRating { G , PG, PG_13,R,NC_17,MA}
    public class StreamingContent
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public float StarRating { get; set; }
        public MaturityRating MaturityRatin { get; set; }
        public bool IsFamilyFriendly 
        { 
            get
            {
                switch (MaturityRatin)
                {
                    case MaturityRating.G:
                    case MaturityRating.PG:
                        return true;
                    case MaturityRating.PG_13:
                    case MaturityRating.NC_17:
                    case MaturityRating.R:
                    case MaturityRating.MA:
                        return false;
                    default:
                        return false;
                }
                if((int)MaturityRatin <= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public GenreType TypeOfGenre { get; set; }

        public StreamingContent() { }
        public StreamingContent(string title, string description, float starRating, MaturityRating mRating, GenreType tOG)
        {
            Title = title;
            Description = description;
            StarRating = starRating;
            MaturityRatin = mRating;
            TypeOfGenre = tOG;
        }

    }
}
