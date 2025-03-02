using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace xarioStudyGroup.Controllers
{
    public class StudyGroupController : Controller
    {
        // GET: StudyGroup
        public ActionResult ListMembers()
        {
            //Creating the list of members for the StudyGroup
            List<Models.MembersModel> members = new List<Models.MembersModel>();

            //Adding all the study group members to the list labeled "members"
            members.Add(new Models.MembersModel { StudentNumber = "u24637646", FirstName = "Xario", Surname = "Zeekoei", EmailAddress = "xario.zeekoei@tuks.co.za" });
            members.Add(new Models.MembersModel { StudentNumber = "u01234567", FirstName = "Scott", Surname = "Allen", EmailAddress = "scott.allen@tuks.co.za" });
            members.Add(new Models.MembersModel { StudentNumber = "u12345678", FirstName = "Kallie", Surname = "Kotze", EmailAddress = "kallie.kotze@tuks.co.za" });
            members.Add(new Models.MembersModel { StudentNumber = "u23456789", FirstName = "Johan", Surname = "Smith", EmailAddress = "johan.smith@tuks.co.za" });
            members.Add(new Models.MembersModel { StudentNumber = "u34567890", FirstName = "Jane", Surname = "Doe", EmailAddress = "jane.doe@tuks.co.za" });

            //Passing the list of members to the view
            return View(members);
        }
    }
}