using System;
using System.Collections.Generic;
using System.Text;

namespace MySerializer.JsonTools
{
    class ConvertCSVtoJSON : MyConverter
    {
        private JSONBuilder builder;

        public ConvertCSVtoJSON ()
        {
            // пока так
            builder = new SimpleJSONBuilder();
        }


        /// <summary>
        /// Конвертирование CSV в JSON
        /// </summary>
        /// <param name="item">строка с данными формата CSV</param>
        /// <returns>строка с данными формата JSON</returns>
        public override string Convert(string item)
        {
            //throw new NotImplementedException(); // TODO: не забыть удалить это

            // распарсить item

            // пока объявим создатель JSON напрямую
            

            string[] csvObjects = item.Split("\r\n");

            builder.AddStartArray();

            for(int i = 0; i < csvObjects.Length; i++)
            {
                AddObject(csvObjects[i]);
                if (i < csvObjects.Length - 1)
                {
                    builder.AddSeparator();
                }
            }

            builder.AddEndArray();

            return builder.GetJSON();
        }

        private void AddObject(string csvObject)
        {
            string[] csvValues = csvObject.Split("#");

            // переменных должно быть три: имя, возраст, телефон, иначе ввод некорректен
            if(csvValues.Length != 3)
            {
                throw new FormatException("Invalid data");
            }

            builder.AddStartClass();
            builder.AddVariable("name", csvValues[0]);
            builder.AddSeparator();
            builder.AddVariable("age", csvValues[1]);
            builder.AddSeparator();
            builder.AddVariable("phone", csvValues[2]);
            builder.AddEndClass();
        }

    }
}
