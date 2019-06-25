using System;
using System.Collections.Generic;
using System.Text;

namespace UnityContainer
{
    public class Language
    {
        public Language(string type)
        {
            this.Type = type;
        }
        public string Type { get; }
    }
}
