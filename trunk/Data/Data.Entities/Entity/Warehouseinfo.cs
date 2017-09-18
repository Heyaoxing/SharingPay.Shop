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
	/// 实体-Warehouseinfo 
	/// </summary>
	public partial class Warehouseinfo : Entity    
	{	
		/// <summary>  
        /// 仓库表Id  
        /// </summary>
		public long WarehouseId { get; set; }  

		/// <summary>  
        /// 供应商信息表Id  
        /// </summary>
		public int? SupplierId { get; set; }  

		/// <summary>  
        /// 商品Id  
        /// </summary>
		public long? ProductId { get; set; }  

		/// <summary>  
        /// 供货单价  
        /// </summary>
		public decimal SupplyPrice { get; set; }  

		/// <summary>  
        /// 库存数量  
        /// </summary>
		public int Quantity { get; set; }  

		/// <summary>  
        /// 创建时间  
        /// </summary>
		public DateTime CreatedOn { get; set; }  

		/// <summary>  
        /// 编辑时间  
        /// </summary>
		public DateTime UpdatedOn { get; set; }  

		/// <summary>  
        /// 状态 0:否 1:是  
        /// </summary>
		public int IsRemove { get; set; }  

		
	}
}
	
