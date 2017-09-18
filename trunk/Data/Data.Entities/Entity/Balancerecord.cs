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
	/// 实体-Balancerecord 
	/// </summary>
	public partial class Balancerecord : Entity    
	{	
		/// <summary>  
        /// 资金流水表Id  
        /// </summary>
		public long BRId { get; set; }  

		/// <summary>  
        /// 提现记录表Id  
        /// </summary>
		public long? WithdrawId { get; set; }  

		/// <summary>  
        /// 订单详情列表Id  
        /// </summary>
		public long? OrderDetailId { get; set; }  

		/// <summary>  
        /// 金额  
        /// </summary>
		public decimal Money { get; set; }  

		/// <summary>  
        /// 快照金额  
        /// </summary>
		public decimal OldMoney { get; set; }  

		/// <summary>  
        /// 变动类型 100: 商品销售收入 200: 提醒支出 300: 提现手续费支出  
        /// </summary>
		public int ChangeType { get; set; }  

		/// <summary>  
        /// 收支类型 100:收入 200:支出 300:冲销  
        /// </summary>
		public int ChargeType { get; set; }  

		/// <summary>  
        /// 创建时间  
        /// </summary>
		public DateTime CreatedOn { get; set; }  

		
	}
}
	
