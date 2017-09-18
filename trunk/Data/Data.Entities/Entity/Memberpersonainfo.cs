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
	/// 实体-Memberpersonainfo 
	/// </summary>
	public partial class Memberpersonainfo : Entity    
	{	
		/// <summary>  
        /// 会员个人中心Id  
        /// </summary>
		public long MPId { get; set; }  

		/// <summary>  
        /// MemberId  
        /// </summary>
		public long MemberId { get; set; }  

		/// <summary>  
        /// 创建时间  
        /// </summary>
		public DateTime CreatedOn { get; set; }  

		
	}
}
	
