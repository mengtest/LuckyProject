//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FairyGUI_GLuaComboBoxWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(FairyGUI.GLuaComboBox), typeof(FairyGUI.GComboBox));
		L.RegFunction("Dispose", Dispose);
		L.RegFunction("New", _CreateFairyGUI_GLuaComboBox);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateFairyGUI_GLuaComboBox(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				FairyGUI.GLuaComboBox obj = new FairyGUI.GLuaComboBox();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: FairyGUI.GLuaComboBox.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Dispose(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.GLuaComboBox obj = (FairyGUI.GLuaComboBox)ToLua.CheckObject<FairyGUI.GLuaComboBox>(L, 1);
			obj.Dispose();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

