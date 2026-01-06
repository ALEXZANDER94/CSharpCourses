using System;

namespace InterfacesExercises
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // 1) Design a workflow engine that takes a workflow object and runs it. A workflow is a series of steps or activities.
            // The workflow engine class should have one method called Run() that takes a workflow, and then iterates over each activity in the workflow and runs it
            try
            {
                WorkflowEngine workflowEngine = new WorkflowEngine();
                workflowEngine.AddActivity(new WorkflowActivity("Uploading a video"));
                workflowEngine.AddActivity(new WorkflowActivity("Posting video to frontend"));
                workflowEngine.AddActivity(new WorkflowActivity("Sending an Email"));
                workflowEngine.AddActivity(new WorkflowActivity("Moving status to published"));
                workflowEngine.Run();
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("WorkflowEngine : Null argument found");
            }
        }
    }
}
