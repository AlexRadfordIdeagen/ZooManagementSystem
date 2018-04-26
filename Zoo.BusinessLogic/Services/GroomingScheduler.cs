namespace Zoo.BusinessLogic.Services
{
  public class GroomingScheduler : AssignJobs
    {
    private static GroomingScheduler instance;

    public static GroomingScheduler Instance
    {
      get
      {
        if (instance == null)
        {
          instance = new GroomingScheduler();
        }

        return instance;
      }
    }

    private GroomingScheduler()
    {
    }
  }
}