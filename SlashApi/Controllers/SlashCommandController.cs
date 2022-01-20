using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;

namespace SlashApi.Controllers
{
    public class SlashCommandController : Controller
    {
        [Route("/api/slack/slashcommand")]
        [HttpPost]
        [Produces("application/json")]
        public string HandleCommand(SlashCommandPayload slashCommandPayload)
        {
            Ping sender = new();
            PingReply reply = sender.Send("8.8.8.8", 1000);

            return $"Ping to 8.8.8.8 sent, Ping {reply.Status} reply Message";
        }
    }
}
