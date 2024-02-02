using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSuperComputer
{
    class processor
    {
        //processor : series, core, cache
        private String series;
        private int core;
        private int cache;

        public processor(){
        
        }

        public void setSeries(String series){
            this.series = series;
        }

        public String getString(){
            return this.series;
        }

        public void setCore(int core){
            this.core = core;
        }

        public int getCore(){
            return this.core;
        }

        public void setCache(int cache){
            this.cache = cache;
        }

        public int getCache(){
            return this.cache;
        }

        public override string ToString()
        {
            return $"Processor series: {this.series} ; Processor core: {this.core}; Processor cache:{this.cache}";
        }
    }
}
