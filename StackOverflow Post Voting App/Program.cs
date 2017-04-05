using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow_Post_Voting_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to create a post (Type 'yes' or 'no'): ");
            string willCreatePost = Console.ReadLine();
            var postnumber = new List<Post>();
            int id = 1; 

            while (willCreatePost.ToLower() == "yes")
            {
                Console.WriteLine("Please type a heading for your post: ");
                string tempTitleOfPost = Console.ReadLine();
                Console.WriteLine("Please type a description of your post: ");
                string tempDescriptionOfPost = Console.ReadLine();

                postnumber.Add(new Post(id, tempTitleOfPost, tempDescriptionOfPost));
                id += 1; 
                Console.WriteLine("Would you like to create another post (Type 'yes' or 'no'): ");
                willCreatePost = Console.ReadLine();
            }

            Console.WriteLine("You now need to vote on your post");
            Console.WriteLine("The following are your posts:");

            for (var i = 0; i < postnumber.Count; i++)
            {
                Console.WriteLine(postnumber[i].Getid() + " " + postnumber[i].GetTitle());
            }           
            Console.Write("Please up or down vote on your posts by typing the post number and '+' or '-'" +
                "or hit enter finish: ");
            var inputVotes = Console.ReadLine();

            while (!String.IsNullOrWhiteSpace(inputVotes))
            {
                char[] PostAndVotes = inputVotes.ToCharArray();
                int postNo = Convert.ToInt32(PostAndVotes[0].ToString());
                var postVote = PostAndVotes[1].ToString();

                for (var i = 0; i < postnumber.Count; i++)
                {
                    if (postNo == postnumber[i].Getid())
                    {
                        if (postVote == "+")
                        {
                            postnumber[i].UpVoting();
                        }
                        else if (postVote == "-")
                        {
                            postnumber[i].DownVoting();
                        }
                        else
                        {
                            Console.WriteLine("That was not a valid entry");
                        }
                    }
                    Console.Write("Please up or down vote on your posts again by typing the post number and '+' or '-'" +
                "or hit enter finish: ");
                    inputVotes = Console.ReadLine();
                }
            }
            Console.WriteLine("Summary of posts with their votes");
            Console.WriteLine("*****************");
            for (var i = 0; i < postnumber.Count; i++)
            {
                Console.WriteLine("{0} {1} post has {2} votes", postnumber[i].Getid(), postnumber[i].GetTitle(), postnumber[i].GetnumberOfVotes());
                Console.WriteLine(postnumber[i].Getdescription());
                Console.WriteLine("*****************");
            }
        }
    }
}
