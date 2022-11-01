using System;
using System.Collections.Generic;

namespace _02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            string[] data = Console.ReadLine()
                    .Split(", ");
            string title = data[0];
            string content = data[1];
            string author = data[2];
            int n = int.Parse(Console.ReadLine());
            Article article = new Article(title, content, author);

            
            for (int i = 0; i < n; i++)
            {
                
                string[] input = Console.ReadLine()
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string command = input[0];
                string changes = input[1];
                


                if (command == "Edit")
                {
                    article.Edit(changes);
                }
                if (command == "ChangeAuthor")
                {
                    article.ChangeAuthor(changes);
                }

                if (command == "Rename")
                {
                    article.Rename(changes);
                }
            }
            Console.WriteLine(article);
        }
        }
    }

    class Article
    {
       public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit( string changes)
        {
            this.Content = changes;
        }
        
        public void ChangeAuthor(string changes)
        {
        this.Author = changes;
        }
        
        public void Rename(string changes)
        {
        this.Title = changes;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }

