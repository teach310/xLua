using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;
using Sample.AdvCommandInterfaces;

public class SampleScene : MonoBehaviour
{
    public class AdvCommand : IAdvCommand
    {
        public void ShowMessage(string message)
        {
            Debug.Log(message);
        }

        public XLua.Custom.LuaAdvCommandAdapter GetAdapter()
        {
            return new XLua.Custom.LuaAdvCommandAdapter(this);
        }
    }

    void Start()
    {
        var luaEnv = new LuaEnv();
        var advCommand = new AdvCommand();
        luaEnv.Global.Set("adv", advCommand.GetAdapter());
        luaEnv.DoString(@"
            adv:ShowMessage('Hello World!')
        ");
        luaEnv.Dispose();
    }
}
