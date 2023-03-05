using System.Collections;
using System.Collections.Generic;
using Sample.AdvCommandInterfaces;
using UnityEngine;

namespace XLua.Custom
{
    [LuaCallCSharp]
    public class LuaAdvCommandAdapter
    {
        public IAdvCommand advCommand;

        public LuaAdvCommandAdapter(IAdvCommand advCommand)
        {
            this.advCommand = advCommand;
        }

        public void ShowMessage(string message)
        {
            advCommand.ShowMessage(message);
        }
    }
}
