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






        // void TakeDamage(int amount)
        //{

        //}

        // public string GetMovementAttackDescription()
        // {
        // returns string contaiing movespeed, attack range, and damange
        //   return Console.WriteLine("MoveSpeed is: {0}", moveSpeed);
        // }

        // abstract string GetSpecialDescription()
        // {
        //returns a descritption of the special attack 
        // }

        // string Attack(Character target)
        // {
        //strings a string if the attack was successful or not 
        // }

        //abstract string Special(Character target)
        //{
        //returns a string describing what happened 
        //}





    }
}
