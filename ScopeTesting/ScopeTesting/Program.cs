﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace ScopeTesting
{
    class Program
    {

        public class MyGenCollection : IEnumerable<int>
        {
            int[] data = { 1, 2, 3 };
        }

        public IEnumerator<int> GetEnumerator()
        {
            foreach (int i in data)
                yield return i;
        }

        static void Main(string[] args)
        {
            
        }
    }
}
