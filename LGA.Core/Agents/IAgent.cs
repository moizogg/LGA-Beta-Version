using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LGA.Core.Models;

namespace LGA.Core.Agents
{
    public interface IAgent
    {
        string Name { get; }

        Task ExecuteAsync(
            Lead lead
        );
    }
}
