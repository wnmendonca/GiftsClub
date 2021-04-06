using GiftsClub.Domain.Entities;
using System.Threading.Tasks;

namespace GiftsClub.Application.Interface
{
    public interface IErrorAppService
    {
        Task Log(Error error);
    }
}
