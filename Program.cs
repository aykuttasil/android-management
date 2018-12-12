using System;
using Google.Apis.AndroidManagement.v1;

namespace android_management
{
    class Program
    {
        static void Main(string[] args)
        {
            var initializer = new AndroidManagementService.Initializer();
            initializer.ApiKey = "";
            initializer.ApplicationName = "";        

            var androidManagementService = new AndroidManagementService(initializer);


            Console.WriteLine("Hello World!");
        }
    }
}
