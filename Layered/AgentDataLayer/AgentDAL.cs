using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AgentEntity;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace AgentDataLayer
{
    public class AgentDAL
    {
        static List<Agent> agentList = new List<Agent>();
        static AgentDAL()
        {
            agentList = new List<Agent>();
        }
        public string ReadAgentFileDAL()
        {
            FileStream fs = new FileStream("E:/files/AgentProject.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter binf = new BinaryFormatter();
            agentList = (List<Agent>)binf.Deserialize(fs);
            foreach (Agent agent in agentList)
            {
                Console.WriteLine(agent);
            }
            
            fs.Close();
            return "Data Restored...";
        }
        public string WriteAgentFileDAL()
        {
            FileStream fs = new FileStream("E:/files/AgentProject.txt", FileMode.Create, FileAccess.Write);
            BinaryFormatter binf = new BinaryFormatter();
            binf.Serialize(fs, agentList);
            fs.Close();
            return "Data Stored in File...";
        }
        public string DeleteAgentDAL(int AgentId)
        {
            Agent agentFound = SearchAgentDAL(AgentId);
            if (agentFound != null)
            {
                agentList.Remove(agentFound);
            }
            return "Agent Record Deleted...";
        }
        public Agent SearchAgentDAL(int AgentId)
        {
            Agent agentFound = null;
            foreach (Agent agent in agentList)
            {
                if (agent.AgentID == AgentId)
                {
                    agentFound = agent;
                }
            }
            return agentFound;

        }
        public string AddAgentDAL(Agent agent)
        {
            agentList.Add(agent);
            return "Agent Added..";
        }
        public List<Agent> ShowAgentDAL()
        {
            return agentList;
        }
        public string UpdateAgentDAL(Agent agent)
        {
            int agentId = agent.AgentID;
            int index = -1;
            foreach (Agent a in agentList)
            {
                if (a.AgentID == agentId)
                {
                    index++;
                    break;
                }
                else
                {
                    index++;
                }
            }
            if (index != -1)
                //  agents.Insert(index, agent);
                agentList[index] = agent;
            return "Agent Updated";

        }
    }
}
