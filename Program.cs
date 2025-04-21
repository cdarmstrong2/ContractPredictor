using System.Data;
using System.Formats.Asn1;

MainMenu();

static void MainMenu() {
    string value = "1";
    while (value != null) {
        Console.Clear();
        Console.WriteLine("Welcome to the NFL Player Contract Predictor!");
        Console.WriteLine("Where do you want to go?");
        Console.WriteLine("1 = Stats, 2 = Salary, 3 = Contract Prediction, or 4 = Exit.");
        
        string choice = Console.ReadLine();

        if (choice == "1") {
            Stats();
        }
        else if (choice == "2") {
            Salary();
        }
        else if (choice == "3") {
            Predictions();
        }
        else if (choice == "4") {
            value = null;
        }
        else {
            Console.WriteLine("Invalid Input. Try Again.");
            Console.ReadKey();
        }
    }
}


static void Stats(){
    Console.Clear();
    System.Console.WriteLine("Welcome to the Stats page!");
    System.Console.WriteLine("Please enter one of the following values to produce the top players of that position:");
    System.Console.WriteLine("\t1 = Quarterback");
    System.Console.WriteLine("\t2 = Reciever");
    System.Console.WriteLine("\t3 = Tightend");
    System.Console.WriteLine("\t4 = Runningback");
    System.Console.WriteLine("\t5 = Defensive Edge");
    System.Console.WriteLine("\tOr enter -1 to return to the Main Menu!");
    string input = Console.ReadLine();
    while( input != "-1"){    
        switch(input){
            case "1":
                QuarterBackStats();
            break;
            case "2":
                WideRecieverStats();
            break;
            case "3":
                TightendStats();
            break;
            case "4":
                RunningbackStats();
            break;
            case "5":
                DefensiveEndStats();
            break;
            default:
                MainMenu();
            break;
        }

       System.Console.WriteLine("Welcome to the Stats page!");
        System.Console.WriteLine("Please enter one of the following values to produce the top players of that position:");
        System.Console.WriteLine("\t1 = Quarterback");
        System.Console.WriteLine("\t2 = Reciever");
        System.Console.WriteLine("\t3 = Tightend");
        System.Console.WriteLine("\t4 = Runningback");
        System.Console.WriteLine("\t5 = Defensive Edge");
        System.Console.WriteLine("\tOr enter -1 to return to the Main Menu!");
        input = Console.ReadLine();
    }
    MainMenu();
}

static void QuarterBackStats(){
    StreamReader inFile = new StreamReader("QB.txt");
    string line = inFile.ReadLine();
    while (line != null){
        System.Console.WriteLine($"{line}\n");
        line = inFile.ReadLine();


    }
    inFile.Close();
}

static void WideRecieverStats(){
    StreamReader inFile = new StreamReader("WR.txt");
    string line = inFile.ReadLine();
    while (line != null){
        System.Console.WriteLine($"{line}\n");
        line = inFile.ReadLine();


    }
    inFile.Close();
}

static void TightendStats(){
    StreamReader inFile = new StreamReader("TE.txt");
    string line = inFile.ReadLine();
    while (line != null){
        System.Console.WriteLine($"{line}\n");
        line = inFile.ReadLine();


    }
    inFile.Close();
}

static void RunningbackStats(){
    StreamReader inFile = new StreamReader("RB.txt");
    string line = inFile.ReadLine();
    while (line != null){
        System.Console.WriteLine($"{line}\n");
        line = inFile.ReadLine();


    }
    inFile.Close();
}

static void DefensiveEndStats(){
    StreamReader inFile = new StreamReader("DE.txt");
    string line = inFile.ReadLine();
    while (line != null){
        System.Console.WriteLine($"{line}\n");
        line = inFile.ReadLine();


    }
    inFile.Close();
}

static void Salary(){
    Console.Clear();
    System.Console.WriteLine("Welcome to the Salaries page!");
    TopTenSalaries();
    System.Console.WriteLine("Please enter one of the following values to produce the top salaries for that position:");
    System.Console.WriteLine("\t1 = Quarterback");
    System.Console.WriteLine("\t2 = Reciever");
    System.Console.WriteLine("\t3 = Tightend");
    System.Console.WriteLine("\t4 = Runningback");
    System.Console.WriteLine("\t5 = Defensive Edge");
    System.Console.WriteLine("\tOr enter -1 to return to the Main Menu!");
    string input = Console.ReadLine();
    while( input != null){
        
        switch(input){
            case "1":
                QuarterBackSalary();
            break;
            case "2":
                WideRecieverSalary();
            break;
            case "3":
                TightendSalary();
            break;
            case "4":
                RunningbackSalary();
            break;
            case "5":
                DefensiveEndSalary();
            break;
            default:
                MainMenu();
            break;
        }
        System.Console.WriteLine("Welcome to the Salaries page!");
        TopTenSalaries();
        System.Console.WriteLine("Please enter one of the following values to produce the top salaries for that position:");
        System.Console.WriteLine("\t1 = Quarterback");
        System.Console.WriteLine("\t2 = Reciever");
        System.Console.WriteLine("\t3 = Tightend");
        System.Console.WriteLine("\t4 = Runningback");
        System.Console.WriteLine("\t5 = Defensive Edge");
        System.Console.WriteLine("\tOr enter -1 to return to the Main Menu!");
        input = Console.ReadLine();
    }
    MainMenu();
}

static void TopTenSalaries(){
    StreamReader inFile = new StreamReader("TopTenSalaries.txt");
    string line = inFile.ReadLine();
    while (line != null){
        System.Console.WriteLine($"{line}\n");
        line = inFile.ReadLine();


    }
    inFile.Close();
}

static void QuarterBackSalary(){
    StreamReader inFile = new StreamReader("QBMoney.txt");
    string line = inFile.ReadLine();
    while (line != null){
        System.Console.WriteLine($"{line}\n");
        line = inFile.ReadLine();


    }
    inFile.Close();
}

static void WideRecieverSalary(){
    StreamReader inFile = new StreamReader("WRMoney.txt");
    string line = inFile.ReadLine();
    while (line != null){
        System.Console.WriteLine($"{line}\n");
        line = inFile.ReadLine();


    }
    inFile.Close();

}

static void TightendSalary(){
    StreamReader inFile = new StreamReader("TEMoney.txt");
    string line = inFile.ReadLine();
    while (line != null){
        System.Console.WriteLine($"{line}\n");
        line = inFile.ReadLine();


    }
    inFile.Close();

}

static void RunningbackSalary(){
    StreamReader inFile = new StreamReader("RBMoney.txt");
    string line = inFile.ReadLine();
    while (line != null){
        System.Console.WriteLine($"{line}\n");
        line = inFile.ReadLine();


    }
    inFile.Close();

}

static void DefensiveEndSalary(){
    StreamReader inFile = new StreamReader("DEMoney.txt");
    string line = inFile.ReadLine();
    while (line != null){
        System.Console.WriteLine($"{line}\n");
        line = inFile.ReadLine();


    }
    inFile.Close();

}


static void Predictions(){
    Console.Clear();
    System.Console.WriteLine("Welcome to the contract predictor!");
    System.Console.WriteLine("Please enter one of the following values to predict a contract for that position:");
    System.Console.WriteLine("\t1 = Quarterback");
    System.Console.WriteLine("\t2 = Reciever");
    System.Console.WriteLine("\t3 = Tightend");
    System.Console.WriteLine("\t4 = Runningback");
    System.Console.WriteLine("\t5 = Defensive Edge");
    System.Console.WriteLine("\tOr enter -1 to return to the Main Menu!");
    string input = Console.ReadLine();
    while( input != null){
        
        switch(input){
            case "1":
                QuarterBacks();
            break;
            case "2":
                WideRecievers();
            break;
            case "3":
                Tightends();
            break;
            case "4":
                Runningbacks();
            break;
            case "5":
                DefensiveEnds();
            break;
            default:
                MainMenu();
            break;
        }

    }

}


