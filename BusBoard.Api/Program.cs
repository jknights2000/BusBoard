﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BusBoard.Api
{
  class Program
  {
        
    static void Main(string[] args)
    {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            PostCodeHandler p = new PostCodeHandler();
            
            Dictionary<string,double> location =  p.GetLatLong(UserInput.GetInput("postcode pls: "));
            TfLHandler handler = new TfLHandler();
            handler.getStopsWithinRadius(location);

    }
    public static void fiveBus(string code)
    {
            
            //https://api.tfl.gov.uk/StopPoint/490008660N/Arrivals
            
            List<string> stops = new List<string>();  //get input from api
            /*for(int i = 0;i < 5;i++)
            {
                string stop = stops[i];
                Console.WriteLine(stop);
            }
            */

            TfLHandler t = new TfLHandler();
            t.getArrivals(code);
            Console.ReadLine();
    }
  }
}
