using Data.Entities;
using Data.Repositories;
using IBusiness.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlSugar;
namespace Business.Services
{
    /// <summary>
    /// 权限服务
    /// </summary>
    public class AuthorityService : IAuthorityService
    {
        private  static IMemberpersonainfoRepository _memberpersonainfoRepository;

        public AuthorityService(IMemberpersonainfoRepository memberpersonainfoRepository)
        {
            _memberpersonainfoRepository = memberpersonainfoRepository;
        }
    }
}
