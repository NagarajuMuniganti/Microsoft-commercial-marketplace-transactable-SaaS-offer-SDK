﻿using System;
using System.Collections.Generic;

namespace Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities
{
    public partial class ARMTemplates
    {
        public int ArmtempalteId { get; set; }
        public string ArmtempalteName { get; set; }
        public string TemplateLocation { get; set; }
        public bool? Isactive { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? UserId { get; set; }
    }
}
