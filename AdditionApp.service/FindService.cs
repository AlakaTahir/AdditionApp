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

        public double FindAddition(FindAdditionmodel model)
        { 
            return model.NumA+ model.NumB;
        }

        public double FindSubtraction(FindSubtractionmodel model)
        {
            return model.NumA - model.NumB;
        }

    }

}
