// Default URL for triggering event grid function in the local environment.
// http://localhost:7071/runtime/webhooks/EventGrid?functionName={functionname}

using System;
using Azure.Messaging;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace az_func_eg_eh_sb_stg
{
    public class DefenderDoneHandler(ILogger<DefenderDoneHandler> logger)
    {
        private readonly ILogger<DefenderDoneHandler> _logger = logger;

        [Function(nameof(DefenderDoneHandler)), ]
        public void Run([EventGridTrigger] CloudEvent cloudEvent) //, FunctionContext context)
        {
//             using (var output = binder.BindAsync<T>(new BindingTypeAttribute(...)))
// {
// }
            _logger.LogInformation("Event type: {type}, Event subject: {subject}", cloudEvent.Type, cloudEvent.Subject);
        }
    }
}
