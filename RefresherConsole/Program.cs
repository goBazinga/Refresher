using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace RefresherConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //start up options
            StatUp(true);

            while (true)
            {

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine($"You've selected: {userChoice}");
                        Console.WriteLine("Running Quadratic Equation");
                        QuadraticRootCalculation();
                        Console.WriteLine("Completed Running Quadratic Equation");
                        StatUp(false);

                        break;
                    case "2":
                        Console.WriteLine($"You've selected: {userChoice}");
                        Console.WriteLine("Running Merge Names");
                        break;
                    case "3":
                        Console.WriteLine($"You've selected: {userChoice}");
                        Console.WriteLine("Running Playlist");
                        PlaylistCheck();
                        Console.WriteLine("Completed Running Playlist");
                        StatUp(false);
                        break;
                    case "4":
                        Console.WriteLine($"You've selected: {userChoice}");
                        Console.WriteLine("Running BinaryTree");
                        NodeCheck();
                        Console.WriteLine("Completed Running Binary Tree");
                        StatUp(false);
                        break;

                    case "5":
                        Console.WriteLine($"You've selected: {userChoice}");
                        Console.WriteLine("Running User Input");
                        UserInput();
                        Console.WriteLine("Completed Running User Input");
                        StatUp(false);
                        break;
                    case "6":
                        Console.WriteLine($"You've selected: {userChoice}");
                        Console.WriteLine("Running Two Sum");
                        TwoSumCheck();
                        Console.WriteLine("Completed Running Two Sum");
                        StatUp(false);
                        break;
                    case "7":
                        Console.WriteLine($"You've selected: {userChoice}");
                        Console.WriteLine("Starting Train Wagon Compostion");
                        AttachDetachWagon();
                        Console.WriteLine("Completed Train Wagon Compostion");
                        StatUp(false);
                        break;
                    case "8":
                        Console.WriteLine($"You've selected: {userChoice}");
                        Console.WriteLine("Starting Reverse String");
                        ReverseString();
                        Console.WriteLine("Completed Reverse String");
                        StatUp(false);
                        break;
                    case "9":
                        Console.WriteLine($"You've selected: {userChoice}");
                        Console.WriteLine("Starting Reverse Words");
                        ReverseStringOfWords();
                        Console.WriteLine("Completed Reverse Words");
                        StatUp(false);
                        break;
                    case "10":
                        Console.WriteLine($"You've selected: {userChoice}");
                        Console.WriteLine("Create array");
                        ArrayOfMultiples(5, 5);
                        Console.WriteLine("Completed creating array");
                        StatUp(false);
                        break;
                    case "11":
                        Console.WriteLine($"You've selected: {userChoice}");
                        Console.WriteLine("Checking Palindrome");
                        CheckPalindrome();
                        Console.WriteLine("Completed checking Palindrome");
                        StatUp(false);
                        break;
                    case "12":
                        Console.WriteLine($"You've selected: {userChoice}");
                        Console.WriteLine("Checking Palindrome");
                        PopularDay();
                        Console.WriteLine("Completed checking Palindrome");
                        StatUp(false);
                        break;
                    default:
                        Console.WriteLine("Invalid Response");
                        StatUp(false);
                        break;
                }

                //Quadratic Equation


            }



        }

        /// <summary>
        /// Startup the app to get user input
        /// </summary>
        /// <param name="isFirstStart"></param>
        public static void StatUp(bool isFirstStart)
        {
            if (isFirstStart)
                Console.WriteLine("Welcome to C# Refresher, which solution would you like to run? Please choose from the following:");
            else
            {
                Console.WriteLine("************************************************************************");
                Console.WriteLine();
                Console.WriteLine("Please choose from the following to run another solution:" + System.Environment.NewLine);
            }

            Console.WriteLine("1= Quadratic Equation");
            Console.WriteLine("2= MergeNames");
            Console.WriteLine("3= Playlist");
            Console.WriteLine("4= Binary Tree");
            Console.WriteLine("5= User Input");
            Console.WriteLine("6= ParsingXML Folders");
            Console.WriteLine("7= Train Wagon Composition");
            Console.WriteLine("8= Reverse String");
            Console.WriteLine("9= Reverse Words");
            Console.WriteLine("10= Create Array of Given Size");
            Console.WriteLine("11= Check Palindrome");
            Console.WriteLine("12=Popular Day");
        }

        /// <summary>
        /// Quadratic Equation
        /// </summary>
        public static void QuadraticRootCalculation()
        {
            Tuple<double, double> roots = QuadraticEquation.FindRoots(2, 10, 8);
            Console.WriteLine("Roots: " + roots.Item1 + ", " + roots.Item2);

        }

        /// <summary>
        /// Binary Search
        /// </summary>
        public static void NodeCheck()
        {
            Node n1 = new Node(1, null, null);
            Node n3 = new Node(3, null, null);
            Node n2 = new Node(2, n1, n3);

            Console.WriteLine(BinarySearchTree.Contains(n2, 3));
        }
        ///<summary>
        ///<para> A playlist is considered a repeating playlist if any of the songs contain a reference to a previous song in the playlist. 
        ///Otherwise, the playlist will end with the last song which points to null.Implement a function IsRepeatingPlaylist that returns true if a playlist is repeating or false if it is not.
        /// For example, the following code prints "True" as both songs point to each other.
        ///Song first = new Song("Hello");
        ///Song second = new Song("Eye of the tiger");
        ///first.NextSong = second;
        ///second.NextSong = first;
        ///Console.WriteLine(first.IsRepeatingPlaylist());</para>
        ///</summary>
        public static void PlaylistCheck()
        {
            Song first = new Song("Hello");
            Song second = new Song("Eye of the tiger");

            first.NextSong = second;
            second.NextSong = first;

            Console.WriteLine(first.IsRepeatingPlaylist());
        }

        /// <summary>
        /// User Input test
        /// </summary>
        public static void UserInput()
        {
            TextInput input = new NumericInput();
            input.Add('1');
            input.Add('a');
            input.Add('0');
            Console.WriteLine(input.GetValue());
        }

        public static void TwoSumCheck()
        {
            Tuple<int, int> indices = TwoSum.FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10);
            if (indices != null)
            {
                Console.WriteLine(indices.Item1 + " " + indices.Item2);
            }
        }

        /// <summary>
        /// Find matching folder names in the xml 
        /// </summary>
        public static void ParsingXML()
        {
            string xml =
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                "<folder name=\"c\">" +
                    "<folder name=\"program files\">" +
                        "<folder name=\"uninstall information\" />" +
                    "</folder>" +
                    "<folder name=\"users\" />" +
                "</folder>";

            foreach (string name in Folders.FolderNames(xml, 'u'))
                Console.WriteLine(name);
        }

        /// <summary>
        /// Count the numbers less than given parameter in a sorted array
        /// </summary>
        public static void CountNumbers()
        {
            Console.WriteLine(SortedSearch.CountNumbers(new int[] { 1, 3, 5, 7 }, 4));
        }

        public static void AttachDetachWagon()
        {
            TrainComposition tree = new TrainComposition();
            tree.AttachWagonFromLeft(7);
            tree.AttachWagonFromLeft(13);
            Console.WriteLine(tree.DetachWagonFromRight()); // 7 
            Console.WriteLine(tree.DetachWagonFromLeft()); // 13            
        }

        public static void EnumFlags()
        {
            Console.WriteLine(Account.Access.Writer.HasFlag(Account.Access.Delete)); //Should print: "False"
        }


        public static void ReverseString()
        {
            Console.WriteLine("Input word to reverse:");
            var input = Console.ReadLine();
            Console.WriteLine(StringsAndArray.ReverseArray(input));
        }

        public static void ReverseStringOfWords()
        {
            string output = StringsAndArray.ReverseWords(new char[] { 't', 'h', 'e', ' ', 'e', 'a', 'g', 'l', 'e', ' ',
                             'h', 'a', 's', ' ', 'l', 'a', 'n', 'd', 'e', 'd' }, true);
            Console.WriteLine(output);
            Console.WriteLine();

            string output1 = StringsAndArray.ReverseWords(new char[] { 't', 'h', 'e', ' ', 'e', 'a', 'g', 'l', 'e', ' ',
                             'h', 'a', 's', ' ', 'l', 'a', 'n', 'd', 'e', 'd' }, false);
            Console.WriteLine(output1);
            Console.WriteLine();
        }


        public static void ArrayOfMultiples(int num, int length)
        {

            List<string> mutiples = new List<string>();

            int i = 1;
            for (i = 1; i <= length; i++)
            {
                mutiples.Add((i * num).ToString());
            }

            Console.WriteLine(String.Join(",", mutiples));
        }

        public static void CheckPalindrome()
        {
            Console.WriteLine("Enter the word or phrase to check: ");
            string input = Console.ReadLine();
            bool flag = false;
            for (int i = 0, j = input.Length - 1; i < input.Length / 2; i++, j--)
            {
                if (input[i] != input[j])
                {
                    flag = false;
                    break;
                }
                else
                    flag = true;
            }
            if (flag)
            {
                Console.WriteLine("Palindrome");
            }
            else
                Console.WriteLine("Not Palindrome");

            input.TrimEnd().TrimStart();
        }

        public static void FindLongestSequence()
        {
            var days = new List<int> { 1, 4, 5, 6, 7, 8, 20, 24, 25, 26, 30 };


        }

        public static void PopularDay()
        {

            var stays = new List<Stay>() {
            new Stay("2019-11-16 2019-11-20"),
            new Stay("2019-11-18 2019-11-20"),
            new Stay("2019-11-19 2019-11-22")
            };


            //Call the test cases first
            //We can test three cases - best case, null, with one stay

            //Best Case - matches the most common date 
            HotelManager. TestStays(stays, new DateTime(2019, 11, 20), "Best Case");

            //Test the Null
            HotelManager.TestStays(null, DateTime.MinValue, "Null Check");

            //Test the list of dates with one stay
            HotelManager.TestStays(new List<Stay> { new Stay("2019-11-18 2019-11-20") }, new DateTime(2019, 11, 18), "One Stay");

            // Test Multiple stay dates with highest frequency
            var stays2 = new List<Stay>() {
            new Stay("2019-11-16 2019-11-18"),
            new Stay("2019-11-16 2019-11-17"),
            new Stay("2019-11-19 2019-11-22"),
            new Stay("2019-11-19 2019-11-23")
            };

            HotelManager.TestStays(stays2, new DateTime(2019, 11, 16), "Multiple stays with same high frequency");

            var mostPopularDay = HotelManager.FindMostPopularDay(stays);

            Console.WriteLine();

            Console.WriteLine("***********SOLUTION****************");
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Guest 1: 2019-11-16 2019-11-17 2019-11-18 2019-11-19 2019-11-20");
            Console.WriteLine("Guest 2:                       2019-11-18 2019-11-19 2019-11-20");
            Console.WriteLine("Guest 3:                                  2019-11-19 2019-11-20 2019-11-21 2019-11-22");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Most popular =  2019-11-19 and  2019-11-20 ");
            Console.WriteLine("But If there are multiple dates with the same popularity, we are asked choose the earliest one.");


            Console.WriteLine(mostPopularDay.ToString("yyyy-MM-dd"));
        }

    }
    
}
