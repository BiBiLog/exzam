using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Application
    {
        private Application application;
        private List<TaskList> taskList;

        

        public Application GetApplication()
        {
            if (application != null)
            {
                return application;
            }
            application = new Application();
            return application;
        }

        
        public TaskList GetTaskListName (string name)
        {
            return taskList.FirstOrDefault(t => t.GetName() == name);
        }
    }
}
