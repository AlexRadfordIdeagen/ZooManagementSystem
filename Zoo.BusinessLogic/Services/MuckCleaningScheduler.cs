namespace Zoo.BusinessLogic
{
    public class MuckCleaningScheduler : AssignJobs
    {
      
    private static MuckCleaningScheduler instance;

        public static MuckCleaningScheduler Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MuckCleaningScheduler();
                }

                return instance;
            }
        }

        private MuckCleaningScheduler()
        {
        }
    }
}