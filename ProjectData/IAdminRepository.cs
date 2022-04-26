using ProjectData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData
{
    public interface IAdminRepository
    {
        Component InsertComponent(List<string> data);

        Manufacturer InsertManufacturer(List<string> data);

        Storefront InsertStorefront(List<string> data);
    }
}
