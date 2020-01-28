using System;
using System.Collections.Generic;
using System.Text;

namespace MySerializer.JsonTools
{
    class SimpleJSONBuilder : JSONBuilder
    {
        private string json;

        public SimpleJSONBuilder()
        {
            this.json = "";
        }

        public override void AddEndArray()
        {
            this.json += "]";
        }

        /// <summary>
        /// Добавляет символ конца объекта
        /// </summary>
        public override void AddEndClass()
        {
            this.json += "}";
        }
        
        public override void AddSeparator()
        {
            this.json += ",";
        }

        public override void AddStartArray()
        {
            this.json += "[ ";
        }

        public override void AddStartClass()
        {
            this.json += "{ ";
        }

        public override void AddVariable(string name, string value)
        {
            this.json += " " + name + " : " + value + " ";
        }

        public override string GetJSON()
        {
            return this.json;
        }
    }
}