static void QuarterBacks(){
    System.Console.WriteLine("What is the name of this quarterback?");
    string name = Console.ReadLine();
    System.Console.WriteLine("How many years has this Quarterback played in the NFL?");
    int years = int.Parse(Console.ReadLine());
    double quarterBackValue = 0;
    System.Console.WriteLine("How old is this Quarterback?");
    int age = int.Parse(Console.ReadLine());
    if (age != 0){
        if(name != "Tom Brady"){
        if(age >= 45){
            quarterBackValue -= 20;
            System.Console.WriteLine("Would highly recommend you do not sign this player.");
        }
        if (age >= 40){
            quarterBackValue -= 10;
        }
        else if (age >= 35){
            quarterBackValue -= 5;
        }
        else if(age >= 30){
            quarterBackValue -= 2;
        }
        else if( age >= 27){
            quarterBackValue += 0;
        }
        else if(age >= 20){
            quarterBackValue += 2;
        }
        else{
            quarterBackValue += 2;
        }
        }
        else{
            System.Console.WriteLine("Give the GOAT whaterver he wants!");
            MainMenu();
        }
        
    }
    System.Console.WriteLine("Please get ready to enter some statistics for this Quarterback.");
    System.Console.WriteLine("Please enter how many passing yards this quarterback had 3 years ago:");
    int passingYards3 = int.Parse(Console.ReadLine());
    
    int contactYears;
    double contractTotal;
    double yearlyAvg;
    if(passingYards3 >= 5000){
        quarterBackValue += 10;
    }
    else if(passingYards3 >= 4000){
        quarterBackValue += 8;
    }
    else if(passingYards3 >= 3000){
        quarterBackValue += 6;
    }
    else if(passingYards3 >= 2000){
        quarterBackValue += 4;

    }
    else if(passingYards3 >= 1000){
        quarterBackValue += 2;
    }
    else{
        quarterBackValue += 1;
    }
    System.Console.WriteLine("Please enter how many passing yards this quarterback had 2 years ago:");
    int passingYards2 = int.Parse(Console.ReadLine());
    if(passingYards2 >= 5000){
        quarterBackValue += 10;
    }
    else if(passingYards2 >= 4000){
        quarterBackValue += 8;
    }
    else if(passingYards2 >= 3000){
        quarterBackValue += 6;
    }
    else if(passingYards2 >= 2000){
        quarterBackValue += 4;

    }
    else if(passingYards2 >= 1000){
        quarterBackValue += 2;
    }
    else{
        quarterBackValue += 1;
    }
    System.Console.WriteLine("Please enter how many passing yards this quarterback had this past year:");
    int passingYards1 = int.Parse(Console.ReadLine());
    if(passingYards1 >= 5000){
        quarterBackValue += 10;
    }
    else if(passingYards1 >= 4000){
        quarterBackValue += 8;
    }
    else if(passingYards1 >= 3000){
        quarterBackValue += 6;
    }
    else if(passingYards1 >= 2000){
        quarterBackValue += 4;

    }
    else if(passingYards1 >= 1000){
        quarterBackValue += 2;
    }
    else{
        quarterBackValue += 1;
    }
    System.Console.WriteLine("Please enter how many rushing yards this Quarterback had 3 years ago:");
    int rushingYards3 = int.Parse(Console.ReadLine());
    if(rushingYards3 >= 1500){
        quarterBackValue += 5;
    }
    else if(rushingYards3 >= 1000){
        quarterBackValue += 4;
    }
    else if(rushingYards3 >= 700){
        quarterBackValue += 3;
    }
    else if(rushingYards3 >= 500){
        quarterBackValue += 2;

    }
    else if(rushingYards3 >= 100){
        quarterBackValue += 1;
    }
    else{
        quarterBackValue += 0.5;
    }
    System.Console.WriteLine("Please enter how many rushing yards this Quarterback had 2 years ago:");
    int rushingYards2 = int.Parse(Console.ReadLine());
    if(rushingYards2 >= 1500){
        quarterBackValue += 5;
    }
    else if(rushingYards2 >= 1000){
        quarterBackValue += 4;
    }
    else if(rushingYards2 >= 700){
        quarterBackValue += 3;
    }
    else if(rushingYards2 >= 500){
        quarterBackValue += 2;

    }
    else if(rushingYards2 >= 100){
        quarterBackValue += 1;
    }
    else{
        quarterBackValue += 0.5;
    }
    System.Console.WriteLine("Please enter how many rushing yards this Quarterback had this past year:");
    int rushingYards1 = int.Parse(Console.ReadLine());
    if(rushingYards1 >= 1500){
        quarterBackValue += 5;
    }
    else if(rushingYards1 >= 1000){
        quarterBackValue += 4;
    }
    else if(rushingYards1 >= 700){
        quarterBackValue += 3;
    }
    else if(rushingYards1 >= 500){
        quarterBackValue += 2;

    }
    else if(rushingYards1 >= 100){
        quarterBackValue += 1;
    }
    else{
        quarterBackValue += 0.5;
    }
    System.Console.WriteLine("Please enter this Quarterbacks completion percentage from 3 years ago:");
    int completionPercentage3 = int.Parse(Console.ReadLine());
    if(completionPercentage3 >= 90){
        quarterBackValue += 10;
    }
    else if(completionPercentage3 >= 75){
        quarterBackValue += 8;
    }
    else if(completionPercentage3 >= 50){
        quarterBackValue += 6;
    }
    else if(completionPercentage3 >= 30){
        quarterBackValue += 4;

    }
    else if(completionPercentage3 >= 10){
        quarterBackValue += 2;
    }
    else{
        quarterBackValue += 1;
    }
    System.Console.WriteLine("Please enter this Quarterbacks completion percentage from 2 years ago:");
    int completionPercentage2 = int.Parse(Console.ReadLine());
    if(completionPercentage2 >= 90){
        quarterBackValue += 10;
    }
    else if(completionPercentage2 >= 75){
        quarterBackValue += 8;
    }
    else if(completionPercentage2 >= 50){
        quarterBackValue += 6;
    }
    else if(completionPercentage2 >= 30){
        quarterBackValue += 4;

    }
    else if(completionPercentage2 >= 10){
        quarterBackValue += 2;
    }
    else{
        quarterBackValue += 1;
    }
    System.Console.WriteLine("Please enter this Quarterbacks completion percentage from this past year:");
    int completionPercentage1 = int.Parse(Console.ReadLine());
    if(completionPercentage1 >= 90){
        quarterBackValue += 10;
    }
    else if(completionPercentage1 >= 75){
        quarterBackValue += 8;
    }
    else if(completionPercentage1 >= 50){
        quarterBackValue += 6;
    }
    else if(completionPercentage1 >= 30){
        quarterBackValue += 4;

    }
    else if(completionPercentage1 >= 10){
        quarterBackValue += 2;
    }
    else{
        quarterBackValue += 1;
    }

    System.Console.WriteLine("How many touchdowns did this Quarterback have 3 years ago:");
    int touchdownsThrown3 = int.Parse(Console.ReadLine());
    if(touchdownsThrown3 >= 55){
        quarterBackValue += 10;
    }
    else if(touchdownsThrown3 >= 45){
        quarterBackValue += 8;

    }
    else if(touchdownsThrown3 >= 35){
        quarterBackValue += 6;
    }
    else if(touchdownsThrown3 >= 25){
        quarterBackValue += 4;
    }
    else if(touchdownsThrown3 >= 15){
        quarterBackValue += 2;
    }
    else if( touchdownsThrown3 >= 5){
        quarterBackValue += 1;
    }
    else{
        quarterBackValue += 0.5;
    }

    System.Console.WriteLine("How many touchdowns did this Quarterback have 2 years ago:");
    int touchdownsThrown2 = int.Parse(Console.ReadLine());
    if(touchdownsThrown2 >= 55){
        quarterBackValue += 10;
    }
    else if(touchdownsThrown2 >= 45){
        quarterBackValue += 8;

    }
    else if(touchdownsThrown2 >= 35){
        quarterBackValue += 6;
    }
    else if(touchdownsThrown2 >= 25){
        quarterBackValue += 4;
    }
    else if(touchdownsThrown2 >= 15){
        quarterBackValue += 2;
    }
    else if( touchdownsThrown2 >= 5){
        quarterBackValue += 1;
    }
    else{
        quarterBackValue += 0.5;
    }

    System.Console.WriteLine("How many touchdowns did this Quarterback have this past year:");
    int touchdownsThrown1 = int.Parse(Console.ReadLine());
    if(touchdownsThrown1 >= 55){
        quarterBackValue += 10;
    }
    else if(touchdownsThrown1 >= 45){
        quarterBackValue += 8;

    }
    else if(touchdownsThrown1 >= 35){
        quarterBackValue += 6;
    }
    else if(touchdownsThrown1 >= 25){
        quarterBackValue += 4;
    }
    else if(touchdownsThrown1 >= 15){
        quarterBackValue += 2;
    }
    else if( touchdownsThrown1 >= 5){
        quarterBackValue += 1;
    }
    else{
        quarterBackValue += 0.5;
    }

    System.Console.WriteLine("How many interceptions did this Quarterback have 3 years ago?");
    int interceptionsthrown3 = int.Parse(Console.ReadLine());
    if(interceptionsthrown3 >= 50){
        quarterBackValue -= 6;
    }
    else if(interceptionsthrown3 >= 40){
        quarterBackValue -= 5;
    }
    else if(interceptionsthrown3 >= 30){
        quarterBackValue -= 4;
    }
    else if(interceptionsthrown3 >= 20){
        quarterBackValue -= 3;
    }
    else if(interceptionsthrown3 >= 15){
        quarterBackValue -= 2;
    }
    else if(interceptionsthrown3 >= 10){
        quarterBackValue -= 1;
    }
    else if(interceptionsthrown3 >= 5){
        quarterBackValue -= 0.5;
    }
    else{
        quarterBackValue -= 0;
    }
    System.Console.WriteLine("How many interceptions did this Quarterback have 2 years ago?");
    int interceptionsthrown2 = int.Parse(Console.ReadLine());
    if(interceptionsthrown2 >= 50){
        quarterBackValue -= 6;
    }
    else if(interceptionsthrown2 >= 40){
        quarterBackValue -= 5;
    }
    else if(interceptionsthrown2 >= 30){
        quarterBackValue -= 4;
    }
    else if(interceptionsthrown2 >= 20){
        quarterBackValue -= 3;
    }
    else if(interceptionsthrown2 >= 15){
        quarterBackValue -= 2;
    }
    else if(interceptionsthrown2 >= 10){
        quarterBackValue -= 1;
    }
    else if(interceptionsthrown2 >= 5){
        quarterBackValue -= 0.5;
    }
    else{
        quarterBackValue -= 0;
    }
    System.Console.WriteLine("How many interceptions did this Quarterback have this past year?");
    int interceptionsthrown1 = int.Parse(Console.ReadLine());
    if(interceptionsthrown1 >= 50){
        quarterBackValue -= 6;
    }
    else if(interceptionsthrown1 >= 40){
        quarterBackValue -= 5;
    }
    else if(interceptionsthrown1 >= 30){
        quarterBackValue -= 4;
    }
    else if(interceptionsthrown1 >= 20){
        quarterBackValue -= 3;
    }
    else if(interceptionsthrown1 >= 15){
        quarterBackValue -= 2;
    }
    else if(interceptionsthrown1 >= 10){
        quarterBackValue -= 1;
    }
    else if(interceptionsthrown1 >= 5){
        quarterBackValue -= 0.5;
    }
    else{
        quarterBackValue -= 0;
    }

    System.Console.WriteLine("How many Super Bowls (if any) has this Quarterback play in?");
    int superBowlsPlayed = int.Parse(Console.ReadLine());

    if (superBowlsPlayed != 0){
        quarterBackValue += superBowlsPlayed * 5;
        System.Console.WriteLine("How many of these Super Bowls (if any) did this Quarterback win?");
        int superBowlsWon = int.Parse(Console.ReadLine());
        if(superBowlsPlayed != 0){
            quarterBackValue += superBowlsWon * 10;
        }
    }

    System.Console.WriteLine("How many years would you like to sign this contract:");
    int contractInput = int.Parse(Console.ReadLine());
    
    if (quarterBackValue >= 75){
        yearlyAvg = 50000000;
        contractTotal = contractInput * yearlyAvg;
    }
    else if (quarterBackValue >= 65){
        yearlyAvg = 45000000;
        contractTotal = contractInput * yearlyAvg;
        
    }
    else if( quarterBackValue >= 55){
        yearlyAvg = 40000000;
        contractTotal = contractInput * yearlyAvg;
        
    }
    else if( quarterBackValue >= 45){
        yearlyAvg = 30000000;
        contractTotal = contractInput * yearlyAvg;
        
    }
    else if( quarterBackValue >= 35){
        yearlyAvg = 21000000;
        contractTotal = contractInput * yearlyAvg;
        
    }
    else if(quarterBackValue >= 25){
        yearlyAvg = 15000000;
        contractTotal = contractInput * yearlyAvg;
        
    }
    else if (quarterBackValue >= 15){
        yearlyAvg = 11000000;
        contractTotal = contractInput * yearlyAvg;
        
    }
    else if (quarterBackValue >= 10){
        yearlyAvg = 6500000;
        contractTotal = contractInput * yearlyAvg;
        
    }
    else if(quarterBackValue >= 5){
        yearlyAvg = 3500000;
        contractTotal = contractInput * yearlyAvg;
        
    }else{
        yearlyAvg = 1670000;
        contractTotal = contractInput * yearlyAvg;
        
    }
    
    System.Console.WriteLine($"{name} should be signed to a {contractInput} year {contractTotal:C2} deal with {yearlyAvg:C2} paid on average per year.");
    System.Console.WriteLine("Would you like to predict another players contract (yes/no)?");
    string input = Console.ReadLine();
    if (input != "yes"){
        MainMenu();
    }
    else{
        Predictions();
    }
    
    
}

