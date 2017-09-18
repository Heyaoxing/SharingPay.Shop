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
	/// 实体-Orderinfo 
	/// </summary>
	public partial class Orderinfo : Entity    
	{	
		/// <summary>  
        /// 订单信息表Id  
        /// </summary>
		public long OrderId { get; set; }  

		/// <summary>  
        /// 会员个人中心Id  
        /// </summary>
		public long? MPId { get; set; }  

		/// <summary>  
        /// 订单编码  
        /// </summary>
		public string OrderCode { get; set; }  

		/// <summary>  
        /// 支付方式  
        /// </summary>
		public int PayWay { get; set; }  

		/// <summary>  
        /// 现金支付金额   
        /// </summary>
		public decimal CashMoney { get; set; }  

		/// <summary>  
        /// 提现积分抵扣金额  
        /// </summary>
		public decimal CashBalance { get; set; }  

		/// <summary>  
        /// 消费积分抵扣金额  
        /// </summary>
		public decimal ConBalance { get; set; }  

		/// <summary>  
        /// 商城积分抵扣金额  
        /// </summary>
		public decimal IntegralBalance { get; set; }  

		/// <summary>  
        /// 订单状态  
        /// </summary>
		public int Status { get; set; }  

		/// <summary>  
        /// 下单时间  
        /// </summary>
		public DateTime OrderTime { get; set; }  

		/// <summary>  
        /// 支付时间  
        /// </summary>
		public DateTime PayTime { get; set; }  

		/// <summary>  
        /// 编辑时间  
        /// </summary>
		public DateTime UpdatedOn { get; set; }  

		/// <summary>  
        /// 创建时间  
        /// </summary>
		public DateTime CreatedOn { get; set; }  

		/// <summary>  
        /// 是否删除 0:否 1是  
        /// </summary>
		public int IsRemove { get; set; }  

		
	}
}
	
