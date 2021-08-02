using EducationCms.Data.Data;
using EducationCms.Data.Model.Pages;
using EducationCms.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCms.Service.Services
{
    public class QAService : BaseService<QuestionAnswer>,IQA
    {
        public QAService(AppDBContext context) : base(context) { }


       
    }
}
