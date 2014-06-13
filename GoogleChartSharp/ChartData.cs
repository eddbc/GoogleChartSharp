using System;
using System.Collections.Generic;
using System.Text;

namespace GoogleChartSharp
{
    class ChartData
    {
        public static string Encode(int[] data)
        {
            int maxValue = findMaxValue(data);
            if (maxValue <= 61)
            {
                return SimpleEncoding(data);
            }
            else if (maxValue <= 4095)
            {
                return ExtendedEncoding(data);
            }

            return null;
        }

        public static string Encode(ICollection<int[]> data)
        {
            int maxValue = findMaxValue(data);
            if (maxValue <= 61)
            {
                return SimpleEncoding(data);
            }
            else if (maxValue <= 4095)
            {
                return ExtendedEncoding(data);
            }

            return null;
        }

        public static string Encode(float[] data)
        {
            return TextEncoding(data);
        }

        public static string Encode(ICollection<float[]> data)
        {
            return TextEncoding(data);
        }

        #region Simple Encoding

        public static string SimpleEncoding(int[] data)
        {
            return "chd=s:" + simpleEncode(data);
        }

        public static string SimpleEncoding(ICollection<int[]> data)
        {
            string chartData = "chd=s:";

            foreach (int[] objectArray in data)
            {
                chartData += simpleEncode(objectArray) + ",";
            }

            return chartData.TrimEnd(",".ToCharArray());
        }

        private static string simpleEncode(int[] data)
        {
            string simpleEncoding = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            string chartData = string.Empty;

            foreach (int value in data)
            {
                if (value == -1)
                {
                    chartData += "_";
                }
                else
                {
                    char c = simpleEncoding[value];
                    chartData += c.ToString();
                }
            }

            return chartData;
        }

        #endregion

        #region Text Encoding

        public static string TextEncoding(float[] data)
        {
            return "chd=t:" + textEncode(data);
        }

        public static string TextEncoding(ICollection<float[]> data)
        {
            string chartData = "chd=t:";

            foreach (float[] objectArray in data)
            {
                chartData += textEncode(objectArray) + "|";
            }

            return chartData.TrimEnd("|".ToCharArray());
        }

        private static string textEncode(float[] data)
        {
            string chartData = string.Empty;

            foreach (float value in data)
            {
                if (value == -1)
                {
                    chartData += "-1,";
                }
                else
                {
                    chartData += value.ToString() + ",";
                }
            }

            return chartData.TrimEnd(",".ToCharArray());
        }

        #endregion

        #region Extended Encoding

        public static string ExtendedEncoding(int[] data)
        {
            return "chd=e:" + extendedEncode(data);
        }

        public static string ExtendedEncoding(ICollection<int[]> data)
        {
            string chartData = "chd=e:";

            foreach (int[] objectArray in data)
            {
                chartData += extendedEncode(objectArray) + ",";
            }

            return chartData.TrimEnd(",".ToCharArray());
        }

        private static string extendedEncode(int[] data)
        {
            string extendedEncoding = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789-.";
            string chartData = string.Empty;

            foreach (int value in data)
            {
                if (value == -1)
                {
                    chartData += "__";
                }
                else
                {
                    int firstCharPos = Convert.ToInt32(Math.Floor((double)(value / extendedEncoding.Length)));
                    int secondCharPos = Convert.ToInt32(Math.Floor((double)(value % extendedEncoding.Length)));

                    chartData += extendedEncoding[firstCharPos];
                    chartData += extendedEncoding[secondCharPos];
                }
            }

            return chartData;
        }

        #endregion


        private static int findMaxValue(int[] data)
        {
            int maxValue = -1;
            foreach (int value in data)
            {
                if (value > maxValue)
                {
                    maxValue = value;
                }
            }

            return maxValue;
        }

        private static int findMaxValue(ICollection<int[]> data)
        {
            List<int> maxValuesList = new List<int>();

            foreach (int[] objectArray in data)
            {
                maxValuesList.Add(findMaxValue(objectArray));
            }

            int[] maxValues = maxValuesList.ToArray();
            Array.Sort(maxValues);
            return maxValues[maxValues.Length - 1];
        }
    }
}
