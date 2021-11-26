using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string investigatedClass, params string[] requestedFields)
        {
            Type classType = Type.GetType(investigatedClass);

            FieldInfo[] classFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static
                | BindingFlags.NonPublic | BindingFlags.Public);

            StringBuilder builder = new StringBuilder();

            Object classInstance = Activator.CreateInstance(classType, new object[] { });

            builder.AppendLine($"Class under investigation: {investigatedClass}");

            foreach (FieldInfo field in classFields.Where(f => requestedFields.Contains(f.Name)))
            {
                builder.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }

            return builder.ToString().Trim();
        }

        public string AnalyzeAccessModifiers(string className)
        {
            Type classType = Type.GetType(className);

            FieldInfo[] classFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static
                | BindingFlags.NonPublic | BindingFlags.Public);

            MethodInfo[] classPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
            MethodInfo[] classNonPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            StringBuilder stringBuilder = new StringBuilder();

            foreach (FieldInfo item in classFields)
            {
                stringBuilder.AppendLine($"{item.Name} must be private!");
            }

            foreach (MethodInfo item in classPublicMethods.Where(i => i.Name.StartsWith("get")))
            {
                stringBuilder.AppendLine($"{item.Name} have to be public!");
            }

            foreach (MethodInfo item in classNonPublicMethods.Where(i => i.Name.StartsWith("set")))
            {
                stringBuilder.AppendLine($"{item.Name} have to be private!");
            }

            return stringBuilder.ToString().Trim();
        }
    }
}
