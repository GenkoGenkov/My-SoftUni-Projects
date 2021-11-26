using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace AuthorProblem
{
    [Author("Victor")]
    class StartUp
    {
        [Author("George")]
        static void Main(string[] args)
        {
            Tracker tracker = new Tracker();

            tracker.PrintMethodsByAuthor();

        }
    }
}