using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MasteringLinq.Models;

namespace MasteringLinq.SelectQuery
{
    public class MasteringSelect
    {
        public void Run()
        {
            var list = SampleData.Data;

            StandardSelect(list);

            var result = list.Select(SelectWithMethod);
        }

        private IEnumerable<string> StandardSelect(IEnumerable<LinqModel> list)
        {
            return list.Select(x => x.Name);
        }

        private string SelectWithMethod(LinqModel model)
        {
            return model.Name;
        }
    }
}
