using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_OOPCharacterBattle
{
    public abstract class Character
    {

        int moveSpeed;
        int damagePerAttack;
        int health;
        int position;
        int priority;
        int attackRange;

       //constructor 
        public Character(int mSpeed, int damage)
        {
            moveSpeed = mSpeed;
            damagePerAttack = damage;
        }

        //default constructor 
        public Character()
        {
        }

        //handle moveSpeed
        public int MSpeed
        {
            get {return moveSpeed;  }
            set{ moveSpeed = value; }
        }

        abstract public int MovesSpeed();

        //handle damagePerAttack 
        public int DamageAttack
        {
            get { return damagePerAttack; }
            set { damagePerAttack = value; }
        }

        abstract public int Damages();

        //handle health 
        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        abstract public int CharacterHealth();

        //handle position
        public int Position
        {
            get { return position; }
            set { position = value; }
        }

        abstract public int CharacterPosition();

        //handle priority 
        public int Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        abstract public int CharacterPriority();

        //handle attack range 
        public int AttackRange
        {
            get { return attackRange; }
            set { attackRange = value; }
        }

        abstract public int CharacterAttackRange();


         void TakeDamage(int amount)
        {
            health = health - damagePerAttack;
        }

        // returns string containing movespeed, attack range, and damange
        public string GetMovementAttackDescription()
         {
            string information = "(Max movement = " + moveSpeed + "Attack range = " + attackRange +  "Damage = " + damagePerAttack + ")";

       
            return information;
        }

      //   abstract string GetSpecialDescription()
       //  {
        //returns a descritption of the special attack 
        // }

        // string Attack(Character target)
        // {
        //strings a string if the attack was successful or not 
        // }

        //abstract string Special(Character target)
        //{
        //returns a string describing what happened 
       // }





    }
}
