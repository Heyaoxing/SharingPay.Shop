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
	/// 实体-Chinaareainfo 
	/// </summary>
	public partial class Chinaareainfo : Entity    
	{	
		/// <summary>  
        /// 全国地理位置信息表Id  
        /// </summary>
		public string AreaID { get; set; }  

		/// <summary>  
        /// 名称  
        /// </summary>
		public string Name { get; set; }  

		/// <summary>  
        /// 父级id  
        /// </summary>
		public string ParentId { get; set; }  

		/// <summary>  
        /// 简称  
        /// </summary>
		public string ShortName { get; set; }  

		/// <summary>  
        /// 层级  
        /// </summary>
		public int? LevelType { get; set; }  

		/// <summary>  
        /// 城市代码  
        /// </summary>
		public string CityCode { get; set; }  

		/// <summary>  
        /// 邮编  
        /// </summary>
		public string ZipCode { get; set; }  

		/// <summary>  
        /// 完整地区名称  
        /// </summary>
		public string MergerName { get; set; }  

		/// <summary>  
        /// 经度  
        /// </summary>
		public string lng { get; set; }  

		/// <summary>  
        /// 纬度  
        /// </summary>
		public string Lat { get; set; }  

		/// <summary>  
        /// 拼音  
        /// </summary>
		public string Pinyin { get; set; }  

		
	}
}
	
