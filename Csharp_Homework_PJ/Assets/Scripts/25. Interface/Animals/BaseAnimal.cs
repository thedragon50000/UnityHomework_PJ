using System;
using UnityEngine;

namespace _25._Interface.Animals
{
    public abstract class BaseAnimal
    {
        private protected E_Animals _eAnimals;

        public string StrName = "";

        public Action[] Actions;

        protected BaseAnimal(E_Animals e)
        {
            _eAnimals = e;
        }

        public virtual void Start()
        {
            Actions = new Action[] {Eat, Sleep, Move};
        }

        private void Sleep()
        {
            Debug.Log(StrName + " Sleep.");
        }

        private void Eat()
        {
            Debug.Log(StrName + " Eat.");
        }

        protected virtual void Move()
        {
            Debug.Log(StrName + " Move.");
        }
    }
}