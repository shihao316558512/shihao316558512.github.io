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
			Redmi 10X pro（5g版）	2020年5月26日		2299		410234			https://u.jd.com/2GgcIM		5g手机，重量208g，4520mAh，33w有线快充，天玑820中高端cpu，三星AMOLED屏幕，z轴线性马达，有nfc
			Redmi 10X（5g版）	2020年5月26日		1599		410209			https://u.jd.com/6XwLz2		5g手机，重量205g，4520mAh，22.5w有线快充，天玑820中高端cpu，三星AMOLED屏幕，z轴线性马达，建议至少买6+128版本
			Redmi 10X（4g版）	2020年5月26日		999		208493			https://u.jd.com/DJczHK		4g手机，重量199g，5020mAh，18w有线快充，9w无线反向充电，联发科g85中低端cpu，Lcd挖孔屏，适合父母用
			realme X50 Pro玩家版	2020年5月25日		2699		594706			https://u.jd.com/OPBhLZ		5g手机，重量209g，4200mAh，65w有线快充，高通865顶级cpu，90hz三星Super AMOLED屏幕，z轴线性马达
			荣耀x10			2020年5月20日		1899		373377			https://u.jd.com/XgwBrZ		5g手机，重量203g，4300mAh，22.5w有线快充，麒麟820中高端cpu，Lcd 90hz屏幕，升降摄像头，建议至少买6+128版本
			iqooz1			2020年5月19日		2198		526401			https://u.jd.com/IoU84V	     	5g手机，重量194g，4500mAh，44w有线快充，天玑1000+高端cpu，Lcd 144hz屏幕，vivo子品牌，性价比高
			Redmi K30极速版		2020年5月11日		1999		349194			https://u.jd.com/8qiWS9		5g手机，重量208g，4500mAh，30W有线快充，高通768g中高端cpu，Lcd 120hz刷新率屏幕，nfc 
			魅族17			2020年5月8日		3699		577763			https://u.jd.com/VpVUat		5g手机，重量199g，4500mAh，30w有线快充，高通865顶级cpu，顶级配置，x轴线性马达，nfc
			魅族17 Pro		2020年5月8日 		4299		590826			https://u.jd.com/uOarQZ		5g手机，重量219g，4500mAh，30w有线快充，27w无线快充，高通865高端cpu，顶级配置，x轴线性马达，nfc
			--2020年4月
			小米10青春版		2020年4月27日		2099		324162			https://u.jd.com/fLbYHh		5g手机，重量192g，4160mAh，20w有线快充，高通765g中端cpu，50倍潜望长焦镜头，nfc
			vivo Y50		2020年4月25日		1698		192319			https://u.jd.com/lxNdIv		4g手机，重量197g，5000mAh，18w有线快充，骁龙665低端cpu，性能比较低，但有5000mAh大电池，续航好，8+128，存储容量够用，适合老人用
			iQOO Neo3		2020年4月23日		2698		600893			https://u.jd.com/ZzrqtH		5g手机，重量198g，4500mAh，44w有线快充，高通865顶级cpu,Lcd 144hz刷新率屏幕，性价比高
			华为Nova7SE		2020年4月23日		2799   		363923			https://u.jd.com/1VaAvl		5g手机，重量189g，4000mAh，40w有线快充，麒麟820中端cpu，适合学生，女生
			华为nova7		2020年4月23日		3399   		404215			https://u.jd.com/CFmAyc		5g手机，重量180g，4000mAh，40w有线快充，麒麟985中高端cpu，没有高刷新率屏幕，性能略微强于麒麟820，nfc，拍照好
			华为Nova7Pro		2020年4月23日		4099		401428			https://u.jd.com/NaHQJL		5g手机，重量178g，4000mAh，40w有线快充，麒麟985中高端cpu，比nova7拍照更好，曲面屏，nfc
			OPPO A92s		2020年4月21日		2199		295798 			https://u.jd.com/alAs9v		5g手机，重量184g，4000mAh，18w有线快充，天玑800中端cpu，Lcd 120hz屏幕，
			努比亚Play5G		2020年4月21日		2399  		330459			https://u.jd.com/w6bkne		5g手机，重量210g，5100mAh，30w有线快充，高通765g中端处理器，144hz刷新率AMOLED屏幕，只是近几年这个品牌没有好好经营，没落了
			iPhoneSE2		2020年4月18日		3299  		468486			https://u.jd.com/L4O8ev		4g手机，重量148g，1821mAh，5w有线快充，外观与iPhone8几乎一样，cpu是最新的a13，性能好，但续航极差，不建议买
			一加8			2020年4月17日		3999  		580460			https://u.jd.com/PyU04P		5g手机，重量180g，4300mAh，30w有线快充，高通865高端cpu，一加正统数字系列年度旗舰，配置是目前顶级，系统十分流畅，但有人说系统不如小米和华为完善
			一加8pro		2020年4月17日		5399		576835			https://u.jd.com/3PCFub		5g手机，重量199g，4510mAh，30w有线快充，30w无线快充，3w无线反向充电，高通865高端cpu，一加正统数字系列年度旗舰，目前最顶级的屏幕，看重影音的推荐购买
			荣耀30			2020年4月15日		2999 		386045			https://u.jd.com/dFFa3Z		5g手机，重量185g，4000mAh，40w有线快充，麒麟985中高端cpu，nfc，拍照好。本来是正统数字系列年度升级，但似乎当了陪衬，厂家重点放在了pro和pro+
			荣耀30pro		2020年4月15日		3999		480614			https://u.jd.com/mQoi1B		5g手机，重量186g，4000mAh，40w有线快充，麒麟990顶级cpu，无高刷新率屏幕唯一遗憾，50倍远摄，z轴线性马达，nfc
			荣耀30pro+		2020年4月15日		4999		521832			https://u.jd.com/zsXeld		5g手机，重量186g，4000mAh，40w有线快充，27w无线快充，麒麟990顶级cpu，曲面屏幕，90hz刷新率，50倍远摄，z轴线性马达，nfc
			OPPO Ace2		2020年4月13日		3999		594678			https://u.jd.com/mLFfEk		5g手机，重量185g，4000mAh，65w有线快充，40w无线快充，高通865顶级cpu，90hz直屏，线性马达，nfc
			荣耀Play4T		2020年4月9日		1199  		150000			https://u.jd.com/d7PHsy	        4g手机，重量176g，4000mAh，10w有线快充，麒麟710A低端cpu，唯一卖点就是国产cpu
			荣耀Play4T Pro		2020年4月9日		1499  		303057			https://u.jd.com/0y5UbM		4g手机，重量165g，4000mAh，22.5w有线快充，麒麟810中端cpu，OLED屏幕，屏幕指纹识别
			华为p40			2020年4月8日		4188  		455633			https://u.jd.com/skUgwm		5g手机，重量175g，3800mAh，22.5w有线快充，麒麟990顶级cpu，Z轴线性马达，nfc
			华为p40pro		2020年4月8日		5988   		468764			https://u.jd.com/PyJ1yX		5g手机，重量209g，4200mAh，40w有线快充，20w无线快充，无线反向充电，麒麟990顶级cpu，90hz刷新率，Z轴线性马达，nfc
			华为p40pro+		2020年4月8日		7988		468764			https://u.jd.com/PyJ1yX		5g手机，重量226g，4200mAh，40w有线快充，40w无线快充，无线反向充电，麒麟990顶级cpu，90hz刷新率，Z轴线性马达，nfc
			--2020年3月
			vivo S6			2020年3月31日		2698		330696			https://u.jd.com/HyKJTJ		5g手机，重量181g，4500mAh，18w有线快充，三星Exynos980中端cpu，三星AMOLED屏幕
			荣耀30S			2020年3月30日		2399		364077			https://u.jd.com/6CIiPl		5g手机，重量190g，4000mAh，40w有线快充，麒麟820中高端cpu，lcd屏幕，比较推荐的一款机型
			Redmi k30pro		2020年3月24日		2999 		595555			https://u.jd.com/oE4VDK		5g手机，重量218g，4700mAh，33w有线快充，高通865顶级cpu，三星E3 AMOLED屏幕60hz刷新率，z轴线性马达，nfc
			中兴AXON 11		2020年3月23日		2698		330638			https://u.jd.com/7CRtca		5g手机，重量168g，4000mAh，18w有线快充，高通765g中端cpu，AMOLED屏幕，nfc
			realme X50 Pro		2020年3月12日		3599		587386			https://u.jd.com/C7AwtA		5g手机，重量205g，4200mAh，65w有线快充，高通865顶级cpu，三星E3 superAMOLED 90hz刷新率屏幕，Z轴线性马达
			nubia 红魔5G		2020年3月12日		3799		575016			https://u.jd.com/e0FegR		5g手机，重量218g，4500mAh，55w有线快充，高通865顶级cpu，144HzAMOLED屏幕，风冷散热，z轴线性马达
			vivo NEX 3S		2020年3月10日		4998  		586515			https://u.jd.com/3rIajZ		5g手机，重量219g，4500mAh，44w有线快充，高通865顶级cpu，无界瀑布屏，旗舰系列，X轴线性马达,
			OPPO Find X2		2020年3月6日		5499		602191			https://u.jd.com/aem7Iv		5g手机，重量209g，4200mAh，65w有线快充，高通865顶级cpu，AMOLED120hz QHD+屏幕，nfc，z轴线性马达
			OPPO Find X2 Pro	2020年3月6日		6999		607147			https://u.jd.com/mWLXNM		5g手机，重量200g，4260mAh，65w有线快充，高通865顶级cpu，AMOLED120hz QHD+屏幕，nfc，X轴线性马达
			腾讯黑鲨游戏手机3	2020年3月3日		3499		570680			https://u.jd.com/s2aemc		5g手机，重量222g，4720mAh，65w有线快充，高通865顶级cpu，三星AMOLED 90hz屏幕，z轴线性马达
			腾讯黑鲨游戏手机3 Pro	2020年3月3日		4699		586062			https://u.jd.com/nbkqbu		5g手机，重量253g，5000mAh，65w有线快充，高通865顶级cpu，三星AMOLED QHD+ 90hz屏幕，x轴线性马达
			华为畅享10e		2020年3月1日		999		87624			https://u.jd.com/abDjsK		4g手机，重量185g，5000mAh，10w有线快充，mtk p35低端cpu，不建议买
			--2020年2月
			vivo Z6			2020年2月29日		2298 		323684			https://u.jd.com/QEJLe9		5g手机，重量201g，5000mAh，44w有线快充，高通765g中端cpu，lcd单挖孔屏幕
			三星S20			2020年2月27日 		6999   		556393			https://u.jd.com/Umj06e		5g手机，重量163g，4000mAh，25W有线快充，高通865顶级cpu，年度旗舰配置，闭眼买
			三星S20+		2020年2月27日 		7999   		556393			https://u.jd.com/ruSVBq		5g手机，重量186g，4500mAh，25W有线快充，高通865顶级cpu，年度旗舰配置，闭眼买
			三星S20Ultra		2020年2月27日		9999		569661			https://u.jd.com/58Q0lE		5g手机，重量220g，5000mAh，25W有线快充，高通865顶级cpu，年度旗舰配置，闭眼买
			iQOO3			2020年2月25日		3598		588990			https://u.jd.com/EXuPg3		5g手机，重量214g，4440mAh，55w有线快充，高通865顶级cpu，x轴线性马达
			小米10			2020年2月13日		3999		581958			https://u.jd.com/xstBn3		5g手机，重量208g，4780mAh，30w有线快充，30w无线快充，10w反向无线快充，高通865顶级cpu，90hz AMOLED屏幕，双扬声器，x轴线性马达，nfc
			小米10pro		2020年2月13日		4999		599859			https://u.jd.com/2UsDYB		5g手机，重量208g，4500mAh，50w有线快充，30w无线快充，10w反向无线快充，高通865顶级cpu，更好的90hz AMOLED屏幕，更好的双扬声器，拍照更好，x轴线性马达，nfc
			OPPO Reno3元气版	2020年2月10日		2999		319569			https://u.jd.com/bpmqxN		5g手机，重量180g，4025mAh，30W有线快充，高通765G中端cpu，nfc
			--2020年1月
			realme X50（5G）	2020年1月7日		2499		330747			https://u.jd.com/airWHM		5g手机，重量202g，4100mAh，30w有线快充，高通765g中端cpu，lcd双挖孔屏，nfc
			--2019年12月
			oppo Reno3		2020年12月26日		3399		405159			https://u.jd.com/DVMs23		5g手机，重量181g，4025mAh，30W有线快充，天玑1000L中高端cpu，nfc
			oppo Reno3 Pro		2020年12月26日		3999		319937			https://u.jd.com/U6l8hl		5g手机，重量171g，4025mAh，30W有线快充，高通765G中端cpu，90Hz曲面屏，nfc
			vivo X30		2019年12月16日		3298		327092			https://u.jd.com/PgTVgL		5g手机，重量198g，4350mAh，33W有线快充，三星Exynos980中端cpu，
			vivo X30 Pro		2019年12月16日		3998		327092			https://u.jd.com/sJMr2o		5g手机，重量198g，4350mAh，33W有线快充，三星Exynos980中端cpu，5倍潜望式长焦镜头
			Redmi K30（5g）		2019年12月10日		1999		329704			https://u.jd.com/lpKFLp		5g手机，重量208g，4350mAh，30W有线快充，高通765g中端cpu，Lcd 120hz刷新率屏幕，nfc
			Redmi K30（4g）		2019年12月10日		1599		278852			https://u.jd.com/Hz8hRt		4g手机，重量208g，4500mAh，27w有线快充，高通730g中低端cpu，Lcd 120hz刷新率屏幕，nfc
			nova6 5G		2019年12月5日		3799		455280			https://u.jd.com/nSg6Zn	        5g手机，重量212g，4200mAh，40w有线快充，麒麟990顶级cpu，nfc
			nova6			2019年12月5日		3199		445630			https://u.jd.com/B2sFT3		4g手机，重量197g，4200mAh，40w有线快充，麒麟990顶级cpu，nfc
			nova6 SE		2019年12月5日		2199		321126			https://u.jd.com/1FpD6F		4g手机，重量183g，4200mAh，40w有线快充，麒麟810中端cpu，
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