
namespace UIS
{
    /// <summary>
    /// String Parameter
    /// </summary>
    [System.Serializable]
    public class StringParameter : Parameter<string>
    {
        public StringParameter(string value, string id) : base(value, id) {
            _value = value;
            _id = id;
        }
    }
}
