using AdditionAppModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdditionApp.service
{
    public interface IFindService
    {
        double FindAddition(NumberModel model);

        double FindSubtraction(NumberModel model);

        double FindMultiplication(NumberModel model);
    }
}
