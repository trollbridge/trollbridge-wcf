using System.ServiceModel;
using System.ServiceModel.Web;
using Trollbridge.Core;

namespace Trollbridge.Wcf
{
    [ServiceContract]
    public interface ITokenService
    {
        /// <summary>
        /// Gets SAS tokens to enable a device to access Azure blobs, queues, and event hubs.
        /// </summary>
        /// <param name="id">Id of device to return SAS tokens for.</param>
        /// <param name="compressed">Whether or not to compress the returned tokens.</param>
        /// <returns></returns>
        [OperationContract]
        TokenHolder GetTokenCompressed(string id, bool compressed);

    }
}
