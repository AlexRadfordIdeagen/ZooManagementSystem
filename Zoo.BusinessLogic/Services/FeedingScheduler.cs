namespace Zoo.BusinessLogic.Services
{
  public class FeedingScheduler : AssignJobs
    {
    private static FeedingScheduler instance;

    public static FeedingScheduler Instance
    {
      get
      {
        if (instance == null)
        {
          instance = new FeedingScheduler();
        }

        return instance;
      }
    }

    private FeedingScheduler()
    {
    }
  }
}