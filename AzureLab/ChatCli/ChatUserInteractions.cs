using System;
using System.Linq;
using ChatService.Interfaces;
using ChatService.Models;

namespace ChatCli
{
    internal class ChatUserInteractions
    {
        public static void RunEventLoop(IChatService serviceClient)
        {
            string msg = string.Empty;

            while (true)
            {
                switch (msg)
                {
                    case "q":
                    case "quit":
                    case "exit":
                        return;
                    default:
                        ChatClientConsole.ClearConsole();
                        ChatClientConsole.SendMessage(serviceClient, msg);
                        ChatClientConsole.PrintAllMessages(serviceClient);
                        msg = ChatClientConsole.ReadMessageFromConsole();
                        break;
                }
            }
        }
    }
}