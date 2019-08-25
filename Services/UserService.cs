using IdealPoultryApp.DataModelsPoultry;
using IdealPoultryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdealPoultryApp.Services
{
    public class UserService : IUserService
    {
        private IdealPoultryContext _context;

        public UserService(IdealPoultryContext context)
        {
            _context = context;
        }

        public bool IsUserValid(LoginModel model)
        {
            return _context.IsUserValid(model)>0;
        }
    }
}
