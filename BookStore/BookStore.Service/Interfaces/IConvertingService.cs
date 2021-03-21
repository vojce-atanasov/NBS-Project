using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Service.Interfaces
{
    public interface IConvertingService
    {
        string ConvertIntegerToString(int intValue);
        public string ConvertAnyToString<T>(T type);
    }
}
