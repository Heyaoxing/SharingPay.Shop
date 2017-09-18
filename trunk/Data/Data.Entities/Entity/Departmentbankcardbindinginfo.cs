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
	/// 实体-Departmentbankcardbindinginfo 
	/// </summary>
	public partial class Departmentbankcardbindinginfo : Entity    
	{	
		/// <summary>  
        /// 银行卡绑定表Id  
        /// </summary>
		public int MBCBIId { get; set; }  

		/// <summary>  
        /// 供应商信息表Id  
        /// </summary>
		public int? SupplierId { get; set; }  

		/// <summary>  
        /// 开户银行名称  
        /// </summary>
		public string BankName { get; set; }  

		/// <summary>  
        /// 开户网点地址  
        /// </summary>
		public string BankAddress { get; set; }  

		/// <summary>  
        /// 开户网点名称  
        /// </summary>
		public string BankPosition { get; set; }  

		/// <summary>  
        /// 银行卡帐号  
        /// </summary>
		public string BankAccount { get; set; }  

		/// <summary>  
        /// 银行卡类型  
        /// </summary>
		public int CardType { get; set; }  

		/// <summary>  
        /// 开户人真实姓名  
        /// </summary>
		public string HolderName { get; set; }  

		/// <summary>  
        /// 状态  
        /// </summary>
		public int? Status { get; set; }  

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
	
