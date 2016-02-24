﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarLight.AI
{
    public static class BotFactory
    {
        public static readonly string[] Names = new[] { "Wunderwaffe", "Prod" };

        public static IWarLightAI Construct(string name)
        {
            switch (name.ToLower())
            {
                case "wunderwaffe":
                    return new Wunderwaffe.Bot.BotMain();
                case "prod":
                    return new Prod.BotMain();
                default:
                    throw new Exception("No bot found named " + name + ", supported names are: " + Names.JoinStrings(", "));
            }
        }
    }
}