static void WideRecievers(){
    double receiverValue = 0;
    System.Console.WriteLine("What is the name of this Wide Receiver?");
    string name = Console.ReadLine();
    System.Console.WriteLine("How many years has this Wide Receiver played in the NFL?");
    int years = int.Parse(Console.ReadLine());
    if(years <= 2){
        System.Console.WriteLine("This player is too young to predict their next contract.");
    }
    System.Console.WriteLine("How old is this Wide Reciever?");
    int age = int.Parse(Console.ReadLine());
    if(age != 0){
        if(name != "Randy Moss"){
            if(age >= 35){
                receiverValue -= 10;
            }
            else if(age >= 33){
                receiverValue -= 5;
            }
            else if(age >= 29){
                receiverValue -= 3;
            }
            else if(age >= 26){
                receiverValue += 0;
            }
            else{
                receiverValue += 3;
            }


        }
        else{
            System.Console.WriteLine("You just got MOSSED!");
            MainMenu();
        }
    }
    System.Console.WriteLine("Please get ready to enter some statistics for this Wide Receiver.");
    System.Console.WriteLine("Please enter how many receiving yards this Wide Receiver had 3 years ago:");
    int receivingYards3 = int.Parse(Console.ReadLine());
    int contactYears;
    double contractTotal;
    double yearlyAvg;
    if(receivingYards3 >= 1900){
        receiverValue += 10;
    }
    else if(receivingYards3 >= 1700){
        receiverValue += 8;
    }
    else if(receivingYards3 >= 1400){
        receiverValue += 6;
    }
    else if(receivingYards3 >= 1000){
        receiverValue += 4;
    }
    else if(receivingYards3 >= 500){
        receiverValue += 2;
    }
    else{
        receiverValue += 1;
    }
    System.Console.WriteLine("Please enter how many receiving yards this Wide Receiver had 2 years ago:");
    int receivingYards2 = int.Parse(Console.ReadLine());
    if(receivingYards2 >= 1900){
        receiverValue += 10;
    }
    else if(receivingYards2 >= 1700){
        receiverValue += 8;
    }
    else if(receivingYards2 >= 1400){
        receiverValue += 6;
    }
    else if(receivingYards2 >= 1000){
        receiverValue += 4;
    }
    else if(receivingYards2 >= 500){
        receiverValue += 2;
    }
    else{
        receiverValue += 1;
    }
    System.Console.WriteLine("Please enter how many receiving yards this Wide Receiver had this past year:");
    int receivingYards1 = int.Parse(Console.ReadLine());
    if(receivingYards1 >= 1900){
        receiverValue += 10;
    }
    else if(receivingYards1 >= 1700){
        receiverValue += 8;
    }
    else if(receivingYards1 >= 1400){
        receiverValue += 6;
    }
    else if(receivingYards1 >= 1000){
        receiverValue += 4;
    }
    else if(receivingYards1 >= 500){
        receiverValue += 2;
    }
    else{
        receiverValue += 1;
    }

    System.Console.WriteLine("Please enter how many rushing yards this Wide Receiver had 3 years ago:");
    int wideRushingYards3 = int.Parse(Console.ReadLine());
    if(wideRushingYards3 >= 1000){
        receiverValue += 5;
    }
    else if(wideRushingYards3 >= 500){
        receiverValue += 4;
    }
    else if(wideRushingYards3 >= 300){
        receiverValue += 3;
    }
    else if(wideRushingYards3 >= 200){
        receiverValue += 2;
    }
    else if(wideRushingYards3 >= 100){
        receiverValue += 1;
    }
    else{
        receiverValue += 0.5;
    }

    System.Console.WriteLine("Please enter how many rushing yards this Wide Receiver had 2 years ago:");
    int wideRushingYards2 = int.Parse(Console.ReadLine());
    if(wideRushingYards2 >= 1000){
        receiverValue += 5;
    }
    else if(wideRushingYards2 >= 500){
        receiverValue += 4;
    }
    else if(wideRushingYards2 >= 300){
        receiverValue += 3;
    }
    else if(wideRushingYards2 >= 200){
        receiverValue += 2;
    }
    else if(wideRushingYards2 >= 100){
        receiverValue += 1;
    }
    else{
        receiverValue += 0.5;
    }

    System.Console.WriteLine("Please enter how many rushing yards this Wide Receiver had this past year:");
    int wideRushingYards1 = int.Parse(Console.ReadLine());
    if(wideRushingYards1 >= 1000){
        receiverValue += 5;
    }
    else if(wideRushingYards1 >= 500){
        receiverValue += 4;
    }
    else if(wideRushingYards1 >= 300){
        receiverValue += 3;
    }
    else if(wideRushingYards1 >= 200){
        receiverValue += 2;
    }
    else if(wideRushingYards1 >= 100){
        receiverValue += 1;
    }
    else{
        receiverValue += 0.5;
    }

    System.Console.WriteLine("How many touchdowns did this Wide Receiver have 3 years ago:");
    int touchdownsCaught3 = int.Parse(Console.ReadLine());
    if(touchdownsCaught3 >= 20){
        receiverValue += 10;
    }
    else if(touchdownsCaught3 >= 15){
        receiverValue += 8;

    }
    else if(touchdownsCaught3 >= 10){
        receiverValue += 6;
    }
    else if(touchdownsCaught3 >= 5){
        receiverValue += 4;
    }
    else if(touchdownsCaught3 >= 3){
        receiverValue += 2;
    }
    else if( touchdownsCaught3 >= 2){
        receiverValue += 1;
    }
    else{
        receiverValue += 0.5;
    }

    System.Console.WriteLine("How many touchdowns did this Wide Receiver have 2 years ago:");
    int touchdownsCaught2 = int.Parse(Console.ReadLine());
    if(touchdownsCaught2 >= 20){
        receiverValue += 10;
    }
    else if(touchdownsCaught2 >= 15){
        receiverValue += 8;

    }
    else if(touchdownsCaught2 >= 10){
        receiverValue += 6;
    }
    else if(touchdownsCaught2 >= 5){
        receiverValue += 4;
    }
    else if(touchdownsCaught2 >= 3){
        receiverValue += 2;
    }
    else if( touchdownsCaught2 >= 2){
        receiverValue += 1;
    }
    else{
        receiverValue += 0.5;
    }

    System.Console.WriteLine("How many touchdowns did this Wide Receiver have this past year:");
    int touchdownsCaught1 = int.Parse(Console.ReadLine());
    if(touchdownsCaught1 >= 20){
        receiverValue += 10;
    }
    else if(touchdownsCaught1 >= 15){
        receiverValue += 8;

    }
    else if(touchdownsCaught1 >= 10){
        receiverValue += 6;
    }
    else if(touchdownsCaught1 >= 5){
        receiverValue += 4;
    }
    else if(touchdownsCaught1 >= 3){
        receiverValue += 2;
    }
    else if( touchdownsCaught1 >= 2){
        receiverValue += 1;
    }
    else{
        receiverValue += 0.5;
    }

    System.Console.WriteLine("How many catches did this Wide Receiver have 3 years ago:");
    int receiverCatches3 = int.Parse(Console.ReadLine());
    if(receiverCatches3 >= 115){
        receiverValue += 10;
    }
    else if(receiverCatches3 >= 100){
        receiverValue += 8;
    }
    else if(receiverCatches3 >= 90){
        receiverValue += 6;
    }
    else if(receiverCatches3 >= 75){
        receiverValue += 4;
    }
    else if(receiverCatches3 >= 50){
        receiverValue += 2;
    }
    else if(receiverCatches3 >= 25){
        receiverValue += 1;
    }
    else{
        receiverValue += 0.5;
    }
    System.Console.WriteLine("How many catches did this Wide Receiver have 2 years ago:");
    int receiverCatches2 = int.Parse(Console.ReadLine());
    if(receiverCatches2 >= 115){
        receiverValue += 10;
    }
    else if(receiverCatches2 >= 100){
        receiverValue += 8;
    }
    else if(receiverCatches2 >= 90){
        receiverValue += 6;
    }
    else if(receiverCatches2 >= 75){
        receiverValue += 4;
    }
    else if(receiverCatches2 >= 50){
        receiverValue += 2;
    }
    else if(receiverCatches2 >= 25){
        receiverValue += 1;
    }
    else{
        receiverValue += 0.5;
    }

    System.Console.WriteLine("How many catches did this Wide Receiver have this past year:");
    int receiverCatches1 = int.Parse(Console.ReadLine());
    if(receiverCatches1 >= 115){
        receiverValue += 10;
    }
    else if(receiverCatches1 >= 100){
        receiverValue += 8;
    }
    else if(receiverCatches1 >= 90){
        receiverValue += 6;
    }
    else if(receiverCatches1 >= 75){
        receiverValue += 4;
    }
    else if(receiverCatches1 >= 50){
        receiverValue += 2;
    }
    else if(receiverCatches1 >= 25){
        receiverValue += 1;
    }
    else{
        receiverValue += 0.5;
    }

    System.Console.WriteLine("How many years would you like to sign this player for:");
    int contractInput = int.Parse(Console.ReadLine());
    
    if (receiverValue >= 65){
        yearlyAvg = 40000000;
        contractTotal = contractInput * yearlyAvg;
    }
    else if (receiverValue >= 60){
        yearlyAvg = 35000000;
        contractTotal = contractInput * yearlyAvg;
        
    }
    else if( receiverValue >= 50){
        yearlyAvg = 25000000;
        contractTotal = contractInput * yearlyAvg;
        
    }
    else if( receiverValue >= 40){
        yearlyAvg = 20000000;
        contractTotal = contractInput * yearlyAvg;
        
    }
    else if( receiverValue >= 30){
        yearlyAvg = 15000000;
        contractTotal = contractInput * yearlyAvg;
        
    }
    else if(receiverValue >= 20){
        yearlyAvg = 10000000;
        contractTotal = contractInput * yearlyAvg;
        
    }
    else if (receiverValue >= 10){
        yearlyAvg = 5000000;
        contractTotal = contractInput * yearlyAvg;
        
    }
    else if (receiverValue >= 7){
        yearlyAvg = 2500000;
        contractTotal = contractInput * yearlyAvg;
        
    }
    else if(receiverValue >= 5){
        yearlyAvg = 1250000;
        contractTotal = contractInput * yearlyAvg;
        
    }else{
        yearlyAvg = 1670000;
        contractTotal = contractInput * yearlyAvg;
        
    }
    
    System.Console.WriteLine($"{name} should be signed to a {contractInput} year {contractTotal:C2} deal with {yearlyAvg:C2} paid on average per year.");
    System.Console.WriteLine("Would you like to predict another players contract (yes/no)?");
    string input = Console.ReadLine();
    if (input != "yes"){
        MainMenu();
    }
    else{
        Predictions();
    }
}

