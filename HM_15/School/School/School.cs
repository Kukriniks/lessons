namespace School
{
    internal class School
    {
        //private SchoolDirector director = new SchoolDirector();

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

        public School()
        {
            this.pupils = new();
        }
    }
}
