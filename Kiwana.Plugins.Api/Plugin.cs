﻿using System.Collections.Generic;

namespace Kiwana.Plugins.Api
{
    /// <summary>
    /// The class all Plugins must inherit from.
    /// </summary>
    public abstract class Plugin
    {
        /// <summary>
        /// The delegate for the SendData function. This will be given to you from the core assembly every call.
        /// </summary>
        /// <param name="command"></param>
        /// <param name="argument"></param>
        public delegate void SendDataEventHandler(string command, string argument = "");

        /// <summary>
        /// Used to send the data back to the core.
        /// </summary>
        //public event SendDataEventHandler SendData;

        /// <summary>
        /// This method gets called every time there's an input that has to be handled by this plugin.
        /// </summary>
        /// <param name="ex">The List of strings resulting from splitting the input line at ' '. The command will already be matched to the name specified in the config (in lower case).</param>
        /// <param name="UserAuthenticated">Whether the user issuing the command is on the user list and authenticated with NickServ, or not.</param>
        /// <param name="console">Whether the command was issued from the console or not.</param>
        public abstract void HandleLine(List<string> ex, bool userAuthenticated, bool console, SendDataEventHandler SendData);
    }
}
