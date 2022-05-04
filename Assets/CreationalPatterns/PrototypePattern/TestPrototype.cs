/**********************************
 * @file TestPrototype.cs
 * @brief TestPrototype
 * @author Saroce, saroce233@gmail.com
 * @date 2022/03/08
 **********************************/

using System;
using UnityEngine;

namespace CreationalPatterns.PrototypePattern
{
    public class TestPrototype : MonoBehaviour
    {
        private void Start() {
            var p1 = new ConcretePrototype1("I");
            var c1 = (ConcretePrototype1)p1.Clone();
            Debug.Log($"Cloned: {c1.Id}");
            
            var p2 = new ConcretePrototype2("II");
            var c2 = (ConcretePrototype2)p2.Clone();
            Debug.Log($"Cloned: {c2.Id}");
        }
    }
}