namespace School
{
    internal class AddPupilEventArgs : EventArgs
    {
        public SchoolBoy pupil;

        public AddPupilEventArgs(SchoolBoy pupil)
        {
            this.pupil = pupil;
        }

        public override string ToString()
        {
            return $"New pupil: {pupil.Name} {pupil.SurName}     Age: {pupil.Age}";
        }
    }
}
