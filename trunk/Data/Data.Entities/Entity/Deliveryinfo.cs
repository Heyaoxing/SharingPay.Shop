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
	/// 实体-Deliveryinfo 
	/// </summary>
	public partial class Deliveryinfo : Entity    
	{	
		/// <summary>  
        /// 物流信息表Id  
        /// </summary>
		public long DeliveryId { get; set; }  

		/// <summary>  
        /// 订单信息表Id  
        /// </summary>
		public long? OrderId { get; set; }  

		/// <summary>  
        /// 订单编码  
        /// </summary>
		public string OrderCode { get; set; }  

		/// <summary>  
        /// 收货地址配置表Id  
        /// </summary>
		public long? SASId { get; set; }  

		/// <summary>  
        /// 运单号  
        /// </summary>
		public string TrackNumber { get; set; }  

		/// <summary>  
        /// 状态  
        /// </summary>
		public int Status { get; set; }  

		/// <summary>  
        /// 运费  
        /// </summary>
		public decimal Freight { get; set; }  

		/// <summary>  
        /// 创建时间  
        /// </summary>
		public DateTime CreatedOn { get; set; }  

		
	}
}
	
