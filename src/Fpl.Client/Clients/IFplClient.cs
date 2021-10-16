using System.Threading;
using Fpl.Client.Models;
using System.Threading.Tasks;

namespace Fpl.Client.Clients
{
    public interface IFplClient
    {
        Task<Data> GetAsync(CancellationToken cancellationToken = default);
    }
}