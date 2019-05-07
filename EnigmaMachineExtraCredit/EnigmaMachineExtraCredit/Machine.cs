using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaMachineExtraCredit
{
    class Machine
    {
        Rotor first;
        Rotor middle;
        Rotor last;
        Reflector reflector;

        //sets the machine
        public Machine(Rotor first, int leftStartingPosition, Rotor middle, int middleStartingPosition, Rotor last, int rightStartingPosition, Reflector reflector)
        {
            this.first = first;
            for (int i = 0; i < leftStartingPosition; i++)
            {
                first.Rotate();
            }

            this.first.originalPosition = leftStartingPosition;
            this.middle = middle;

            for (int i = 0; i < middleStartingPosition; i++)
            {
                middle.Rotate();
            }

            this.middle.originalPosition = middleStartingPosition;
            this.last = last;

            for (int i = 0; i < rightStartingPosition; i++)
            {
                last.Rotate();
            }

            this.last.originalPosition = rightStartingPosition;
            this.reflector = reflector;
        }

        //gets the input value and creates result
        public int InputValue(int i)
        {
            int result = last.Input(middle.Input(first.Input(i)));
            result = reflector.Input(result);
            result = first.InputReverse(middle.InputReverse(last.InputReverse(result)));

            RotateRotors();
            return result;
        }

        //rotate the rotors if needed 
        void RotateRotors()
        {
            if (last.Rotate())
            {
                if (middle.Rotate())
                {
                    first.Rotate();
                }
            }
        }
    }
}
