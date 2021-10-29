﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GenericScale
{
    public class StartUp
    {
        public static void Main(string[] args)
        {



        }
    }

    public class EqualityScale<T>
      
    {
        private T left;
        private T right;

        public EqualityScale(T left, T right)
        {
            this.left = left;
            this.right = right;
        }

        public bool AreEqual()
        {
            // Equals -> left == right (class)
            // Equals -> byte-to-byte (struct)
            return left.Equals(right);
        }
    }
}