using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using AspPageWebApplication.Domain;
using AspPageWebApplication.Application.ManageUniversity;

namespace WebApplication.Pages.Universitites
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;

        private readonly IManageUniversity manageUniversity;

        public string Message { get; set; }
        public List<University> Universities { get; set; }

        public ListModel(IConfiguration configuration, IManageUniversity manageUniversity)
        {
            config = configuration;
            this.manageUniversity = manageUniversity;
        }

        public void OnGet()
        {

            Universities = manageUniversity.GetUniversities();

        }
    }
}
