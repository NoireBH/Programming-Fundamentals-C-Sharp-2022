using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();
            
            int n = int.Parse(Console.ReadLine());

            
            

            for (int i = 0; i < n; i++)
            {

                string[] data = Console.ReadLine()
                     .Split(", ");
                string title = data[0];
                string content = data[1];
                string author = data[2];

                Article article = new Article(title, content, author);
                articles.Add(article);
                // Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}"); if ToString(); is not overwritten this is how to solve it


            }
            string type = Console.ReadLine();
            foreach (var article in articles)
            {
                Console.WriteLine(articles);
            }
           
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

    

    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }
}