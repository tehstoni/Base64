using System.Text;


namespace Base64
{
    class Program
    {

        static string encode(string input)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            string base64 = Convert.ToBase64String(bytes);
            return base64;
        }

        static string decode(string input)
        {
            byte[] bytes = Convert.FromBase64String(input);
            string base64 = Encoding.UTF8.GetString(bytes);
            return base64;
        }

        static void Main(string[] args)
        {
            if (args.Length == 2)
            {
                string input = args[1];
                if (args[0] == "-d")
                {
                    Console.WriteLine(decode(input));
                }
                else if (args[0] == "-e")
                {
                    Console.WriteLine(encode(input));
                } else if (args[0] == "-p")
                {
                    string pipe = Console.In.ReadToEnd();
                    if (pipe == null)
                    {
                        Console.WriteLine("No input");
                    }
                    else
                    {
                        if (input == "-d")
                        {
                            Console.WriteLine(decode(pipe));
                        }
                        else if (input == "-e")
                        {
                            Console.WriteLine(encode(pipe));
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid argument");
                } 

            }
            else
            {
                Console.WriteLine("Usage: Base64 -d <base64 string> or Base64 -e <string> or Base64 -p (-d or -e)");
            }
        }
    }
}