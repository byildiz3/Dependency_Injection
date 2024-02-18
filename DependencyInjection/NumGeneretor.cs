namespace DependencyInjection
{
    public class NumGeneretor: INumGenerator
    {
        public int RandomValue { get; }



        public NumGeneretor()
        {
            RandomValue= new Random().Next(1000);
        }

     
    }


    public interface INumGenerator
    {
        public int RandomValue { get; }
         
    }
}
