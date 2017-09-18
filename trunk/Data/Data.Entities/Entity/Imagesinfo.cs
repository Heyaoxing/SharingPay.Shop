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
	/// 实体-Imagesinfo 
	/// </summary>
	public partial class Imagesinfo : Entity    
	{	
		/// <summary>  
        /// 图片信息表Id  
        /// </summary>
		public long ImageId { get; set; }  

		/// <summary>  
        /// 图片Url  
        /// </summary>
		public string ImgUrl { get; set; }  

		/// <summary>  
        /// 图片MD5值  
        /// </summary>
		public string MDCode { get; set; }  

		/// <summary>  
        /// 磁盘路径  
        /// </summary>
		public string DiscUrl { get; set; }  

		/// <summary>  
        /// 图片尺寸  
        /// </summary>
		public int Size { get; set; }  

		/// <summary>  
        /// 创建时间  
        /// </summary>
		public DateTime CreatedOn { get; set; }  

		
	}
}
	
