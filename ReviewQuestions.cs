using System.Runtime.CompilerServices;
using static System.Console;


class ReviewQuestions
{
    static void Main()
    {


     // Question 2 
        int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

             foreach(int num in nums)
                {
                    if(num== 1 || num == 3 || num == 6 || num == 9)
                    {
                        WriteLine(num + " ");
                    }
                }
                
                //better way
                if(nums %3 ==0)
                {
                    WriteLine;
                }

              // quesstion 4 
                int num = 31;
                int result = ((num*2 / 20) %5);

                WriteLine(result);





// question 1
            WriteLine("Enter your grade");
            char choice = Convert.ToChar(ReadLine());
            string grade;

switch( choice )
 {
            case 'A':
                grade = "nice";
                break;
            case 'B':
                grade = "good";
                break;
            case 'C':
                grade = "pass";
                break;
            case 'D':
                grade = "dangr";
                break;
            default:
                grade = "fail";
                break;
	}


//     // Second choice 

        if(choice == 'A')
        {
            grade = "nice";
            WriteLine(grade);
        }
        else if(choice == 'B')
        {   
            grade = "good";
            WriteLine(grade);

        }
        else if(choice == 'C')
        {
            grade ="pass";
            WriteLine(grade);
        }
        else if(choice == 'D')
        {
            grade = "danger";
            WriteLine("danger");
        }
        else
        {
            grade = "fall";
            WriteLine(grade);
        }



            char[] Letters = ['A', 'B', 'C','D'];
            WriteLine(string.Join(":" + Letters));

            
            

            



    }
}