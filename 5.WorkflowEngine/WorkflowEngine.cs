public class WorkflowEngine
{
    public void Run(Workflow workflow)
    {
        foreach (var activitiy in workflow.Activities)
        {
            activitiy.Execute();
        }
    }
}