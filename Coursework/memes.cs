using System.Collections.Generic;

namespace Coursework
{
    public class memes
    {
        public string Filename { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public List<string> tags { get; set; }

        public memes()
        {
            tags = new List<string>();
            Name = "<NoName>";
            Category = "<NoCategory>";
        }
        public memes(string i_filename)
        {
            Filename = i_filename;

            int index = 0;
            if (i_filename[i_filename.Length - 5] == '.') index = 5;
            else if (i_filename[i_filename.Length - 4] == '.') index = 4;
            Name = i_filename.Remove(i_filename.Length - index);

            Category = "<NoCategory>";
            tags = new List<string>();
        }
        public memes(string i_filename, string i_name)
        {
            Filename = i_filename;
            Name = i_name;
            Category = "<NoCategory>";
            tags = new List<string>();
        }
        public memes(string i_filename, string i_name, string i_category)
        {
            Filename = i_filename;
            Name = i_name;
            Category = i_category;
            tags = new List<string>();
        }

        public void AddTags(string tag)
        {
            if (!tags.Contains(tag)) tags.Add(tag.ToLower());
        }

        public void RemoveTag(string tag)
        {
            tags.Remove(tag);
        }

        public bool HaveTag(string tag)
        {
            return tags.Contains(tag);
        }
    }
}
