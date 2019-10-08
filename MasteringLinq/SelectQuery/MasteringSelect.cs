using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasteringLinq.SelectQuery
{
    public class MasteringSelect
    {
        public void Run()
        {
            var list = new List<SelectModel>
            {
                new SelectModel
                {
                    Name = "Newt",
                    Gender = Gender.Male,
                    Age = 27,
                },
                new SelectModel
                {
                    Name = "Alicia",
                    Gender = Gender.Female,
                    Age = 27,
                }
            };

            StandardSelect(list);

            var result = list.Select(SelectWithMethod);
        }

        private IEnumerable<string> StandardSelect(IEnumerable<SelectModel> list)
        {
            return list.Select(x => x.Name);
        }

        private string SelectWithMethod(SelectModel model)
        {
            return model.Name;
        }
    }

    public class SelectModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }
}
