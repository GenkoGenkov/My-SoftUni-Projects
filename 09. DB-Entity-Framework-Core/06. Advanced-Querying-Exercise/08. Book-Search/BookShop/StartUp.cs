namespace BookShop
{
    using BookShop.Models.Enums;
    using Data;
    using Initializer;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            var db = new BookShopContext();
            //DbInitializer.ResetDatabase(db);

            Console.WriteLine(GetBookTitlesContaining(db, "sK"));
        }

        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            List<string> bookTitles = context.Books
               .Where(b => b.Title.ToLower().Contains(input.ToLower()))
               .Select(b => b.Title)
               .OrderBy(bt => bt)
               .ToList();

            return string.Join(Environment.NewLine, bookTitles);
        }

    }
}
