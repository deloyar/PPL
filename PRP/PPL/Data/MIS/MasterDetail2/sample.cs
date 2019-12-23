using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PRP.PPL.Data.MIS.MasterDetail2
{
    public class Sample: NotifyPropertyChanged
    {
        public string Nothing { get; set; }

        private string firstName;
        private string lastName;

        [Required(ErrorMessage = "FirstName is required")]
        public string FirstName
        {
            get { return firstName; }
            set { SetField(FirstName, ref firstName, value); }
        }


        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get { return lastName; } set { SetField(LastName, ref lastName, value); } }
        [Required(ErrorMessage = "Email is required")]

        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid Count Number")]
        public string Count { get; set; }


        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Mobile Number:")]
        [Required(ErrorMessage = "Mobile Number is required.")]
        [RegularExpression(@"\+?(88)?0?1[356789][0-9]{8}\b", ErrorMessage = "Invalid Mobile Number.")]
        public string Phone { get; set; }

    }
}
