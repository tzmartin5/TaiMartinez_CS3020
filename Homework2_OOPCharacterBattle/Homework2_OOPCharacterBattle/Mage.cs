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
         int health = 50;
         int priority = 2;
         int attackRange = 6;
        int position = 23;

        //handles moveSpeed
        public int Moves
        {
            get { return moveSpeed; }
            set { moveSpeed = value; }
        }

        public override int MovesSpeed()
        { return Moves; }

        //handle damage 
        public int SetDamage
        {
            get { return damagePerAttack; }
            set { damagePerAttack = value; }
        }

        public override int Damages()
        { return SetDamage; }

        //handle health 
        public int SetHealth
        {
            get { return health; }
            set { health = value; }
        }

        public override int CharacterHealth()
        { return SetHealth; }

        //handle position
        public int SetPosition
        {
            get { return position; }
            set { position = value; }
        }

        public override int CharacterPosition()
        { return SetPosition; }

        //handle priority 
        public int SetPriority 
        {
            get { return priority; }
            set { priority = value; }
        }

        public override int CharacterPriority()
        { return SetPriority; }

        //handle attack range 
        public int SetAttackRange
        {
            get { return attackRange; }
            set { attackRange = value; }
        }

        public override int CharacterAttackRange()
        { return SetAttackRange; }



        public override string GetSpecialDescription()
        {
            return "3 range attack that knocks the oppenent away 4 units and deals 10 damage";
        }


        //knock back the oppenent 4 units, range 3, deals 3 damange 
        public override string Special(Character target)
        {
            if (attackRange >= target.Position)
            {
                return "Oppenent in range - Special unleashed, oppenent knocked back 4 units and 3 damage.";
            }
            else
            {
                return "Oppenent not in range - special denied";
            }
        }



    }
}
