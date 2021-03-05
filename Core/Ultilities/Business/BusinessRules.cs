using Core.Ultilities.Result;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Ultilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics)
        {
            foreach (IResult logic in logics)
            {
                if (!logic.Success)
                {
                    return logic;
                }
            }
            return null;
        }
    }
}
