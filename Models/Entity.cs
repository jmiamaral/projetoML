using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace app.Models
{
    public class Entity
    {
        public String table_name { get; set; }
        public List<string> columns { get; set; }
        public List<string> fields { get; set; }

    }
}