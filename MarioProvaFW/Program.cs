using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.OData;

namespace MarioProvaFW
{
    class Program
    {
        static void Main(string[] args)
        {
            var rightUpdObj = new MyObject
            {
                Id = 1,
                Name = "Dario",
                Surname = "Capocci",
                Number = 33
            };
            var partialUpdObj = new MyObject
            {
                Id = 3,
                Name = "Mario",
            };

            var list = MyList.List;

            var oldObj1 = list.Where(x => x.Id == rightUpdObj.Id).FirstOrDefault();
            var oldObj2 = list.Where(x => x.Id == partialUpdObj.Id).FirstOrDefault();

            var properties = typeof(MyObject).GetProperties();

            var result = new MyObject();

            foreach (var prop in properties)
            {
                PropertyInfo propertyInfo = rightUpdObj.GetType().GetProperty(prop.Name);

                var propUpValue = propertyInfo.GetValue(rightUpdObj);
                var propOldValue = propertyInfo.GetValue(oldObj1);
                
                if (propUpValue == propOldValue)
                {
                    propertyInfo.SetValue(result, propOldValue);
                    continue;
                }
                if (propUpValue.Equals(propOldValue))
                {
                    propertyInfo.SetValue(result, propOldValue);
                    continue;
                }

                propertyInfo.SetValue(result, propUpValue);
            }

            return;
        }
    }
}
