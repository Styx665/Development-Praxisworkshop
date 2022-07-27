using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;

using Development_Praxisworkshop.Helper;

namespace Development_Praxisworkshop.Pages
{
    //[AllowAnonymous]
    [Authorize(Roles = ("a6d89943-0f07-4eec-aa1c-2f9ef44fb5c5"))] // testgrp
    public class GalleryModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        private readonly IConfiguration _config;
        public List<String> images;
        public GalleryModel(ILogger<PrivacyModel> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }
        public void OnGet()
        {
            StorageAccountHelper todo = new StorageAccountHelper(_config);
            images = todo.GetImages();
        }
    }
}
