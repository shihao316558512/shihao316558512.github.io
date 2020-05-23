using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shihao316558512.github.io
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            string a = @"
	     vivoX50			2020年6月1日		待发布					
			--2020年5月
			Redmi x10		2020年5月26日		待发布
			荣耀x10			2020年5月20日		1899
			iqooz1			2020年5月19日		2198
			魅族17			2020年5月8日		3699
			魅族17 Pro		2020年5月8日 		4299
			--2020年4月
			小米10青春版		2020年4月27日		2099
			vivo Y50		2020年4月25日		1698
			iQOO Neo3		2020年4月23日		2698
			华为nova7		2020年4月23日		3399   
			华为Nova7Pro		2020年4月23日		4099
			华为Nova7SE		2020年4月23日		2799   
			OPPO A92s		2020年4月21日		2199   
			努比亚Play5G		2020年4月21日		2399  
			iPhoneSE2		2020年4月18日		3299  
			一加8			2020年4月17日		3999  
			一加8pro		2020年4月17日		5399
			荣耀30pro+		2020年4月15日		4999
			荣耀30pro		2020年4月15日		3999
			荣耀30			2020年4月15日		2999 
			OPPO Ace2		2020年4月13日		3999
			荣耀Play4T		2020年4月9日		1199  
			荣耀Play4T Pro		2020年4月9日		1499  
			华为p40			2020年4月8日		4188  
			华为p40pro		2020年4月8日		5988   
			华为p40pro+		2020年4月8日		7988
			--2020年3月
			vivo S6			2020年3月31日		2698
			荣耀30S			2020年3月30日		2399
			Redmi k30pro		2020年3月24日		2999 
			中兴AXON 11		2020年3月23日		2698
			realme X50 Pro		2020年3月12日		3599
			nubia 红魔5G		2020年3月12日		3799
			vivo NEX 3S		2020年3月10日		4998  
			OPPO Find X2		2020年3月6日		5499
			OPPO Find X2 Pro	2020年3月6日		6999
			腾讯黑鲨游戏手机3	2020年3月3日		3499
			腾讯黑鲨游戏手机3 Pro	2020年3月3日		4699
			华为畅享10e		2020年3月1日		999
			--2020年2月
			vivo Z6			2020年2月29日		2298 
			三星S20			2020年2月27日 		6999   
			三星S20Ultra		2020年2月27日		9999
			iQOO3			2020年2月25日		3598
			小米10			2020年2月13日		3999
			小米10pro		2020年2月13日		4999
";
            string[] b = a.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            List<Mobile> mobileList = new List<Mobile>();
            try
            {
                foreach (var item in b)
                {
                    string[] mobiles = item.Split(new string[] { "\t" }, StringSplitOptions.RemoveEmptyEntries);
                    mobileList.Add(new Mobile()
                    {
                        name = mobiles[0],
                        time = mobiles.Length > 1 ? mobiles[1] : string.Empty,
                        price = mobiles.Length > 2 ? mobiles[2] : string.Empty,
                        score = mobiles.Length > 3 ? mobiles[3] : string.Empty,
                        href = mobiles.Length > 4 ? mobiles[4] : string.Empty,
                        content = mobiles.Length > 5 ? mobiles[5] : string.Empty
                    });
                }

                string data = string.Format(@"var data={0};", Nms.Common.DataSerializer.EntityToJson(mobileList));
                using (StreamWriter sw = new StreamWriter(Server.MapPath("/js/antutunew.js"), false, Encoding.UTF8))
                {
                    sw.Write(data);
                }
            }
            catch (Exception ex)
            {
                string bx = ex.Message;
            }
        }
    }
    public class Mobile
    {
        public string name { get; set; }
        public string time { get; set; }
        public string score { get; set; }
        public string price { get; set; }
        public string href { get; set; }
        public string content { get; set; }
    }
}