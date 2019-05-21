using System;
using Microsoft.Extensions.DependencyInjection;

namespace Console2ASP.NETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var servicesProvider= 
                //新增 service connection
                new ServiceCollection()
                    //設定每次 request 都會建立 Runner(YowkoRunner)
                    .AddTransient<IRunner, Runner>()
                    //建立 service provider
                    .BuildServiceProvider();
            //從 service provider 中取得上面設定建立的 Runner(YowkoRunner) 服務
            var runner = servicesProvider.GetRequiredService<IRunner>();
            //透過取得的服務來執行某個動作
            runner.DoAction("Yowko");
            Console.ReadLine();
        }
    }
    public interface IRunner
    {
        void DoAction(string name);
    }
    public class Runner : IRunner
    {
        public void DoAction(string name)
        {
            Console.WriteLine($"Doing hard work! {name}");
        }
    }
    public class YowkoRunner : IRunner
    {
        public void DoAction(string name)
        {
            Console.WriteLine($"YowkoRunner : Doing hard work! {name}");
        }
    }
}