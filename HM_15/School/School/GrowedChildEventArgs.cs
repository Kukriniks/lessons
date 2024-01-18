namespace School
{
    internal class GrowedChildEventArgs : EventArgs
    {
        private SchoolBoy pupil = new();

        public GrowedChildEventArgs(Child child)
        {
            this.pupil.Age = child.Age;
            this.pupil.SurName = child.SurName;
            this.pupil.Name = child.Name;
        }

        public SchoolBoy Pupil { get { return pupil; } }

    }
}
