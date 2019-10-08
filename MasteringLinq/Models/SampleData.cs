using System;
using System.Collections.Generic;
using System.Text;

namespace MasteringLinq.Models
{
    public static class SampleData
    {
        public static IList<LinqModel> Data
        {
            get
            {
                return new List<LinqModel>
                {
                    new LinqModel
                    {
                        Name = "Newt",
                        Gender = Gender.Male,
                        Age = 27,
                    },
                    new LinqModel
                    {
                        Name = "Alicia",
                        Gender = Gender.Female,
                        Age = 27,
                    }
                };
            }
        }
    }
}
