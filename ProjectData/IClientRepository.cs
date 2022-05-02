using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectData.Models;

namespace ProjectData
{
    public interface IClientRepository
    {
        List<ComponentDisplay> GetComponents(string componentName);

        ComponentDisplay InsertComponent(List<string> data);
    }
}
