﻿using EducationCms.Data.Data;
using EducationCms.Data.Model.Pages;
using EducationCms.Service.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCms.Service.Services
{
    public class ConsumerService : BaseService<Consumer>, IConsumer
    {
        public ConsumerService(AppDBContext context) : base(context) { }

      

      

        
    }
}