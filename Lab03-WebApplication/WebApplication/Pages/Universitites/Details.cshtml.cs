using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspPageWebApplication.Application.ManageUniversity;
using AspPageWebApplication.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication.Pages.Universitites
{
    public class DetailsModel : PageModel
    {
        private readonly IManageUniversity manageUniversity;
        public University University { get; set; }

        public DetailsModel(IManageUniversity manageUniversity)
        {
            this.manageUniversity = manageUniversity;
        }

        public void OnGet(int universityId)
        {
            University = manageUniversity.GetUniversityByID(universityId);
        }
    }
}
