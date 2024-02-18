namespace DependencyInjection
{
    public class NumGenerator2 : INumGenerator2
    {
        public int RandomValue { get; }
        private readonly INumGenerator _numGenerator2;

        public NumGenerator2(INumGenerator numGenerator)
        {
            RandomValue = new Random().Next(1000);
            _numGenerator2 = numGenerator;
        }

        public int GetNumGeneratorRandomNumber()
        {
            return _numGenerator2.RandomValue;
        }
    }


    public interface INumGenerator2
    {
        public int RandomValue { get; }
        public int GetNumGeneratorRandomNumber();


    }
}
