using System;
using Rozifus.SequenceFun.Interfaces;
using Rozifus.SequenceFun.StringExtensions;

namespace Rozifus.SequenceFun.StringSequences
{
    public class LowerAlphaIncrementer : IIncrementer
    {
        private string _value;
        private readonly int firstChar = 97;
        private readonly int lastChar = 122;

        public LowerAlphaIncrementer(string initial) {
            Value = initial;
        }

        public LowerAlphaIncrementer() {
            Value = ((char)firstChar).ToString();
        }

        private string Zero () => ((char)firstChar).ToString();

        public string Value {
            get {
                return _value;
            }
            set {
                if (!IsValidValue(value)) {
                    throw new Exception($"Invalid lower-alpha-string: {value}");
                } else {
                    _value = value;
                }
            }
        }

        public void Next() {
            for(var i = _value.Length - 1; i >= 0; i--) {

                var ascii = (int)_value[i];

                if (ascii < lastChar) {
                    Value = Value.ReplaceCharAt(i, (char)(ascii+1));
                    for (var j = i+1; j < _value.Length; j++) {
                        Value = Value.ReplaceCharAt(j, (char)firstChar);
                    }
                    return;
                }

                if (i == lastChar) {
                    Value = Value.ReplaceCharAt(i, (char)firstChar);
                    continue;
                }
            }

            Value = new String((char)firstChar, Value.Length+1);
        } 

        public override string ToString() {
            return Value;
        }

        private bool IsValidValue(string value) { 
            foreach (var c in value.ToCharArray()) {

                var ascii = (int)c;
                if(ascii < firstChar || ascii > lastChar) {
                    return false;
                }
            }

            return true;
        }
    }
}
