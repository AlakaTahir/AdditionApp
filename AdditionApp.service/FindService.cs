using AdditionAppModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdditionApp.service
{
    public class FindService : IFindService
    {
        public FindService() 
        { 
        }

        public double FindAddition(NumberModel model)
        { 
            return model.NumA+ model.NumB;
        }

        public double FindSubtraction(NumberModel model)
        {
            return model.NumA - model.NumB;
        }

        public double FindMultiplication(NumberModel model)
        {
            return model.NumA * model.NumB;
        }

    }

}
