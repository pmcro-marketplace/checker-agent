using A2A;
using Microsoft.Agents.AI;
var baseUrl=args.Length==1?args[0]:"http://127.0.0.1:5094";
var resolver=new A2ACardResolver(new Uri(baseUrl));
AIAgent remote=await resolver.GetAIAgentAsync();
AgentResponse response=await remote.RunAsync("PMCR-O Checker A2A transport proof. Do not verify or mutate.");
if(!response.Text.StartsWith("NOT_INVOKED:",StringComparison.Ordinal)){Console.Error.WriteLine("FAIL "+response.Text);return 1;}
Console.WriteLine("PASS A2A discovery");Console.WriteLine("PASS A2A message transport");Console.WriteLine(response.Text);return 0;
