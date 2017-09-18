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
	/// 实体-Salepricerecord 
	/// </summary>
	public partial class Salepricerecord : Entity    
	{	
		/// <summary>  
        /// 售货流水表Id  
        /// </summary>
		public long SRId { get; set; }  

		/// <summary>  
        /// 商品Id  
        /// </summary>
		public long? ProductId { get; set; }  

		/// <summary>  
        /// 供应商信息表Id  
        /// </summary>
		public int? SupplierId { get; set; }  

		/// <summary>  
        /// 订单详情列表Id  
        /// </summary>
		public long? OrderDetailId { get; set; }  

		/// <summary>  
        /// 供应商价格  
        /// </summary>
		public decimal SupplyPrice { get; set; }  

		/// <summary>  
        /// 运费  
        /// </summary>
		public decimal Freight { get; set; }  

		/// <summary>  
        /// 支付方式 100:支付宝 200:提现享付宝支付 300:购物享付宝加支付宝支付  
        /// </summary>
		public int PayWay { get; set; }  

		/// <summary>  
        /// 创建时间  
        /// </summary>
		public DateTime? CreatedOn { get; set; }  

		
	}
}
	
