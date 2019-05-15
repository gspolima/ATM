using System;

namespace ATM 
{
    public class Atm 
    {
        public void Calculate(int value)
        {
            for (int i = amountNotes.Length - 1; i >= 0; i--)
            {
                if (value == 0)
                {
                    break;
                }

                if (value >= amountNotes[i])
                {
                    amountNotes[i] = value / moneyNotes[i];
                    value = value % moneyNotes[i];
                    string output = amountNotes[i] + " NOTA DE " + moneyNotes[i];
                    Console.WriteLine(output);
                }
            }
        }

        public int[] GetArray() 
        {
            return amountNotes;
        }

        private int[] moneyNotes = new int[6] { 2, 5, 10, 20, 50, 100 };

        private int[] amountNotes = new int[6] { 0, 0, 0, 0, 0, 0 };
    }
}