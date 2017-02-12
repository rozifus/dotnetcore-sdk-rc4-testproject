using System;
using Rozifus.SequenceFun.IntSequences;

namespace Rozifus.SequenceFun.ConsoleApp
{
    static class App {
        static void Main(string[] args)
        {
            var intSeq = new IntegerSequencer();
            Console.WriteLine(intSeq.Value);
            for (var x=0; x<5; x++) {
                intSeq = (IntegerSequencer)intSeq.Next();
                Console.WriteLine(intSeq.Value);
            }
            for (var x=0; x<10; x++) {
                intSeq = (IntegerSequencer)intSeq.Prev();
                Console.WriteLine(intSeq.Value);
            }
        }
    }
}
