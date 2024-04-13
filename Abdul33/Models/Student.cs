using System.ComponentModel.DataAnnotations;

namespace Abdul33.Models
{
    public class Student
    {
        [Display(Name="Student Name")]
        [Required(ErrorMessage = "Name Is Must")]
        //[StringLength(15,MinimumLength=3, ErrorMessage ="Name must be with in 3 to 15 charecters")]
        //[MaxLength(15)]
        [MinLength(3, ErrorMessage ="Minimum Length must be 3")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email Is Must")]
        //[EmailAddress]
        [RegularExpression("^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$", ErrorMessage ="Invalid Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Age Is Must")]
        [Range(10 , 50 ,ErrorMessage ="Age must be with in 10 to 50")]
        public int? Age { get; set; }   //jab bhi int use kar rahe hai and us 
        //ke upar required ko use kar rahe hai to us case me int ke age question 
        //mark lagana se hum usko nullable bana rahe hai is se kay hoga ki 
        //hamara message print hoga 



        //[Required(ErrorMessage = "Password Is Must")]
        //[RegularExpression("\r\n(?=^.{8,}$)((?=.*\\d)|(?=.*\\W+))(?![.\\n])(?=.*[A-Z])(?=.*[a-z]).*$" , ErrorMessage = "Uppercase, Lowercase, Numbers, Symbol, Min 8 Chars")] //ye 
        ////Regularexpression is telling taht i am making a strong password or not 
        ////thats why i am puting that type of condition in between
        //public string Password {  get; set; }

        //[Required(ErrorMessage = "ConfirmPassword Is Must")]
        //[Compare("Password", ErrorMessage ="Both Password must be Identical")]
        //[Display(Name = "Enter Confirm Password")]
        //public string ConfirmPassword { get; set; }




        //[Required(ErrorMessage = "Number Is Must")]
        //[RegularExpression("^((\\+92)|(0092))-{0,1}\\d{3}-{0,1}\\d{7}$|^\\d{11}$|^\\d{4}-\\d{7}$", ErrorMessage ="Invalid Moblie Number")]
        //public string PNumber { get; set; }


        //[Required(ErrorMessage = "Websit URL Is Must")]
        //[Url(ErrorMessage = "Invalid URL")]
        //public string WebsiteURL {  get; set; }
    }
}
