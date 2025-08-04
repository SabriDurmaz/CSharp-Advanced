using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var text = new StringBuilder();
        var history = new Stack<(int type, string value)>();

        for (int i = 0; i < n; i++)
        {
            string[] cmd = Console.ReadLine().Split();
            int op = int.Parse(cmd[0]);

            switch (op)
            {
                case 1:
                    string s = cmd[1];
                    history.Push((1, s.Length.ToString()));
                    text.Append(s);
                    break;
                case 2:
                    int count = int.Parse(cmd[1]);
                    string removed = text.ToString(text.Length - count, count);
                    history.Push((2, removed));
                    text.Remove(text.Length - count, count);
                    break;
                case 3:
                    int index = int.Parse(cmd[1]);
                    Console.WriteLine(text[index - 1]);
                    break;
                case 4:
                    var undo = history.Pop();
                    if (undo.type == 1)
                        text.Remove(text.Length - int.Parse(undo.value), int.Parse(undo.value));
                    else
                        text.Append(undo.value);
                    break;
            }
        }
    }
}