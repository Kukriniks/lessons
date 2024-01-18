namespace School
{
    internal class SchoolDirector
    {
        public void PupilAdded(object? sender, EventArgs e)
        {
            Console.WriteLine(e);
        }
    }
}
