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
	/// 实体-Productinfo 
	/// </summary>
	public partial class Productinfo : Entity    
	{	
		/// <summary>  
        /// 商品Id  
        /// </summary>
		public long ProductId { get; set; }  

		/// <summary>  
        /// 商品编码  
        /// </summary>
		public string ProductCode { get; set; }  

		/// <summary>  
        /// 分类Id  
        /// </summary>
		public int? ProductTypeId { get; set; }  

		/// <summary>  
        /// 商品缩略图  
        /// </summary>
		public long? SmallImageId { get; set; }  

		/// <summary>  
        /// 商品原图  
        /// </summary>
		public long? OriginalImageId { get; set; }  

		/// <summary>  
        /// 品牌信息表Id  
        /// </summary>
		public int? BrandId { get; set; }  

		/// <summary>  
        /// 商品发货地址表Id  
        /// </summary>
		public int? SASId { get; set; }  

		/// <summary>  
        /// 商品名称  
        /// </summary>
		public string Name { get; set; }  

		/// <summary>  
        /// 状态  
        /// </summary>
		public int Status { get; set; }  

		/// <summary>  
        /// 是否删除 0:否 1:是  
        /// </summary>
		public int IsRemove { get; set; }  

		/// <summary>  
        /// 商品备注  
        /// </summary>
		public string GoodsRemark { get; set; }  

		/// <summary>  
        /// SKU  
        /// </summary>
		public string SKU { get; set; }  

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
	
