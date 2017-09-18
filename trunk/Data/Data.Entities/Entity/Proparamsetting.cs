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
	/// 实体-Proparamsetting 
	/// </summary>
	public partial class Proparamsetting : Entity    
	{	
		/// <summary>  
        /// 产品参数表Id  
        /// </summary>
		public long ProParamId { get; set; }  

		/// <summary>  
        /// 商品Id  
        /// </summary>
		public long? ProductId { get; set; }  

		/// <summary>  
        /// 参数名称  
        /// </summary>
		public string ParamName { get; set; }  

		/// <summary>  
        /// 参数值  
        /// </summary>
		public string ParamValue { get; set; }  

		
	}
}
	
