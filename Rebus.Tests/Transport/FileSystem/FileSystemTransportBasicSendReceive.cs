using NUnit.Framework;
using Rebus.Tests.Contracts.Transports;

namespace Rebus.Tests.Transport.FileSystem
{
    [TestFixture]
    public class FileSystemTransportBasicSendReceive : BasicSendReceive<FileSystemTransportFactory>
    {
        protected override TransportBehavior Behavior => new TransportBehavior(ReturnsNullWhenQueueIsEmpty: true);
    }
}