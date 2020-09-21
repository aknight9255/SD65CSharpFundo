﻿using _07_RepositoryPattern_Repository;
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
                        break;
                    case "2":
                        //Find by Title
                        break;
                    case "3":
                        //Add New
                        CreateNewContent();
                        break;
                    case "4":
                        //Remove
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

    }
}