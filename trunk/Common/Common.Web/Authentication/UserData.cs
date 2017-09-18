using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common.Web.Authentication
{
    public class UserData
    {
        /// <summary>  
        /// 人员表主键  
        /// </summary>
        public int PersonId { get; set; }
        /// <summary>
        /// 部门最高ID
        /// </summary>
        public int DepartmentId { get; set; }
        /// <summary>  
        /// 帐号  
        /// </summary>
        public string Account { get; set; }

        /// <summary>  
        /// 昵称  
        /// </summary>
        public string nickname { get; set; }

        /// <summary>  
        /// 姓名  
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 部门类型
        /// </summary>
        public int DepartmentType { set; get; }

        /// <summary>
        /// 所属机构
        /// </summary>
        public int RoleGroupType { set; get; }

        /// <summary>
        /// 角色类型
        /// </summary>
        public int ManagerRoleType { set; get; }
    }
}
