using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSuperComputer
{
    class computer
    {
        private Monitor monitor;
        private Printer printer;
        private Processor processor;
        private Ram ram;
        private Vga vga;

        public computer(StringBuilder builder){
            this.monitor = builder.monitor;
            this.series = series;
            this.ppm = ppm;
        }
}
