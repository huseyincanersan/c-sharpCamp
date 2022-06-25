using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesDemo2
{
    class ProjectManager
    {
        public void Add(IPersonManager person)
        {
            person.Add();
        }
    }
}
