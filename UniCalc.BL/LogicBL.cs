using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniCalc.BL
{
    /// <summary>
    /// Сервис для логических операций
    /// </summary>
    public class LogicBL
    {
        /// <summary>
        /// Сложение
        /// </summary>
        /// <param name="x1">Первая переменная</param>
        /// <param name="x2">Вторая переменная</param>
        /// <returns></returns>
        public string Plus(long x1, long x2)
        {
            return (x1 + x2).ToString();
        }
    }
}
