namespace HW_8_Library
{
    abstract class Transport
    {
        protected abstract bool Move();
        protected abstract string Engine { get; set; }
    }
}
