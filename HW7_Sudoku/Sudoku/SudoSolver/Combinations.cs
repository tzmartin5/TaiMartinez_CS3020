using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sudoku
{
    public class Combinations<T>
    {
        
        /// Generate combinations of the items in a list.
        public static IEnumerable<IEnumerable<T>> Get(List<T> source, int comboLength, int startIndex = 0)
        {
            if (comboLength == 1)
            {
                for (var i = startIndex; i < source.Count; i++)
                {
                    yield return new List<T> { source[i] };
                }
            }
            else
            {

                for (var i = startIndex; i <= source.Count - comboLength; i++)
                {
                    foreach (var combo in Get(source, comboLength - 1, i + 1))
                    {
                        var prefix = new List<T> { source[i] };
                        yield return prefix.Concat(combo);
                    }
                }
            }

            yield break;
        }
    }
}
