using System.ComponentModel.DataAnnotations;

namespace HelpByPros.BusinessLogic
{
    public class User : IUser
    {
        /// <summary>
        /// Id for User Table DB
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// First Name
        /// </summary>
        [Required(ErrorMessage = "First Name is Required.")]
        [Display(Name = "First Name")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "The Input Must be Letters")]
        public string FirstName { get; set; }

        /// <summary>
        /// Last Name 
        /// </summary>
        [Required(ErrorMessage = "Last Name is Required.")]
        [Display(Name = "Last Name")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "The Input Must be Letters")]
        public string LastName { get; set; }


        /// <summary>
        /// Phone Number
        /// </summary>
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Provided Phone Number not Valid")]
        public string Phone { get; set; }


        /// <summary>
        /// To notify a question has been raised or answer has been answered
        /// </summary>
        [Required]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Must Enter Correct Email Address.")]
        public string Email { get; set; }

        /// <summary>
        /// username
        /// </summary>
        [Required]
        [Display(Name = "Username: 3-12 Characters")]
        [StringLength(12, MinimumLength = 3, ErrorMessage = "Must be Between 3 and 12 Characters.")]
        public string Username { get; set; }

        /// <summary>
        /// password 
        /// </summary>
        [Required(ErrorMessage = "Password is required")]
        [StringLength(12, MinimumLength = 4, ErrorMessage = "Must be Between 4 and 12 Characters.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        /// <summary>
        /// adding pictures in the future
        /// </summary>
        
        public byte[] Profile_Pic { get; set; }
    }
}
