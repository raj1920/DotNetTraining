using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AgentEntity;
using Exceptions;
using AgentBusinessLayer;
using System.Threading.Tasks;

namespace EmployProject
{
    class Program
    {
        static int agntID = 1;
        
        static AgentBAL bal = new AgentBAL();
        public static void AddAgentMain()
        {
            Agent agent = new Agent();
            Console.WriteLine("Enter AgentID: " +agntID);
            agent.AgentID = agntID;
            agntID++;
            Console.WriteLine("Enter Agent Name:  ");
            agent.AgentName = Console.ReadLine();
            Console.WriteLine("Enter Gender: ");
            string gen = Console.ReadLine().ToUpper();
            if (gen.Equals("MALE"))
            {
                agent.Gender = Gender.MALE;
            }
            else if (gen.Equals("FEMALE"))
            {
                agent.Gender = Gender.FEMALE;
            }
            else
            {
                throw new AgentException("Gender must be male or female: ");
            }
            Console.WriteLine("Enter PayMode: ");
            agent.Paymode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Premium: ");
            agent.Premium = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(bal.AddAgentBAL(agent));
          //  bal.AddAgentBAL(agent);

        }
        public static void UpdateEmployMain()
        {
            Console.WriteLine("Enter the Agent you Want To Update: \r\n");
            Agent agent = new Agent();
            Console.WriteLine("Enter AgentID:   ");
            agent.AgentID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Agent Name:  ");
            agent.AgentName = Console.ReadLine();
            Console.WriteLine("Enter Gender: ");
            string gen = Console.ReadLine().ToUpper();
            if (gen.Equals("MALE"))
            {
                agent.Gender = Gender.MALE;
            }
            if (gen.Equals("FEMALE"))
            {
                agent.Gender = Gender.FEMALE;
            }
            Console.WriteLine("Enter PayMode: ");
            agent.Paymode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Premium: ");
            agent.Premium = Convert.ToDouble(Console.ReadLine());
            bal.UpdateAgentBAL(agent);

        }

        public static void SearchAgentMain()
        {
            int agentID;
            Console.WriteLine("Enter Employ No  ");
            agentID = Convert.ToInt32(Console.ReadLine());
            Agent agent = bal.SearchAgentBAL(agentID);
            if (agent != null)
            {
                Console.WriteLine(agent);
            }
            else
            {
                Console.WriteLine("Record Not Found...");
            }
        }

        public static void DeleteAgentMain()
        {
            int agentID;
            Console.WriteLine("Enter AgentID:   ");
            agentID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(bal.DeleteAgentBAL(agentID));
        }
        public static void ShowAgentMain()
        {
            List<Agent> agentList = bal.ShowAgentBAL();
             foreach (Agent agent in agentList)
            {
                Console.WriteLine(agent);
            }
        }

        public static void ReadAgentFileMain()
        {
            Console.WriteLine(bal.ReadAgentFileBAL());
            //bal.ReadAgentFileBAL();
        }
        public static void WriteAgentFileMain()
        {
            Console.WriteLine(bal.WriteAgentFileBAL());
           // bal.WriteAgentFileBAL();
        }

        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("O P T I O N S ");
                Console.WriteLine("--------------");
                Console.WriteLine("1. Add Agent");
                Console.WriteLine("2. Show Agent");
                Console.WriteLine("3. Search Agent");
                Console.WriteLine("4. Delete Agent");
                Console.WriteLine("5. Update Agent");
                Console.WriteLine("6. Write Agent");
                Console.WriteLine("7. Read Agent");
                Console.WriteLine("8. Exit");
                Console.WriteLine("Enter Your Choice   ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        try
                        {
                            AddAgentMain();
                        }
                        catch (AgentException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                        break;
                    case 2:
                        ShowAgentMain();
                        break;
                    case 3:
                        SearchAgentMain();
                        break;
                    case 4:
                        DeleteAgentMain();
                        break;
                    case 5:
                        UpdateEmployMain();
                        break;
                    case 6:
                        WriteAgentFileMain();
                        break;
                    case 7:
                        ReadAgentFileMain();
                        break;
                    case 8:
                        return;
                }
            } while (choice != 8);
        }
    }
}