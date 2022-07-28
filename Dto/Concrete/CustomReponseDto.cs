using System.Collections.Generic;

namespace Bussiness.Configuration.Filters
{
    public class CustomReponseDto<T>
    {

        public static object Fail(int i, List<string> errors)
        {
            throw new System.NotImplementedException();
        }
    }
}
