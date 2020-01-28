using System;
using System.Collections.Generic;
using System.Text;

namespace MySerializer.JsonTools
{
    /// <summary>
    /// Инструментарий для сборки JSON 
    /// </summary>
    abstract class JSONBuilder
    {
        public abstract string GetJSON();

        // тело класса
        // начало
        public abstract void AddStartClass();
        //конец
        public abstract void AddEndClass();

        // тело массива
        // начало
        public abstract void AddStartArray();
        //конец
        public abstract void AddEndArray();

        // символ разделения строк
        public abstract void AddSeparator();

        // переменная
        public abstract void AddVariable(string name, string value);
    }
}
