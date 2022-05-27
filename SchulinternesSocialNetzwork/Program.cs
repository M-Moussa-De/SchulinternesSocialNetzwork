using App;

class Program
{
    static void Main(string[] args)
    {

        Person ss = new("Sara", "Schmidt");
        Person mm = new("Mahmoud", "Moussa");
        Person js = new("Jakoub", "Schneider");
        Person tm = new("Tim", "Müller");
        Person lw = new("Laura", "Weber");
        Person am = new("Alexander", "Meyer");
        Person ab = new("Aly", "Becker");

        TextMessage msg1 = new(mm, "Message_One");
        TextMessage msg2 = new(mm, "Message_Two");
        TextMessage msg3 = new(ss, "Message_Three");
        TextMessage msg4 = new(ab, "Message_Four");
        TextMessage msg5 = new(tm, "Message_Five");
        TextMessage msg6 = new(lw, "Message_Six");
        TextMessage msg7 = new(js, "Message_Seven");

        SocialNetwork fb = new();
        fb.AddMembers(ss);
        fb.AddMembers(mm);
        fb.AddMembers(lw);
        fb.AddMembers(am);
        fb.AddMembers(ab);
        fb.AddMembers(js);
        fb.AddMembers(tm);

        fb.AddMessage(msg1);
        fb.AddMessage(msg2);
        fb.AddMessage(msg3);
        fb.AddMessage(msg4);
        fb.AddMessage(msg5);
        fb.AddMessage(msg6);
        fb.AddMessage(msg7);

        Console.WriteLine("Members: ");
        fb.GetAllMemebers()?.ForEach(m => { Console.Write(m + ", "); });

        Console.WriteLine();

        Console.WriteLine("============================");

        Console.WriteLine("Messages: ");
        fb.GetAllMessages()?.ForEach(m => { Console.Write(m.Message + ", "); });

        Console.WriteLine();

        Console.WriteLine("============================");

        Console.WriteLine("Message/s after a member: ");
        fb.GetMessagesFilteredByPerson(mm)?.ForEach(m => { Console.Write(m.Message + ", ");  });

        Console.WriteLine("\n\n\n");


    }
}