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
	/// 实体-Productshowinfo 
	/// </summary>
	public partial class Productshowinfo : Entity    
	{	
		/// <summary>  
        /// 商品图片展示Id  
        /// </summary>
		public long PSId { get; set; }  

		/// <summary>  
        /// 商品Id  
        /// </summary>
		public long? ProductId { get; set; }  

		/// <summary>  
        /// 图片信息表Id  
        /// </summary>
		public long? ImageId { get; set; }  

		/// <summary>  
        /// 创建时间  
        /// </summary>
		public DateTime CreatedOn { get; set; }  

		/// <summary>  
        /// 分类顺序  
        /// </summary>
		public int Sort { get; set; }  

		
	}
}
	
