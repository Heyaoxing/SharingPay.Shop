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
	/// 实体-Producttypeinfo 
	/// </summary>
	public partial class Producttypeinfo : Entity    
	{	
		/// <summary>  
        /// 分类Id  
        /// </summary>
		public int ProductTypeId { get; set; }  

		/// <summary>  
        /// 上级Id  
        /// </summary>
		public int? ParentId { get; set; }  

		/// <summary>  
        /// 分类名称  
        /// </summary>
		public string Name { get; set; }  

		/// <summary>  
        /// 分类顺序  
        /// </summary>
		public int Sort { get; set; }  

		/// <summary>  
        /// 是否删除 0:否 1是  
        /// </summary>
		public int IsRemove { get; set; }  

		
	}
}
	
