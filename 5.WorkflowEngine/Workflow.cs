public class Workflow
{

    public List<IWorkflowActivity> Activities { get; private set; } = new List<IWorkflowActivity>();

    public void AddActivity(IWorkflowActivity workFlowActivity)
    {
        Activities.Add(workFlowActivity);
    }
}