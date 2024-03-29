﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSuperComputer
{
    class printer
    {
        private String brand;
        private String series;
        private int ppm;
        public printer(String brand, String series, int ppm){
            this.brand = brand;
            this.series = series;
            this.ppm = ppm;
        }

        public String getBrand(){
            return this.brand;
        }

        public String getSeries(){
            return this.series;
        }

        public int getppm(){
            return this.ppm;
        }

        public override string ToString()
        {
            return $"Printer brand: {this.brand} ; Printer series : {this.series}; Printer piper per minutes (ppm) : {this.ppm}";
        }
    }
}
