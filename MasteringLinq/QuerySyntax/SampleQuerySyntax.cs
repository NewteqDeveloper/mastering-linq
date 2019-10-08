using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MasteringLinq.Models;

namespace MasteringLinq.QuerySyntax
{
    public class SampleQuerySyntax
    {
        public void Run()
        {
            var list = SampleData.Data;

            var filter1 = from person in list
                where person.Age > 25
                select person.Name;

            var filter2 = from person in list
                let personGender = person.Gender
                where person.Age > 25
                select personGender;
        }
    }
}
