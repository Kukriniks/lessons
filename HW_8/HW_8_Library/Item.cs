using System;

namespace HW_8_ForTest_classes
{
    public class Item
    {
        private string _name = "unknown";
        public void SetName(string name) => this._name = name;
        //{ this.Name = name; }
        public string GetName() => _name;
        //{ return  Name; }
    }
}
