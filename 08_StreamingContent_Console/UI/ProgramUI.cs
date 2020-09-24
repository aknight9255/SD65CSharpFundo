using _07_RepositoryPattern_Repository;
using _10_StreamingContent_UIRefactor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StreamingContent_Console.UI
{
    public class ProgramUI
    {
        private readonly IConsole _console;
        private readonly StreamingRepositorycs _streamingRepo = new StreamingRepositorycs();
        public ProgramUI(IConsole console)
        {
            _console = console;
        }
        public void Run()
        {
            SeedContent();
            RunMenu();
        }

        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                //add one of the following 
                //Get all shows 
                //Get all movies 
                //get show/movie by title

                _console.Clear();
                _console.WriteLine("Enter the number of the option you'd like to select: \n" +
                    "1) Show all streaming content \n" +
                    "2) Find by title \n" +
                    "3) Add new content \n" +
                    "4) Remove content \n" +
                    "5) Show All Movies \n" +
                    "6) Exit");
                string userInput = _console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        //Show All
                        ShowAllContent();
                        break;
                    case "2":
                        //Find by Title
                        ShowContentByTitle();
                        break;
                    case "3":
                        //Add New
                        CreateNewContent();
                        break;
                    case "4":
                        //Remove
                        RemoveContentFromList();
                        break;
                    case "5":
                        //Show All Movies
                        ShowAllMovies();
                        break;
                    case "6":
                        //Exit
                        continueToRun = false;
                        break;
                    default:
                        //default
                        _console.WriteLine("Please enter a valid number between 1 and 5. \n" +
                            "Press any key to continue......");
                        _console.ReadKey();
                        break;
                }
            }

        }

        private void CreateNewContent()
        {
            // a new content object 
            StreamingContent content = new StreamingContent();
            //Ask user for information 
            //Title
            _console.WriteLine("Please enter the title of the new content");
            string contentTitle = _console.ReadLine();
            content.Title = contentTitle;
            //Description
            _console.WriteLine($"Please enter the description for {content.Title}");
            content.Description = _console.ReadLine();
            //StarRating
            _console.WriteLine($"Please enter the star rating for {content.Title}");
            content.StarRating = float.Parse(_console.ReadLine());
            //Maturity Rating
            _console.WriteLine("Select a Maturity Rating: \n" +
                "1) G \n" +
                "2) PG \n" +
                "3) PG 13 \n" +
                "4) R \n" +
                "5) NC 17 \n" +
                "6) MA");
            string maturityResponse = _console.ReadLine();
            switch (maturityResponse)
            {
                case "1":
                    content.MaturityRatin = MaturityRating.G;
                    break;
                case "2":
                    content.MaturityRatin = MaturityRating.PG;
                    break;
                case "3":
                    content.MaturityRatin = MaturityRating.PG_13;
                    break;
                case "4":
                    content.MaturityRatin = MaturityRating.R;
                    break;
                case "5":
                    content.MaturityRatin = MaturityRating.NC_17;
                    break;
                case "6":
                    content.MaturityRatin = MaturityRating.MA;
                    break;
            }
            //TypeOfGenre
            _console.WriteLine("Select a genre: \n" +
                "1) Horror \n" +
                "2) RomCom \n" +
                "3) Fantasy \n" +
                "4) Sci-Fi \n" +
                "5) Drama \n" +
                "6) Bromance \n" +
                "7) Action \n" +
                "8) Documentary \n" +
                "9) Thriller");
            string genreResponse = _console.ReadLine();
            int genreID = int.Parse(genreResponse);
            content.TypeOfGenre = (GenreType)genreID;

            //a new content with properties filled out by user 
            //Pass that to the add method in our repo 
            _streamingRepo.AddContentToDirectory(content);
        }
        private void ShowAllContent()
        {
            _console.Clear();
            //GET the items from our fake database 
            List<StreamingContent> listOfContent = _streamingRepo.GetContents();
            //Take EACH item and display property values
            foreach(StreamingContent content in listOfContent)
            {
                DisplaySimple(content);
            }
            //Pause the program so the user can see the printed objects
            _console.WriteLine("Press any key to continue....");
            _console.ReadKey();
            //GOAL: Show all items in our fake database 
        }
        private void ShowContentByTitle()
        {
            _console.Clear();
            //GOAL? Show only one object -> found by title
            //Step one Get title from user
            _console.WriteLine("Please enter the title: ");
            string title = _console.ReadLine();
            //use that title to find the ONE object -> we have built this method
            StreamingContent foundContent = _streamingRepo.GetContentByTitle(title);
            //If object found display data / if not inform user that title does not exist
            if(foundContent != null)
            {
                DisplayAllProps(foundContent);
            }
            else
            {
                _console.WriteLine("There are no titles that matched the one you gave me. \n" +
                    "Do better");
            }

            _console.WriteLine("Press any key to continue.....");
            _console.ReadKey();
        }
        private void RemoveContentFromList()
        {
            //Ask the user which one they want to remove 
            _console.WriteLine("Which item would you like to remove?");
            //need a list of the items 
            List<StreamingContent> contentList = _streamingRepo.GetContents();
            int count = 0;
            foreach(var content in contentList)
            {
                count++;
                _console.WriteLine($"{count}) {content.Title}");
            }
            //take in user response 
            int targetContentID = int.Parse(_console.ReadLine());
            int correctIndex = targetContentID - 1;
            if(correctIndex >= 0 && correctIndex < contentList.Count)
            {
                StreamingContent desiredContent = contentList[correctIndex];
                //Remove that item 
                if (_streamingRepo.DeleteExistingContent(desiredContent))
                {
                    _console.WriteLine($"{desiredContent.Title} successfully removed!");
                }
                else
                {
                    _console.WriteLine("I'm sorry, Dave. I'm afriad I can't do that.");
                }
            }
            else
            {
                _console.WriteLine("INVALID OPTION");
            }
            _console.WriteLine("Press any key to continue....");
            _console.ReadKey();

        
        }
        private void ShowAllMovies()
        {
            _console.Clear();
            //GET all the movies 
            List<Movie> listOfMovie = _streamingRepo.GetAllMovies();
            foreach(var oneMovie in listOfMovie)
            {
                DisplaySimple(oneMovie);
            }
            _console.WriteLine("Press any key to continue....");
            _console.ReadKey();
        }

        private void DisplaySimple(StreamingContent content)
        {
            _console.WriteLine($"{content.Title} \n" +
                    $"{content.Description} \n" +
                    $"-----------------------");
        }
        private void DisplayAllProps(StreamingContent content)
        {
            _console.WriteLine($"Title: {content.Title} \n" +
                $"Description: {content.Description} \n" +
                $"Genre: {content.TypeOfGenre} \n" +
                $"Stars: {content.StarRating} \n" +
                $"Content is Family Friendly: {content.IsFamilyFriendly} \n" +
                $"Maturity Rating: {content.MaturityRatin}");
        }
        private void SeedContent()
        {
            var titleOne = new StreamingContent("Toy Story", "Toys have a story", 4.5f, MaturityRating.PG, GenreType.Bromance);
            var titleTwo = new StreamingContent("Star Wars", "Stars at War", 10f, MaturityRating.PG_13, GenreType.Documentary);
            var titleThree = new StreamingContent("Baby Driver", "Your driver for the night is a baby", 48f, MaturityRating.MA, GenreType.Documentary);
            var titleFour = new StreamingContent("Bananas", "The Banana strikes back", 20f, MaturityRating.PG, GenreType.SciFi);
            var titleFive = new StreamingContent("Harry Potter", "Harry Makes Pottery", 42f, MaturityRating.PG,  GenreType.Fantasy);

            Movie movieOne = new Movie();
            Movie movieTwo = new Movie("Venom","Two Bros",9001,MaturityRating.NC_17,GenreType.RomCom,123);
            Movie movieThree = new Movie("Another Movie", "Test Data", 1, MaturityRating.NC_17, GenreType.RomCom, 123);

            _streamingRepo.AddContentToDirectory(movieOne);
            _streamingRepo.AddContentToDirectory(movieTwo);
            _streamingRepo.AddContentToDirectory(movieThree);

            _streamingRepo.AddContentToDirectory(titleOne);
            _streamingRepo.AddContentToDirectory(titleTwo);
            _streamingRepo.AddContentToDirectory(titleThree);
            _streamingRepo.AddContentToDirectory(titleFour);
            _streamingRepo.AddContentToDirectory(titleFive);
        }




    }
}
