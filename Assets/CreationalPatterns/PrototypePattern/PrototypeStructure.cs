/**********************************
 * @file PrototypeStructure.cs
 * @brief 原型模式(浅复制实现)
 * @author Saroce, saroce233@gmail.com
 * @date 2022/03/08
 **********************************/

namespace CreationalPatterns.PrototypePattern
{
    abstract class Prototype
    {
        private string id;

        public string Id {
            get { return id; }
        }
        
        protected Prototype(string id) {
            this.id = id;
        }

        public abstract Prototype Clone();
    }

    class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(string id) : base(id) {
        }

        public override Prototype Clone() {
            return (Prototype)this.MemberwiseClone();
        }
    }
    
    class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2(string id) : base(id) {
        }

        public override Prototype Clone() {
            return (Prototype)this.MemberwiseClone();
        }
    }
}