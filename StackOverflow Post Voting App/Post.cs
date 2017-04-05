using System;

namespace StackOverflow_Post_Voting_App
{
    public class Post
    {   //Note I have come from Java and have a habit of typing my variable types
        private int id1;
        private string title;
        private string description1;
        private DateTime dateAndTimeOfPost1;
        private int numberOfVotes1 = 0;

        //ctor
        public Post(int id, string titleOfPost, string descriptionOfPost)
        {
            Setid(id);
            SetTitle(titleOfPost);
            Setdescription(descriptionOfPost);
            SetnumberOfVotes(0);
            SetdateAndTimeOfPost(DateTime.Now); 
        }

        //methods
        public void UpVoting()
        {
            SetnumberOfVotes(GetnumberOfVotes() + 1); 
        }
        public void DownVoting()
        {
            SetnumberOfVotes(GetnumberOfVotes() - 1); 
        }

        //Getters and setters. Note that some are private. 
        public string GetTitle()
        {
            return title;
        }

        private void SetTitle(string value)
        {
            title = value;
        }

        public int Getid()
        {
            return id1;
        }

        private void Setid(int value)
        {
            id1 = value;
        }

        public string Getdescription()
        {
            return description1;
        }

        private void Setdescription(string value)
        {
            description1 = value;
        }

        public DateTime GetdateAndTimeOfPost()
        {
            return dateAndTimeOfPost1;
        }

        private void SetdateAndTimeOfPost(DateTime value)
        {
            dateAndTimeOfPost1 = value;
        }

        public int GetnumberOfVotes()
        {
            return numberOfVotes1;
        }

        private void SetnumberOfVotes(int value)
        {
            numberOfVotes1 = value;
        }
    }
}
