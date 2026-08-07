using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGA.Core.Agents
{
    public class AgentRegistry
    {
        private readonly Dictionary<string, IAgent> _agents;
        public AgentRegistry()
        {
            _agents = new Dictionary<string, IAgent>();
        }

        public void Register(IAgent agent)
        {
            if (!_agents.ContainsKey(agent.Name))
            {
                _agents.Add(agent.Name, agent);
            }
        }

        public IAgent? GetAgent(string name)
        {

            if (_agents.TryGetValue(name, out var agent))
            {
                return agent;
            }
            return null;
        }



        public IEnumerable<IAgent> GetAll()
        {
            return _agents.Values;
        }
    }
}
