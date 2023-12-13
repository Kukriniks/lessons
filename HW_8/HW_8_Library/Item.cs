using System;

namespace HW_8_ForTest_classes
{
    public class Item
    {
        private string Name = "unknown";
        public void SetName(string name) => this.Name = name;
        //{ this.Name = name; }
        public string GetName() => Name;
        //{ return  Name; }
    }
}
