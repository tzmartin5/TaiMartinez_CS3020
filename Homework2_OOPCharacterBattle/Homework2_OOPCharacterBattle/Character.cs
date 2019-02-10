using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_OOPCharacterBattle
{
   public abstract class Character
    {

        int moveSpeed = 0;
        int damagePerAttack = 0;
        int health = 0;
        int position = 0;
        int priority = 0;
        int attackRange = 0;

        void TakeDamage(int amount)
        {

        }

        string GetMovementAttackDescription()
        {
            // returns string contaiing movespeed, attack range, and damange
            return ;
        }

        abstract string GetSpecialDescription()
        {
            //returns a descritption of the special attack 
        }

        string Attack(Character target)
        {
            //strings a string if the attack was successful or not 
        }

        abstract string Special(Character target)
        {
            //returns a string describing what happened 
        }





    }
}
