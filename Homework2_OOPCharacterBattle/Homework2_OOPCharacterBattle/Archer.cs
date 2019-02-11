using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_OOPCharacterBattle
{
   public class Archer : Character
    {
        int moveSpeed = 3;
        int damagePerAttack = 15;
        int health = 65;
        int priority = 1;
        int attackRange = 3;

       
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

        //override string Special(Character target)
        //12 range attack, deals 10 damage




    }
}
