﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public  class Farmers
    {
        public int Id { get; set; }

        public int price { get; set; }
        public int EachKiloPrice { get; set; }
        public int weight { get; set; }
        public int autherprices { get; set; }

        //هزینه های سرد خانه 
        public int sardkhaneprice { get; set; }
        public string Name { get; set; }

        //sharh
        public string Sarh { get; set; }
    }
}