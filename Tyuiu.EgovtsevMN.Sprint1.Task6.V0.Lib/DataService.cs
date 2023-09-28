using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.EgovtsevMN.Sprint1.Task6.V0.Lib
{
    public class DataService : ISprint1Task6V15
    {
        public bool CheckLettersCount(string value)
        {
           
            int LettersAmount = 0;
            int CharAmount = 0;

            for (int i = 0; i < value.Length; i++)
            {
                if (char.IsLetter(value[i]))
                {
                    LettersAmount = ++LettersAmount;
                }
                else
                {
                    CharAmount = ++CharAmount;
                }
            }

            if (LettersAmount > CharAmount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
    }






