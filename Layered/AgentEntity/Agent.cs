using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentEntity
{
    [Serializable]
    public class Agent
    {
        public int AgentID { get; set; }
        public string AgentName { get; set; }
        public Gender Gender { get; set; }  
        public int Paymode { get; set; }
        public double Premium { get; set; }

        public override string ToString()
        {
            return "Agent ID:  " + AgentID + "  AgentName: " + AgentName + "  Gender: " + Gender + "  PayMode: " + Paymode + "  Premium: " + Premium;
         }
    }
}
