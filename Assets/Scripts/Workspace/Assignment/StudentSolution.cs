using AssignmentSystem.Services;
using UnityEngine;
using Debug = AssignmentSystem.Services.AssignmentDebugConsole;

namespace Assignment
{
    public class StudentSolution : IAssignment
    {
        #region Examples

        public void As01_SyntaxIf(bool isSixoClock)
        {
            if (isSixoClock == true)
            {
                Debug.Log("You can get in");
            }
            Debug.Log("Crack Crack!!!!");
        }


        public void As02_StringComparisonExample(string password)
        {
           if (password == "Moon")
            {
                Debug.Log("password is correct");
            }
            if (password != "Moon")
            {
                Debug.Log("wrong password");
            }
        }

        public void As03_NumberComparisonExample(int number)
        {
            if (number > 10)
            {
                Debug.Log("My Number > 10");
            }
            if (number < 10)
            {
                Debug.Log("My Number < 10");
            }
            if (number == 10)
            {
                Debug.Log("My Number == 10");
            }
            if (number >= 10)
            {
                Debug.Log("My Number >= 10");
            }
            if (number <= 10)
            {
                Debug.Log("My Number <= 10");
            }
            if (number != 10)
            {
                Debug.Log("My Number != 10");
            }
        }

        public void As04_AndOrOperatorExample(int number)
        {
            // && = and
            // || = or
           if (number > 8 && number < 12) // 9, 10, 11
            {
                Debug.Log("My Number 8 > < 12");
            }
            if (number > 8 || number < 12) 
            {
                Debug.Log("My Number or 8 || 12");
            }
        }

        public void As05_GuessingNumberExample(int guessingNumber, int randomNumber)
        {
            Debug.Log("Guessing number " + randomNumber);
            //Debug.Log($"Guessing number {randomNumber}");
            if (guessingNumber == randomNumber)
            {
                Debug.Log("Congratulations! You guessed the correct number.");
            }
            else
            {
                Debug.Log("I guess we can just agree to disagree.");
            }
        }

        public void As06_GuessingNumberMoreOrLessExample(int guessingNumber, int randomNumber)
        {
            Debug.Log("Guessing number " + randomNumber);
            if (guessingNumber < randomNumber)
            {
                Debug.Log("Too low! Try again.");
            }
            else if (guessingNumber > randomNumber)    
            {
                Debug.Log("Too high! Try again.");
            }
            else
            {
                Debug.Log("Congratulations! We are same mind.");
            }
        }

        public void As07_VerifyIdentityExample(string username, string password, int age, bool isPaid)
        {
            if (username == "user" && password == "user123")
            {
                Debug.Log("You have user access.");
                if (isPaid) //if (isPaid == true)
                {
                    Debug.Log("welcome vip member.");
                    if (age > 18)
                    {
                        Debug.Log("You have access to exclusive content.");
                    }    
                }
                else
                {
                    Debug.Log("welcome free member.");
                }
            }
            else
            {
                Debug.Log("You have guest access.");
            }
           
        }

        #endregion

        #region Level 1: Simple

        public void Lv01_CheckNumberSign(int number)
        {
            // TODO: Implement logic to determine sign
            // Example: Debug.Log("Positive");
            throw new System.NotImplementedException();
        }

        public void Lv02_GetDayName(int day)
        {
            // TODO: Implement logic to return day name
            // Example: Debug.Log("Monday");
            throw new System.NotImplementedException();
        }

        public void Lv03_ValidatePassword(string inputPassword, string correctPassword)
        {
            // TODO: Implement password validation logic
            // Example: Debug.Log("True");
            throw new System.NotImplementedException();
        }

        public void Lv04_GetGrade(int score)
        {
            // TODO: Implement logic to return grade
            // Example: Debug.Log("A");
            throw new System.NotImplementedException();
        }

        public void Lv05_IsLeapYear(int year)
        {
            // TODO: Implement leap year check logic
            // Example: Debug.Log("True");
            throw new System.NotImplementedException();
        }

        public void Lv06_Calculate(double num1, char op, double num2)
        {
            // TODO: Implement calculator logic
            // Example: Debug.Log("Result: 42");
            throw new System.NotImplementedException();
        }

        public void Lv07_GetSeason(int month)
        {
            // TODO: Implement logic to return season
            // Example: Debug.Log("Summer");
            throw new System.NotImplementedException();
        }

        #endregion

        #region Level 2: Moderate

        public void Ex01_PurchasingSystemExample(int quantity, int price, int payment)
        {
            throw new System.NotImplementedException();
        }

        public void Ex02_RockPaperScissorsExample(int userChoice, int computerChoice)
        {
            throw new System.NotImplementedException();
        }

        public void Ex03_CalculateWeaponDamage(string weaponType, int baseDamage)
        {
            // TODO: Add your implementation here
            // Example: AssignmentDebugConsole.Log("result as string");
            throw new System.NotImplementedException();
        }

        public void Ex04_DeterminePlayerRank(int score, int completionTime)
        {
            // TODO: Add your implementation here
            // Example: AssignmentDebugConsole.Log("result as string");
            throw new System.NotImplementedException();
        }

        #endregion

    }
}
