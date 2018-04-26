using System.Collections.Generic;
using Zoo.BusinessLogic.Models;
using Zoo.BusinessLogic.Models.Animals;

namespace Zoo.BusinessLogic
{
    public class AssignJobs
    {
        public void AssignGroomingJobs(IEnumerable<Keeper> keepers, IEnumerable<Animal> animals)
        {
            foreach (var keeper in keepers)
            {
                foreach (var animal in keeper.GetResponsibleAnimals())
                {
                    var groomableAnimal = animal as AnimalThatCanBeGroomed;

                    if (groomableAnimal != null)
                    {
                        keeper.GroomAnimal(groomableAnimal);
                    }
                }
            }
        }

        public void AssignFeedingJobs(IEnumerable<Keeper> keepers, IEnumerable<Animal> animals)
        {
            foreach (var keeper in keepers)
            {
                foreach (var animal in keeper.GetResponsibleAnimals())
                {
                    if (animal.IsHungry())
                    {
                        keeper.FeedAnimal(animal);
                    }
                }
            }
        }

        public void AssignCleaningJobs(IEnumerable<Keeper> keepers, IEnumerable<Animal> animals)
        {
            foreach (var keeper in keepers)
            {
                foreach (var animal in keeper.GetResponsibleAnimals())
                {
                    var cleanableAnimal = animal as ICanHaveMuckSweptOut;

                    if (cleanableAnimal != null)
                    {
                        keeper.CleanableAnimal(cleanableAnimal);
                    }
                }
            }
        }

    }
}
