using _07_RepositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StreamingContent_Console.UI
{
    class ProgramUI
    {
        private readonly StreamingRepositorycs _streamingRepo = new StreamingRepositorycs();
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
                Console.Clear();
                Console.WriteLine("Enter the number of the option you'd like to select: \n" +
                    "1) Show all streaming content \n" +
                    "2) Find by title \n" +
                    "3) Add new content \n" +
                    "4) Remove content \n" +
                    "5) Exit");
                string userInput = Console.ReadLine();
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
                        //Exit
                        continueToRun = false;
                        break;
                    default:
                        //default
                        Console.WriteLine("Please enter a valid number between 1 and 5. \n" +
                            "Press any key to continue......");
                        Console.ReadKey();
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
            Console.WriteLine("Please enter the title of the new content");
            string contentTitle = Console.ReadLine();
            content.Title = contentTitle;
            //Description
            Console.WriteLine($"Please enter the description for {content.Title}");
            content.Description = Console.ReadLine();
            //StarRating
            Console.WriteLine($"Please enter the star rating for {content.Title}");
            content.StarRating = float.Parse(Console.ReadLine());
            //Maturity Rating
            Console.WriteLine("Select a Maturity Rating: \n" +
                "1) G \n" +
                "2) PG \n" +
                "3) PG 13 \n" +
                "4) R \n" +
                "5) NC 17 \n" +
                "6) MA");
            string maturityResponse = Console.ReadLine();
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
            Console.WriteLine("Select a genre: \n" +
                "1) Horror \n" +
                "2) RomCom \n" +
                "3) Fantasy \n" +
                "4) Sci-Fi \n" +
                "5) Drama \n" +
                "6) Bromance \n" +
                "7) Action \n" +
                "8) Documentary \n" +
                "9) Thriller");
            string genreResponse = Console.ReadLine();
            int genreID = int.Parse(genreResponse);
            content.TypeOfGenre = (GenreType)genreID;

            //a new content with properties filled out by user 
            //Pass that to the add method in our repo 
            _streamingRepo.AddContentToDirectory(content);
        }
        private void ShowAllContent()
        {
            Console.Clear();
            //GET the items from our fake database 
            List<StreamingContent> listOfContent = _streamingRepo.GetContents();
            //Take EACH item and display property values
            foreach(StreamingContent content in listOfContent)
            {
                DisplaySimple(content);
            }
            //Pause the program so the user can see the printed objects
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
            //GOAL: Show all items in our fake database 
        }
        private void ShowContentByTitle()
        {
            Console.Clear();
            //GOAL? Show only one object -> found by title
            //Step one Get title from user
            Console.WriteLine("Please enter the title: ");
            string title = Console.ReadLine();
            //use that title to find the ONE object -> we have built this method
            StreamingContent foundContent = _streamingRepo.GetContentByTitle(title);
            //If object found display data / if not inform user that title does not exist
            if(foundContent != null)
            {
                DisplayAllProps(foundContent);
            }
            else
            {
                Console.WriteLine("There are no titles that matched the one you gave me. \n" +
                    "Do better");
            }

            Console.WriteLine("Press any key to continue.....");
            Console.ReadKey();
        }
        private void RemoveContentFromList()
        {
            //Ask the user which one they want to remove 
            Console.WriteLine("Which item would you like to remove?");
            //need a list of the items 
            List<StreamingContent> contentList = _streamingRepo.GetContents();
            int count = 0;
            foreach(var content in contentList)
            {
                count++;
                Console.WriteLine($"{count}) {content.Title}");
            }
            //take in user response 
            int targetContentID = int.Parse(Console.ReadLine());
            int correctIndex = targetContentID - 1;
            if(correctIndex >= 0 && correctIndex < contentList.Count)
            {
                StreamingContent desiredContent = contentList[correctIndex];
                //Remove that item 
                if (_streamingRepo.DeleteExistingContent(desiredContent))
                {
                    Console.WriteLine($"{desiredContent.Title} successfully removed!");
                }
                else
                {
                    Console.WriteLine("I'm sorry, Dave. I'm afriad I can't do that.");
                }
            }
            else
            {
                Console.WriteLine("INVALID OPTION");
            }
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();

        
        }

        private void DisplaySimple(StreamingContent content)
        {
            Console.WriteLine($"{content.Title} \n" +
                    $"{content.Description} \n" +
                    $"-----------------------");
        }
        private void DisplayAllProps(StreamingContent content)
        {
            Console.WriteLine($"Title: {content.Title} \n" +
                $"Description: {content.Description} \n" +
                $"Genre: {content.TypeOfGenre} \n" +
                $"Stars: {content.StarRating} \n" +
                $"Content is Family Friendly: {content.IsFamilyFriendly} \n" +
                $"Maturity Rating: {content.MaturityRatin}");
        }
        private void SeedContent()
        {
            var titleOne = new StreamingContent("Toy Story", "Toys have a story", 4.5f, MaturityRating.PG, false, GenreType.Bromance);
            var titleTwo = new StreamingContent("Star Wars", "Stars at War", 10f, MaturityRating.PG_13, false, GenreType.Documentary);
            var titleThree = new StreamingContent("Baby Driver", "Your driver for the night is a baby", 48f, MaturityRating.MA, false, GenreType.Documentary);
            var titleFour = new StreamingContent("Bananas", "The Banana strikes back", 20f, MaturityRating.PG, false, GenreType.SciFi);
            var titleFive = new StreamingContent("Harry Potter", "Harry Makes Pottery", 42f, MaturityRating.PG, false, GenreType.Fantasy);
            _streamingRepo.AddContentToDirectory(titleOne);
            _streamingRepo.AddContentToDirectory(titleTwo);
            _streamingRepo.AddContentToDirectory(titleThree);
            _streamingRepo.AddContentToDirectory(titleFour);
            _streamingRepo.AddContentToDirectory(titleFive);
        }




    }
}
