using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmpModel.Models
{
    [MetadataType(typeof(DepartmentMetaData))]
    public partial class Department { }
    public class DepartmentMetaData
    {
        [Display(Name ="Department name")]
        public string Name { get; set; }
    }

    
}