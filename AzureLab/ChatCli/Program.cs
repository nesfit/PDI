using System;
using System.Linq;
using System.ServiceModel;
using ChatService.Interfaces;
using ChatService.Models;

namespace ChatCli
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //In case that you want to connect to locally hosted service.
            //Uri uri = new Uri(string.Format("http://localhost:26007/ChatApi.svc", Environment.MachineName));

            Uri uri = new Uri(string.Format("http://azurelabfit.azurewebsites.net/ChatApi.svc", Environment.MachineName));
            
            RunDemoChatClient(uri);

            //RunChatClient(uri);
        }

        private static void RunDemoChatClient(Uri uri)
        {
            using (IChatService serviceClient = CreateServiceClient(uri))
            {
                SendMessage(serviceClient, "Message test");

                PrintAllMessages(serviceClient);

                WaitForPressedKey();
            }
        }

        private static void RunChatClient(Uri uri)
        {
            using (IChatService serviceClient = CreateServiceClient(uri))
            {
                DoMessageLoop(serviceClient);
            }
        }

        private static void DoMessageLoop(IChatService serviceClient)
        {
            string msg = string.Empty;
            while (msg != "q" && msg != "quit" && msg != "exit")
            {
                ClearConsole();
                SendMessage(serviceClient, msg);
                PrintAllMessages(serviceClient);
                msg = ReadMessageFromConsole();
            }
        }

        private static string ReadMessageFromConsole()
        {
            Console.Write("Message> ");
            return Console.ReadLine();
        }

        private static void SendMessage(IChatService serviceClient, string msg)
        {
            if (msg.Any()) serviceClient.SendMessage(new ChatMessage {Message = msg, Sender = Environment.MachineName});
        }

        private static void ClearConsole()
        {
            Console.Clear();
        }

        private static void WaitForPressedKey()
        {
            Console.WriteLine("Press ANY key to continue...");
            Console.ReadKey();
        }

        private static void PrintAllMessages(IChatService serviceClient)
        {
            IOrderedEnumerable<ChatMessage> messages = serviceClient.GetAllMessages().OrderBy(m => m.TimeStamp);
            foreach (ChatMessage chatMessage in messages)
                Console.WriteLine($"{chatMessage.TimeStamp}, {chatMessage.Sender}> {chatMessage.Message}");
        }

        private static IChatService CreateServiceClient(Uri uri)
        {
            BasicHttpBinding binding = new BasicHttpBinding();
            EndpointAddress endpoint = new EndpointAddress(uri);
            ChannelFactory<IChatService> channelFactory = new ChannelFactory<IChatService>(binding, endpoint);
            IChatService serviceClient = channelFactory.CreateChannel();
            return serviceClient;
        }
    }
}