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
	/// 实体-Aftersaleapplyinfo 
	/// </summary>
	public partial class Aftersaleapplyinfo : Entity    
	{	
		/// <summary>  
        /// 售后申请表Id  
        /// </summary>
		public long ASAId { get; set; }  

		/// <summary>  
        /// 订单详情列表Id  
        /// </summary>
		public long? OrderDetailId { get; set; }  

		/// <summary>  
        /// 会员个人中心Id  
        /// </summary>
		public long? MPId { get; set; }  

		/// <summary>  
        /// 审核人员id  
        /// </summary>
		public long? PersonId { get; set; }  

		/// <summary>  
        /// 售后类型  
        /// </summary>
		public int AfterSaleType { get; set; }  

		/// <summary>  
        /// 售后理由  
        /// </summary>
		public string Reason { get; set; }  

		/// <summary>  
        /// 状态  
        /// </summary>
		public int Status { get; set; }  

		/// <summary>  
        /// 失败原因  
        /// </summary>
		public string ErrorMessage { get; set; }  

		/// <summary>  
        /// 审核时间  
        /// </summary>
		public DateTime ReviewOn { get; set; }  

		/// <summary>  
        /// 申请时间  
        /// </summary>
		public DateTime ApplyOn { get; set; }  

		/// <summary>  
        /// 创建时间  
        /// </summary>
		public DateTime CreatedOn { get; set; }  

		/// <summary>  
        /// 编辑时间  
        /// </summary>
		public DateTime UpdatedOn { get; set; }  

		
	}
}
	
