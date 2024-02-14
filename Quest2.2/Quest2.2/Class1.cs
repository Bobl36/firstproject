using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest2._2
{
    internal class Class1
    {
        string _sceneName = "";

        public string SceneName { 
            get { return _sceneName; } 
            set { _sceneName = value; }
        }

        public bool Show()
        {
            Console.WriteLine(_sceneName);
            return true;
        }
    }
}
