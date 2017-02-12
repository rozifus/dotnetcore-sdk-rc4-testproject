using System;

namespace Rozifus.SequenceFun.Interfaces
{
    public interface ISequencer<T>
    {
        T Value {get; set;} 
        ISequencer<T> Next();
        ISequencer<T> Prev();
        string ToString();
    }
}
