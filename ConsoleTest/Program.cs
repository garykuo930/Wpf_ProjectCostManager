using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            global::PMEntityModel.ProjectManagementEntities dbContext = new PMEntityModel.ProjectManagementEntities();

            var q = dbContext.View_TaskAndResource;
            foreach(var p in q)
            {
                Console.WriteLine(p.TaskID + p.ResourceID + p.ResourceName);
            }
        }
    }
}
