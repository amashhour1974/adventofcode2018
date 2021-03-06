﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace day2
{
    class Program
    {
        public static Dictionary<char, int> hash;
        static void Main(string[] args)
        {
            Part2();
            /*
            var lines = System.IO.File.ReadAllLines("inputtest.txt");

            InitHash();
            int twos = 0;
            int threes = 0;
            foreach (var l in lines)
            {
                foreach (var c in l)
                {
                    hash[c]++;
                }
                if (hash.Any(h => h.Value == 2)) {
                    twos++;
                }
                if (hash.Any(h => h.Value == 3)) {
                    threes++;
                }
                InitHash();
            }
            Console.WriteLine(twos * threes);
             */
        }

        public static void Part2() {
            var lines = System.IO.File.ReadAllLines("input.txt");

            // naiive
            foreach (var line in lines) {
                foreach (var line2 in lines) {
                    var diffs = 0;
                    for (int i=0;i<line.Length;i++) {
                        if (line[i] != line2[i])
                            diffs++;
                    }
                    if (diffs == 1) {
                        Console.WriteLine($"ID 1: {line}");
                        Console.WriteLine($"ID 2: {line2}");
                        Console.WriteLine("You can take out the different value manually :)");
                        Environment.Exit(0);
                    }
                }
            }
        }

        public static void InitHash()
        {
            hash = new Dictionary<char, int>();
            hash.Add('a', 0);
            hash.Add('b', 0);
            hash.Add('c', 0);
            hash.Add('d', 0);
            hash.Add('e', 0);
            hash.Add('f', 0);
            hash.Add('g', 0);
            hash.Add('h', 0);
            hash.Add('i', 0);
            hash.Add('j', 0);
            hash.Add('k', 0);
            hash.Add('l', 0);
            hash.Add('m', 0);
            hash.Add('n', 0);
            hash.Add('o', 0);
            hash.Add('p', 0);
            hash.Add('q', 0);
            hash.Add('r', 0);
            hash.Add('s', 0);
            hash.Add('t', 0);
            hash.Add('u', 0);
            hash.Add('v', 0);
            hash.Add('w', 0);
            hash.Add('x', 0);
            hash.Add('y', 0);
            hash.Add('z', 0);
        }
    }
}
