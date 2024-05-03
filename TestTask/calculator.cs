using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    public class calculator
    {
        private double min;
        private double max;
        private double mathExpect;
        public string name { get; set; }
        public float times;
        private double sum;
        private void getMax(double[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i]>this.max)
                {
                    this.max = values[i];
                }
            }
        }
        private void getMin(double[] values)
        {
            this.min = this.max;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < this.min)
                {
                    this.min = values[i];
                }
            }
        }
        private void calculateMathExpext()
        {
            this.mathExpect = this.sum / this.times;
        }
        public void setValues(double[] values)
        {
            getMax(values);
            getMin(values);
            for (int i = 0; i < values.Length; i++)
            {
                this.sum += values[i];
            }
        }
        public string[] getData()
        {
            string[] values = new string[4];
            values[0] = this.name;
            values[1] = this.min.ToString();
            values[2] = this.max.ToString();
            calculateMathExpext();
            values[3] = this.mathExpect.ToString();
            return values;
        }
    }
}
