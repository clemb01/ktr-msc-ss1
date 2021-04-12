using System;

namespace ktr_msc_ss1
{
    class Program
    {
        static void Main(string[] args)
        {
            Character warrior = new Warrior("Jean-Luc");
            Character mage = new Mage("Robert");

            warrior.Attack("hammer");
            mage.Attack("magic");

            warrior.MoveRight();
            warrior.MoveLeft();
            warrior.MoveBack();
            warrior.MoveForward();
            mage.MoveRight();
            mage.MoveLeft();
            mage.MoveBack();
            mage.MoveForward();

            warrior.TryToAttack("screwdriver");
            mage.TryToAttack("hammer");
            warrior.TryToAttack("hammer");

            try
            {
                mage.Attack("");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
