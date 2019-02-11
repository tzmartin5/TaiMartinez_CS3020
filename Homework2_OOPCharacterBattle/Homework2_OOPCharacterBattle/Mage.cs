using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_OOPCharacterBattle
{
    public class Mage: Character
    {

         int moveSpeed = 1;
         int damagePerAttack = 20;
        // int health = 50;
        // int priority = 2;
        // int attackRange = 6;       


        //handles moveSpeed
        public int Moves
        {
            get { return moveSpeed; }
            set { moveSpeed = value; }
        }

        public override int MovesSpeed()
        { return Moves; }

        //handle damange 
        public int SetDamage
        {
            get { return damagePerAttack; }
            set { damagePerAttack = value; }
        }

        public override int Damages()
        { return SetDamage; }






        //override string Special(Character target)
        //knock back the oppenent 4 units, range 3, deals 3 damange 



    }
}
