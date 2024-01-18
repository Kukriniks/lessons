
namespace School
{
    internal class ChilderGarden
    {
        public event EventHandler<GrowedChildEventArgs> ChildGrownUP;

        private List<Child>? children;

        protected virtual void OnChildGrownUP(GrowedChildEventArgs e)
        {
            ChildGrownUP?.Invoke(this, e);
        }

        public void AddChild(Child child)
        {
            children.Add(child);
        }

        public void RemoveChild(Child child)
        {
            children.Remove(child);
        }

        private void StartGrowUP()
        {
            for (int i = 0; i < children.Count; i++)
            {
                Console.WriteLine(children[i] + " early to school");
                children[i].Age++;
                if (children[i].Age >= 6)
                {
                    OnChildGrownUP(new GrowedChildEventArgs(children[i]));
                    RemoveChild(children[i]);
                }
            }
        }

        public void CheckChildren()
        {
            if (children.Exists(x => x.Age < 6))
            {
                StartGrowUP();
            }
        }

        public ChilderGarden()
        {
            children = new();
        }
    }
}
