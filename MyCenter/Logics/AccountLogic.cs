using MyCenter.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyCenter.Logics
{
    public class AccountLogic : IAccountLogic
    {
        private ICache _cache;
        public AccountLogic(ICache cache)
        {
            _cache = cache;
        }

        public long Login(string userName, string password)
        {
            if (userName.Equals("edwin"))
            {
                if (password.Equals("abc123_"))
                {
                    _cache.Add<long>(SessionConstant.USER, 80808);
                    return 80808;
                }
                return -2;
            }
            if (userName.Equals("a") && password.Equals("a"))
            {
                if (password.Equals("a"))
                {
                    _cache.Add<long>(SessionConstant.USER, 7078);
                    return 7078;
                }
                return -2;
            }
            return -1;
        }


        public bool LogOut(long userId)
        {
            var user = _cache.Get<long>(SessionConstant.USER);
            if (user == userId)
            {
                _cache.Remove(SessionConstant.USER);
            }
            return true;
        }
    }

    public interface IAccountLogic
    {
        long Login(string userName, string password);

        bool LogOut(long userId);
    }
}