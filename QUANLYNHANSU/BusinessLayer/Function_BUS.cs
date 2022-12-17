using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Function_BUS
    {
		//Đếm số ngày làm việc trong tháng
		public static int demSoNgayLamViecTrongThang(int thang, int nam)
		{
			//int dem = 0;
			//DateTime f = new DateTime(nam, thang, 01);
			//int x = f.Month +1;
			//while (f.Month <= x)
			//{
			//	dem = dem + 1;
			//	if (f.DayOfWeek == DayOfWeek.Sunday)
			//	{
			//		dem = dem - 1;
			//	}
			//	f = f.AddDays(1);
			//}
			//return dem;
			int daysInMonth = 0;
			int days = DateTime.DaysInMonth(nam, thang);
			for (int i = 1; i <= days; i++)
			{
				DateTime day = new DateTime(nam, thang, i);
				if (day.DayOfWeek != DayOfWeek.Sunday)
				{
					daysInMonth++;
				}
			}
			return daysInMonth;
		}
		public static int laySoNgayCuaThang(int thang, int nam)
		{
			return DateTime.DaysInMonth(nam, thang);
		}

		public static string layThuTrongTuan(int nam, int thang, int ngay)
		{
			string thu = "";
			DateTime newDate = new DateTime(nam, thang, nam);
			switch (newDate.DayOfWeek.ToString())
			{
				case "Monday":
					thu = "Thứ hai";
					break;
				case "Tuesday":
					thu = "Thứ ba";
					break;
				case "Wednesday":
					thu = "Thứ tư";
					break;
				case "Thursday":
					thu = "Thứ năm";
					break;
				case "Friday":
					thu = "Thứ sáu";
					break;
				case "Saturday":
					thu = "Thứ sáu";
					break;
				case "Sunday":
					thu = "Chủ nhật";
					break;
			}
			return thu;
		}
	}
}
