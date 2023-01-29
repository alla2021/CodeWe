using System;
using System.Data;
using System.Diagnostics;
using System.Runtime.InteropServices.ComTypes;
using static System.Net.Mime.MediaTypeNames;

namespace CalculateUserAge
{
    public class CalculateAge 
    {
        DateTime userBirthDate;
        //DateTime now;

        private int age;
        private bool isAdult;
        private int adultYear;
        
        public CalculateAge(){ }

        public int BirthYear
        {
            get => this.userBirthDate.Year;
        }

        public int BirthDay
        {
            get => this.userBirthDate.Day;
        }

        public int BirthMonth
        {
            get => this.userBirthDate.Month;
        }

        public int Age
        {
            get => this.Age;
        }

        private int enterNumber(string text)
        {
            Console.WriteLine($"Enter your --{text}-- of birth: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public void inputInfo()
        {
            try
            {
                userBirthDate = birthDate(enterNumber("year"), enterNumber("Month"), enterNumber("Day"));
            }
           catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private DateTime birthDate(int birthYear, int birthMonth, int birthDay)
        {      
            return new DateTime(birthYear, birthMonth, birthDay);
        }

        public int calculateUserAge()
        {
            DateTime now = DateTime.Now;
            age = now.Year - userBirthDate.Year;
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
            return userBirthDate.AddYears(18).Year;
        }

        private int totalDays()
        {
            return Convert.ToInt32(DateTime.Now.Subtract(userBirthDate).TotalDays);
        }

        private int totalMonth(DateTime now)
        {
            return ((now.Year - userBirthDate.Year) * 12) + now.Month - userBirthDate.Month;
        }
       

        public void printInfo()
        {
           Console.WriteLine(age > 0 ? $"The person is --{age}-- years old." : 
               "This is the child who born in current year.");
            Console.WriteLine(isAdult ? $"The person is ADULT. 18 years was in --{adultYear}--" : 
                "The person is young.");
            Console.WriteLine($"You have been alive for --{totalDays()}-- days OR --{totalMonth(DateTime.Now)}-- months");
        }
    }
}
