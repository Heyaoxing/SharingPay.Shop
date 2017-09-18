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
	/// 实体-Marketinginfo 
	/// </summary>
	public partial class Marketinginfo : Entity    
	{	
		/// <summary>  
        /// 商品营销表Id  
        /// </summary>
		public long MarketingId { get; set; }  

		/// <summary>  
        /// 商品Id  
        /// </summary>
		public long? ProductId { get; set; }  

		/// <summary>  
        /// 商品点击量  
        /// </summary>
		public int ClickNumber { get; set; }  

		/// <summary>  
        /// 是否新品 0:否 1:是  
        /// </summary>
		public int IsNew { get; set; }  

		/// <summary>  
        /// 是否热销 0:否 1:是  
        /// </summary>
		public int IsHot { get; set; }  

		/// <summary>  
        /// 被放购物车数量  
        /// </summary>
		public int CartVolume { get; set; }  

		/// <summary>  
        /// 销售数量  
        /// </summary>
		public int SalesVolume { get; set; }  

		/// <summary>  
        /// 更新时间  
        /// </summary>
		public DateTime UpdatedOn { get; set; }  

		
	}
}
	
