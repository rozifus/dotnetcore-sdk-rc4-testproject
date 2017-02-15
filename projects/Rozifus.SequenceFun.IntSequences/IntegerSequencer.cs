using System;
using Rozifus.SequenceFun.Interfaces;

namespace Rozifus.SequenceFun.IntSequences
{
    public class IntegerSequencer : ISequencer
    {
        public static int Zero = 0;
        int _value;

        public IntegerSequencer(int initial) {
            Value = initial;            
        }

        public IntegerSequencer() {
            Value = Zero;
        }

        public int Value {
            get {
                return _value;
            }
            set {
                _value = value;
            }
        }

        public void Next() {
            _value += 1;
        }

        public void Prev() {
            _value -= 1;
        }

        public override string ToString() {
            return Value.ToString();
        }
    }
}
