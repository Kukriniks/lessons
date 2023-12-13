using HW_8_ForTest_classes;


namespace HW_8_Library
{
    public class Bag
    {
        private bool _isOpen;
        public void  openBag(bool open=false)
        { 
            _isOpen = open;
        }
        private Item[] bag = new Item[8];
        public bool addToBag(Item item)
        { 
            if (_isOpen)
            {
                if (!bag.Contains(null)) //there no empty slots
                {
                    Console.WriteLine("bag is full");
                    return false;
                }
                else
                {
                    int i = 0;
                    for (; i < bag.Length; i++)
                    {
                        if (bag[i] == null)
                        {
                            bag[i] = item;
                            break;
                        }
                    }
                    Console.WriteLine($"Item {item.GetName()} have been added to the bag on place {i}");
                    return true;
                }   
            }
            return false;
        }

        public bool removeFromBag(int index, out Item item)
        {
            item = null;
            if (_isOpen && index >=0 && index < bag.Length) //if open and index in a range
            { 
                item = bag[index];
                Console.WriteLine($"item {bag[index].GetName()} have been removed from the bag");
                bag[index] = null;
                return true;
            }
            return false;
        }
        //TODO: потом разобраться 
        //private Item this [int index] 
        //{
        //    get
        //    {
        //        if (_isOpen)
        //        {
        //            Console.WriteLine($"item {bag[index].GetName()} removed from bag");
        //            bag[index] = null; //можем положить на это место еще что-то
        //            return bag[index];
        //        }
        //        return null;
        //    }
        //  //set { bag[index] = value; }
        //}
    }
}
