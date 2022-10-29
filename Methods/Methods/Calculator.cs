namespace Methods
{
    public class Calculator
    {
        //params keyword sayesinde Add(1,2,3) diye çağırabiliyoruz fonksiyonu
        public int Add(params int[] numbers)
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
}
