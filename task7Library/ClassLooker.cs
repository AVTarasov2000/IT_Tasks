using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace task7Library
{
    public class ClassLooker
    {
        public string ClassLibraryPath { get;}
        private Assembly Assembly { get;}

        public ClassLooker(string classLibraryPath)
        {
            ClassLibraryPath = classLibraryPath;
            Assembly = Assembly.LoadFrom(ClassLibraryPath);
        }
        
        public Type GetType(string name)
        {
            var enumerable = Assembly.GetTypes().Where(type => type.Name.Equals(name));
            List<Type> types = new List<Type>(enumerable);
            if (types.Count != 1)
                throw new ArgumentException($"Incorrect count classes of {name} : 0 or more than 1");
            return types[0];
        }
        
        public List<Type> AllChildrenAndImpls(Type type)
        {
            if (!type.IsInterface && !type.IsAbstract)
                return new List<Type>();
            
            return new List<Type>(Assembly.GetTypes().Where(t => CheckClass(t, type)));
        }
        
        public List<Type> AllAbstractClassesAndInterfaces()
        {
            return new List<Type>(Assembly.GetTypes().Where(t => t.IsAbstract||t.IsInterface));
        }

        private bool CheckClass(Type type, Type baseType)
        {
            if (!type.IsClass || type.IsAbstract || type is null)
                return false;

            if (baseType == null)
                return type.IsInterface || type == typeof(object);

            if (baseType.IsInterface)
                return type.GetInterfaces().Contains(baseType);
            
            Type tmp = type;
            while (tmp != null)
            {
                if (tmp.BaseType == baseType)
                    return true;
                tmp = tmp.BaseType;
            }
            return false;
        }
    }
}