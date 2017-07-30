using System;
using LuaInterface;

class Program
{
    private static Player mainPlayer = new Player();
    
    //测试out关键字
    public static void GetLength(string str,out int len)
    {
        Console.WriteLine(str);
        len = str.Length;
    }

    //测试ref关键字
    public static void Calc(int num1,ref int num2)
    {
        num2 = num1 * num2;
    }

    public static Player GetMainPlayer()
    {
        return Program.mainPlayer;
    }
    
    static void Main(string[] args)
    {
        Lua lua = new Lua();

        //1.get和set全局变量
        lua["num"] = 34;
        Console.WriteLine(lua["num"]);

        //2.DoString
        lua.DoString("a = 2");
        lua.DoString("b = 'yzl'");
        object[] var = lua.DoString("return a,b");
        foreach (object obj in var)
            Console.WriteLine(obj);

        //3.运行lua文件
        lua.DoFile("main.lua");

        //4.注册类非静态方法
        lua.RegisterFunction("GetMainPlayer", null, typeof(Program).GetMethod("GetMainPlayer"));
        lua.RegisterFunction("Render", mainPlayer, mainPlayer.GetType().GetMethod("Render"));
        lua.RegisterFunction("Move", mainPlayer, mainPlayer.GetType().GetMethod("Move"));
        lua.DoFile("player.lua");

        //5.注册类
        lua.DoFile("script.lua");

    }

}

public class Player
{
    private int x;
    private int y;
    public Player()
    {
        x = 0;
        y = 0;
    }

    public void Render()
    {
        Console.WriteLine("我现在在(" + x + ", " + y + ")");
    }

    public void Move(int dx, int dy)
    {
        x += dx;
        y += dy;
    }
}