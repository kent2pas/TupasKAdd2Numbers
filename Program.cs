//Kent Tupas
//10/17/2022
//github mini challenge 2
// update and upload to github
//

Console.Clear();
string user, user2, numberone, numbertwo;
string input = "yes";
bool num = true;
bool num2;
int vaildnum = 0;

Console.WriteLine(" Want to play a game?");
Console.ReadLine();

Console.WriteLine("Lets add two numbers ");
while(input == "yes"){
Console.WriteLine("Pick a number ");
 numberone = Console.ReadLine();
   num2 = Int32.TryParse(numberone,out vaildnum);
    if(num2 == true){
        if(vaildnum % 2 == 0 ){
          
        }else{
            Console.WriteLine("");
        }
        }else{
            Console.WriteLine("invalid entry. please try again");
        }
Console.WriteLine("Pick another one");
 numbertwo = Console.ReadLine();
    num2 = Int32.TryParse(numberone,out vaildnum);
    if(num2 == true){
        if(vaildnum % 2 == 0 ){
          
        }else{
            Console.WriteLine("");
        }
        }else{
            Console.WriteLine("invalid entry. please try again");
        }
 
int num1 = Convert.ToInt32(numberone);
int num3 = Convert.ToInt32(numbertwo);
Console.WriteLine("Your sum is " + (num1 + num3));
Console.WriteLine("Type play again or type no to stop");
input = Console.ReadLine();
    }



