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
            //throw new System.NotImplementedException();
            if (number > 0)
            {
                Debug.Log("Positive");
            }
            else if (number < 0)
            {
                Debug.Log("Negative");
            }
            else
            {
                Debug.Log("Zero");
            }
        }

        public void Lv02_GetDayName(int day)
        {
            // TODO: Implement logic to return day name
            // Example: Debug.Log("Monday");
            //throw new System.NotImplementedException();
            switch (day)
            {
                case 1: Debug.Log("Monday"); break;
                case 2: Debug.Log("Tuesday"); break;
                case 3: Debug.Log("Wednesday"); break;
                case 4: Debug.Log("Thursday"); break;
                case 5: Debug.Log("Friday"); break;
                case 6: Debug.Log("Saturday"); break;
                case 7: Debug.Log("Sunday"); break;

                default: Debug.Log("Invalid day"); break;
            }

        }

        public void Lv03_ValidatePassword(string inputPassword, string correctPassword)
        {
            // TODO: Implement password validation logic
            // Example: Debug.Log("True");
            //throw new System.NotImplementedException();
            if (inputPassword == correctPassword)
            {
                Debug.Log("True");
            }
            else
            {
                Debug.Log("False");
            }
        }

        public void Lv04_GetGrade(int score)
        {
            // TODO: Implement logic to return grade
            // Example: Debug.Log("A");
            //throw new System.NotImplementedException();
            if (score >= 80)
            {
                Debug.Log("A");
            }
            else if (score >= 70)
            {
                Debug.Log("B");
            }
            else if (score >= 60)
            {
                Debug.Log("C");
            }
            else if (score >= 50)
            {
                Debug.Log("D");
            }
            else
            {
                Debug.Log("F");
            }
        }

        public void Lv05_IsLeapYear(int year)
        {
            // TODO: Implement leap year check logic
            // Example: Debug.Log("True");
            //throw new System.NotImplementedException();
            if (year % 400 == 0)
            {
                Debug.Log("True");
            }
            else if (year % 100 == 0)
            {
                Debug.Log("False");
            }
            else if (year % 4 == 0)
            {
                Debug.Log("True");
            }
            else
            {
                Debug.Log("False");
            }
        }

        public void Lv06_Calculate(double num1, char op, double num2)
        {
            // TODO: Implement calculator logic
            // Example: Debug.Log("Result: 42");
            //throw new System.NotImplementedException();

            switch (op)
            {
                case '+':
                    Debug.Log($"Result: {num1 + num2}");
                    break;

                case '-':
                    Debug.Log($"Result: {num1 - num2}");
                    break;

                case '*':
                    Debug.Log($"Result: {num1 * num2}");
                    break;

                case '/':
                    if (num2 == 0)
                        Debug.Log("Error: Cannot divide by zero.");
                    else
                        Debug.Log($"Result: {num1 / num2}");
                    break;

                default:
                    Debug.Log("Invalid operator. Please use +, -, *, or /.");
                    break;
            }
        }

        public void Lv07_GetSeason(int month)
        {
            // TODO: Implement logic to return season
            // Example: Debug.Log("Summer");
            //throw new System.NotImplementedException();
            if (month >= 1 && month <= 12)
            {
                if (month == 12 || month == 1 || month == 2)
                {
                    Debug.Log("It's Winter.");
                }
                else if (month >= 3 && month <= 5)
                {
                    Debug.Log("It's Spring.");
                }
                else if (month >= 6 && month <= 8)
                {
                    Debug.Log("It's Summer.");
                }
                else if (month >= 9 && month <= 11)
                {
                    Debug.Log("It's Fall.");
                }
            }
            else
            {
                Debug.Log("Invalid month number. Please enter a number between 1 and 12.");
            }

        }

        #endregion

        #region Level 2: Moderate

        public void Ex01_PurchasingSystemExample(int quantity, int price, int payment)
        {
            //throw new System.NotImplementedException();
            if (quantity > 0)
            {
                if (payment >= price)
                {
                    Debug.Log("คุณได้รับสินค้าแล้ว");

                    int change = payment - price;
                    if (change > 0)
                    {
                        Debug.Log($"คุณได้รับเงินทอน {change} บาท");
                    }
                }
                else
                {
                    Debug.Log("คุณมีเงินไม่พอ");
                }
            }
            else
            {
                Debug.Log("สินค้าหมด");
            }
        }

        public void Ex02_RockPaperScissorsExample(int userChoice, int computerChoice)
        {
            //throw new System.NotImplementedException();
            if (userChoice < 0 || userChoice > 2)
            {
                Debug.Log("กรุณาเลือกเป็นตัวเลขที่ถูกต้อง");
                return;
            }

            // ถ้าเสมอ
            if (userChoice == computerChoice)
            {
                Debug.Log("เสมอ");
            }
            // Logic ชนะ
            else if ((userChoice == 0 && computerChoice == 2) ||   // Rock ชนะ Scissors
                     (userChoice == 1 && computerChoice == 0) ||   // Paper ชนะ Rock
                     (userChoice == 2 && computerChoice == 1))     // Scissors ชนะ Paper
            {
                Debug.Log("คุณชนะ!");
            }
            else
            {
                Debug.Log("คุณแพ้!");
            }
        }

        public void Ex03_CalculateWeaponDamage(string weaponType, int baseDamage)
        {
            // TODO: Add your implementation here
            // Example: AssignmentDebugConsole.Log("result as string");
            //throw new System.NotImplementedException();

            double multiplier = 1.0;
            switch (weaponType?.ToLower())
            {
                case "sword": multiplier = 1.3; break;
                case "axe": multiplier = 1.4; break;
                case "bow": multiplier = 1.2; break;
                case "staff": multiplier = 1.5; break;
                case "dagger": multiplier = 1.1; break;

                default: multiplier = 1.0; break;
            }
            int totalDamage = (int)(baseDamage * multiplier);
            Debug.Log(totalDamage.ToString());
        }

        public void Ex04_DeterminePlayerRank(int score, int completionTime)
        {
            // TODO: Add your implementation here
            // Example: AssignmentDebugConsole.Log("result as string");
            // throw new System.NotImplementedException();

            if (score < 0 || completionTime < 0)
            {
                Debug.Log("Invalid score or time");
                return;
            }

            string rank;
            int baseCoins;

            if (score >= 8000)
            {
                rank = "Gold"; baseCoins = 100;
            }
            else if (score >= 6000)
            {
                rank = "Silver"; baseCoins = 75;
            }
            else if (score >= 4000)
            {
                rank = "Bronze"; baseCoins = 50;
            }
            else
            {
                rank = "Participation"; baseCoins = 25;
            }

            int timeBonus = 0;
            if (completionTime <= 30)
            {
                timeBonus = 25;
            }
            else if (completionTime <= 60)
            {
                timeBonus = 10;
            }

            int totalCoins = baseCoins + timeBonus;
            {

            }

            Debug.Log($"{rank} Rank - {totalCoins} coins earned!");
        
        }

        #endregion

    }
}
