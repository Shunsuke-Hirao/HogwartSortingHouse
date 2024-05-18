
// See https://aka.ms/new-console-template for more information
using System;

namespace finalproject

{
    class Program
    {
        static void Main(string[] args)
        {   
            // question option lists
            string[] option1={"1.Wolf ", "2.Lion ", "3.Squirrel ", "4.Eagle "};
            string[] option2={"1.be with your love ", "2.be the smartest in the world ", "3.be able to talk with animal ", "4.be the strongest in the world "};
            string[] option3={"1.Can fly", "2.Can expect future", "3.Can read mind", "4.Can teleport"};
            
            // sorthouse
            string[] house={"Gryffindor", "Slytherin", "Ravenclaw", "Hufflepuff"};

            int gri=0;
            int sly=0;
            int rav=0;
            int huf=0;

            // List of loop questions
            bool yes=true;
            bool q1=true;
            bool q2=true;
            bool q3=true;
            bool answer=true;

            Random random=new Random();

            while(yes==true){
                Console.WriteLine("Welcome to Hogwart! I let you sort your house"); //instruction
                Console.WriteLine("Let's start!");
                Console.ReadLine();

                while(q1==true){
                Console.WriteLine("Choose and type number animal you like"); //first question
                Console.WriteLine(option1[0]); //option1
                Console.WriteLine(option1[1]); //option2
                Console.WriteLine(option1[2]); //option3
                Console.WriteLine(option1[3]);  //option4 
                int ans1;
                //error handling
                 try{
                    ans1=Convert.ToInt32(Console.ReadLine());
                    if(ans1>=5){
                        Console.WriteLine("Error! you must type between 1 and 4");
                        continue;
                    }
                 }
                 catch(FormatException){
                        Console.WriteLine("Type number between 1 and 4! Try again please");
                        continue;
                 }
                 switch(ans1){
                    case(1):
                        Console.WriteLine(option1[0]);
                        sly++;
                        break;
                    case(2):
                        Console.WriteLine(option1[1]);
                        gri++;
                        break;
                    case(3):
                        Console.WriteLine(option1[2]);
                        huf++;
                        break;
                    case(4):
                        Console.WriteLine(option1[3]);
                        rav++;
                        break;
                }
                break;
              }
                
                while(q2==true){
                Console.WriteLine("If you could have one wish fulfilled, what would it be? Choose and type number!"); //second question
                Console.WriteLine(option2[0]); //option1
                Console.WriteLine(option2[1]); //option2
                Console.WriteLine(option2[2]); //option3
                Console.WriteLine(option2[3]);  //option4 
                int ans2;
                
                // Errorhandling
                 try{
                    ans2=Convert.ToInt32(Console.ReadLine());
                    if(ans2>=5){
                        Console.WriteLine("Error! you must type between 1 and 4");
                        continue;
                    }
                 }
                 catch(FormatException){
                        Console.WriteLine("Type number between 1 and 4! Try again please");
                        continue;
                 }
                 switch(ans2){
                    case(1):
                        Console.WriteLine(option2[0]);
                        gri++;
                        break;
                    case(2):
                        Console.WriteLine(option2[1]);
                        rav++;
                        break;
                    case(3):
                        Console.WriteLine(option2[2]);
                        huf++;
                        break;
                    case(4):
                        Console.WriteLine(option2[3]);
                        sly++;
                        break;
                }
                break;
               }

                while(q3==true){    
                Console.WriteLine("What is the ability you want the most? Choose and type number");//last question
                Console.WriteLine(option3[0]); //option1
                Console.WriteLine(option3[1]); //option2
                Console.WriteLine(option3[2]); //option3
                Console.WriteLine(option3[3]);  //option4  
                int ans3;
                
                // Errorhandling
                 try{
                    ans3=Convert.ToInt32(Console.ReadLine());
                    if(ans3>=5){
                        Console.WriteLine("Error! you must type between 1 and 4");
                        continue;
                    }
                 }
                 catch(FormatException){
                        Console.WriteLine("Type number between 1 and 4! Try again please");
                        continue;
                 }
                switch(ans3){
                    case(1):
                        Console.WriteLine(option3[0]);
                        huf++;
                        break;
                    case(2):
                        Console.WriteLine(option3[1]);
                        gri++;
                        break;
                    case(3):
                        Console.WriteLine(option3[2]);
                        rav++;
                        break;
                    case(4):
                        Console.WriteLine(option3[3]);
                        sly++;
                        break;
                }
                break;
               }

                //result
                if(gri==2 ||gri==3){
                    Console.WriteLine("Your house is "+ house[0]);
                }
                else if(sly==2 ||sly==3){
                    Console.WriteLine("Your house is "+ house[1]);
                }
                else if(rav==2 || rav==3){
                    Console.WriteLine("Your house is "+ house[2]);
                }
                else if(huf==2 || huf==3){
                    Console.WriteLine("Your house is "+ house[3]);
                }
              else {
                    Console.WriteLine("Your house is "+house[random.Next(0,4)]);
                }
                
            
                while(answer==true){
                //try again or not
                Console.WriteLine("Do you wanna try again? Yes or No");
                string yourans=Console.ReadLine();

                // errorhandling
                if(yourans.ToLower()!="yes"&& yourans.ToLower()!="no"){
                      Console.WriteLine("type yes or no");
                      continue;
                }
                //if type yes
                if(yourans.ToLower()!="yes"){
                    yes=false;
                    answer=false;
                    break;
                }
                //if type no
                if(yourans.ToLower()=="yes"){
                    Console.WriteLine("Let's try again");
                    break;
                }
                break;
               }
            }
        Console.WriteLine("Thank you");
        }
    }
}