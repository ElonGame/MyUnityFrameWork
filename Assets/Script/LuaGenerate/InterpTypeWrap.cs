﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class InterpTypeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(InterpType));
		L.RegVar("Default", get_Default, null);
		L.RegVar("Linear", get_Linear, null);
		L.RegVar("InBack", get_InBack, null);
		L.RegVar("OutBack", get_OutBack, null);
		L.RegVar("InOutBack", get_InOutBack, null);
		L.RegVar("OutInBack", get_OutInBack, null);
		L.RegVar("InQuad", get_InQuad, null);
		L.RegVar("OutQuad", get_OutQuad, null);
		L.RegVar("InoutQuad", get_InoutQuad, null);
		L.RegVar("InCubic", get_InCubic, null);
		L.RegVar("OutCubic", get_OutCubic, null);
		L.RegVar("InoutCubic", get_InoutCubic, null);
		L.RegVar("OutInCubic", get_OutInCubic, null);
		L.RegVar("InQuart", get_InQuart, null);
		L.RegVar("OutQuart", get_OutQuart, null);
		L.RegVar("InOutQuart", get_InOutQuart, null);
		L.RegVar("OutInQuart", get_OutInQuart, null);
		L.RegVar("InQuint", get_InQuint, null);
		L.RegVar("OutQuint", get_OutQuint, null);
		L.RegVar("InOutQuint", get_InOutQuint, null);
		L.RegVar("OutInQuint", get_OutInQuint, null);
		L.RegVar("InSine", get_InSine, null);
		L.RegVar("OutSine", get_OutSine, null);
		L.RegVar("InOutSine", get_InOutSine, null);
		L.RegVar("OutInSine", get_OutInSine, null);
		L.RegVar("InExpo", get_InExpo, null);
		L.RegVar("OutExpo", get_OutExpo, null);
		L.RegVar("InOutExpo", get_InOutExpo, null);
		L.RegVar("OutInExpo", get_OutInExpo, null);
		L.RegFunction("IntToEnum", IntToEnum);
		L.EndEnum();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Default(IntPtr L)
	{
		ToLua.Push(L, InterpType.Default);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Linear(IntPtr L)
	{
		ToLua.Push(L, InterpType.Linear);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_InBack(IntPtr L)
	{
		ToLua.Push(L, InterpType.InBack);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OutBack(IntPtr L)
	{
		ToLua.Push(L, InterpType.OutBack);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_InOutBack(IntPtr L)
	{
		ToLua.Push(L, InterpType.InOutBack);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OutInBack(IntPtr L)
	{
		ToLua.Push(L, InterpType.OutInBack);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_InQuad(IntPtr L)
	{
		ToLua.Push(L, InterpType.InQuad);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OutQuad(IntPtr L)
	{
		ToLua.Push(L, InterpType.OutQuad);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_InoutQuad(IntPtr L)
	{
		ToLua.Push(L, InterpType.InoutQuad);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_InCubic(IntPtr L)
	{
		ToLua.Push(L, InterpType.InCubic);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OutCubic(IntPtr L)
	{
		ToLua.Push(L, InterpType.OutCubic);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_InoutCubic(IntPtr L)
	{
		ToLua.Push(L, InterpType.InoutCubic);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OutInCubic(IntPtr L)
	{
		ToLua.Push(L, InterpType.OutInCubic);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_InQuart(IntPtr L)
	{
		ToLua.Push(L, InterpType.InQuart);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OutQuart(IntPtr L)
	{
		ToLua.Push(L, InterpType.OutQuart);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_InOutQuart(IntPtr L)
	{
		ToLua.Push(L, InterpType.InOutQuart);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OutInQuart(IntPtr L)
	{
		ToLua.Push(L, InterpType.OutInQuart);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_InQuint(IntPtr L)
	{
		ToLua.Push(L, InterpType.InQuint);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OutQuint(IntPtr L)
	{
		ToLua.Push(L, InterpType.OutQuint);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_InOutQuint(IntPtr L)
	{
		ToLua.Push(L, InterpType.InOutQuint);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OutInQuint(IntPtr L)
	{
		ToLua.Push(L, InterpType.OutInQuint);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_InSine(IntPtr L)
	{
		ToLua.Push(L, InterpType.InSine);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OutSine(IntPtr L)
	{
		ToLua.Push(L, InterpType.OutSine);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_InOutSine(IntPtr L)
	{
		ToLua.Push(L, InterpType.InOutSine);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OutInSine(IntPtr L)
	{
		ToLua.Push(L, InterpType.OutInSine);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_InExpo(IntPtr L)
	{
		ToLua.Push(L, InterpType.InExpo);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OutExpo(IntPtr L)
	{
		ToLua.Push(L, InterpType.OutExpo);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_InOutExpo(IntPtr L)
	{
		ToLua.Push(L, InterpType.InOutExpo);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OutInExpo(IntPtr L)
	{
		ToLua.Push(L, InterpType.OutInExpo);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		InterpType o = (InterpType)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}
