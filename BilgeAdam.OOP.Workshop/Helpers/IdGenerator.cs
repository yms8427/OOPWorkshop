using BilgeAdam.OOP.Workshop.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.OOP.Workshop.Helpers
{
    public static class IdGenerator
    {
        private static readonly Dictionary<string, int> mappings;
        static IdGenerator()
        {
            mappings = new Dictionary<string, int>();  
        }
        public static int Create<T>() where T : IPublishable
        {
            var typeName = typeof(T).Name;
            if (mappings.ContainsKey(typeName))
            {
                var value = mappings[typeName];
                value++;
                mappings[typeName] = value;
                return value;
            }
            else
            {
                mappings.Add(typeName, 1);
                return 1;
            }
        }
    }
}
