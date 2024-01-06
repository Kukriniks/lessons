namespace Animal
{
    public interface IHerbivore
    {
        //не придумал что тут надо имплементить
        public string typeH { get; set; }
        public string foodH { get; set; }

        public void DisplayEatH();
    }
}
