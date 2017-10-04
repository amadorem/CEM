using System;
using System.Collections.Generic;
using System.Text;

namespace CEM.Core.Entities
{
    /// <summary>
    /// The sy class.
    /// </summary>
    public class SY : BaseEntity
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        public DateTime EndDate { get; set; }
    }
}