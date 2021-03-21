using BookStore.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Service
{
    public class ConvertingService : IConvertingService
    {
        public string ConvertIntegerToString(int intVlalue)         
        {
            string result = intVlalue.ToString();
            return result;
        }

        #region Helper Functions  /* -- da ne se optovaruvaat mnogu funkcii so mnogu kod*/
        private int ConvertStringToInt(string stringValue)
        {
            int result = int.Parse(stringValue);
            return result;
        }

        public string ConvertAnyToString<T>(T type)
        {
            var result = type.ToString();
            return result;
        }

        #endregion



    }
}
