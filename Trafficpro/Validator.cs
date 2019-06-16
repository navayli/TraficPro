using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Trafficpro
{
    public class Validator
    {
        public List<ValidationError> validationErrors;
        public Validator()
        {
            validationErrors = new List<ValidationError>();
        }

        public bool IsValid<T>( T type)
        {
            PropertyInfo[] propertyInfos = type.GetType().GetProperties();
            foreach(PropertyInfo propertyInfo in propertyInfos)
            {
                var attributes = propertyInfo.GetCustomAttributes();
                foreach(Attribute attribute in attributes)
                {
                    if(attribute is PenaltyAttribute)
                    {
                        // get the value of attribute
                        byte maxPenalty = (attribute as PenaltyAttribute).MaxPenalty;
                        //get the value of input 
                        byte inputPenalty = byte.Parse(propertyInfo.GetValue(type).ToString());
                       
                        if(inputPenalty>maxPenalty)
                        {
                            validationErrors.Add(new ValidationError
                            {
                                ErrorMessage = "Penalty is out of range",
                                PropertyName = propertyInfo.Name
                            });
                            return false;
                        }

                    }
                }
            }
            return true;
        }
        
    }
}
