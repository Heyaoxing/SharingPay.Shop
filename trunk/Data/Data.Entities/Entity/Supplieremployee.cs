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
	/// 实体-Supplieremployee 
	/// </summary>
	public partial class Supplieremployee : Entity    
	{	
		/// <summary>  
        /// 供应商员工消息表Id  
        /// </summary>
		public int EmployeeId { get; set; }  

		/// <summary>  
        /// 供应商信息表Id  
        /// </summary>
		public int SupplierId { get; set; }  

		/// <summary>  
        /// 昵称  
        /// </summary>
		public string nickname { get; set; }  

		/// <summary>  
        /// 登录账户  
        /// </summary>
		public string Account { get; set; }  

		/// <summary>  
        /// 登录密码  
        /// </summary>
		public string Password { get; set; }  

		/// <summary>  
        /// 编辑时间  
        /// </summary>
		public DateTime UpdatedOn { get; set; }  

		/// <summary>  
        /// 创建时间  
        /// </summary>
		public DateTime CreatedOn { get; set; }  

		
	}
}
	
