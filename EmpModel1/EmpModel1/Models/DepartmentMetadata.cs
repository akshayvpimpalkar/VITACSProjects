using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmpModel1.Models
{
    [MetadataType(typeof(DepartmentMetadata))]
    public partial class Dept
    { }

    public class DepartmentMetadata
    {   [Display(Name="Department Name")]
        public string Name { get; set; }
    }
}