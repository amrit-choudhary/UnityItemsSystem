using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Base Item class
/// </summary>

namespace UIS
{
    [CreateAssetMenu(fileName = "Item", menuName = "Item System/Create New Item", order = 1)]
    public class Item : ScriptableObject
    {
        public IntParameter id;
        public StringParameter itemName;
        public FloatParameter value;
    }
}
