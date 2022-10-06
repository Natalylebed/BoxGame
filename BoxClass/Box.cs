using System;
using System.Collections.Generic;
using System.Text;

namespace BoxClass
{
    public class Box
    {

        public Knod knod { get; set; }
        public List<Knod> KnodInBox { get; set; }

         public Box()
        {
            knod = new Knod();
            KnodInBox = new List<Knod>();
        }
      
    }
}
