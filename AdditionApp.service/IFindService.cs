using AdditionAppModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdditionApp.service
{
    public interface IFindService
    {
        double FindAddition(FindAdditionmodel model);

        double FindSubtraction(FindSubtractionmodel model);
    }
}
