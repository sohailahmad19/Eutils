using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TekTrackingCore.Models;

namespace TekTrackingCore.Repositry
{
    public interface ILoginRepository
    {
        string BtnText();
        bool IsAlreadyLoggedIn();
        Task<UserInfo> Login(string username, string password);
        void Proceed();
    }


}
