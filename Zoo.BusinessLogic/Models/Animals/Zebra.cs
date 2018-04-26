using System;

namespace Zoo.BusinessLogic.Models.Animals
{
  public class Zebra : AnimalThatCanBeGroomed , ICanHaveMuckSweptOut
    {

        private DateTime lastCleaned;
    public Zebra(DateTime dateOfBirth) : base(dateOfBirth)
    {
    }

        public void Clean()
        {
            lastCleaned = DateTime.Now;
        }

        public override string ToString()
        {
            return base.ToString() + $"; Last Cleaned {lastCleaned}";
        }

    }
}