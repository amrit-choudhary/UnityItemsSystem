
[System.Serializable]
public class TestParam {

    [UnityEngine.SerializeField]
    private int _value;
    private string _id;
    public string ID {
        get{
            return _id;
        }
    }

    public TestParam(int value, string id) {
        _value = value;
        _id = id;
    }

    public void TestFn() {

    }

    public static implicit operator int(TestParam testParam) {
        return testParam._value;
    }

    public override string ToString() {
        return _value.ToString();
    }

    public static bool operator ==(TestParam b1, TestParam b2) {
        return (b1._value == b2._value);
    }

    public static bool operator !=(TestParam b1, TestParam b2) {
        return !(b1 == b2);
    }

    public override bool Equals(object obj) {
        return base.Equals(obj);
    }

    public override int GetHashCode() {
        return base.GetHashCode();
    }

}
