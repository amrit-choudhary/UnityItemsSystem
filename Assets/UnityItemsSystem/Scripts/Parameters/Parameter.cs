
namespace UIS
{
    /// <summary>
    /// Parameters are the base descriptors/attributes of an item
    /// Examples include value, weight, ID, description
    /// </summary>
    /// <typeparam name="T"> Type of parameter, example: int, string </typeparam>
    [System.Serializable]
    public class Parameter<T>
    {
        [UnityEngine.SerializeField]
        protected T _value;
        protected string _id;
        public string ID {
            get {
                return _id;
            }
        }

        public Parameter(T value, string id) {
            _value = value;
            _id = id;
        }

        public static implicit operator T(Parameter<T> param) {
            return param._value;
        }

        public override string ToString() {
            return _value.ToString();
        }

        public static bool operator ==(Parameter<T> p1, Parameter<T> p2) {
            return (p1._value.Equals(p2._value));
        }

        public static bool operator !=(Parameter<T> p1, Parameter<T> p2) {
            return !(p1 == p2);
        }

        public override bool Equals(object obj) {
            return base.Equals(obj);
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }
    }
}
