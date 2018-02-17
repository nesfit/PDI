using ChatService.Interfaces;

namespace ChatCli
{
    internal class ChatDemoInteractions
    {
        public static void RunEventLoop(IChatService serviceClient)
        {
            string msg = string.Empty;
            switch (msg)
                {
                    case "q":
                        return;
                    default:
                        ChatClientConsole.SendMessage(serviceClient, "Message test");
                        ChatClientConsole.PrintAllMessages(serviceClient);
                        break;
                }
        }
    }
}