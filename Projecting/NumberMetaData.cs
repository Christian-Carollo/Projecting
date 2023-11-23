using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecting
{
    internal class NumberMetaData
    {
        public int Number {  get; set; }
        public bool IsEven {  get; set; }

        public int NumberOfCharacters { get; set; }

        public NumberMetaData(int Number)
        {
            this.Number = Number;
            this.IsEven = Number % 2 == 0;
            this.NumberOfCharacters = Number.ToString().Length;        }
    }
}
