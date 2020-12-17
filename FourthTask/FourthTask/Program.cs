namespace FourthTask
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var bmw = new BmwCar();

            bmw.Drive();
            bmw.Park();

            var anyOthercar = new AnyOtherCar();
            anyOthercar.Drive();
            anyOthercar.Park();
        }
    }
}