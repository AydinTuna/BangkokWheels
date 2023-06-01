using System;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BK.Models.ViewModels
{
    public class AdVM
    {
        public Ad Ad { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> CarList { get; set; }
    }
}

