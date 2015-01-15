using System;

class BankAccountData
{
    
    static void Main()
    {
        string firstName = "Rosen";
        string middleName = "Stoyanov";
        string lastName = "Kolev";
        long bankCount = 23231313132;
        string bankName = "WesternUnion";
        string iban = "2rrqeeww";
        object firstCardNumber = "NABCD1234";
        object secondCardNumber = "MABCD1234";
        object thirdNumber = "LABCD1234";

        Console.WriteLine(" First Name: {0} \n Middle Name: {1} \n Last Name: {2} \n Bank Count: {3} \n Bank Name: {4} \n IBAN: {5} \n First card number: {6} \n Second card number: {7} \n Third card number: {8}"
            , firstName, middleName, lastName, bankCount, bankName, iban, firstCardNumber, secondCardNumber, thirdNumber);
    }
}

