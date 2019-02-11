using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_OOPCharacterBattle
{
   public class Warrior : Character
    {

       int moveSpeed = 2;
       int damagePerAttack = 20;
       int health = 75;
       int priority = 3;
        int attackRange = 1;


        //handles moveSpeed
        public int Moves
        {
            get { return moveSpeed; }
            set { moveSpeed = value; }
        }

        public override int MovesSpeed()
        { return Moves;}


        //handle damange 
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
        int position;
        public override int CharacterPosition()
        {
            return position;
        }

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
            return "Leaps up to 8 units toward the target. If target is greater than 5 units way, but less than 9, deals 30 damage";
        }


        //leap up to 8 units to the spot infront of the oppenent if possible, if opponent is greater than 5 units away, deal 30 damange 
      public override string Special(Character target)
        {
            if (attackRange >= target.Position)
            {
                return "Oppenent in range - Special unleashed.";
            }
            else
            {
                return "Oppenent not in range - special denied";
            }
        }




    }
}
