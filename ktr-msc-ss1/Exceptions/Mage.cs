using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktr_msc_ss1
{
    public class Mage : Character
    {
        public Mage(string name) : base(name, "Mage")
        {
            _life = 70;
            _strength = 3;
            _agility = 10;
            _wit = 10;

            Speak("May the gods be with me.");
        }

        public override void Attack(string weapon)
        {
            if (string.IsNullOrEmpty(weapon))
            {
                throw new WeaponException(GenerateMessage("I refuse to fight with my bare hands."));
            }

            if (weapon == "magic" || weapon == "wand")
            {
                base.Attack(weapon);
                Speak($"Feel the power of my {weapon}!");
            }
            else
            {
                throw new WeaponException(GenerateMessage($"I don 't need this stupid {weapon}! Don 't misjudge my powers !"));
            }
        }

        public override void MoveLeft()
        {
            Speak("Moves left furtively.");
        }

        public override void MoveRight()
        {
            Speak("Moves right furtively.");
        }

        public override void MoveForward()
        {
            Speak("Moves forward furtively.");
        }

        public override void MoveBack()
        {
            Speak("Moves back furtively.");
        }
    }
}
