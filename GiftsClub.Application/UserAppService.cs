using GiftsClub.Application.Interface;
using GiftsClub.Domain.Entities;
using GiftsClub.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftsClub.Application
{
    public class UserAppService : AppServiceBase<User>, IUserAppService
    {
        private readonly IUserService _userService;

        public UserAppService(IUserService userService)
            : base(userService)
        {
            _userService = userService;
        }
    }
}
