namespace CommandPattern.Receiver
{
    public class MathOperations
    {
        public int Value { get; private set; }  
        public void Add(int number)
        {
            Value += number;
        }   

        public void Substract(int number)
        {
            Value -= number;
        }   
    }
}
