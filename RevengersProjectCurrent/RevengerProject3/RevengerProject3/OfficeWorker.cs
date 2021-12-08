using System;
using System.Collections.Generic;
using System.Text;

namespace RevengerProject3
{
    class OfficeWorker
    {
        protected string _OfficeWorkerTitle;
        protected int _OfficeWorkerAmount;

        public string officeWorkerTitle { get; set; }
        public string officeWorkerAmount { get; set; }
        public OfficeWorker(string officeWTitle, int officeWAmount)
        {
            _OfficeWorkerAmount = officeWAmount;
            _OfficeWorkerTitle = officeWTitle;

        }
    }

}
