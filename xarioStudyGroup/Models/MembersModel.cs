using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace xarioStudyGroup.Models
{
    public class MembersModel
    {
        //Creating the Primary Key for the StudyGroupMembers Table
        [Key]
        [Display(Name = "Student Number")]
        public string StudentNumber { get; set; }

        //Creating the column for the StudyGroupMembers Table
        [Display(Name = "Name")]
        public string FirstName { get; set; }

        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }


    }
}