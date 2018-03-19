
namespace UIS
{
    /// <summary>
    /// Integer Parameter
    /// </summary>
    [System.Serializable]
    public class IntParameter : Parameter<int>
    {
        public IntParameter(int value, string id) : base(value, id) {
            _value = value;
            _id = id;
        }
    }
}
