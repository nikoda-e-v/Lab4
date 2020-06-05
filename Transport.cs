using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    public class Transport
    {
        public int passangers;
        public List<human> pass = new List<human>();

        public void addPass(human passanger)
        {
            try
            {
                pass.Add(passanger);
            }
            catch
            {
                
            }
           
        }



        public void delPass(int num)
        {
            try
            {
                pass.RemoveAt(num);
            }
            catch
            {

            }
        }


    }
}
