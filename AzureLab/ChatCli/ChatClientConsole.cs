using System;
using System.Linq;
using ChatService.Interfaces;
using ChatService.Models;

namespace ChatCli
{
    internal class ChatClientConsole
    {
        public static string ReadMessageFromConsole()
        {
            Console.Write("Message> ");
            return Console.ReadLine();
        }

        public static void SendMessage(IChatService serviceClient, string msg)
        {
            if (msg.Any()) serviceClient.SendMessage(new ChatMessage {Message = msg, Sender = Environment.MachineName});
        }

        public static void ClearConsole()
        {
            Console.Clear();
        }

        public static void PrintAllMessages(IChatService serviceClient)
        {
            IOrderedEnumerable<ChatMessage> messages = serviceClient.GetAllMessages().OrderBy(m => m.TimeStamp);
            foreach (ChatMessage chatMessage in messages)
                Console.WriteLine($"{chatMessage.TimeStamp}, {chatMessage.Sender}> {chatMessage.Message}");
        }
    }
}