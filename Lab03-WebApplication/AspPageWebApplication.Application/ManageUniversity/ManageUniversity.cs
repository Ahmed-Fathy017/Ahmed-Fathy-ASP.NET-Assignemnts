using AspPageWebApplication.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AspPageWebApplication.Application.ManageUniversity
{
    public class ManageUniversity : IManageUniversity
    {
        public List<University> GetUniversities()
        {
            return new List<University>() {
                new University() {Id = 1, Name = "Cairo University", Address = "Egypt" },
                new University() {Id = 2, Name = "Alexandira University", Address = "Egypt" },
                new University() {Id = 3, Name = "Manchester University", Address = "Manchester" },
                new University() {Id = 4, Name = "Harvard University", Address = "USA" },
                new University() {Id = 5, Name = "Cambridge University", Address = "GB" }
            };
        }

        public University GetUniversityByID(int universityID)
        {
            return GetUniversities().SingleOrDefault(uni => uni.Id == universityID);
        }
    }
}
