using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    public class firetruck : auto
    {
        public new List<fireman> pass = new List<fireman>();

        public void addPass(fireman passanger)
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
