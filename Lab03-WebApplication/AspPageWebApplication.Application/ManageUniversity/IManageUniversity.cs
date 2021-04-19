using AspPageWebApplication.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspPageWebApplication.Application.ManageUniversity
{
    public interface IManageUniversity
    {
        List<University> GetUniversities();
        University GetUniversityByID(int universityID);
    }
}
