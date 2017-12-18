using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebConfigTransform.Web.Models
{
    public class ConfigTransformViewModel
    {
        [Display(Name = "Web Config")]
        public string WebConfigStr { get; set; }

        [Display(Name ="Transform File")]
        public string TransformConfigStr { get; set; }

        [Display(Name ="Output File")]
        public string OutPutConfigStr { get; set; }
    }
}