static void Tightends(){
    double tightEndValue = 0;
    System.Console.WriteLine("What is the name of this Tightend?");
    string name = Console.ReadLine();
    System.Console.WriteLine("How many years has this Tightend played in the NFL?");
    int years = int.Parse(Console.ReadLine());
    if(years <= 2){
        System.Console.WriteLine("This player is not yet elligable for a contract extension");
        MainMenu();
    }
    System.Console.WriteLine("How old is this Tightend?");
    int age = int.Parse(Console.ReadLine());
    if(age != 0){
        if(name != "Travis Kelce"){
            if(age >= 35){
                tightEndValue -= 10;
            }
            else if(age >= 33){
                tightEndValue -= 5;
            }
            else if(age >= 29){
                tightEndValue -= 3;
            }
            else if(age >= 26){
                tightEndValue += 0;
            }
            else{
                tightEndValue += 3;
            }


        }
        else{
            tightEndValue += 2;
        }
    }
    System.Console.WriteLine("Please get ready to enter some statistics for this Tightend.");
    System.Console.WriteLine("Please enter how many receiving yards this Tightend had 3 years ago:");
    int receivingYards3 = int.Parse(Console.ReadLine());
    int contactYears;
    double contractTotal;
    double yearlyAvg;
    if(receivingYards3 >= 1200){
        tightEndValue += 10;
    }
    else if(receivingYards3 >= 1000){
        tightEndValue += 8;
    }
    else if(receivingYards3 >= 800){
        tightEndValue += 6;
    }
    else if(receivingYards3 >= 500){
        tightEndValue += 4;
    }
    else if(receivingYards3 >= 300){
        tightEndValue += 2;
    }
    else{
        tightEndValue += 1;
    }
    System.Console.WriteLine("Please enter how many receiving yards this Tightend had 2 years ago:");
    int receivingYards2 = int.Parse(Console.ReadLine());
    if(receivingYards2 >= 1200){
        tightEndValue += 10;
    }
    else if(receivingYards2 >= 1000){
        tightEndValue += 8;
    }
    else if(receivingYards2 >= 800){
        tightEndValue += 6;
    }
    else if(receivingYards2 >= 500){
        tightEndValue += 4;
    }
    else if(receivingYards2 >= 300){
        tightEndValue += 2;
    }
    else{
        tightEndValue += 1;
    }
    System.Console.WriteLine("Please enter how many receiving yards this Tightend had this past year:");
    int receivingYards1 = int.Parse(Console.ReadLine());
    if(receivingYards1 >= 1200){
        tightEndValue += 10;
    }
    else if(receivingYards1 >= 1000){
        tightEndValue += 8;
    }
    else if(receivingYards1 >= 800){
        tightEndValue += 6;
    }
    else if(receivingYards1 >= 500){
        tightEndValue += 4;
    }
    else if(receivingYards1 >= 300){
        tightEndValue += 2;
    }
    else{
        tightEndValue += 1;
    }

    System.Console.WriteLine("Please enter how many rushing yards this Tightend had 3 years ago:");
    int tightRushingYards3 = int.Parse(Console.ReadLine());
    if(tightRushingYards3 >= 1000){
        tightEndValue += 5;
    }
    else if(tightRushingYards3 >= 500){
        tightEndValue += 4;
    }
    else if(tightRushingYards3 >= 300){
        tightEndValue += 3;
    }
    else if(tightRushingYards3 >= 200){
        tightEndValue += 2;
    }
    else if(tightRushingYards3 >= 100){
        tightEndValue += 1;
    }
    else{
        tightEndValue += 0.5;
    }

    System.Console.WriteLine("Please enter how many rushing yards this Tightend had 2 years ago:");
    int tightRushingYards2 = int.Parse(Console.ReadLine());
    if(tightRushingYards2 >= 1000){
        tightEndValue += 5;
    }
    else if(tightRushingYards2 >= 500){
        tightEndValue += 4;
    }
    else if(tightRushingYards2 >= 300){
        tightEndValue += 3;
    }
    else if(tightRushingYards2 >= 200){
        tightEndValue += 2;
    }
    else if(tightRushingYards2 >= 100){
        tightEndValue += 1;
    }
    else{
        tightEndValue += 0.5;
    }

    System.Console.WriteLine("Please enter how many rushing yards this Tightend had this past year:");
    int tightRushingYards1 = int.Parse(Console.ReadLine());
    if(tightRushingYards1 >= 1000){
        tightEndValue += 5;
    }
    else if(tightRushingYards1 >= 500){
        tightEndValue += 4;
    }
    else if(tightRushingYards1 >= 300){
        tightEndValue += 3;
    }
    else if(tightRushingYards1 >= 200){
        tightEndValue += 2;
    }
    else if(tightRushingYards1 >= 100){
        tightEndValue += 1;
    }
    else{
        tightEndValue += 0.5;
    }

    System.Console.WriteLine("How many touchdowns did this Tightend have 3 years ago:");
    int touchdownsCaught3 = int.Parse(Console.ReadLine());
    if(touchdownsCaught3 >= 10){
        tightEndValue += 10;
    }
    else if(touchdownsCaught3 >= 7){
        tightEndValue += 8;

    }
    else if(touchdownsCaught3 >= 5){
        tightEndValue += 6;
    }
    else if(touchdownsCaught3 >= 3){
        tightEndValue += 4;
    }
    else if(touchdownsCaught3 >= 2){
        tightEndValue += 2;
    }
    else if( touchdownsCaught3 >= 1){
        tightEndValue += 1;
    }
    else{
        tightEndValue += 0.5;
    }

    System.Console.WriteLine("How many touchdowns did this Tightend have 2 years ago:");
    int touchdownsCaught2 = int.Parse(Console.ReadLine());
    if(touchdownsCaught2 >= 10){
        tightEndValue += 10;
    }
    else if(touchdownsCaught2 >= 7){
        tightEndValue += 8;

    }
    else if(touchdownsCaught2 >= 5){
        tightEndValue += 6;
    }
    else if(touchdownsCaught2 >= 3){
        tightEndValue += 4;
    }
    else if(touchdownsCaught2 >= 2){
        tightEndValue += 2;
    }
    else if( touchdownsCaught2 >= 1){
        tightEndValue += 1;
    }
    else{
        tightEndValue += 0.5;
    }

    System.Console.WriteLine("How many touchdowns did this Tightend have this past year:");
    int touchdownsCaught1 = int.Parse(Console.ReadLine());
    if(touchdownsCaught1 >= 10){
        tightEndValue += 10;
    }
    else if(touchdownsCaught1 >= 7){
        tightEndValue += 8;

    }
    else if(touchdownsCaught1 >= 5){
        tightEndValue += 6;
    }
    else if(touchdownsCaught1 >= 3){
        tightEndValue += 4;
    }
    else if(touchdownsCaught1 >= 2){
        tightEndValue += 2;
    }
    else if( touchdownsCaught1 >= 1){
        tightEndValue += 1;
    }
    else{
        tightEndValue += 0.5;
    }

    System.Console.WriteLine("How many catches did this Tightend have 3 years ago:");
    int tightEndCatches3 = int.Parse(Console.ReadLine());
    if(tightEndCatches3 >= 115){
        tightEndValue += 10;
    }
    else if(tightEndCatches3 >= 100){
        tightEndValue += 8;
    }
    else if(tightEndCatches3 >= 90){
        tightEndValue += 6;
    }
    else if(tightEndCatches3 >= 75){
        tightEndValue += 4;
    }
    else if(tightEndCatches3 >= 50){
        tightEndValue += 2;
    }
    else if(tightEndCatches3 >= 25){
        tightEndValue += 1;
    }
    else{
        tightEndValue += 0.5;
    }
    System.Console.WriteLine("How many catches did this Tightend have 2 years ago:");
    int tightEndCatches2 = int.Parse(Console.ReadLine());
    if(tightEndCatches2 >= 115){
        tightEndValue += 10;
    }
    else if(tightEndCatches2 >= 100){
        tightEndValue += 8;
    }
    else if(tightEndCatches2 >= 90){
        tightEndValue += 6;
    }
    else if(tightEndCatches2 >= 75){
        tightEndValue += 4;
    }
    else if(tightEndCatches2 >= 50){
        tightEndValue += 2;
    }
    else if(tightEndCatches2 >= 25){
        tightEndValue += 1;
    }
    else{
        tightEndValue += 0.5;
    }

    System.Console.WriteLine("How many catches did this Tightend have this past year:");
    int tightEndCatches1 = int.Parse(Console.ReadLine());
    if(tightEndCatches1 >= 115){
        tightEndValue += 10;
    }
    else if(tightEndCatches1 >= 100){
        tightEndValue += 8;
    }
    else if(tightEndCatches1 >= 90){
        tightEndValue += 6;
    }
    else if(tightEndCatches1 >= 75){
        tightEndValue += 4;
    }
    else if(tightEndCatches1 >= 50){
        tightEndValue += 2;
    }
    else if(tightEndCatches1 >= 25){
        tightEndValue += 1;
    }
    else{
        tightEndValue += 0.5;
    }

    System.Console.WriteLine("How many years would you like to sign this player for:");
    int contractInput = int.Parse(Console.ReadLine());
    
    if (tightEndValue >= 65){
        yearlyAvg = 20000000;
        contractTotal = contractInput * yearlyAvg;
    }
    else if (tightEndValue >= 60){
        yearlyAvg = 17000000;
        contractTotal = contractInput * yearlyAvg;
        
    }
    else if( tightEndValue >= 50){
        yearlyAvg = 13000000;
        contractTotal = contractInput * yearlyAvg;
        
    }
    else if( tightEndValue >= 40){
        yearlyAvg = 10000000;
        contractTotal = contractInput * yearlyAvg;
        
    }
    else if( tightEndValue >= 30){
        yearlyAvg = 7000000;
        contractTotal = contractInput * yearlyAvg;
        
    }
    else if(tightEndValue >= 20){
        yearlyAvg = 5000000;
        contractTotal = contractInput * yearlyAvg;
        
    }
    else if (tightEndValue >= 10){
        yearlyAvg = 2500000;
        contractTotal = contractInput * yearlyAvg;
        
    }
    else if (tightEndValue >= 7){
        yearlyAvg = 1500000;
        contractTotal = contractInput * yearlyAvg;
        
    }
    else if(tightEndValue >= 5){
        yearlyAvg = 1000000;
        contractTotal = contractInput * yearlyAvg;
        
    }else{
        yearlyAvg = 500000;
        contractTotal = contractInput * yearlyAvg;
        
    }
    
    System.Console.WriteLine($"{name} should be signed to a {contractInput} year {contractTotal:C2} deal with {yearlyAvg:C2} paid on average per year.");
    System.Console.WriteLine("Would you like to predict another players contract (yes/no)?");
    string input = Console.ReadLine();
    if (input != "yes"){
        MainMenu();
    }
    else{
        Predictions();
    }
}

