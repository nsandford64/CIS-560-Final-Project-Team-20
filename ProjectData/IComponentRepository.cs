using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectData.Models;

namespace ProjectData
{
    public interface IComponentRepository
    {
        List<Component> GetComponents(string componentName);

        Component InsertComponent(List<string> data);
    }
}
