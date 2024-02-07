﻿using Plugin;
using System.Reflection;
using System.Runtime.Loader;


namespace RunPlugin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Plugin.Plugin plugin = new Plugin.Plugin();
            plugin.RunLogic("From general approach");

            string path = @"C:\Users\a.nadolsky\source\repos\Lessons\HW_20\Plugin\bin\Debug\net7.0\Plugin.dll";

            AssemblyName plug = new AssemblyName("Plug");   
            Assembly assembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(path);

            Type type = assembly.GetType("Plugin.Plugin");
            object? instance = Activator.CreateInstance(type);
            MethodInfo ? method = type.GetMethod("RunLogic");

            method?.Invoke(instance, new object[] {"From Reflection "});
        }
    }
}