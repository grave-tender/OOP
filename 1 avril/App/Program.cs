using System;
using static System.Console;
using CatProject; //car les 2 autres class sont dans un namespace

namespace App
{
    class Program
    {
        static void skipLine(){
            WriteLine("");
        }

        static void Main(string[] args)
        {
            Chat chat = new Chat("Livy", DateTime.Now); //classe normale avec 2 paramètres
            MonChat monChat = new MonChat("Daisy", DateTime.Now, 9, false); //classe enfant de Chat avec 2 nouveaux paramètres

            WriteLine($"nom du chat: {chat.getNom()}"); //appel de méthode normale
            WriteLine($"nom de mon chat: {monChat.getNom()}"); //appel de la méthode de la classe parent
            skipLine();

            DateTime chatNaissance = chat.getDateDeNaissance(); //extraction de la date 
            WriteLine("date de naissance du chat: {0}, {1}, {2}",
                chatNaissance.Year,
                chatNaissance.Month,
                chatNaissance.Day
            );

            DateTime monChatNaissance = monChat.getDateDeNaissance(); //extraction de la date depuis le parent
            WriteLine("date de naissance du chat: {0}, {1}, {2}",
                monChatNaissance.Year,
                monChatNaissance.Month,
                monChatNaissance.Day
            );
            skipLine();

            WriteLine(monChat.getIsCatHugable()); //methode unique à la classe enfant
            skipLine();

            try
            {
                monChat.hug(); //methode unique à la classe enfant
            }
            catch (System.Exception e)
            {
                WriteLine($"Error: {e.Message}"); //Exception envoyé depuis la classe enfant
            }
        }
    }
}
