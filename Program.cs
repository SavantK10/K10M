using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First Program
            //Console.WriteLine("Hello. This is my first line of code");


            //Console.WriteLine("Please enter your name");
            //string guestName = Console.ReadLine();

            //Console.WriteLine("Thank you " + guestName);

            #endregion

            #region Data Types

            //int favNum1 = 10;
            //string firstName = "Kuavo";
            //bool isPermanentEmployee = true;
            //double height = 6.35;

            //Console.WriteLine("Enter First Number");
            //int firstNum = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Second Number");
            //int secondNum = Convert.ToInt32(Console.ReadLine());

            //int addition = firstNum + secondNum;
            //int subtraction = firstNum - secondNum;
            //int multiplication = firstNum * secondNum;
            //int division = firstNum / secondNum;

            //Console.WriteLine("Addition of your numbers are : " + addition);
            //Console.WriteLine("Subtraction of your numbers are : " + subtraction);
            //Console.WriteLine("Multiplication of your numbers are : " + multiplication);
            //Console.WriteLine("Division of your numbers are : " + division);

            ////if you want the user to terminate the program add this line
            //Console.ReadLine();
            ////if you want the program to terminate on its own, you do not need to put anything
            #endregion

            #region conditions

            #region Simple IF condition
            //Console.WriteLine("Please enter a number");
            //int num = Convert.ToInt32(Console.ReadLine());

            //if (num >= 0)
            //{
            //    Console.WriteLine("Good and a Positive Number");

            //}
            //else
            //{
            //    Console.WriteLine("Bad and it is a negative number");
            //}

            //Console.ReadLine();


            #endregion

            //Console.WriteLine("Enter a Positive Number");
            //int num = Convert.ToInt32(Console.ReadLine());

            //if (num < 0)
            //{
            //    Console.WriteLine("Bad number");
            //}
            //else if (num > 0 && num <= 10)
            //{
            //    Console.WriteLine("Good Number");
            //}
            //else if (num > 0 && num <= 20)
            //{
            //    Console.WriteLine("Very good number");
            //}
            //else if (num > 0 && num <= 30)
            //{
            //    Console.WriteLine("Excellent Number");
            //}
            //else
            //{
            //    Console.WriteLine("Number is greater than Excellent");
            //}

            //Console.ReadLine();

            #endregion

            #region Login

            //Console.WriteLine("~~~~~~~~~~~ Welcome to DBD~~~~~~~~~~~~~");
            //Console.WriteLine("Enter User Name");
            //string username = Console.ReadLine();

            //Console.WriteLine("Enter Password");
            //string password = Console.ReadLine();

            //if (username == "Kuavo" && password == "TooNiceBruh")
            //{
            //    Console.WriteLine("Login Successful!!");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Credentials");
            //}
            //Console.ReadLine();

            #endregion

            #region Switch Case Actual Banking App Demo 
            Console.WriteLine("!!!~~~~~~~~~~~~~~~~~~ Welcome to Trippie Redd Bank ~~~~~~~~~~~~~~~~!!!");
            Console.WriteLine("1. Open a new Acount");
            Console.WriteLine("2. Withdraw Funds");
            Console.WriteLine("3. Deposit Funds");
            Console.WriteLine("4. Wire Funds");
            Console.WriteLine("5. View past transactions");
            Console.WriteLine("6. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                #region 1. Open an Account and Personal Details
                case 1:
                    Console.WriteLine("Enter Last Name for the Account");
                    string lastName = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Thanks, Enter your correct pronoun. Try 'He', 'She', or 'They' please.");
                    string userPronoun = Convert.ToString(Console.ReadLine());
                    if (userPronoun == "He")
                    {
                        Console.WriteLine("Thanks Mr. " + lastName);
                    }
                    else if (userPronoun == "She")
                    {
                        Console.WriteLine("Thanks Ms. " + lastName);
                    }
                    else if (userPronoun == "They")
                    {
                        Console.WriteLine("Thanks, we will use " + userPronoun + " your pronoun");
                    }
                    else
                    {
                        Console.WriteLine("Please Enter one of the provided prnouns ");
                        Console.WriteLine("Enter your correct pronoun. Try 'He', 'She', or 'They' please.");
                        userPronoun = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Thanks your pronoun is now: " + userPronoun);
                    }

                    Console.WriteLine("Enter First Name for the Account");
                    string firstName = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Thanks, so far we have your pronoun as : " + userPronoun + " and your name as " + firstName + " " + lastName);
                    Console.WriteLine("Next lets add some personal details");
                    Console.WriteLine("Are you over 18 years old? Type 'y' for Yes or 'n' for No");
                    string underMinAge = Convert.ToString(Console.ReadLine());
                    if (underMinAge == "n")
                    {
                        Console.WriteLine("Sorry, to make an account you must be 18 years or older. Come back when you are of proper age");
                        Console.WriteLine("Thank you for your interest in Trippie Redd Bank, we look forward to growing with you!");
                    }
                    else
                    {
                        Console.WriteLine("Are you over 21 years old? Type 'y' for Yes or 'n' for No");
                        string underAdultAge = Convert.ToString(Console.ReadLine());
                        if (underAdultAge == "n")
                        {
                            Console.WriteLine("Since you are over 18 years old but under 21, you need an older adult to finish setting up a Junior account at a local branch.");
                            Console.WriteLine("Let's go to the next step, just keep that in mind when banking in the future.");
                        }
                    }
                        Console.WriteLine("Just some verification. Now enter your actual age using numbers");
                        int actualAge = Convert.ToInt32(Console.ReadLine());
                    if (actualAge > 99 )
                    {
                        Console.WriteLine("Wow! Thank you " + userPronoun + lastName + "We are grateful for your business, here's to another 100 years!");
                    }
                        Console.WriteLine("Would you like to add a phone number to your account? Type 'y' for Yes or 'n' for No. You can add a phone number at a future time.");
                        string addingPhoneNow = Convert.ToString(Console.ReadLine());
                    if (addingPhoneNow == "y")
                    {
                        Console.WriteLine("Alright, enter your ten-digit phone number. Don't worry about dashes, just numbers please");
                        long numericPhoneNow = Convert.ToInt64(Console.ReadLine());
                       
                    }
                    else
                    {
                        Console.WriteLine("Alright, you can add a phone number later");
                    }
                    Console.WriteLine("Thanks, if you entered a phone number, Please confirm it by repeating it once more");
                    Console.WriteLine("Otherwise just hit enter");
                    long numericPhoneNumber = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Lastly, lets record a few details about your place of residence");
                    Console.WriteLine("Do you live in the area that you are opening this acccount in? Type 'y' for Yes or 'n' for No");
                    string verifyArea = Convert.ToString(Console.ReadLine());
                    if (verifyArea == "n")
                    {
                        Console.WriteLine("That's alright. First type the full name of the city that you live in");
                        string verifyCity = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Thanks. Next type the full name of the state you live in");
                        string verifyState = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("So far we have your area of residence as : " + verifyCity + "," + verifyState);
                    }
                    
                    else if (verifyArea == "y")
                    {
                        
                        verifyArea = "Local Business";
                   
                        Console.WriteLine("Great! We are grateful for your local business");
                    }
                    Console.WriteLine("Confirm you area of residence once again. Please repeat the city name");
                    string validCity = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Thank you. Next repeat the name of the state");
                    string validState = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("|");

                    Console.WriteLine("How much would you like to deposit for a starting balance? A Junior account can start with $5 minimum");
                    double startBal = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("To Confirm, you would like to deposit $" + startBal);
                    Console.WriteLine("Type 'y' for Yes or 'n' for No.");
                    string confStartBal = Console.ReadLine();
                    if (confStartBal == "y")
                    {
                        Console.WriteLine("Thanks! That was the last step for setting up your account in Trippie Redd Bank app");
                    }
                    else
                    {
                        Console.WriteLine("Okay.Let's try that again. How much would you like to deposit for a starting balance? A Junior account can start with $5 minimum");
                        double newStartBal = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("To Confirm, you would like to deposit $" + newStartBal);
                        Console.WriteLine("Type 'y' for Yes");
                        string confNewBal = Console.ReadLine();
                    }
                    Console.WriteLine("Alright.");
                    Console.WriteLine("|");
                    Console.WriteLine("Thanks for these details, here's a review of the information recorded thus far: ");
                    Console.WriteLine("Your name is : " + userPronoun + " " + firstName  + " " + lastName);
                    Console.WriteLine("Your age is : " + actualAge);
                    Console.WriteLine("Your area of residence : " + validCity + "," + validState);
                    Console.WriteLine("Your phone number is : " + numericPhoneNumber);
                    break;
                #endregion
                
                #region 2. Withdrawal Function                
                case 2:
                    Console.WriteLine("Haha, very good choice there! How are you able to make an online withdrawal? Not in this app, try it at your local branch.");
                    
                    #region Actual withdrawal feature
                    //Console.WriteLine("Enter Amount to withdraw");
                    //int withdAmount = Convert.ToInt32(Console.ReadLine());
                    //Console.WriteLine("To confirm, you would like to withdraw " + withdAmount + " from your Account ?");
                    //Console.WriteLine("Type 'y' for Yes or 'n' for No");
                    //string withdConfirm = Console.ReadLine();
                    //Console.WriteLine("Withdrawal of $" + withAmount + " is successful");
                    #endregion
                    
                    break;

                #endregion

                #region 3. Deposit Function
                case 3:
                    Console.WriteLine("Enter amount to deposit");
                    int depoAmount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("How would you like to deposit $" + depoAmount + "?");
                    Console.WriteLine("1. Type 'card' to use another card not associated with your account");
                    Console.WriteLine("2. Type 'check' to deposit using a personal check or one from another bank");
                    string depoType = Convert.ToString(Console.ReadLine());
                    switch (depoType)
                    {
                        case 1:
                          depoType == "card";
                          Console.WriteLine("Enter Card number with no spaces below")
                          long depoCardNum = Convert.ToInt64(Console.ReadLine());
                          Console.WriteLine("Next Enter Expiration date as month-year combo, numbers only");
                          Console.WriteLine("|");
                          Console.WriteLine("Ex: 0223")
                          int depoCardExpr = Convert.ToInt32(Console.ReadLine());
                          Console.WriteLine("To confirm you would like to deposit $" + depoAmount)
                          Console.WriteLine("Using card number : " + depoCardNum + " with expiration date of " + depoCardExpr);
                          Console.WriteLine("Type 'y' to confirm");
                          string depoConfirm = Console.ReadLine();
                        break;

                        default:
                            depoType == "check";
                            Console.WriteLine("Stay tuned for the next update, we will be adding mobile depositing features for checks very soon!");
                        break;
                    }
                    Console.WriteLine("To confirm once again you would like to deposit $" + depoAmount + " into your Account ?");
                    Console.WriteLine("Deposit of $" + depoAmount + "is successful");
                    break;
                #endregion

                #region 4. Wire Transfer
                case 4:
                    Console.WriteLine("Enter amount to transfer");
                    double transfAmount = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter Account Number you would like to transfer to, numbers only");
                    long transfAccount = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("|");
                    Console.WriteLine("To confirm, you would like to transfer " + transfAmount + " to Account No: " + transfAccount " ?");
                    Console.WriteLine("Type 'y' for Yes or 'n' for No");
                    string transfConfirm = Console.ReadLine();
                    switch (transConfirm)
                    {
                        case 1: transfConfirm == "y"
                        Console.WriteLine("Thanks.");
                        Console.WriteLine("|");
                        Console.WriteLine("Wire Funds processing.......");
                        Console.WriteLine("|");
                        Console.WriteLine("|");
                        Console.WriteLine("Funds Transferred");                        
                        break;

                        default: transfConfirm == "n"
                        Console.WriteLine("Okay, lets try again");
                        Console.WriteLine("Enter amount to transfer");
                        double newTransfAmount = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter Account Number you would like to transfer to, numbers only");
                        long newTransfAccount = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("To confirm, you would like to transfer " + newTransfAmount + " to Account No: " + newTransfAccount " ?");
                        Console.WriteLine("Type 'y' for Yes");
                        string newTransfConfirm = Console.ReadLine();
                        Console.WriteLine("Thanks");
                        break;
                    }

                    break;

                #endregion

                #region 5. Transaction History 
                case 5:
                    Console.WriteLine("How many transactions would you like to see? Enter a number");
                    Console.WriteLine("Choose up to ten transactions");
                    int transacHistoryChoice = Console.ReadLine();
                    transacHistoryChoice = x;
                    for (x = 0; x < 5; x++)
                    {
                        Console.WriteLine("This is the information for your first transaction: " + "Your have no transactions as your account is new.");
                        transacHistoryChoice++
                    }
                  
                    break;
                #endregion

                #region 6. Exit from program or choose other option
                case 6:
                    Console.WriteLine("Thank you for being with us.");
                    break;
                default:
                    Console.WriteLine("Sorry. Choose another option");
                    break;
            }

                #endregion


        }

    }
}


