using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week3Challenge3 : MonoBehaviour
{
    
    //Value user puts in to see what they will recieve.
    public int AmountToBePaid;
    //The amount of this dollar bill
    private int OneHundred, Fifty, Twenty, Ten, Five, One;

    //A string variable for each bill to alow for plurals (you can expect 1 fifty || you can expect 2 fifties)
    //This is not essential for the program to run but will polish the output.
    private string NHundred = " hundred";
    private string NFifty = " fifty";
    private string NTwenty = " twenty";
    private string NTen = " ten";
    private string NFive = " five";
    private string NOne = " one";

    void Start()
    {
        Hundreds:    //This line here will be the starting point for goto, it continuosly subtracts 100s until the total to be paid
                     //is not divisible by 100.  Convention is plural of the bill name.
        if (AmountToBePaid >= 100)
        {
            AmountToBePaid -= 100;
            OneHundred++;
            //Debug.Log("Number of hundreds: " + OneHundred);
            goto Hundreds;
        }


        Fifties:  //Same as the Hundred line before, and this will be repeated for every bill.
        if(AmountToBePaid >= 50)
        {
            AmountToBePaid -= 50;
            Fifty++;
            //Debug.Log("Number of fifties:" + Fifty);
            goto Fifties;
        }
        //Debug.Log(AmountToBePaid);


        Twenties:
        if(AmountToBePaid >= 20)
        {
            AmountToBePaid -= 20;
            Twenty++;
            //Debug.Log("Number of twenties:" + Twenty);
            goto Twenties;
        }
        //Debug.Log(AmountToBePaid);


        Tens:
        if(AmountToBePaid >= 10)
        {
            AmountToBePaid -= 10;
            Ten++;
            //Debug.Log("Number of tens:" + Ten);
            goto Tens;
        }
        //Debug.Log(AmountToBePaid);
    

        Fives:
        if(AmountToBePaid >= 5)
            {
                AmountToBePaid -= 5;
                Five++;
                goto Fives;
            }


        Ones:
        if(AmountToBePaid >= 1)
            {
                AmountToBePaid -= 1;
                One++;
                //Debug.Log("Number of ones:" + One);
                goto Ones;
            }
            //Debug.Log("Amount to be paid " + AmountToBePaid);

            //Calling the function to change the names of the bills to account for plurals.  *Not essential, just polish!
            NHundred = naming(NHundred, OneHundred);
            NFifty = naming(NFifty, Fifty);
            NTwenty = naming(NTwenty, Twenty);
            NTen = naming(NTen, Ten);
            NFive = naming(NFive, Five);
            NOne = naming(NOne, One);
            
            //The final output
            Debug.Log("You can expect " + OneHundred + NHundred + ", "  + Fifty + NFifty + ", " + Twenty + NTwenty + ", " + Ten + NTen + ", " + Five + NFive + ", and " + One + NOne);
    }

    string naming(string name, int bill)
        {
            int Y = name.IndexOf('y');
            if(bill != 1)  //If there is more than one of these bills, then make it plural.
            {
                 if(Y == -1)
                {
                    name = name + "s";  
                }
                else
                {
                    name = name.Replace("y", "ies");
                }
            }
            return name;
        } 
}