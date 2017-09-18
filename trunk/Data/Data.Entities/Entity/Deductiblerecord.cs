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
	/// 实体-Deductiblerecord 
	/// </summary>
	public partial class Deductiblerecord : Entity    
	{	
		/// <summary>  
        /// 平台积分抵扣流水Id  
        /// </summary>
		public string DeductibleId { get; set; }  

		/// <summary>  
        /// 平台信息表Id  
        /// </summary>
		public int? PlatformId { get; set; }  

		/// <summary>  
        /// 订单信息表Id  
        /// </summary>
		public long? OrderId { get; set; }  

		/// <summary>  
        /// 抵扣类型  
        /// </summary>
		public int DeductibleType { get; set; }  

		/// <summary>  
        /// 抵扣金额  
        /// </summary>
		public decimal Money { get; set; }  

		/// <summary>  
        /// 创建时间  
        /// </summary>
		public DateTime CreatedOn { get; set; }  

		
	}
}
	
