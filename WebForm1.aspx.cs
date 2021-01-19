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
  --2021年1月
			三星S21			2021年1月18日		4999		700000			https://u.jd.com/tbLh5xg	169	5g	4000	25		高通骁龙888顶级处理器，120hzAmoled屏幕，15w无线充电
			三星S21+		2021年1月18日		7199		700000			https://u.jd.com/tVLxKX2	200	5g	4800	25		高通骁龙888顶级处理器，120hzAmoled屏幕，15w无线充电
			三星S21 Ultra		2021年1月18日		9699		700000			https://u.jd.com/tZL7egJ	227	5g	5100	25		高通骁龙888顶级处理器，120hzAmoled屏幕，15w无线充电，S Pen
			iqoo7			2021年1月11日		3798		752939			https://u.jd.com/tgTVtCt	209	5g	4000	120		高通骁龙888顶级处理器，120hzAmoled屏幕，120w快充
			realmeV15		2021年1月7日		1399		341298			https://u.jd.com/t6Rf8sP	176	5g	4310	50		联发科天玑800U中端处理器，国潮色
			--2020年12月														
			vivo X60		2020年12月29日		3498		693600			https://u.jd.com/tKQxePF	175	5g	4300	33		三星Exynos 1080，120hz三星AMOLED直屏，
			vivo X60 Pro		2020年12月29日		4498		693600			https://u.jd.com/taqtyfo	178	5g	4200	33		三星Exynos 1080，120Hz三星AMOLED曲面屏
			小米11			2020年12月28日		3999		708425			https://u.jd.com/t1QxTXv	196	5g	4600	55		高通骁龙888顶级cpu，2k 120hz Amoled屏幕，50w无线快充，10w反向充电，x轴线性马达，nfc，红外
			oppo Reno5 pro+		2020年12月24日		3999		685976			https://u.jd.com/tFQRPwI	184	5g	4500	65		高通骁龙865顶级cpu，90Hz屏幕
			华为 nova8		2020年12月23日		3299		413621			https://u.jd.com/t4T9tF7	169	5g	3800	66		麒麟985中高端cpu，90Hz OLED
			华为 nova8 Pro		2020年12月23日		3999		413621			https://u.jd.com/tsTXtQz	184	5g	4000	66		麒麟985中高端cpu，120Hz OLED
			oppo Reno5 		2020年12月10日		2699		350000			https://u.jd.com/tFQm6LY	172	5g	4300	65		高通骁龙765G中端cpu，90Hz屏幕
			oppo Reno5 pro		2020年12月10日		3399		516000			https://u.jd.com/trQkM88	173	5g	4350	65		高通天玑1000+高端cpu，90Hz屏幕，z轴线性马达
			--2020年11月
			红米note9 4G		2020年11月16日		999		190000			https://u.jd.com/toQHMke	198	5g	6000	18		高通骁龙662低端cpu，大电池，长续航
			红米note9 5G		2020年11月16日		1299		345370			https://u.jd.com/taQFUFc	199	5g	5000	18		联发科天玑800U中端cpu，线性马达
			红米note9 Pro		2020年11月16日 		1599		351232			https://u.jd.com/tcQX67a	190	5g	4820	33		高通骁龙750G中端cpu，120hz LCD屏幕，线性马达，nfc
			华为 nova8 se		2020年11月5日		2699		300000			https://u.jd.com/tkQXZDT	178	5g	3800	66		联发科天玑720中低端cpu/高配天机800U中端cpu，oled屏幕
			vivo s7e		2020年11月4日		2398		300484			https://u.jd.com/tGWUz9z	171	5g	4100	33		联发科天玑720中低端cpu
			OPPO K7x		2020年11月4日		1399		263759			https://u.jd.com/tIWlNAE	194	5g	5000	30		联发科天玑720中低端cpu，90hz屏幕
			--2020年10月
			华为Mate40		2020年10月30日		4999		693605			https://u.jd.com/ty7KJyK	188	5g	4200	40		麒麟9000E顶级cpu
			华为Mate40 Pro		2020年10月30日		6499		685339			https://u.jd.com/thWYwb2	212	5g	4400	66		麒麟9000顶级cpu，50w无线充电
			华为Mate40 Pro Plus	2020年10月30日		8999 		685339			https://u.jd.com/tNW6cfB	230	5g	4400	66		麒麟9000顶级cpu，50w无线充电
			华为Mate40 RS 保时捷	2020年10月30日		11999		685339			https://u.jd.com/tHToJbg	234	5g	4400	66		麒麟9000顶级cpu，50w无线充电 
			Redmi K30s 至尊纪念版	2020年10月27日		2299		673723			https://u.jd.com/tjWQyot	216	5g	5000	30		高通骁龙865顶级cpu，144hzLCD屏幕，nfc，红外
			坚果R2			2020年10月21日		4499		593531			https://u.jd.com/tCWB988	216	5g	4510	55		高通骁龙865顶级cpu，90hz曲面屏
			一加8T			2020年10月15日		3399		591688			https://u.jd.com/toWwUoN	188	5g	4500	65		高通骁龙865顶级cpu，120hz OLED屏幕，nfc
			iphone12 mini		2020年10月14日		5499		573719			https://u.jd.com/tjWGzxx	133	5g	2227	20		A14顶级cpu，5.4寸屏幕
			iphone12		2020年10月14日		6299		573719			https://u.jd.com/tfTxLX5	162	5g	2775	20		A14顶级cpu，最推荐购买的一款
			iphone12 pro		2020年10月14日		8499		574155			https://u.jd.com/tJT9STy	187	5g	2815	20		A14顶级cpu，拍照更好
			iphone12 pro Max	2020年10月14日		9299		574155			https://u.jd.com/tAWLMHY	226	5g	3687	20		A14顶级cpu，拍照续航更好
			realme Q2i		2020年10月14日		998		300484			https://u.jd.com/tPW1hLl	190	5g	5000	18		联发科天玑720中低端cpu，长续航
			realme Q2		2020年10月14日		1299		330567			https://u.jd.com/trWbOek	194	5g	5000	30		联发科天玑800u中端cpu，90hz高刷新率屏幕
			realme Q2 Pro		2020年10月14日		1799		340030			https://u.jd.com/tMWYtRc	175	5g	4300	65		联发科天玑800u中端cpu，65w快充
			--2020年9月 
			oppo reno4se		2020年9月21日		2499		280000			https://u.jd.com/tuWWvXc	169	5g	4300	65		联发科天玑720中低端cpu
			华为畅享 20		2020年9月2日		1649		280000			https://u.jd.com/tiTo1yZ	188	5g	5000	10		联发科天玑720中低端cpu
			华为畅享 20 Plus	2020年9月3日		2249		280000			https://u.jd.com/tRTkIOu	197	5g	4200	40		联发科天玑720中低端cpu
			Realme X7		2020年9月1日		1799		340000			https://u.jd.com/NFGa6B		175	5g	4300	65		联发科天玑800U中端cpu
			Realme X7 Pro		2020年9月1日		2199		535879			https://u.jd.com/9iofBW		184	5g	4500	65		联发科天玑1000+高端cpu，120hz E3Amoled屏幕，z轴线性马达，双扬声器，有nfc 
			Realme V3		2020年9月1日		999		300000			https://u.jd.com/i7gyUc		190	5g	5000	18		联发科天玑720中低端cpu
			中兴AXON 20		2020年9月1日		2198		329325			https://u.jd.com/TyxQai		198	5g	4220	30		高通765g中端cpu，首发量产屏下摄像头
			--2020年8月 
			iQOO 5			2020年8月17日		3998		631695			https://u.jd.com/ItexzA		197	5g	4500	55		高通865顶级cpu，120hz Super Amoled屏幕，z轴线性马达，有nfc
			iQOO 5 Pro		2020年8月17日		4998		677256			https://u.jd.com/gxnGuF		198	5g	3890	120		高通865顶级cpu，120hz Super Amoled曲面屏幕，潜望式长焦镜头，x轴线性马达，有nfc
			三星Note20		2020年8月13日		7399		613800			https://u.jd.com/DNg8XQ		192	5g	4300	25		高通865顶级cpu，60hz顶级屏幕
			三星Note20+		2020年8月13日		7399		613800			https://u.jd.com/DNg8XQ		192	5g	4300	25		高通865顶级cpu，60hz顶级屏幕
			三星Note20 Ultra	2020年8月13日		9199		607206			https://u.jd.com/QU9KMU		208	5g	4500	25		高通865顶级cpu，120hz刷新率顶级屏幕
			Redmi K30 至尊纪念版	2020年8月12日		1999		507154			https://u.jd.com/MzrbrJ		213	5g	4500	30		联发科天玑1000+高端cpu，120hz三星E3 Amoled屏幕，线性马达，有nfc
			小米10 至尊纪念版	2020年8月12日		5299		631313			https://u.jd.com/UYNQDN		221	5g	4500	120		高通865顶级cpu，120倍长焦相机，120hz刷新率屏幕，120w有线充电，50w无线闪充，有nfc
			OPPO K7			2020年8月4日		1999		336098			https://u.jd.com/TDVGI3		180	5g	4249	30		高通765G中端cpu，有nfc
			vivo S7			2020年8月3日		2798		320000			https://u.jd.com/mSr7CQ		170	5g	4000	30		高通765G中端cpu，7.39mm超薄，前置4400万相机，有nfc
			Realme V5		2020年8月3日		1399		290972			https://u.jd.com/WjBHS0		194	5g	5000	30		联发科天玑720中端cpu，90hz刷新率lcd屏幕
			--2020年7月
			黑鲨3S			2020年7月31日		3999		634453			https://u.jd.com/zxtxzL		222	5g	4720	65		高通865顶级cpu，90hz Amoled屏幕
			红魔5S			2020年7月29日		3799		607927			https://u.jd.com/RNH8DN		218	5g	4500	55		高通865顶级cpu，144hz Amoled屏幕
			Redmi 9A		2020年7月28日		599		100000			https://u.jd.com/NpbGzJ		194	4g	5000	10		联发科g25低端处理器
			华为麦芒9		2020年7月27日		2199		300000			https://u.jd.com/Y2sctD		212	5g	4300	22.5		联发科天玑800中端cpu
			OPPO A72		2020年7月25日		1899		281876			https://u.jd.com/bnbvRO		175	5g	4040	18		联发科天玑720中端cpu，90hz LCD屏幕
			ROG3			2020年7月23日		3999		643676			https://u.jd.com/9qEiS4		240	5g	6000	30		高通865+顶级cpu，144hz Amoled屏幕
			拯救者电竞手机Pro	2020年7月22日		3499		634453			https://u.jd.com/oYhWlm		239	5g	5000	45 		高通865+顶级cpu，144hz Amoled屏幕，双x轴线性马达
			IQOO U1			2020年7月16日		1198		282127			https://u.jd.com/MgbMVh		190	5g	4500	18		联发科天玑720中端cpu，Micro USB充电口
			iQOOZ1x			2020年7月9日		1598		333363			https://u.jd.com/27Fl8F		199	5g	5000	33		高通765G中端cpu,120Hz刷新率lcd
			荣耀30青春版		2020年7月3日		1699		278360			https://u.jd.com/qKytDk		192	5g	4000	22.5		联发科天玑800中端cpu，90hz刷新率lcd
			荣耀X10 Max		2020年7月3日		1899		314879			https://u.jd.com/6ALJH7		227	5g	5000	22.5		联发科天玑800中端cpu，7.09英寸屏幕，双扬声器，nfc
			--2020年6月															
			Redmi 9			2020年6月24日		799		200000			https://u.jd.com/oZUdHt		198	4g	5020	18		联发科g80中低端cpu，入门机
			华为畅享 20 Pro		2020年6月19日		1999		309890			https://u.jd.com/YiGrrH		192	5g	4000	22.5		联发科天玑800中端cpu，90hz lcd屏幕
			oppo Reno4		2020年6月5日		2999		340000			https://u.jd.com/Kqk0bq		183	5g	4020	65		高通765G中端cpu，2.5D打孔曲面屏，有nfc，主打视频拍摄
			oppo Reno4 Pro		2020年6月5日		3799		340000			https://u.jd.com/IpO6rG		172	5g	4000	65		高通765G中端cpu，90Hz刷新率3D曲面屏，有nfc
			荣耀Play4		2020年6月3日		1799		315000			https://u.jd.com/GnmRC3		213	5g	4300	22.5		联发科天玑800中端cpu，Lcd单挖孔屏
			荣耀Play4Pro		2020年6月3日		2899		480000			https://u.jd.com/Srr9ef		213	5g	4200	40		麒麟990外挂5g顶级cpu，lcd双挖孔屏，无接触红外测温，有nfc
			vivoX50			2020年6月1日		3498		334135			https://u.jd.com/0X0ssv		174	5g	4200	33		高通765g中端cpu，90hz超薄柔性屏，有nfc
			vivoX50 Pro		2020年6月1日		4298		334135			https://u.jd.com/gTdHid		181	5g	4315	33		高通765g中端cpu，90hz轻薄曲面屏，主打微云台超感光主摄，nfc
			vivoX50 Pro+		2020年6月1日		4998		600219			https://u.jd.com/J8nNQq		174	5g	4350	44		高通865顶级cpu，120hz曲面屏，nfc
			Axon11 SE		2020年6月1号		1998		334352			https://u.jd.com/c3mDNp		184	5g	4000	18		联发科天玑800中端cpu
			--2020年5月														          	    	
			vivoY70s		2020年5月26日		1998		288005			https://u.jd.com/JLQG6D		190	5g	4500	18		三星Exynos880中端cpu，Lcd打孔屏
			Redmi 10X pro（5g版）	2020年5月26日		2299		410234			https://u.jd.com/2GgcIM		208	5g	4520	33		联发科天玑820中高端cpu，三星AMOLED屏幕，z轴线性马达，有nfc
			Redmi 10X（5g版）	2020年5月26日		1599		410209			https://u.jd.com/6XwLz2		205	5g	4520	22.5		联发科天玑820中高端cpu，三星AMOLED屏幕，z轴线性马达，建议至少买6+128版本
			Redmi 10X（4g版）	2020年5月26日		999		208493			https://u.jd.com/DJczHK		199	4g	5020	18		9w无线反向充电，联发科g85低端cpu，Lcd挖孔屏，适合父母用
			realme X50 Pro玩家版	2020年5月25日		2699		594706			https://u.jd.com/OPBhLZ		209	5g	4200	65		高通865顶级cpu，90hz三星Super AMOLED屏幕，z轴线性马达
			Redmi K30i		2020年5月25日		1799		329704			https://u.jd.com/cctPNe		208	5g	4350	30		高通765g中端cpu，Lcd 120hz刷新率屏幕，nfc
			华为畅享z		2020年5月24日		1699		316328			https://u.jd.com/g4J6jW		182	5g	4000	22.5		联发科天玑800中端cpu，90hzLCD屏幕
			荣耀x10			2020年5月20日		1899		373377			https://u.jd.com/XgwBrZ		203	5g	4300	22.5		麒麟820中高端cpu，Lcd 90hz屏幕，升降摄像头，建议至少买6+128版本
			iqooz1			2020年5月19日		2198		526401			https://u.jd.com/IoU84V		194	5g	4500	44		联发科天玑1000+高端cpu，Lcd 144hz屏幕，vivo子品牌，性价比高
			Redmi K30极速版		2020年5月11日		1999		349194			https://u.jd.com/8qiWS9		208	5g	4500	30		高通768g中高端cpu，Lcd 120hz刷新率屏幕，nfc 
			魅族17			2020年5月8日		3699		577763			https://u.jd.com/VpVUat		199	5g	4500	30		高通865顶级cpu，顶级配置，x轴线性马达，nfc
			魅族17 Pro		2020年5月8日 		4299		590826			https://u.jd.com/uOarQZ		219	5g	4500	30		27w无线快充，高通865高端cpu，顶级配置，x轴线性马达，nfc
			--2020年4月														          	    	  	
			小米10青春版		2020年4月27日		2099		324162			https://u.jd.com/fLbYHh		192	5g	4160	20		高通765g中端cpu，50倍潜望长焦镜头，nfc
			vivo Y50		2020年4月25日		1698		192319			https://u.jd.com/lxNdIv		197	4g	5000	18		高通665低端cpu，性能比较低，但有5000mAh大电池，续航好，8+128，存储容量够用，适合老人用
			iQOO Neo3		2020年4月23日		2698		600893			https://u.jd.com/ZzrqtH		198	5g	4500	44		高通865顶级cpu,Lcd 144hz刷新率屏幕，性价比高
			华为Nova7SE		2020年4月23日		2799   		363923			https://u.jd.com/1VaAvl		189	5g	4000	40		麒麟820中端cpu，适合学生，女生
			华为nova7		2020年4月23日		3399   		404215			https://u.jd.com/CFmAyc		180	5g	4000	40		麒麟985中高端cpu，没有高刷新率屏幕，性能略微强于麒麟820，nfc，拍照好
			华为Nova7Pro		2020年4月23日		4099		401428			https://u.jd.com/NaHQJL		178	5g	4000	40		麒麟985中高端cpu，比nova7拍照更好，曲面屏，nfc
			OPPO A92s		2020年4月21日		2199		295798 			https://u.jd.com/alAs9v		184	5g	4000	18		联发科天玑800中端cpu，Lcd 120hz屏幕，
			努比亚Play5G		2020年4月21日		2399  		330459			https://u.jd.com/w6bkne		210	5g	5100	30		高通765g中端处理器，144hz刷新率AMOLED屏幕，只是近几年这个品牌没有好好经营，没落了
			iPhoneSE2		2020年4月18日		3299  		468486			https://u.jd.com/L4O8ev		148	4g	1821	5		外观与iPhone8几乎一样，cpu是最新的a13，性能好，但续航极差，不建议买
			一加8			2020年4月17日		3999  		580460			https://u.jd.com/PyU04P		180	5g	4300	30		高通865高端cpu，一加正统数字系列年度旗舰，配置是目前顶级，系统十分流畅，但有人说系统不如小米和华为完善
			一加8pro		2020年4月17日		5399		576835			https://u.jd.com/3PCFub		199	5g	4510	30		30w无线快充，3w无线反向充电，高通865高端cpu，一加正统数字系列年度旗舰，目前最顶级的屏幕，看重影音的推荐购买
			荣耀30			2020年4月15日		2999 		386045			https://u.jd.com/dFFa3Z		185	5g	4000	40		麒麟985中高端cpu，nfc，拍照好。本来是正统数字系列年度升级，但似乎当了陪衬，厂家重点放在了pro和pro+
			荣耀30pro		2020年4月15日		3999		480614			https://u.jd.com/mQoi1B		186	5g	4000	40		麒麟990顶级cpu，无高刷新率屏幕唯一遗憾，50倍远摄，z轴线性马达，nfc
			荣耀30pro+		2020年4月15日		4999		521832			https://u.jd.com/zsXeld		186	5g	4000	40		27w无线快充，麒麟990顶级cpu，曲面屏幕，90hz刷新率，50倍远摄，z轴线性马达，nfc
			OPPO Ace2		2020年4月13日		3999		594678			https://u.jd.com/mLFfEk		185	5g	4000	65		40w无线快充，高通865顶级cpu，90hz直屏，线性马达，nfc
			荣耀Play4T		2020年4月9日		1199  		150000			https://u.jd.com/d7PHsy	        176	4g	4000	10		麒麟710A低端cpu，唯一卖点就是国产cpu
			荣耀Play4T Pro		2020年4月9日		1499  		303057			https://u.jd.com/0y5UbM		165	4g	4000	22.5		麒麟810中端cpu，OLED屏幕，屏幕指纹识别
			华为p40			2020年4月8日		4188  		455633			https://u.jd.com/skUgwm		175	5g	3800	22.5		麒麟990顶级cpu，Z轴线性马达，nfc
			华为p40pro		2020年4月8日		5988   		468764			https://u.jd.com/PyJ1yX		209	5g	4200	40		20w无线快充，无线反向充电，麒麟990顶级cpu，90hz刷新率，Z轴线性马达，nfc
			华为p40pro+		2020年4月8日		7988		468764			https://u.jd.com/Fe2IXk		226	5g	4200	40		40w无线快充，无线反向充电，麒麟990顶级cpu，90hz刷新率，Z轴线性马达，nfc
			--2020年3月														          	    	
			vivo S6			2020年3月31日		2698		330696			https://u.jd.com/HyKJTJ		181	5g	4500	18		三星Exynos980中端cpu，三星AMOLED屏幕
			荣耀30S			2020年3月30日		2399		364077			https://u.jd.com/6CIiPl		190	5g	4000	40		麒麟820中高端cpu，lcd屏幕，比较推荐的一款机型
			Redmi k30pro		2020年3月24日		2999 		595555			https://u.jd.com/oE4VDK		218	5g	4700	33		高通865顶级cpu，三星E3 AMOLED屏幕60hz刷新率，z轴线性马达，nfc
			Redmi k30pro 变焦版	2020年3月24日		3799		595555			https://u.jd.com/oE4VDK		218	5g	4700	33		高通865顶级cpu，三星E3 AMOLED屏幕60hz刷新率，z轴线性马达，nfc，dxomark上榜
			中兴AXON 11		2020年3月23日		2698		330638			https://u.jd.com/7CRtca		168	5g	4000	18		高通765g中端cpu，AMOLED屏幕，nfc
			realme X50 Pro		2020年3月12日		3599		587386			https://u.jd.com/C7AwtA		205	5g	4200	65		高通865顶级cpu，三星E3 superAMOLED 90hz刷新率屏幕，Z轴线性马达
			nubia 红魔5G		2020年3月12日		3799		575016			https://u.jd.com/e0FegR		218	5g	4500	55		高通865顶级cpu，144HzAMOLED屏幕，风冷散热，z轴线性马达
			vivo NEX 3S		2020年3月10日		4998  		586515			https://u.jd.com/3rIajZ		219	5g	4500	44		高通865顶级cpu，无界瀑布屏，旗舰系列，X轴线性马达,
			OPPO Find X2		2020年3月6日		5499		602191			https://u.jd.com/aem7Iv		209	5g	4200	65		高通865顶级cpu，AMOLED120hz QHD+屏幕，nfc，z轴线性马达
			OPPO Find X2 Pro	2020年3月6日		6999		607147			https://u.jd.com/mWLXNM		200	5g	4260	65		高通865顶级cpu，AMOLED120hz QHD+屏幕，nfc，X轴线性马达
			腾讯黑鲨游戏手机3	2020年3月3日		3499		570680			https://u.jd.com/s2aemc		222	5g	4720	65		高通865顶级cpu，三星AMOLED 90hz屏幕，z轴线性马达
			腾讯黑鲨游戏手机3 Pro	2020年3月3日		4699		586062			https://u.jd.com/nbkqbu		253	5g	5000	65		高通865顶级cpu，三星AMOLED QHD+ 90hz屏幕，x轴线性马达
			华为畅享10e		2020年3月1日		999		87624			https://u.jd.com/abDjsK		185	4g	5000	10		联发科p35垃圾cpu，不建议买
			--2020年2月														          	    	  		
			vivo Z6			2020年2月29日		2298 		323684			https://u.jd.com/QEJLe9		201	5g	5000	44		高通765g中端cpu，lcd单挖孔屏幕
			三星S20			2020年2月27日 		6999   		556393			https://u.jd.com/Umj06e		163	5g	4000	25		高通865顶级cpu，年度旗舰配置，闭眼买
			三星S20+		2020年2月27日 		7999   		556393			https://u.jd.com/ruSVBq		186	5g	4500	25		高通865顶级cpu，年度旗舰配置，闭眼买
			三星S20Ultra		2020年2月27日		9999		569661			https://u.jd.com/58Q0lE		220	5g	5000	25		高通865顶级cpu，年度旗舰配置，闭眼买
			iQOO3			2020年2月25日		3598		588990			https://u.jd.com/EXuPg3		214	5g	4440	55		高通865顶级cpu，x轴线性马达
			小米10			2020年2月13日		3999		581958			https://u.jd.com/xstBn3		208	5g	4780	30		30w无线快充，10w反向无线快充，高通865顶级cpu，90hz AMOLED屏幕，双扬声器，x轴线性马达，nfc
			小米10pro		2020年2月13日		4999		599859			https://u.jd.com/2UsDYB		208	5g	4500	50		30w无线快充，10w反向无线快充，高通865顶级cpu，更好的90hz AMOLED屏幕，更好的双扬声器，拍照更好，x轴线性马达，nfc
			OPPO Reno3元气版	2020年2月10日		2999		319569			https://u.jd.com/bpmqxN		180	5g	4025	30		高通765G中端cpu，nfc
			--2020年1月														          	    	  		
			realme X50（5G）	2020年1月7日		2499		330747			https://u.jd.com/airWHM		202	5g	4100	30		高通765g中端cpu，lcd双挖孔屏，nfc
			--2019年12月														          	    	  		
			oppo Reno3		2020年12月26日		3399		405159			https://u.jd.com/DVMs23		181	5g	4025	30		联发科天玑1000L中高端cpu，nfc
			oppo Reno3 Pro		2020年12月26日		3999		319937			https://u.jd.com/U6l8hl		171	5g	4025	30		高通765G中端cpu，90Hz曲面屏，nfc
			vivo X30		2019年12月16日		3298		327092			https://u.jd.com/PgTVgL		198	5g	4350	33		三星Exynos980中端cpu，
			vivo X30 Pro		2019年12月16日		3998		327092			https://u.jd.com/sJMr2o		198	5g	4350	33		三星Exynos980中端cpu，5倍潜望式长焦镜头
			Redmi K30（5g）		2019年12月10日		1999		329704			https://u.jd.com/lpKFLp		208	5g	4350	30		高通765g中端cpu，Lcd 120hz刷新率屏幕，nfc
			Redmi K30（4g）		2019年12月10日		1599		278852			https://u.jd.com/Hz8hRt		208	4g	4500	27		高通730g中低端cpu，Lcd 120hz刷新率屏幕，nfc
			nova6（5g）		2019年12月5日		3799		455280			https://u.jd.com/nSg6Zn	        212	5g	4200	40		麒麟990外挂5g顶级cpu，nfc
			nova6（4g）		2019年12月5日		3199		445630			https://u.jd.com/B2sFT3		197	4g	4200	40		麒麟990顶级cpu，nfc
			nova6 SE		2019年12月5日		2199		321126			https://u.jd.com/1FpD6F		183	4g	4200	40		麒麟810中端cpu
			--2019年11														          	    	  		
			荣耀V30 		2019年11月26日		3299		454642			https://u.jd.com/WCYcL4		213	5g	4200	40		麒麟990外挂5g顶级cpu，LCD双挖孔屏，有nfc
			荣耀V30 PRO 		2019年11月26日		3899		488940			https://u.jd.com/w384Yi		206	5g	4100	40		27W无线充电，7.5W反向充电，麒麟990顶级cpu，LCD双挖孔屏，主打拍照旗舰，有nfc，降价可买，dxomark上榜
			--2019年10														          	    	  		
			oppo Reno Ace		2019年10月10日		2999		500802			https://u.jd.com/K8KOkQ		185	4g	4000	65		高通855plus顶级cpu，三星Amoled90Hz屏幕，有nfc，如果暂时不需要5g，降价可买
			--2019年9
			Mate30（4g）		2019年9月26日  		3999		467630			https://u.jd.com/j9Iy1o		196	4g	4200	40		27w无线充电，7.5W反向充电，麒麟990 4g顶级cpu，OLED屏幕，莱卡相机，有nfc，ip53防水，线性马达
			Mate30（5g）		2019年9月26日		4999		485336			https://u.jd.com/T7LdbZ		196	5g	4200	40		27w无线充电，7.5W反向充电，麒麟990集成5g顶级cpu，OLED屏幕，莱卡相机，有nfc，ip53防水，线性马达
			Mate30 Pro（4g）	2019年9月26日		5799		470643			https://u.jd.com/b2m6h1		198	5g	4500	40		27w无线充电，7.5W反向充电，麒麟990 4g顶级cpu，OLED环幕屏，有nfc，莱卡四摄，ip68防水，线性马达
			Mate30 Pro（5g）	2019年9月26日		6899		457357			https://u.jd.com/DrF4pm		198	5g	4500	40		27w无线充电，7.5W反向充电，麒麟990集成5g顶级cpu，OLED环幕屏，有nfc，莱卡四摄，ip68防水，线性马达
			--2019年8														          	    	  		
			Redmi Note8		2019年8月29日		899		175623			https://u.jd.com/h1ASv6		190	4g	4000	18		高通665低端cpu，1000内可选
			Redmi Note8 pro		2019年8月29日		1399		289559			https://u.jd.com/oZUdHt		199	4g	4500	18		联发科g90t中低端cpu，有nfc，水桶机，建议选购8+128版本，目前售价在1500内

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
                        name = mobiles[0].Trim(),
                        time = mobiles.Length > 1 ? mobiles[1].Trim() : string.Empty,
                        price = mobiles.Length > 2 ? mobiles[2].Trim() : string.Empty,
                        score = mobiles.Length > 3 ? mobiles[3].Trim() : string.Empty,
                        href = mobiles.Length > 4 ? mobiles[4].Trim() : string.Empty,
                        weight = mobiles.Length > 5 ? mobiles[5].Trim() : string.Empty,
                        generation = mobiles.Length > 6 ? mobiles[6].Trim() : string.Empty,
                        battery = mobiles.Length > 7 ? mobiles[7].Trim() : string.Empty,
                        charge = mobiles.Length > 8 ? mobiles[8].Trim() : string.Empty,
                        content = mobiles.Length > 9 ? mobiles[9].Trim() : string.Empty
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
        public string weight { get; set; }
        public string generation { get; set; }
        public string battery { get; set; }
        public string charge { get; set; }
        public string content { get; set; }
    }
}