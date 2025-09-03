namespace Delegates
{
    public delegate void Notify(string message);
    public class Program
    {
        static void SendMail(string message)
        {
            Console.WriteLine("Email sent: " + message);
        }

        public static void SendSMS(string message)
        {
            Console.WriteLine("SMS sent: " + message);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Notify notify = SendMail;

            notify("Your order is confirmed");

            notify = SendSMS;

            notify("Your order is confirmed1");
        }
    }
}
