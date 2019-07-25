using Newtonsoft.Json;
using System;

namespace Cloudcherry
{
    //class to store the range of dates and pass it as json object
    internal class DateFilter
    {
        [JsonProperty("afterDate")]
        public DateTime AfterDate { get; set; }

        [JsonProperty("beforeDate")]
        public DateTime BeforeDate { get; set; }

        public DateFilter(DateTime afterDate, DateTime beforeDate)
        {
            AfterDate = afterDate;
            BeforeDate = beforeDate;
        }
    }
}