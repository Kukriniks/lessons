namespace School
{
    internal class AddPupilEventArgs : EventArgs
    {
        public int Age { get; }
        public string Name { get; }
        public string SurName { get; }

        public AddPupilEventArgs(SchoolBoy pupil)
        {
            Age = pupil.Age; Name = pupil.Name; SurName = pupil.SurName;
        }

        public override string ToString()
        {
            return $"New pupil: {Name} {SurName}     Age: {Age}";
        }
    }
}
