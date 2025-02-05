﻿using System.Web.Http;
//
using Ray.EssayNotes.AutoFac.Service.IService;


namespace Ray.EssayNotes.AutoFac.NetFrameworkApi.Controllers
{
    public class StudentController : ApiController
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        /// <summary>
        /// 获取学生姓名
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Student/GetStuNameById")]
        public string GetStuNameById(long id)
        {
            return _studentService.GetStuName(123);
        }
    }
}