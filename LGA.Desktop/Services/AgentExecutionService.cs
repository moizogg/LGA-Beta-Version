using LGA.Core.Models;
using LGA.Core.Workflow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGA.Desktop.Services
{
    public class AgentExecutionService
    {


        private readonly WorkflowEngine
            _workflowEngine;



        public AgentExecutionService(
            WorkflowEngine workflowEngine
        )
        {

            _workflowEngine =
                workflowEngine;

        }




        public async Task ExecuteLeadAnalysis()
        {


            var lead =
                new Lead
                {

                    Name =
                    "Demo Customer",


                    Company =
                    "Sample Company",


                    Email =
                    "customer@test.com"

                };



            await _workflowEngine
                .ExecuteAsync(
                    lead
                );


        }


    }
}
