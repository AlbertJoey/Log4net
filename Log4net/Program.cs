using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]  
namespace Log4net
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                //创建日志记录组件实例  
                //ILog log = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);  

                //ILog log=log4net.LogManager.GetLogger(typeof(Program));
                ILog log = log4net.LogManager.GetLogger("Daily.Logging");
                ILog log1 = log4net.LogManager.GetLogger("Login.Logging");
                ////记录错误日志  
                //log.Error("error", new Exception("在这里发生了一个异常,Error Number:"+random.Next()));  
                ////记录严重错误  
                //log.Fatal("fatal", new Exception("在发生了一个致命错误，Exception Id："+random.Next()));  
                ////记录一般信息  
                log4net.LogicalThreadContext.Properties["Id"] = Guid.NewGuid();
                log4net.LogicalThreadContext.Properties["api_Parameter"] = "xxoo";
                log4net.LogicalThreadContext.Properties["ReturnMessage"] = "xxoosdfljdslfjlsdjfldsjfljdsfljdslfj";
                log.Info("提示：系统正在运行");
                log1.Info("提示：系统正在运行");
                ////记录调试信息  
                //log.Debug("调试信息：debug");  
                ////记录警告信息  
                //log.Warn("警告：warn");  
            }
            //Console.WriteLine("日志记录完毕。");
            Console.Read();  
        }
    }
}
