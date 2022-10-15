using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.cs
{
    class Analyzer3rdParty
    {
        public double[] PerRowAverage(double[][] data)
        {
            int rowCount = data.Length;
            double[] results = new double[rowCount];
            for (int i = 0; i < rowCount; i++)
            {
                results[i] = data[i].Average();
            }
            return results;
        }
        public double[] PerColumnAverage(double[][] data)
        {

            /*
             * 00  01
             * 10  11
              */
            int columnCount = data[0].GetLength(0);
            int rowCount = data.Length;
            double[] results = new double[columnCount];
            for (int i = 0; i < columnCount; i++)
            {
                double sum = 0.0;
                for (int j = 0; j < rowCount; j++)
                {
                    sum = sum + data[j][i];
                }

                results[i] = (sum / rowCount);
            }

            return results;
        }
    }
}