static void Runningbacks(){
    double runningBackValue = 0;
    System.Console.WriteLine("What is the name of this Running Back?");
    string name = Console.ReadLine();
    System.Console.WriteLine("How many years has this Running Back played in the NFL?");
    int years = int.Parse(Console.ReadLine());
    if(years <= 2){
        System.Console.WriteLine("This player is not yet elligable for a contract extension");
        MainMenu();
    }
    System.Console.WriteLine("How old is this Running Back?");
    int age = int.Parse(Console.ReadLine());
    if(age != 0){
        if(name != "Derrick Henry"){
            if(age >= 35){
                runningBackValue -= 10;
            }
            else if(age >= 33){
                runningBackValue -= 5;
            }
            else if(age >= 29){
                runningBackValue -= 3;
            }
            else if(age >= 25){
                runningBackValue += 0;
            }
            else{
                runningBackValue += 2;
            }


        }
        else{
            runningBackValue += 1;
            System.Console.WriteLine("He is the KING!");
        }
    }
    System.Console.WriteLine("Please get ready to enter some statistics for this Running Back.");
    System.Console.WriteLine("Please enter how many receiving yards this Running Back had 3 years ago:");
    int receivingYards3 = int.Parse(Console.ReadLine());
    int contactYears;
    double contractTotal;
    double yearlyAvg;
    if(receivingYards3 >= 500){
        runningBackValue += 5;
    }
    else if(receivingYards3 >= 300){
        runningBackValue += 4;
    }
    else if(receivingYards3 >= 200){
        runningBackValue += 3;
    }
    else if(receivingYards3 >= 100){
        runningBackValue += 2;
    }
    else if(receivingYards3 >= 50){
        runningBackValue += 1;
    }
    else{
        runningBackValue += 0.5;
    }
    System.Console.WriteLine("Please enter how many receiving yards this Running Back had 2 years ago:");
    int receivingYards2 = int.Parse(Console.ReadLine());
    if(receivingYards2 >= 500){
        runningBackValue += 5;
    }
    else if(receivingYards2 >= 300){
        runningBackValue += 4;
    }
    else if(receivingYards2 >= 200){
        runningBackValue += 3;
    }
    else if(receivingYards2 >= 100){
        runningBackValue += 2;
    }
    else if(receivingYards2 >= 50){
        runningBackValue += 1;
    }
    else{
        runningBackValue += 0.5;
    }
    System.Console.WriteLine("Please enter how many receiving yards this Running Back had this past year:");
    int receivingYards1 = int.Parse(Console.ReadLine());
    if(receivingYards1 >= 500){
        runningBackValue += 5;
    }
    else if(receivingYards1 >= 300){
        runningBackValue += 4;
    }
    else if(receivingYards1 >= 200){
        runningBackValue += 3;
    }
    else if(receivingYards1 >= 100){
        runningBackValue += 2;
    }
    else if(receivingYards1 >= 50){
        runningBackValue += 1;
    }
    else{
        runningBackValue += 0.5;
    }

    System.Console.WriteLine("Please enter how many rushing yards this Tightend had 3 years ago:");
    int rushingYards3 = int.Parse(Console.ReadLine());
    if(rushingYards3 >= 1000){
        runningBackValue += 10;
    }
    else if(rushingYards3 >= 800){
        runningBackValue += 8;
    }
    else if(rushingYards3 >= 600){
        runningBackValue += 6;
    }
    else if(rushingYards3 >= 400){
        runningBackValue += 4;
    }
    else if(rushingYards3 >= 200){
        runningBackValue += 2;
    }
    else{
        runningBackValue += 1;
    }

    System.Console.WriteLine("Please enter how many rushing yards this Running Back had 2 years ago:");
    int rushingYards2 = int.Parse(Console.ReadLine());
    if(rushingYards2 >= 1000){
        runningBackValue += 10;
    }
    else if(rushingYards2 >= 800){
        runningBackValue += 8;
    }
    else if(rushingYards2 >= 600){
        runningBackValue += 6;
    }
    else if(rushingYards2 >= 400){
        runningBackValue += 4;
    }
    else if(rushingYards2 >= 200){
        runningBackValue += 2;
    }
    else{
        runningBackValue += 1;
    }

    System.Console.WriteLine("Please enter how many rushing yards this Running Back had this past year:");
    int rushingYards1 = int.Parse(Console.ReadLine());
    if(rushingYards1 >= 1000){
        runningBackValue += 10;
    }
    else if(rushingYards1 >= 800){
        runningBackValue += 8;
    }
    else if(rushingYards1 >= 600){
        runningBackValue += 6;
    }
    else if(rushingYards1 >= 400){
        runningBackValue += 4;
    }
    else if(rushingYards1 >= 200){
        runningBackValue += 2;
    }
    else{
        runningBackValue += 1;
    }

    System.Console.WriteLine("How many touchdowns did this Running Back have 3 years ago:");
    int touchdowns3 = int.Parse(Console.ReadLine());
    if(touchdowns3 >= 20){
        runningBackValue += 10;
    }
    else if(touchdowns3 >= 15){
        runningBackValue += 8;

    }
    else if(touchdowns3 >= 10){
        runningBackValue += 6;
    }
    else if(touchdowns3 >= 7){
        runningBackValue += 4;
    }
    else if(touchdowns3 >= 5){
        runningBackValue += 2;
    }
    else if( touchdowns3 >= 3){
        runningBackValue += 1;
    }
    else{
        runningBackValue += 0.5;
    }

    System.Console.WriteLine("How many touchdowns did this Running Back have 2 years ago:");
    int touchdowns2 = int.Parse(Console.ReadLine());
    if(touchdowns2 >= 20){
        runningBackValue += 10;
    }
    else if(touchdowns2 >= 15){
        runningBackValue += 8;

    }
    else if(touchdowns2 >= 10){
        runningBackValue += 6;
    }
    else if(touchdowns2 >= 7){
        runningBackValue += 4;
    }
    else if(touchdowns2 >= 5){
        runningBackValue += 2;
    }
    else if( touchdowns2 >= 3){
        runningBackValue += 1;
    }
    else{
        runningBackValue += 0.5;
    }

    System.Console.WriteLine("How many touchdowns did this Running Back have this past year:");
    int touchdowns1 = int.Parse(Console.ReadLine());
    if(touchdowns1 >= 20){
        runningBackValue += 10;
    }
    else if(touchdowns1 >= 15){
        runningBackValue += 8;

    }
    else if(touchdowns1 >= 10){
        runningBackValue += 6;
    }
    else if(touchdowns1 >= 7){
        runningBackValue += 4;
    }
    else if(touchdowns1 >= 5){
        runningBackValue += 2;
    }
    else if( touchdowns1 >= 3){
        runningBackValue += 1;
    }
    else{
        runningBackValue += 0.5;
    }

    System.Console.WriteLine("How many catches did this Running Back have 3 years ago:");
    int catches3 = int.Parse(Console.ReadLine());
    if(catches3 >= 40){
        runningBackValue += 10;
    }
    else if(catches3 >= 30){
        runningBackValue += 8;
    }
    else if(catches3 >= 25){
        runningBackValue += 6;
    }
    else if(catches3 >= 15){
        runningBackValue += 4;
    }
    else if(catches3 >= 10){
        runningBackValue += 2;
    }
    else if(catches3 >= 5){
        runningBackValue += 1;
    }
    else{
        runningBackValue += 0.5;
    }
    System.Console.WriteLine("How many catches did this Running Back have 2 years ago:");
    int catches2 = int.Parse(Console.ReadLine());
    if(catches2 >= 40){
        runningBackValue += 10;
    }
    else if(catches2 >= 30){
        runningBackValue += 8;
    }
    else if(catches2 >= 25){
        runningBackValue += 6;
    }
    else if(catches2 >= 15){
        runningBackValue += 4;
    }
    else if(catches2 >= 10){
        runningBackValue += 2;
    }
    else if(catches2 >= 5){
        runningBackValue += 1;
    }
    else{
        runningBackValue += 0.5;
    }

    System.Console.WriteLine("How many catches did this Running Back have this past year:");
    int catches1 = int.Parse(Console.ReadLine());
    if(catches1 >= 40){
        runningBackValue += 10;
    }
    else if(catches1 >= 30){
        runningBackValue += 8;
    }
    else if(catches1 >= 25){
        runningBackValue += 6;
    }
    else if(catches1 >= 15){
        runningBackValue += 4;
    }
    else if(catches1 >= 10){
        runningBackValue += 2;
    }
    else if(catches1 >= 5){
        runningBackValue += 1;
    }
    else{
        runningBackValue += 0.5;
    }

    System.Console.WriteLine("How many years would you like to sign this player for:");
    int contractInput = int.Parse(Console.ReadLine());
    
    if (runningBackValue >= 85){
        yearlyAvg = 20000000;
        contractTotal = contractInput * yearlyAvg;
    }
    else if (runningBackValue >= 75){
        yearlyAvg = 15000000;
        contractTotal = contractInput * yearlyAvg;
        
    }
    else if( runningBackValue >= 65){
        yearlyAvg = 13000000;
        contractTotal = contractInput * yearlyAvg;
        
    }
    else if( runningBackValue >= 50){
        yearlyAvg = 10000000;
        contractTotal = contractInput * yearlyAvg;
        
    }
    else if( runningBackValue >= 40){
        yearlyAvg = 7000000;
        contractTotal = contractInput * yearlyAvg;
        
    }
    else if(runningBackValue >= 30){
        yearlyAvg = 5000000;
        contractTotal = contractInput * yearlyAvg;
        
    }
    else if (runningBackValue >= 20){
        yearlyAvg = 2500000;
        contractTotal = contractInput * yearlyAvg;
        
    }
    else if (runningBackValue >= 10){
        yearlyAvg = 1500000;
        contractTotal = contractInput * yearlyAvg;
        
    }
    else if(runningBackValue >= 7){
        yearlyAvg = 1000000;
        contractTotal = contractInput * yearlyAvg;
        
    }else{
        yearlyAvg = 500000;
        contractTotal = contractInput * yearlyAvg;
        
    }
    
    System.Console.WriteLine($"{name} should be signed to a {contractInput} year {contractTotal:C2} deal with {yearlyAvg:C2} paid on average per year.");
    System.Console.WriteLine("Would you like to predict another players contract (yes/no)?");
    string input = Console.ReadLine();
    if (input != "yes"){
        MainMenu();
    }
    else{
        Predictions();
    }

}

