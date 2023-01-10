using Microsoft.AspNetCore.Mvc;
using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportViewerSSRS.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index() =>  View();

        public IActionResult GetReport()  =>  StiNetCoreViewer.GetReportResult(this, new StiReport());  
        public IActionResult ViewerEvent() => StiNetCoreViewer.ViewerEventResult(this);
    }
}
