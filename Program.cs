using Microsoft.Extensions.DependencyInjection;
using StudyTogether.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyTogether
{
    static class Program
    {
        private static IServiceProvider _serviceProvider;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //using (var ctx = new StudyContext())
            //{
            //    var stud = new Student() { StudentName = "Bill" };

            //    ctx.Students.Add(stud);
            //    ctx.SaveChanges();
            //}
           // RunAsync().GetAwaiter().GetResult();


            RegisterServices();
            var service = _serviceProvider.GetService<ITestService>();
            //service.DoThing();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dashboard());
        }
        private static void RegisterServices()
        {
            var collection = new ServiceCollection();
            collection.AddTransient<StudyContext>();
            collection.AddScoped<ITestService, TestService>();
            _serviceProvider = collection.BuildServiceProvider();
        }
    }
}
