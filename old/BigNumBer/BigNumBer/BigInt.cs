using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigNumBer
{
    class BigInt
    {
        private string svalue;
        public bool SoAm = false;
        public string value
        {
            get
            {
                if (svalue != "")
                {
                    return svalue;
                }
                else
                {
                    return "0";
                }
            }
            set
            {
                if (value == "0" || value == "-0")
                {
                    svalue = "";
                }
                else if(value[0] == '-')
                {
                    svalue = value;
                    SoAm = true;
                }
                else
                {
                    svalue = value;
                    SoAm = false;
                }
            }
        }

        public BigInt()
        {
            value = "";
        }
        public BigInt(string input)
        {
            value = input;
        }
        public BigInt Cong(BigInt a, BigInt b)
        {
            BigInt result = new BigInt();
            string numberA = a.value;
            string numberB = b.value;
            int sum;
            bool carry = false;
            string ketQua = "";
            if (numberA.Length != numberB.Length)
            {
                int length = Math.Abs(numberA.Length - numberB.Length);
                if (numberA.Length < numberB.Length)
                {
                    numberA = string.Join("", Enumerable.Repeat("0", length)) + numberA;
                }      
                else
                {
                    numberB = string.Join("", Enumerable.Repeat("0", length)) + numberB;
                }
            }

            for (int i = numberA.Length - 1; i >= 0; i--)
            {
                sum = int.Parse(numberA.Substring(i, 1)) + int.Parse(numberB.Substring(i, 1));
                if (sum >= 10)
                {
                    carry = true;
                    sum = sum % 10;
                }
                sum += (carry ? 1 : 0);
                ketQua = sum.ToString() + ketQua;
            }
            result.value = ketQua;

            return result;
        }

        
    }
}
