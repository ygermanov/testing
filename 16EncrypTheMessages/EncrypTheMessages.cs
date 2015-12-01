using System;
using System.Collections.Generic;

namespace _16EncrypTheMessages
{
    class EncrypTheMessages
    {
        static void Main()
        {
            List<string> message = new List<string>();
            string tempMessage = Console.ReadLine();
            bool check = true;
            if(tempMessage == "END" || tempMessage == "end") check = false;
            while (check)
            {
                message.Add(tempMessage);
                tempMessage = Console.ReadLine();
                if (tempMessage == "END" || tempMessage == "end") check = false;
            }
            Dictionary<char, char> specSymbols = new Dictionary<char, char>()
            {
                {' ', '+'},
                {',', '%'},
                {'.', '&'},
                {'?', '#'},
                {'!', '$'}
            };
            tempMessage = string.Empty;
            List<string> encryptMessage = new List<string>();
            int count = 0;
            foreach (string v in message)
            {
                if (v == "START" || v == "start")
                {
                    check = true;
                }
                else if (check && v.Length > 0)
                {
                    for (int i = 0; i < v.Length; i++)
                    {
                        if (specSymbols.ContainsKey(v[i]))
                        {
                            tempMessage += specSymbols[v[i]];
                        }
                        else if ((v[i] >= 65 && v[i] <= 77) || (v[i] >= 97 && v[i] <= 109))
                        {
                            tempMessage += (char)(v[i] + 13);
                        }
                        else if ((v[i] > 77 && v[i] <= 90) || (v[i] > 109 && v[i] <= 122))
                        {
                            tempMessage += (char)(v[i] - 13);
                        }
                        else
                        {
                            tempMessage += v[i];
                        }
                    }
                    count++;
                    encryptMessage.Add(tempMessage);
                    tempMessage = string.Empty;
                }
            }
            if (count > 0) Console.WriteLine("Total number of messages: {0}", count);
            else Console.WriteLine("No messages sent.");
            foreach (string v in encryptMessage)
            {
                char[] tempCharAray = v.ToCharArray();
                Array.Reverse(tempCharAray);
                Console.WriteLine(tempCharAray);
            }
        }
    }
}
