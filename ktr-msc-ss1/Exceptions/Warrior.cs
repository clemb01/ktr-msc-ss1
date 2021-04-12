using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktr_msc_ss1
{
    public class Warrior : Character
    {
        public Warrior(string name) : base(name, "Warrior")
        {
            _life = 100;
            _strength = 10;
            _agility = 8;
            _wit = 3;

            Speak("My name will go down in history !");
        }

        public override void Attack(string weapon)
        {
            if (string.IsNullOrEmpty(weapon))
                throw new WeaponException(GenerateMessage("I refuse to fight with my bare hands."));

            if (weapon == "sword" || weapon == "hammer")
            {
                base.Attack(weapon);
                Speak($"I'll crush you with my {weapon}!");
            }
            else
            {
                throw new WeaponException(GenerateMessage($"A {weapon}?? What should I do with this?!"));
            }
        }

        public override void MoveLeft()
        {
            Speak("Moves left like a bad boy.");
        }

        public override void MoveRight()
        {
            Speak("Moves right like a bad boy.");
        }

        public override void MoveForward()
        {
            Speak("Moves forward like a bad boy.");
        }

        public override void MoveBack()
        {
            Speak("Moves back like a bad boy.");
        }
    }
}
