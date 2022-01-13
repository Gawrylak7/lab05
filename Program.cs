using lab05;

 Zad1.Launch(args);
// Zad2.Launch(args);
// Zad3.Launch(args);
// zad4();
void zad4 (){
 SomeClass someClassObj = new SomeClass();
 int i = 1;
 try
 {

  someClassObj.CanThrowException();
  i++;
  someClassObj.CanThrowException();
  i++;
  someClassObj.CanThrowException();
  i++;
  someClassObj.CanThrowException();
  i++;
  someClassObj.CanThrowException();
  i++;
  Console.WriteLine("Brak");
 }
 catch (Exception e)
 {
  Console.WriteLine("wystapilo na " + i + " instrukcji");
  Console.WriteLine(e.StackTrace);

 }
}
//Zad5_6.Launch(args);