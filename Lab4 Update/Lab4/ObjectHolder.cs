using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    //Part 1 - Modify the below Class to accept a generic held value, instead of only an integer. 
    class ObjectHolder<T>
    {
        //Constructor
        public ObjectHolder(string whatItsHolding, T heldValue)
        {
            WhatItsHolding = whatItsHolding;
            HeldValue = heldValue;
        }



        //do not modify
        public string WhatItsHolding
        {
            get; set;
        }


        //Update Property to Be Generic

        public T HeldValue
        {
            get;set;
        }
    }
}
