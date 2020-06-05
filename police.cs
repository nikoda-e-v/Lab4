using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    public class police : auto
    {
        public new List<policeman> pass = new List<policeman>();

        public void addPass(policeman passanger)
        {
            try
            {
                pass.Add(passanger);
            }
            catch
            {

            }
        }
    }
}
