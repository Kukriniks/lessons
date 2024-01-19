namespace School
{
    internal class School
    {
        public event EventHandler<AddPupilEventArgs>? PupilAdded;

        private List<SchoolBoy> pupils;

        protected virtual void OnAddPupil(AddPupilEventArgs e)
        {
            PupilAdded?.Invoke(this, e);
        }

        public void AddPupil(SchoolBoy pupil)
        {
            pupils.Add(pupil);
            OnAddPupil(new AddPupilEventArgs(pupil));
        }

        public void OnChildGrownUP(object? sender, GrowedChildEventArgs e)
        {
            AddPupil(e.Pupil);
        }

        public School()
        {
            this.pupils = new();
        }
    }
}
