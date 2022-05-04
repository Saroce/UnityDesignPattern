/**********************************
 * @file PrototypeExample1.cs
 * @brief PrototypeExample1
 * @author Saroce, saroce233@gmail.com
 * @date 2022/03/08
 **********************************/

using System;
using System.Collections.Generic;
using UnityEngine;

namespace CreationalPatterns.PrototypePattern
{
    abstract class ColorPrototype
    {
        public abstract ColorPrototype Clone();
    }

    class Color : ColorPrototype
    {
        private int red;
        private int green;
        private int blue;

        public Color(int red, int green, int blue) {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        public override string ToString() {
            return $"red:{red} green:{green} blue:{blue}";
        }

        public override ColorPrototype Clone() {
            return this.MemberwiseClone() as Color;
        }
    }

    class ColorManager
    {
        private Dictionary<string, ColorPrototype> colorDict = new Dictionary<string, ColorPrototype>();

        public ColorPrototype this[string key] {
            get => colorDict[key];
            set => colorDict.Add(key, value);
        }
    }
    
    public class PrototypeExample1 : MonoBehaviour
    {
        private void Start() {
            var colorManager = new ColorManager();
            
            colorManager["red"] = new Color(255, 0, 0);
            colorManager["green"] = new Color(0, 255, 0);
            colorManager["blue"] = new Color(0, 0, 255);

            var color1 = colorManager["red"].Clone() as Color;
            var color2 = colorManager["green"].Clone() as Color;
            var color3 = colorManager["blue"].Clone() as Color;
            
            Debug.Log(color1?.ToString());
            Debug.Log(color2?.ToString());
            Debug.Log(color3?.ToString());
        }
    }
}