using System;
using static System.Console;
using CatProject;

namespace App
{
    class Program
    {
        static void skipLine(){
            WriteLine("");
        }

        static void Main(string[] args)
        {
            Chat chat = new Chat("Livy", DateTime.Now);
            MonChat monChat = new MonChat("Daisy", DateTime.Now, 9, false);

            WriteLine($"nom du chat: {chat.getNom()}");
            WriteLine($"nom de mon chat: {monChat.getNom()}");
            skipLine();

            DateTime chatNaissance = chat.getDateDeNaissance();
            WriteLine("date de naissance du chat: {0}, {1}, {2}",
                chatNaissance.Year,
                chatNaissance.Month,
                chatNaissance.Day
            );

            DateTime monChatNaissance = monChat.getDateDeNaissance();
            WriteLine("date de naissance du chat: {0}, {1}, {2}",
                monChatNaissance.Year,
                monChatNaissance.Month,
                monChatNaissance.Day
            );
            skipLine();

            WriteLine(monChat.getIsCatHugable());
            skipLine();

            try
            {
                monChat.hug();
            }
            catch (System.Exception e)
            {
                WriteLine($"Error: {e.Message}");
            }
        }
    }
}
