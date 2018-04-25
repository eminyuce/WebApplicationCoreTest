using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationCoreTest.Services;
using WebApplicationCoreTest.Models.HomeViewModels;

namespace WebApplicationCoreTest.Controllers
{
    public class TestController : BaseController
    {

        private readonly ITestService _testService;

        public TestController(ITestService testService)
        {
            _testService = testService;
        }

        // /test/index/233?y=223
        public IActionResult Index(int id, int y)
        {
            var p = new TestModel();
            p.Result = _testService.TestSum(id, y);
            return View(p);
        }
    }
}