﻿using _1_DAL.DomainMolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
	public interface IMauSacServices
	{
        bool Add(MauSac obj);
        bool Update(MauSac obj);
        bool Delete(MauSac obj);
        List<MauSac> GetAll();
        List<MauSac> GetAll(string input);
    }
}
