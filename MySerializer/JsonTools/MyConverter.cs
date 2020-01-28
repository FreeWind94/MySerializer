namespace MySerializer.JsonTools
{
    /// <summary>
    /// Конвертиртор строковых форматов данных
    /// </summary>
    abstract class MyConverter
    {
        public abstract string Convert(string item);
    }
}
