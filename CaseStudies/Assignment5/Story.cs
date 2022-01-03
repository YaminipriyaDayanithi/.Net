using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    class Story : IComparable
    {
        private string name, authorName, genre;
        private int noOfChapters, noOfLikes, noOfReads;

        public Story(string name, string authorName, string genre, int noOfChapters, int noOfLikes, int noOfReads)
        {
            this.Name = name;
            this.AuthorName = authorName;
            this.Genre = genre;
            this.NoOfChapters = noOfChapters;
            this.NoOfLikes = noOfLikes;
            this.NoOfReads = noOfReads;
        }

        public string Name { get => name; set => name = value; }
        public string AuthorName { get => authorName; set => authorName = value; }
        public string Genre { get => genre; set => genre = value; }
        public int NoOfChapters { get => noOfChapters; set => noOfChapters = value; }
        public int NoOfLikes { get => noOfLikes; set => noOfLikes = value; }
        public int NoOfReads { get => noOfReads; set => noOfReads = value; }


        public int CompareTo(object obj)
        {
            Story story = (Story)obj;
            return this.Name.CompareTo(story.Name);
        }

        public override string ToString()
        {
            return string.Format(this.Name + " " + " " + this.AuthorName + " " + this.Genre
                + " " + this.NoOfChapters + " " + this.NoOfLikes + " " + this.NoOfReads);
        }

    }
}