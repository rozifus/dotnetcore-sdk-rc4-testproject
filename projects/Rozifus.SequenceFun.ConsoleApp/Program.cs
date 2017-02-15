using System;
using System.Collections.Generic;
using Rozifus.SequenceFun.IntSequences;
using Rozifus.SequenceFun.StringSequences;
using Rozifus.SequenceFun.Interfaces;

namespace Rozifus.SequenceFun.ConsoleApp
{
    static class App {
        static void Main(string[] args)
        {
            var incers = new List<IIncrementer> { 
                new IntegerSequencer(0), 
                new IntegerSequencer(16),
                new LowerAlphaIncrementer("a"),
                new LowerAlphaIncrementer("ay")  
            };

            PrintAll(incers);

            for (var x=0; x<8; x++) {
                IncrementAll(incers);
                PrintAll(incers);
            }
        }

        private static void IncrementAll(IEnumerable<IIncrementer> incrementers) {
            foreach (var incer in incrementers) {
                incer.Next();
            }
        }

        private static void PrintAll(IEnumerable<IElement> elements) {
            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
