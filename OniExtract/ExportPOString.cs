using OniExtract2;
using System;
using System.IO;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

public class ExportPOString : BaseExport
{
    public override string ExportFileName { get; set; } = "po_string";
    public Dictionary<string, string> CREATURES = new Dictionary<string, string>();

    public class POMsg
    {
        public string msgId = null;
        public string msgUIFormat = null;
        public List<POMsg> subMsg = new List<POMsg>();

        public POMsg() { }

        public POMsg(string msgId, StringEntry msgUIFormat)
        {
            this.msgId = msgId;
            this.msgUIFormat = msgUIFormat;
        }

        public static List<POMsg> getSubMsg(Type nestedType, string msgId)
        {
            var result = new List<POMsg>();
            return result;
        }
    }

    public ExportPOString()
	{
    }

    public int Traverse(Type type, object instance, string parentTypeName, Dictionary<string, string> poDict)
    {
        // 输出类名
        Debug.Log("Class: " + parentTypeName);

        // 输出类的所有成员
        if(type.GetNestedTypes().Length == 0)
        {
            foreach (var member in type.GetMembers(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance))
            {
                string typeName = parentTypeName + "." + member.Name;
                // 判断成员类型是否为 LocString
                if (member is FieldInfo fieldInfo && fieldInfo.FieldType == typeof(LocString))
                {
                    Debug.Log("LocString Member: " + member.Name);
                    poDict.Add(typeName, fieldInfo.GetValue(instance).ToString());
                }
                else if (member is PropertyInfo propertyInfo && propertyInfo.PropertyType == typeof(LocString))
                {
                    Debug.Log("LocString Member: " + member.Name);
                    poDict.Add(typeName, propertyInfo.GetValue(instance).ToString());
                }
            }

        }

        // 递归遍历子类
        foreach (var nestedType in type.GetNestedTypes())
        {
            string typeName = parentTypeName+"."+nestedType.Name;
            int nestedTypeNum = Traverse(nestedType, Activator.CreateInstance(nestedType), typeName, poDict);
        }

        return type.GetNestedTypes().Length;
    }


    public void ExportAll()
    {
        Type type = typeof(STRINGS.CREATURES);
        Traverse(type, Activator.CreateInstance(type), type.Name, CREATURES);
    }
}
