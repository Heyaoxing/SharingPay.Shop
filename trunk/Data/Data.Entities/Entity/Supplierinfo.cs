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
	/// 实体-Supplierinfo 
	/// </summary>
	public partial class Supplierinfo : Entity    
	{	
		/// <summary>  
        /// 供应商信息表Id  
        /// </summary>
		public int SupplierId { get; set; }  

		/// <summary>  
        /// 供应商名称  
        /// </summary>
		public string SupplierName { get; set; }  

		/// <summary>  
        /// 联系人  
        /// </summary>
		public string ContactName { get; set; }  

		/// <summary>  
        /// 全国地理位置信息表Id  
        /// </summary>
		public string AreaID { get; set; }  

		/// <summary>  
        /// 联系地址  
        /// </summary>
		public string Street { get; set; }  

		/// <summary>  
        /// 供应商描述  
        /// </summary>
		public string Descropt { get; set; }  

		/// <summary>  
        /// 状态 100:禁用 200:启用  
        /// </summary>
		public int Status { get; set; }  

		/// <summary>  
        /// 货款余额  
        /// </summary>
		public decimal Balance { get; set; }  

		/// <summary>  
        /// 冻结金额  
        /// </summary>
		public decimal FreezeMoney { get; set; }  

		/// <summary>  
        /// 是否删除 0:否 1:是  
        /// </summary>
		public int IsRemove { get; set; }  

		/// <summary>  
        /// 创建人  
        /// </summary>
		public long PersonId { get; set; }  

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
	
