﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Properties
    {
        private string _field = null;
        private string Field 
        {
            get 
            {
                return _field; 
            } 

            set
            {
                _field = value; 
            }
        }

        private string AutoField { get; set; }
    }
}
