using System;

namespace Zoo.BusinessLogic.Models.Animals
{
  public class Lion : Animal, ICanHaveMuckSweptOut
    {

        private DateTime lastCleaned;


        public Lion(DateTime dateOfBirth) : base(dateOfBirth)
    {
    }
        public void Clean()
        {
            lastCleaned = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Last Cleaned {lastCleaned}";
        }

    }
}
 