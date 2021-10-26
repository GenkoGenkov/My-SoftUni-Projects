namespace RawData
{
    public class Tire
    {

        public Tire(int age, double pressure)
        {
            Pressure = pressure;
            Age = age;
        }
        public int Age { get; set; }

        public double Pressure { get; set; }
    }

}
