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
	/// 实体-Orderdetailinfo 
	/// </summary>
	public partial class Orderdetailinfo : Entity    
	{	
		/// <summary>  
        /// 订单详情列表Id  
        /// </summary>
		public long OrderDetailId { get; set; }  

		/// <summary>  
        /// 订单信息表Id  
        /// </summary>
		public long? OrderId { get; set; }  

		/// <summary>  
        /// 商品Id  
        /// </summary>
		public long? ProductId { get; set; }  

		/// <summary>  
        /// 商品种类表Id  
        /// </summary>
		public long? kindId { get; set; }  

		/// <summary>  
        /// ShelfId  
        /// </summary>
		public long? ShelfId { get; set; }  

		/// <summary>  
        /// 商品编码  
        /// </summary>
		public string ProductCode { get; set; }  

		/// <summary>  
        /// 商品缩略图  
        /// </summary>
		public long? SmallImageId { get; set; }  

		/// <summary>  
        /// 商品原图  
        /// </summary>
		public long? OriginalImageId { get; set; }  

		/// <summary>  
        /// 商品名称  
        /// </summary>
		public string Name { get; set; }  

		/// <summary>  
        /// 购买数量  
        /// </summary>
		public int SaleQuantity { get; set; }  

		/// <summary>  
        /// 商品单市场价  
        /// </summary>
		public decimal MarketPrice { get; set; }  

		/// <summary>  
        /// 商品单会员价  
        /// </summary>
		public decimal MemberPrice { get; set; }  

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
	
