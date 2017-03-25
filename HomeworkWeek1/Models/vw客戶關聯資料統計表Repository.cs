using System;
using System.Linq;
using System.Collections.Generic;
	
namespace HomeworkWeek1.Models
{   
	public  class vw客戶關聯資料統計表Repository : EFRepository<vw客戶關聯資料統計表>, Ivw客戶關聯資料統計表Repository
	{

	}

	public  interface Ivw客戶關聯資料統計表Repository : IRepository<vw客戶關聯資料統計表>
	{

	}
}