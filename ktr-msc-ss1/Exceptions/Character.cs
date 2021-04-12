using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktr_msc_ss1
{
    public abstract class Character : Movable
    {
        protected string _name;
        protected int _life = 50;
        protected int _agility = 2;
        protected int _strength = 2;
        protected int _wit = 2;
        protected readonly string _rpgClass;

        public string GetName() => _name;
        public int GetLife() => _life;
        public int GetAgility() => _agility;
        public int GetStrength() => _strength;
        public int GetWit() => _wit;
        public string GetRPGClass() => _rpgClass;

        public Character(string name, string rpgClass)
        {
            _name = name;
            _rpgClass = rpgClass;
        }

        protected string GenerateMessage(string message) => $"{_name}: {message}";

        protected void Speak(string phrase)
        {
            Console.WriteLine(GenerateMessage(phrase));
        }

        public virtual void Attack(string weapon)
        {
            Speak("Rrrrrrrrr ....");
        }

        public void TryToAttack(string weapon)
        {
            try
            {
                Attack(weapon);
            }
            catch (WeaponException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Unsheathe()
        {
            Speak("Unsheathes his weapon.");
        }

        public virtual void MoveLeft()
        {
            Speak("Moves left");
        }

        public virtual void MoveRight()
        {
            Speak("Moves right");
        }

        public virtual void MoveForward()
        {
            Speak("Moves forward");
        }

        public virtual void MoveBack()
        {
            Speak("Moves back");
        }
    }
}
