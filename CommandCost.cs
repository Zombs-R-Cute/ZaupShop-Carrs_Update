﻿using System.Collections.Generic;

using Rocket.API;
using Rocket.Unturned.Player;

namespace ZaupShop
{
    public class CommandCost : IRocketCommand
    {

        public AllowedCaller AllowedCaller
        {
            get
            {
                return AllowedCaller.Player;
            }
        }
        public string Name
        {
            get
            {
                return "cost";
            }
        }
        public string Help
        {
            get
            {
                return "Tells you the cost of a selected item.";
            }
        }
        public string Syntax
        {
            get
            {
                return "[v.]<name or id>";
            }
        }
        public List<string> Aliases
        {
            get { return new List<string>(); }
        }
        public List<string> Permissions
        {
            get { return new List<string>(); }
        }
        public void Execute(IRocketPlayer playerid, string[] msg)
        {
            ZaupShop.Instance.Cost((UnturnedPlayer)playerid, msg);
        }
    }
}