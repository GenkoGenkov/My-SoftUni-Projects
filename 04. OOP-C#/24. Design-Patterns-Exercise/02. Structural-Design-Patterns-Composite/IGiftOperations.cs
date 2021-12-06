using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public interface IGiftOperations
    {
        void Add(GiftBase gift);

        void Remove(GiftBase gift);
    }
}
