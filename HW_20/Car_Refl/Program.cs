using System.Reflection;
using System.Runtime.Loader;

namespace Car_Refl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\a.nadolsky\source\repos\Lessons\HW_20\Car\bin\Debug\net7.0\Car.dll";

            //AssemblyName car = new AssemblyName("car");
            Assembly assembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(path);

            Type type = assembly.GetType("Car.MyCar");
            object? instance = Activator.CreateInstance(type);

            MethodInfo? method = type.GetMethod("CarMethod", BindingFlags.NonPublic | BindingFlags.Instance);
            FieldInfo? str = type.GetField("age", BindingFlags.Instance | BindingFlags.NonPublic);
            str?.SetValue(instance, 10);
            method?.Invoke(instance, new object[] { "Hey!" });
        }
    }
}
