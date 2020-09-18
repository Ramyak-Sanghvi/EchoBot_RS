// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
//
// Generated with Bot Builder V4 SDK Template for Visual Studio EchoBot v4.10.3

using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;

namespace EchoBot_RS.Bots
{
    public class EchoBot : ActivityHandler
    {
        protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {
            string[] values = turnContext.Activity.Text.Split(',');
            TeamsText.Response text = new TeamsText.Response();
            text.Id = Convert.ToInt32(values[0].Trim());
            text.Text = values[1].Trim();
            using (var output = File.Create("teamsText.dat"))
            {
                text.WriteTo(output);
            }
            TeamsText.Response text1;
            using (var input = File.OpenRead("teamsText.dat"))
            {
                text1 = TeamsText.Response.Parser.ParseFrom(input);
            }
            Console.WriteLine(text1.Id);
            Console.WriteLine(text1.Text);

            var replyText = turnContext.Activity.From.Name + ": " + turnContext.Activity.Text;
            Console.WriteLine(replyText);
            await turnContext.SendActivityAsync(MessageFactory.Text(replyText, replyText), cancellationToken);
        }
    }
}
