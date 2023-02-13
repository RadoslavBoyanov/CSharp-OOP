using System;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string investigate, params string[] nameOfFields)
        {
            Type classType = Type.GetType(investigate);
            FieldInfo[] fields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);

            StringBuilder stringBuilder = new StringBuilder();

            Object classInstance = Activator.CreateInstance(classType, new object[] { });

            stringBuilder.AppendLine($"Class under investigation: {investigate}");

            foreach (var field in fields.Where(f => nameOfFields.Contains(f.Name)))
            {
                stringBuilder.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }

            return stringBuilder.ToString().Trim();
        }

        public string AnalyzeAccessModifiers(string className)
        {
            Type classType = Type.GetType(className);

            FieldInfo[] fieldInfos =
                classType!.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
            MethodInfo[] publicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
            MethodInfo[] nonPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
            
            StringBuilder sb = new StringBuilder();

            foreach (var field in fieldInfos)
            {
                sb.AppendLine($"{field.Name} must be private!");
            }

            foreach (var publicMethod in publicMethods.Where(m => m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{publicMethod.Name} have to be public!");
            }

            foreach (var nonPublicMethod in nonPublicMethods.Where(n => n.Name.StartsWith("set")))
            {
                sb.AppendLine($"{nonPublicMethod.Name} have to be private!");
            }

            return sb.ToString().Trim();
        }

        public string RevealPrivateMethods(string className)
        {
            Type classType = Type.GetType(className);

            MethodInfo[] privateMethods = classType!.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic);

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"All Private Methods of Class: {className}");
            stringBuilder.AppendLine($"Base Class: {classType.BaseType.Name}");

            foreach (var privateMethod in privateMethods)
            {
                stringBuilder.AppendLine($"{privateMethod.Name}");
            }

            return stringBuilder.ToString().Trim();
        }

        public string CollectGettersAndSetters(string investigatedClass)
        {
            Type classType = Type.GetType(investigatedClass);

            MethodInfo[] allMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic);

            StringBuilder stringBuilder = new StringBuilder();

            foreach (var method in allMethods.Where(name => name.Name.StartsWith("get")))
            {
                stringBuilder.AppendLine($"{method.Name} will return {method.ReturnType}");
            }

            foreach (var method in allMethods.Where(name => name.Name.StartsWith("set")))
            {
                stringBuilder.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
            }
            return stringBuilder.ToString().Trim();
        }
    }
}
