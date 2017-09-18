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
	/// 实体-Aftersalecertificate 
	/// </summary>
	public partial class Aftersalecertificate : Entity    
	{	
		/// <summary>  
        /// 售后凭证表Id  
        /// </summary>
		public long ASCId { get; set; }  

		/// <summary>  
        /// 图片信息表Id  
        /// </summary>
		public long? ImageId { get; set; }  

		/// <summary>  
        /// 售后申请表Id  
        /// </summary>
		public long? ASAId { get; set; }  

		/// <summary>  
        /// 创建时间  
        /// </summary>
		public DateTime CreatedOn { get; set; }  

		
	}
}
	
