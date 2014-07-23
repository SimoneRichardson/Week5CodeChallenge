using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//add a using statement for data annotations
using System.ComponentModel.DataAnnotations;

namespace Week5CodeChallenge.Models
{

    //create a partial class for SimoneEntities
    //so we can connect the validation properties with
    //MetaData
    [MetadataType(typeof(Week5CodeChallengeValidation))]
    public partial class Week5CodeChallenge
    {
    
    }



    


    public class Week5CodeChallengeValidation
    {
        
       [Required, 
        Display(Name="First Name")
        ,MaxLength(50)]
        public string FirstName { get; set; }
        [Required,
        Display(Name="Last Name")
        ,MaxLength(50)]
        public string LastName { get; set; }
        [Required
        ,Display(Name="Email")
        ,MaxLength(50)]
        public string Email { get; set; }
        [Required
        ,Display(Name="Phone Number")
        ]
        public int PhoneNumber { get; set; }
        [Required
        ,Display(Name="Company Name")
        ,MaxLength(50)]
        public string CompanyName { get; set; }
        [Required
        ,Display(Name="Project Description")
        ,MaxLength(50)]
        public string ProjectDescription { get; set; }
        [Required
        ,Display(Name="Comment")
        ,MaxLength(50)]
        public string Comment { get; set; }
    }
}

    
