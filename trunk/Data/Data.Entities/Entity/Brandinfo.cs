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
	/// 实体-Brandinfo 
	/// </summary>
	public partial class Brandinfo : Entity    
	{	
		/// <summary>  
        /// 品牌信息表Id  
        /// </summary>
		public int BrandId { get; set; }  

		/// <summary>  
        /// 品牌名称  
        /// </summary>
		public string Name { get; set; }  

		/// <summary>  
        /// 创建时间  
        /// </summary>
		public DateTime CreatedOn { get; set; }  

		/// <summary>  
        /// 是否删除 0:否 1:是  
        /// </summary>
		public int IsRemove { get; set; }  

		
	}
}
	
