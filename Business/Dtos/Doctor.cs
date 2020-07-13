﻿using System.Collections.Generic;
using System.Linq;

using XperienceAdapter.Dtos;

namespace Business.Dtos
{
    /// <summary>
    /// Information about a doctor
    /// </summary>
    public class Doctor : BasePage
    {
        public override IEnumerable<string> SourceColumns => base.SourceColumns.Concat(new[] 
        { 
            "Degree" 
        });

        /// <summary>
        /// Academic degree.
        /// </summary>
        public string? Degree { get; set; }
    }
}