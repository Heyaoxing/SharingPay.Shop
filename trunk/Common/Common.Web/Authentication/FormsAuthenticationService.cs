using Common.Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Security;

namespace Common.Web.Authentication
{
    public class FormsAuthenticationService : IAuthenticationService
    {
        private readonly TimeSpan _expirationTimeSpan;
        private UserData _cachedUserData;

        public FormsAuthenticationService()
            : this(null)
        {

        }

        public FormsAuthenticationService(HttpContextBase httpContext)
        {
            // _expirationTimeSpan = FormsAuthentication.Timeout;60*8
            _expirationTimeSpan = DateTime.Now.AddMinutes(60).Subtract(DateTime.Now);
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="userData"></param>
        /// <param name="createPersistentCookie"></param>
        public virtual void SignIn(UserData userData, bool createPersistentCookie = false)
        {
            var now = DateTime.UtcNow.ToLocalTime();

            var ticket = new FormsAuthenticationTicket(
                                                            1,
                                                            userData.Account,
                                                            now,
                                                            now.Add(_expirationTimeSpan),
                                                            createPersistentCookie,
                                                            new JavaScriptSerializer().Serialize(userData),
                                                            FormsAuthentication.FormsCookiePath
                                                       );

            var encryptedTicket = FormsAuthentication.Encrypt(ticket);
            //TimeSpan ts = DateTime.Now.AddMinutes(60).Subtract(DateTime.Now);
            //TimeSpan ts = _expirationTimeSpan;
            //bool s= RedisHelper.SetTimeSpan<UserData>(FormsAuthentication.FormsCookieName, userData,ts);
            
            var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket) { HttpOnly = true };

            if (ticket.IsPersistent)
            {
                cookie.Expires = ticket.Expiration;
            }
            cookie.Secure = FormsAuthentication.RequireSSL;
            cookie.Path = FormsAuthentication.FormsCookiePath;
            if (FormsAuthentication.CookieDomain != null)
            {
                cookie.Domain = FormsAuthentication.CookieDomain;
            }
            HttpContext.Current.Response.Cookies.Add(cookie);
            _cachedUserData = userData;
            //if (s)
            //{
            //    _cachedUserData = userData;
            //}
        }

        /// <summary>
        /// 登出
        /// </summary>
        public virtual void SignOut()
        {
            _cachedUserData = null;
            FormsAuthentication.SignOut();
        }

        /// <summary>
        /// 获取登录信息
        /// </summary>
        /// <returns></returns>
        public virtual UserData GetAuthenticatedUserData()
        {


            if (HttpContext.Current == null ||
                HttpContext.Current.Request == null ||
                !HttpContext.Current.Request.IsAuthenticated ||
                !(HttpContext.Current.User.Identity is FormsIdentity))
            {
                return null;
            }

            if (_cachedUserData != null)
                return _cachedUserData;

            var formsIdentity = (FormsIdentity)HttpContext.Current.User.Identity;
            //var user = RedisHelper.Get<UserData>(FormsAuthentication.FormsCookieName);
            var customer = GetAuthenticatedUserDataFromTicket(formsIdentity.Ticket);
            if (customer != null)
            { _cachedUserData = customer; }
            //if (user!=null) {
            //    _cachedUserData = user;
            //}
            return _cachedUserData;
        }

        protected virtual UserData GetAuthenticatedUserDataFromTicket(FormsAuthenticationTicket ticket)
        {
            if (ticket == null)
                throw new ArgumentNullException("ticket");

            return new JavaScriptSerializer().Deserialize<UserData>(ticket.UserData);
        }
    }
}
