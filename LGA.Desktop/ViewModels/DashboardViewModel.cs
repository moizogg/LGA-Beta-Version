using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LGA.Desktop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGA.Desktop.ViewModels
{
    public partial class DashboardViewModel : ObservableObject
    {
        [ObservableProperty]
        private string userName = "Cristian Flores"; //Temp
        [ObservableProperty]
        private string welcomeMessage = "Welcome to LGA AI Agent Platform";
        [RelayCommand]
        private async Task RunAgent()
        {


            await _agentService
                .ExecuteLeadAnalysis();


        }
        private readonly AgentExecutionService
        _agentService;



        public DashboardViewModel(
            AgentExecutionService agentService
        )
        {

            _agentService =
                agentService;

        }

    }
}
