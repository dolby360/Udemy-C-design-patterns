namespace Udemy
{
    public enum Brand { Samsund, Xiaomi, LG };
    public enum Processor { Qualcomm, A9, Exynos }

    public class Phone
    {
        public double size { get; set; }
        public Brand brand { get; set; }
        public Processor proc { get; set; }

        public Phone(double s, Brand b, Processor p)
        {
            size = s;
            brand = b;
            proc = p;
        }
    }
}
