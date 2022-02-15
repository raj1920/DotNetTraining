using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Exceptions;
using AgentEntity;
using AgentDataLayer;
using System.Threading.Tasks;

namespace AgentBusinessLayer
{
    public class AgentBAL
    {
        static StringBuilder sb = new StringBuilder();
        static AgentDAL dal = new AgentDAL();
        public bool ValidateAgent(Agent agent)
        {
            bool isValid = true;
            if(agent.AgentName.Length<5 || agent.AgentName.Length >= 12)
            {
                sb.Append("Agent Name Contains less than 5 character or more than 12 character..\r\n");
                isValid = false;
            }
           if(agent.Paymode> 3)
           {
                sb.Append("Enter Valid PayMode.. \r\n");
                isValid=false;
            }
            if (agent.Premium < 15000)
            {
                sb.Append("Premium Should me more than 15000...\r\n");
                isValid = false;
            }
            
            return isValid; 
        }
        public string ReadAgentFileBAL()
        {
            return dal.ReadAgentFileDAL();
        }
        public string WriteAgentFileBAL()
        {
            return dal.WriteAgentFileDAL();
        }
        public string DeleteAgentBAL(int AgentID)
        {
            return dal.DeleteAgentDAL(AgentID);
        }
        public string AddAgentBAL(Agent agent)
        {
            if (ValidateAgent(agent) == false)
            {
                throw new AgentException(sb.ToString());
            }
            else
            {
                return dal.AddAgentDAL(agent);
            }
        }
        public Agent SearchAgentBAL(int agentID)
        {
            return dal.SearchAgentDAL(agentID);
        }
        public string UpdateAgentBAL(Agent agent)
        {
            return dal.UpdateAgentDAL(agent);
        }

        public List<Agent> ShowAgentBAL()
        {
            return dal.ShowAgentDAL();
        }

    }
}