static void DefensiveEnds(){
    double defensiveEndValue = 0;
    System.Console.WriteLine("What is the name of this Defensive End?");
    string name = Console.ReadLine();
    System.Console.WriteLine("How many years has this Defensive End played in the NFL?");
    int years = int.Parse(Console.ReadLine());
    if(years <= 2){
        System.Console.WriteLine("This player is not yet elligable for a contract extension");
        MainMenu();
    }
    System.Console.WriteLine("How old is this Defensive End?");
    int age = int.Parse(Console.ReadLine());
    if(age != 0){
        if(name != "Myles Garrett"){
            if(age >= 35){
                defensiveEndValue -= 5;
            }
            else if(age >= 33){
                defensiveEndValue -= 3;
            }
            else if(age >= 29){
                defensiveEndValue -= 1;
            }
            else if(age >= 26){
                defensiveEndValue += 0;
            }
            else{
                defensiveEndValue += 2;
            }


        }
        else{
            defensiveEndValue += 1;
        }
    }
    System.Console.WriteLine("Please get ready to enter some statistics for this Defensive End.");
    System.Console.WriteLine("Please enter how many sacks did this Defensive End had 3 years ago:");
    double sacks3 = int.Parse(Console.ReadLine());
    int contactYears;
    double contractTotal;
    double yearlyAvg;
    if(sacks3 >= 15){
        defensiveEndValue += 10;
    }
    else if(sacks3 >= 10){
        defensiveEndValue += 8;
    }
    else if(sacks3 >= 7){
        defensiveEndValue += 6;
    }
    else if(sacks3 >= 5){
        defensiveEndValue += 4;
    }
    else if(sacks3 >= 3){
        defensiveEndValue += 2;
    }
    else{
        defensiveEndValue += 1;
    }
    System.Console.WriteLine("Please enter how many sacks did this Defensive End had 2 years ago:");
    double sacks2 = int.Parse(Console.ReadLine());
    if(sacks2 >= 15){
        defensiveEndValue += 10;
    }
    else if(sacks2 >= 10){
        defensiveEndValue += 8;
    }
    else if(sacks2 >= 7){
        defensiveEndValue += 6;
    }
    else if(sacks2 >= 5){
        defensiveEndValue += 4;
    }
    else if(sacks2 >= 3){
        defensiveEndValue += 2;
    }
    else{
        defensiveEndValue += 1;
    }
    System.Console.WriteLine("Please enter how many sacks did this Defensive End had this past year:");
    double sacks1 = int.Parse(Console.ReadLine());
    if(sacks1 >= 15){
        defensiveEndValue += 10;
    }
    else if(sacks1 >= 10){
        defensiveEndValue += 8;
    }
    else if(sacks1 >= 7){
        defensiveEndValue += 6;
    }
    else if(sacks1 >= 5){
        defensiveEndValue += 4;
    }
    else if(sacks1 >= 3){
        defensiveEndValue += 2;
    }
    else{
        defensiveEndValue += 1;
    }

    System.Console.WriteLine("Please enter how many tackles this Tightend had 3 years ago:");
    int tfl3 = int.Parse(Console.ReadLine());
    if(tfl3 >= 20){
        defensiveEndValue += 5;
    }
    else if(tfl3 >= 15){
        defensiveEndValue += 4;
    }
    else if(tfl3 >= 10){
        defensiveEndValue += 3;
    }
    else if(tfl3 >= 7){
        defensiveEndValue += 2;
    }
    else if(tfl3 >= 5){
        defensiveEndValue += 1;
    }
    else{
        defensiveEndValue += 0.5;
    }

    System.Console.WriteLine("Please enter how many tackles this Defensive End had 2 years ago:");
    int tfl2 = int.Parse(Console.ReadLine());
    if(tfl2 >= 20){
        defensiveEndValue += 5;
    }
    else if(tfl2 >= 15){
        defensiveEndValue += 4;
    }
    else if(tfl2 >= 10){
        defensiveEndValue += 3;
    }
    else if(tfl2 >= 7){
        defensiveEndValue += 2;
    }
    else if(tfl2 >= 5){
        defensiveEndValue += 1;
    }
    else{
        defensiveEndValue += 0.5;
    }

    System.Console.WriteLine("Please enter how many tackles this Defensive End have this past year:");
    int tfl1 = int.Parse(Console.ReadLine());
    if(tfl1 >= 20){
        defensiveEndValue += 5;
    }
    else if(tfl1 >= 15){
        defensiveEndValue += 4;
    }
    else if(tfl1 >= 10){
        defensiveEndValue += 3;
    }
    else if(tfl1 >= 7){
        defensiveEndValue += 2;
    }
    else if(tfl1 >= 5){
        defensiveEndValue += 1;
    }
    else{
        defensiveEndValue += 0.5;
    }

    System.Console.WriteLine("How many forced fumbles did this Defensive End have 3 years ago:");
    int interceptions3 = int.Parse(Console.ReadLine());
    if(interceptions3 >= 5){
        defensiveEndValue += 10;
    }
    else if(interceptions3 >= 15){
        defensiveEndValue += 8;

    }
    else if(interceptions3 >= 10){
        defensiveEndValue += 6;
    }
    else if(interceptions3 >= 7){
        defensiveEndValue += 4;
    }
    else if(interceptions3 >= 5){
        defensiveEndValue += 2;
    }
    else if( interceptions3 >= 3){
        defensiveEndValue += 1;
    }
    else{
        defensiveEndValue += 0.5;
    }

    System.Console.WriteLine("How many forced fumbles did this Defensive End have 2 years ago:");
    int interceptions2 = int.Parse(Console.ReadLine());
    if(interceptions2 >= 20){
        defensiveEndValue += 10;
    }
    else if(interceptions2 >= 15){
        defensiveEndValue += 8;

    }
    else if(interceptions2 >= 10){
        defensiveEndValue += 6;
    }
    else if(interceptions2 >= 7){
        defensiveEndValue += 4;
    }
    else if(interceptions2 >= 5){
        defensiveEndValue += 2;
    }
    else if( interceptions2 >= 3){
        defensiveEndValue += 1;
    }
    else{
        defensiveEndValue += 0.5;
    }

    System.Console.WriteLine("How many forced fumbles did this Defensive End have this past year:");
    int interceptions1 = int.Parse(Console.ReadLine());
    if(interceptions1 >= 20){
        defensiveEndValue += 10;
    }
    else if(interceptions1 >= 15){
        defensiveEndValue += 8;

    }
    else if(interceptions1 >= 10){
        defensiveEndValue += 6;
    }
    else if(interceptions1 >= 7){
        defensiveEndValue += 4;
    }
    else if(interceptions1 >= 5){
        defensiveEndValue += 2;
    }
    else if( interceptions1 >= 3){
        defensiveEndValue += 1;
    }
    else{
        defensiveEndValue += 0.5;
    }

    System.Console.WriteLine("How many pressures did this Defensive End have 3 years ago:");
    int pressures3 = int.Parse(Console.ReadLine());
    if(pressures3 >= 80){
        defensiveEndValue += 10;
    }
    else if(pressures3 >= 70){
        defensiveEndValue += 8;
    }
    else if(pressures3 >= 60){
        defensiveEndValue += 6;
    }
    else if(pressures3 >= 50){
        defensiveEndValue += 4;
    }
    else if(pressures3 >= 40){
        defensiveEndValue += 2;
    }
    else if(pressures3 >= 30){
        defensiveEndValue += 1;
    }
    else{
        defensiveEndValue += 0.5;
    }
    System.Console.WriteLine("How many pressures did this Defensive End have 2 years ago:");
    int pressures2 = int.Parse(Console.ReadLine());
    if(pressures2 >= 80){
        defensiveEndValue += 10;
    }
    else if(pressures2 >= 70){
        defensiveEndValue += 8;
    }
    else if(pressures2 >= 60){
        defensiveEndValue += 6;
    }
    else if(pressures2 >= 50){
        defensiveEndValue += 4;
    }
    else if(pressures2 >= 40){
        defensiveEndValue += 2;
    }
    else if(pressures2 >= 30){
        defensiveEndValue += 1;
    }
    else{
        defensiveEndValue += 0.5;
    }

    System.Console.WriteLine("How many pressures did this Defensive End have this past year:");
    int pressures1 = int.Parse(Console.ReadLine());
    if(pressures1 >= 80){
        defensiveEndValue += 10;
    }
    else if(pressures1 >= 70){
        defensiveEndValue += 8;
    }
    else if(pressures1 >= 60){
        defensiveEndValue += 6;
    }
    else if(pressures1 >= 50){
        defensiveEndValue += 4;
    }
    else if(pressures1 >= 40){
        defensiveEndValue += 2;
    }
    else if(pressures1 >= 30){
        defensiveEndValue += 1;
    }
    else{
        defensiveEndValue += 0.5;
    }

    System.Console.WriteLine("How many years would you like to sign this player for:");
    int contractInput = int.Parse(Console.ReadLine());
    
    if (defensiveEndValue >= 70){
        yearlyAvg = 40000000;
        contractTotal = contractInput * yearlyAvg;
    }
    else if (defensiveEndValue >= 60){
        yearlyAvg = 30000000;
        contractTotal = contractInput * yearlyAvg;
        
    }
    else if( defensiveEndValue >= 50){
        yearlyAvg = 25000000;
        contractTotal = contractInput * yearlyAvg;
        
    }
    else if( defensiveEndValue >= 40){
        yearlyAvg = 20000000;
        contractTotal = contractInput * yearlyAvg;
        
    }
    else if( defensiveEndValue >= 30){
        yearlyAvg = 15000000;
        contractTotal = contractInput * yearlyAvg;
        
    }
    else if(defensiveEndValue >= 20){
        yearlyAvg = 10000000;
        contractTotal = contractInput * yearlyAvg;
        
    }
    else if (defensiveEndValue >= 15){
        yearlyAvg = 5000000;
        contractTotal = contractInput * yearlyAvg;
        
    }
    else if (defensiveEndValue >= 10){
        yearlyAvg = 2500000;
        contractTotal = contractInput * yearlyAvg;
        
    }
    else if(defensiveEndValue >= 7){
        yearlyAvg = 1000000;
        contractTotal = contractInput * yearlyAvg;
        
    }else{
        yearlyAvg = 500000;
        contractTotal = contractInput * yearlyAvg;
        
    }
    
    System.Console.WriteLine($"{name} should be signed to a {contractInput} year {contractTotal:C2} deal with {yearlyAvg:C2} paid on average per year.");
    System.Console.WriteLine("Would you like to predict another players contract (yes/no)?");
    string input = Console.ReadLine();
    if (input != "yes"){
        MainMenu();
    }
    else{
        Predictions();
    }

}

