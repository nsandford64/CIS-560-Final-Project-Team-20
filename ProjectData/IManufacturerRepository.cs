﻿using ProjectData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData
{
    public interface IManufacturerRepository
    {
        Manufacturer InsertManufacturer(List<string> data);
    }
}
