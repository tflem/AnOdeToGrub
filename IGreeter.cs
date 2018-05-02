namespace AnOdeToGrub
{
    public interface IGreeter
    {
        string GetMessageOfTheDay();
    }

    public class Greeter : IGreeter
    {
        public string GetMessageOfTheDay()
        {
            return "Greetings Patrick Star!";
        }
    }
}