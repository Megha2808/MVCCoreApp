using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMVC.DomainModels.ApplicationClasses
{
    public class ProductGroupAc
    {
        public int Id { get; set; }
        public string GroupDescription { get; set; }
        public Guid GroupCode { get; set; }
    }
}
