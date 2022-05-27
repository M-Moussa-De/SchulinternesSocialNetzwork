namespace App
{
 public class CustomException : Exception
    {
        public CustomException(string msg, string extraInfo = ""): base(msg) {}
    }
}
