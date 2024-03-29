﻿using DataAccess;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectData.Models;

namespace ProjectData.DataDelegates
{
    public class InsertComponentDataDelegate : DataDelegate
    {
        private readonly string name;
        private readonly string modelNo;
        private readonly string manufacturer;
        private readonly string category;
        private readonly decimal MSRP;

        public InsertComponentDataDelegate(string name, string modelNo, string manufacturer, string category, decimal MSRP)
            : base("PartFinder.InsertComponent")
        {
            this.name = name;
            this.modelNo = modelNo;
            this.manufacturer = manufacturer;
            this.category = category;
            this.MSRP = MSRP;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Name", name);
            command.Parameters.AddWithValue("ModelNumber", modelNo);
            command.Parameters.AddWithValue("Manufacturer", manufacturer);
            command.Parameters.AddWithValue("ComponentCategory", category.ToString());
            command.Parameters.AddWithValue("MSRP", MSRP);
        }
    }
}


