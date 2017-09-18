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
	/// 实体-Shoppingcartinfo 
	/// </summary>
	public partial class Shoppingcartinfo : Entity    
	{	
		/// <summary>  
        /// 购物车Id  
        /// </summary>
		public long CartId { get; set; }  

		/// <summary>  
        /// 商品Id  
        /// </summary>
		public long? ProductId { get; set; }  

		/// <summary>  
        /// 商品种类表Id  
        /// </summary>
		public long? kindId { get; set; }  

		/// <summary>  
        /// 商品缩略图  
        /// </summary>
		public long? ImageId { get; set; }  

		/// <summary>  
        /// 会员个人中心Id  
        /// </summary>
		public long? MPId { get; set; }  

		/// <summary>  
        /// ShelfId  
        /// </summary>
		public long? ShelfId { get; set; }  

		/// <summary>  
        /// 商品数量  
        /// </summary>
		public int Quantity { get; set; }  

		/// <summary>  
        /// 商品单市场价  
        /// </summary>
		public decimal MarketPrice { get; set; }  

		/// <summary>  
        /// 商品单会员价  
        /// </summary>
		public decimal MemberPrice { get; set; }  

		/// <summary>  
        ///   
        /// </summary>
		public DateTime CreatedOn { get; set; }  

		/// <summary>  
        ///   
        /// </summary>
		public DateTime UpdatedOn { get; set; }  

		
	}
}
	
