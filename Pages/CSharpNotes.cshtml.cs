using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Diagnostics;
using AspenDelta.com.Models;
using Microsoft.AspNetCore.Http;

namespace AspenDelta.com.Pages
{
    public class CSharpNotesModel : PageModel
    {
        private string halloween = "";


        public string Message { get; private set; } = "";

        static void Main(string[] args) {

            Console.WriteLine("Non returning function");
        }

        public void OnGet()
        {
            int x = 0;
            char alpha = 'a';
            double amount = 9.99;
            long big_money = 999999999999999999;
            bool is_active = false;
            string name = "kevin";

            //cast 
            int myCastedInt = (int)amount;    // Manual casting: double to int
            //Method Casting
            //Convert.ToString();
            //Convert.ToDouble()
           // Convert.ToInt32(amount) 9
           //Convert.ToString(true)

            int lower_start = 97;
            int upper_start = 65;
            
            int year = 2023;

            //Array
            int[] nums = { 1, 2, 3, 4, 5 };
            char[] chars = { 'a', 'b', 'c' };

            string choice = "witch";

            int num_letters = 26;


            string[] cars = new string[2] { "car 1", "cars 2" };
            //defined class data
            Car myCar1 = new Car {Id=1, Make = "Chevrolet", Model = "Silverado", Color = "Red", Year = 2016 };
            Car myCar2 = new Car { Id = 2, Make = "Chevrolet", Model = "Traverse", Color = "Blue", Year = 2019 };

            Car[] myCars = new Car[2] {myCar1,myCar2 };

            //Cars[] cars = new Cars[2] { "car 1", "cars 2" };


            foreach (Car car in myCars)
            {
                Console.WriteLine(car);
                Console.WriteLine(car.Make);
            }

            //forloop
            for (int i = 0; i < num_letters; i++)
            {
                //Console.WriteLine(i);
                //Console.WriteLine((char)i);
                //Console.WriteLine("Hello \n" + "World");
                //Modulus
                if ((i % 2) == 0)
                {
                    Debug.WriteLine(i + " :");
                    Debug.WriteLine(i + upper_start);
                    Debug.WriteLine((char)(i + upper_start));
                    
                    Debug.WriteLine("\n");
                    Message += (char)(i + upper_start);
                }
                else {
                    Debug.WriteLine(i + " ");
                    Debug.WriteLine(i + lower_start);
                    Debug.WriteLine((char)(i + lower_start));
                    Debug.WriteLine("\n");
                    Message += (char)(i + lower_start);
                }
            }

            int c = 0;
            while (c < 0) 
            {

                if (this.halloween != "")
                {
                
                }else{
                    break;
                }

                c++;
            }

            switch (choice) 
            {

                case "witch":
                    this.halloween = choice;
                break;
                
                default: 
                break;
            
            }


            try {
                string result = "kevin";
                Console.WriteLine(Convert.ToInt32(result) + 10);

            } catch (Exception ex) {
                Console.WriteLine(ex.Message);

            }

            /*
             * 
                   //[ResponseType(typeof())]
        public IHttpActionResult Get_loans(DateTime open_date, string lookup_type = "", int status_code = 0)
        {
            DateTime open_date_converted = Convert.ToDateTime(open_date);
            Int64 loan_class2_no = 6;//floorplan - change this later to have ability to filter by loan type
            string lookup_direction = ">";

            // var past_due_loans = new IEnumerable<int> ;
            //IEnumerable<IEnumerable<int>> past_due_loans;
            
            var all_loans = (from la in db.loanacct
                             where la.loan_class2_no == loan_class2_no && la.status_code_no == status_code
                             select new LoanModel { acctrefno = la.acctrefno, loan_number = la.loan_number, loan_type = la.loan_type, entity = la.entity, open_date = la.open_date, curr_maturity_date = la.curr_maturity_date, open_maturity_date = la.open_maturity_date, closed_date = la.closed_date, dealer_cifno = la.dealer_cifno, loan_officer_no = la.loan_officer_no, current_payoff_balance = la.current_payoff_balance, total_current_due_balance = la.total_current_due_balance }
                                                 );
            if (lookup_type == "gt")
            {  private VACNLSEntities db = new VACNLSEntities();

                all_loans = (from la in db.loanacct
                             where la.loan_class2_no == loan_class2_no && la.status_code_no == status_code && la.open_date >= open_date_converted
                             select new LoanModel { acctrefno = la.acctrefno, loan_number = la.loan_number, loan_type = la.loan_type, entity = la.entity, open_date = la.open_date, curr_maturity_date = la.curr_maturity_date, open_maturity_date = la.open_maturity_date, closed_date = la.closed_date, dealer_cifno = la.dealer_cifno, loan_officer_no = la.loan_officer_no, current_payoff_balance = la.current_payoff_balance, total_current_due_balance = la.total_current_due_balance }
                                              );

            }

            var b = all_loans.ToList();


            if (all_loans == null)
            {
                return NotFound();
            }

            return Ok(b);
        }
            */

            Message += this.halloween;






        }
    }
}
