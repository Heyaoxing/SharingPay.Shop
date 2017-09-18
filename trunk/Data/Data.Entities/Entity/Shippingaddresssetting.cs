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
	/// 实体-Shippingaddresssetting 
	/// </summary>
	public partial class Shippingaddresssetting : Entity    
	{	
		/// <summary>  
        /// 收货地址配置表Id  
        /// </summary>
		public long SASId { get; set; }  

		/// <summary>  
        /// 会员个人中心Id  
        /// </summary>
		public long? MPId { get; set; }  

		/// <summary>  
        /// 收件人  
        /// </summary>
		public string Addressee { get; set; }  

		/// <summary>  
        /// 手机号码  
        /// </summary>
		public string MobilePhoneNumber { get; set; }  

		/// <summary>  
        /// 是否默认  
        /// </summary>
		public int isDefault { get; set; }  

		/// <summary>  
        /// 全国地理位置信息表Id  
        /// </summary>
		public string AreaID { get; set; }  

		/// <summary>  
        /// 街道地址  
        /// </summary>
		public string Street { get; set; }  

		/// <summary>  
        /// 邮编  
        /// </summary>
		public string ZipCode { get; set; }  

		/// <summary>  
        /// 创建时间  
        /// </summary>
		public DateTime CrearedOn { get; set; }  

		/// <summary>  
        /// 编辑时间  
        /// </summary>
		public DateTime UpdatedOn { get; set; }  

		/// <summary>  
        /// 是否删除 0:否 1是  
        /// </summary>
		public int IsRemove { get; set; }  

		
	}
}
	
