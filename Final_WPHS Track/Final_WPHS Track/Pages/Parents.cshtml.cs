﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Final_WPHS_Track.Pages
{
    public class ParentsModel : PageModel
    {
            public string Message { get; set; }

            public void OnGet()
            {
                Message = "Parents page";
            }
    }
}