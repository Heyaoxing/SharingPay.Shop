//------------------------------------------------------------------------------
// 警告:
//     该代码由T4工具根据模板自动生成,直接在该代码上进行任何修改都将在重新生成后丢失!
//     如有需要应使用partial class或是继承该类进行自定义扩展。
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using  Common.DataEntity;

namespace Data.Entities
{	
	/// <summary>
	/// 实体-Personinfo 
	/// </summary>
	public partial class Personinfo : Entity    
	{	
		/// <summary>  
        /// Id  
        /// </summary>
		public long PersonId { get; set; }  

		/// <summary>  
        /// 用户名  
        /// </summary>
		public string Account { get; set; }  

		/// <summary>  
        /// 所属部门Id  
        /// </summary>
		public long? DepartmentId { get; set; }  

		/// <summary>  
        /// 密码  
        /// </summary>
		public string Password { get; set; }  

		/// <summary>  
        /// 手机号  
        /// </summary>
		public string PhoneNumber { get; set; }  

		/// <summary>  
        /// Email  
        /// </summary>
		public string Email { get; set; }  

		/// <summary>  
        /// 创建时间  
        /// </summary>
		public DateTime? CreatedOn { get; set; }  

		
	}
}
	
