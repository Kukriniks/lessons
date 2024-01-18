namespace School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            School school = new School();
            SchoolDirector director = new SchoolDirector();
            school.PupilAdded += director.PupilAdded;

            school.AddPupil(new SchoolBoy("Ivan", "Ivanov", 12));
            school.AddPupil(new SchoolBoy("Petr", "Pertov", 10));
            school.AddPupil(new SchoolBoy("Vasiya", "Vasilev", 6));

            ChilderGarden childrenGarden = new ChilderGarden();
            childrenGarden.ChildGrownUP += school.OnChildGrownUP;

            childrenGarden.AddChild(new Child("Masha", "Kurichkina", 3));
            childrenGarden.AddChild(new Child("Misha", "Dunin", 3));
            childrenGarden.AddChild(new Child("Olga", "Minina", 3));

            childrenGarden.CheckChildren();
            childrenGarden.CheckChildren();
            childrenGarden.CheckChildren();
            childrenGarden.CheckChildren();
        }


    }
}
