using System;
using System.Data;
using System.Diagnostics;
using System.Runtime.InteropServices.ComTypes;
using static System.Net.Mime.MediaTypeNames;

namespace CalculateUserAge
{
    public class CalculateAge 
    {
        private int birthYear;
        private int birthDay;
        private int birthMonth;

        DateTime userBirthDate;
        DateTime now;

        private bool isAdult;
        private int adultYear;
        
        public CalculateAge(){ }

        public int BirthYear
        {
            get => this.birthYear;
            set => this.birthYear = value;
        }

        public int BirthDay
        {
            get => this.birthDay;
            set => this.birthDay = value;
        }

        public int BirthMonth
        {
            get => this.birthMonth;
            set => this.birthMonth = value;
        }

        public void inputInfo()
        {
            try
            {
                Console.WriteLine("Enter your --year-- of birth: ");
                BirthYear = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Enter your --Day-- of birth: ");
                BirthDay = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your --Month-- of birth: ");
                BirthMonth = Convert.ToInt32(Console.ReadLine());

                userBirthDate = birthDate();
            }
           catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private DateTime birthDate()
        {  
            DateTime theDate = new DateTime(birthYear, birthMonth, birthDay);          
            return theDate;
        }

        public int calculateUserAge()
        {
            now = DateTime.Now;
            int age = now.Year - userBirthDate.Year;
            if (now<userBirthDate) {
                throw new Exception("ERROR. The birthday cannot be in the future!");
            } else if (now.Month < userBirthDate.Month || (now.Month == userBirthDate.Month && now.Day < userBirthDate.Day)){ 
                age--; 
            }
            isAdult = age >= 18 ? true : false;
            if (isAdult)
            {
                adultYear = isAdultCalc();
            }
            return age;
        }

        private int isAdultCalc()
        {
            DateTime year = userBirthDate.AddYears(18);
            return year.Year;
        }

        private int totalDays()
        {
            now = DateTime.Now;
            TimeSpan ts =  now.Subtract(userBirthDate);
            return Convert.ToInt32(ts.TotalDays);
        }

        private int totalMonth()
        {
            int total = 0;

    
                total = ((now.Year - userBirthDate.Year) * 12) + now.Month - userBirthDate.Month;   
            
            return total;
        }
       

        public void printInfo()
        {  
            Console.WriteLine($"The person is {calculateUserAge()} years old.");
            Console.WriteLine(isAdult ? $"The person is ADULT. 18 years was in {adultYear}" : "The person is young.");
            Console.WriteLine($"You have been alive for {totalDays()} days");
            Console.WriteLine($"You have been alive for {totalMonth()} months");
        }
    }
}
