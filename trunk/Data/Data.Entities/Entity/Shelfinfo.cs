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
	/// 实体-Shelfinfo 
	/// </summary>
	public partial class Shelfinfo : Entity    
	{	
		/// <summary>  
        /// ShelfId  
        /// </summary>
		public long ShelfId { get; set; }  

		/// <summary>  
        /// 商品Id  
        /// </summary>
		public long? ProductId { get; set; }  

		/// <summary>  
        /// 商品种类表Id  
        /// </summary>
		public long? kindId { get; set; }  

		/// <summary>  
        /// 商品数量  
        /// </summary>
		public int Quantity { get; set; }  

		/// <summary>  
        /// 市场价  
        /// </summary>
		public decimal MarketPrice { get; set; }  

		/// <summary>  
        /// 会员价  
        /// </summary>
		public decimal MemberPrice { get; set; }  

		/// <summary>  
        /// 积分抵扣  
        /// </summary>
		public decimal Deductible { get; set; }  

		/// <summary>  
        /// 运费  
        /// </summary>
		public decimal Freight { get; set; }  

		/// <summary>  
        /// 状态 100:下架 200:上架  
        /// </summary>
		public int Status { get; set; }  

		/// <summary>  
        /// 上架时间  
        /// </summary>
		public DateTime? shelvesOn { get; set; }  

		/// <summary>  
        /// 下架时间  
        /// </summary>
		public DateTime? shelvesOff { get; set; }  

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
	
