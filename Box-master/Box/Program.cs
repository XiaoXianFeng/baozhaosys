using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Box
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}





































/*
 * count-订单设备数--ShebeiNo-标签颜色.
 * 
 * platcode-平台代码--JiantaoNo-建滔code
 * 
 * abandoncount-废弃数量--CustomerNo-客户code
 * 
 * repaircount-维修数量--Test1No-备用选项1
 * 
 * failcount-失败数量--Test2No-备用选项2
*/
