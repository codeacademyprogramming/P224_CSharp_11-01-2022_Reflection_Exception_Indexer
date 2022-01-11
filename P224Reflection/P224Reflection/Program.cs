using System;
using System.Reflection;

namespace P224Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.LoadFrom(@"C:\Users\memme\Desktop\P224\Task\P224DemoLibrary\P224DemoLibrary\bin\Debug\netcoreapp3.1\P224DemoLibrary.dll");
            Type[] types = assembly.GetTypes();
            foreach (Type type in types)
            {
                MemberInfo[] memberInfos = type.GetMembers(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);

                foreach (MemberInfo memberInfo in memberInfos)
                {

                    if (memberInfo.DeclaringType.ToString() == "P224DemoLibrary.Models.Developer")
                    {
                        if (memberInfo.Name == "Write")
                        {
                            MethodInfo methodInfo = type.GetMethod(memberInfo.Name);
                            ParameterInfo[] parameterInfos = methodInfo.GetParameters();

                            object obj = Activator.CreateInstance(type);
                            type.GetProperty("Name").SetValue(obj, "Hello");
                            type.GetProperty("SurName").SetValue(obj, "World");
                            type.GetProperty("Position").SetValue(obj, "P224");

                            object[] parametrs = new object[]
                            {
                                "Test",
                                25
                            };

                            Console.WriteLine(methodInfo.Invoke(obj, parametrs));
                            
                        }
                    }
                    //Console.WriteLine($"{memberInfo.DeclaringType} {memberInfo.Name}");
                }
            }
        }
    }
}
