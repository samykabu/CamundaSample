using System;
using System.Collections.Generic;

namespace CamundaClient.Dto
{
    public class ProcessInstance
    {
        public string Id { get; set; }
        public string DefinitionId { get; set; }
        public string BusinessKey { get; set; }
        public bool Ended { get; set; }
        public bool Suspended { get; set; }
        public Dictionary<string, Variable> Variables { get; set; }
        public override string ToString() => $"ProcessInstance [Id={Id}, BusinessKey={BusinessKey}]";
    }

    public class GenericResponse
    {
        public string type { get; set; }
        public string message { get; set; }
    }
    public class ProcessInstanceStatus
    {
        public string Id { get; set; }
        public DateTime? startTime { get; set; }
        public DateTime? endTime { get; set; }
        public long? durationInMillis { get; set; }
        public string state { get; set; }

    }
    public class ProcessInstanceVariable
    {
        public string type { get; set; }
        public object value { get; set; }
       public string name { get; set; }
    }

}
