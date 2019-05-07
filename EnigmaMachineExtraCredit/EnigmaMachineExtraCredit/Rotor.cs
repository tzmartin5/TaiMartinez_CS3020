using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaMachineExtraCredit
{
    class Rotor
    {
        List<int> offset = new List<int>();
        int position = 0;
        public int originalPosition = 0;

        public Rotor(List<int> offset, int position = 0)
        {
            this.offset = offset;
            this.position = position;
        }

        public Rotor(Rotor r)
        {
            for (int i = 0; i < r.offset.Count; i++)
            {
                offset.Add(r.offset[i]);
            }
            position = r.position;
            originalPosition = r.originalPosition;
        }

        //gets the input 
        public int Input(int val)
        {
            if (val + offset[val] < offset.Count)
            {
                return val + offset[val];
            }
            else
            {
                return val + offset[val] - offset.Count;
            }
        }

        //reverses input 
        public int InputReverse(int val)
        {
            for (int i = 0; i < offset.Count; i++)
            {
                if (i + offset[i] >= offset.Count)
                {
                    if (i + offset[i] - offset.Count == val)
                    {
                        return i;
                    }
                }
                else
                {
                    if (i + offset[i] == val)
                    {
                        return i;
                    }
                }

            }
            return 0;
        }

        //rotate the rotor 
        public bool Rotate()
        {
            offset.Insert(0, offset.Last());
            offset.RemoveAt(offset.Count - 1);

            position++;

            //determines if the rotor needs to be rotated 
            if (position == offset.Count)
            {
                position = 0;
            }
            //if the previous rotor needs to be rotated
            if (position == originalPosition)
            {
                return true;
            }
            // if the previous rotor does not need to be rotated
            else
            {
                return false;
            }

        }
    }
}
