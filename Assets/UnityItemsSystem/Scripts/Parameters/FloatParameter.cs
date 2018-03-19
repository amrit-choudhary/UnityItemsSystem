
namespace UIS
{
    /// <summary>
    /// Float Parameters
    /// </summary>
    [System.Serializable]
    public class FloatParameter : Parameter<float>
    {
        public FloatParameter(float value, string id) : base(value, id) {
            _value = value;
            _id = id;
        }
    }
}
