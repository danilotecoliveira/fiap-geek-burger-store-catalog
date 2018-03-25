using Microsoft.Azure.ServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GeekBurger.StoreCatalog.ServiceBus
{
    public class ReceiveMessage
    {
        public ReceiveMessage() => ReceberMensagemAsync();


        const string ServiceBusConnectionString = "Endpoint=sb://geekburger.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=VrwaCn+4NbZkDFguQNGDCu2cMQ7IXyjOPLMto0HuE8Q=";       
        const string TopicName = "storecatalog";
        const string SubscriptionName = "catalog";
        static ISubscriptionClient subscriptionClient;

        /// <summary>
        /// Método responsável por se subscrever em um tópico
        /// </summary>
        /// <returns></returns>
        public async Task ReceberMensagemAsync()
        {       
            subscriptionClient = new SubscriptionClient(ServiceBusConnectionString, TopicName, SubscriptionName, ReceiveMode.PeekLock);                     
            RegisterOnMessageHandlerAndReceiveMessages();          
        }
        /// <summary>
        /// Método responsável por definir ações de sucesso e err na captura da mensagem
        /// </summary>
        private static void RegisterOnMessageHandlerAndReceiveMessages()
        {
            var messageHandlerOptions = new MessageHandlerOptions(ExceptionReceivedHandler)
            {
                MaxConcurrentCalls = 3,
                AutoComplete = false
            };

            subscriptionClient.RegisterMessageHandler(ProcessMessagesAsync, messageHandlerOptions);
        }


        /// <summary>
        /// Método responsável por processar a mensagem
        /// </summary>
        /// <param name="message"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        private static async Task ProcessMessagesAsync(Message message, CancellationToken token)
        {
            string teste = Encoding.UTF8.GetString(message.Body);
            await subscriptionClient.CompleteAsync(message.SystemProperties.LockToken);
        }

        /// <summary>
        /// Métofo de exceção
        /// </summary>
        /// <param name="exceptionReceivedEventArgs"></param>
        /// <returns></returns>
        private static Task ExceptionReceivedHandler(ExceptionReceivedEventArgs exceptionReceivedEventArgs)
        {
            return Task.CompletedTask;
        }


    }
}
