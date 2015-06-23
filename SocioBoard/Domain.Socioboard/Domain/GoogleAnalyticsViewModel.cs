﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Socioboard.Domain
{
   public class GoogleAnalyticsViewModel
    {
       public string TotalPageViews { get; set; }
       public string TotalSessions { get; set; }
       public string RealTimePageViews { get; set; }
       public List<AnalyticsGraphViewModel> PageViewsGraphData { get; set; }
       public List<GoogleAnalyticsCityPageViews> citypageviews { get; set; }
    }
}
