namespace InterfacesExercises
{
    public interface IWorkflowActivity
    {
        void Execute();
    }
    public class WorkflowActivity : IWorkflowActivity
    {
        private readonly string _activity;

        public WorkflowActivity(string activity)
        {
            if(activity == null)
            {
                throw new ArgumentNullException();
            }
            this._activity = activity;
        }

        public void Execute()
        {
            Console.WriteLine(string.Format("Executing {0}", this._activity));
        }
    }
    class WorkflowEngine
    {
        private readonly List<WorkflowActivity> _activities = new List<WorkflowActivity>();


        public void AddActivity(WorkflowActivity newActivity)
        {
            if(newActivity == null)
            {
                throw new ArgumentNullException();
            }
            _activities.Add(newActivity);
        }


        public void Run()
        {
            if (_activities.Count > 0)
            {
                foreach(WorkflowActivity activity in this._activities)
                {
                    activity.Execute();
                }
            }
        }
    }
}
