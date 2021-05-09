﻿using System.Collections.Generic;

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

}
