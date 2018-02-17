using ChatService.Interfaces;

namespace ChatCli.Interactions
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
                        ClientConsole.ClearConsole();
                        ClientConsole.SendMessage(serviceClient, msg);
                        ClientConsole.PrintAllMessages(serviceClient);
                        msg = ClientConsole.ReadMessageFromConsole();
                        break;
                }
            }
        }
    }
}