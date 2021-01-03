using Microsoft.AspNetCore.SignalR;
using NetCoreAngularChat.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAngularChat.API.Hubs
{
    public class ChartHub : Hub
    {
        public async Task BroadcastChartData(List<ChartModel> data) => await Clients.All.SendAsync("Broadcastchartdata", data);
    }
}
