var workflowEngine = new WorkflowEngine();
var workflow = new Workflow();

workflow.AddActivity(new SendRequestActivity());
workflow.AddActivity(new DisplayOutputActivity());

workflowEngine.Run(workflow);