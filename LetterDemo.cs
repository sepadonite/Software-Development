using static System.Console;
class LetterDemo
{
   static void Main()
   {
    Letter letter = new Letter();
    letter.Name = "Harold";
    letter.Date = "11/26/2022";
    WriteLine(letter);
    WriteLine("\n");
    CertifiedLetter certifiedLetter = new CertifiedLetter();
    certifiedLetter.Name = "Harrison";
    certifiedLetter.Date = "12/25/2022";
    certifiedLetter.TrackingNumber = "LMNOP789";
    WriteLine(certifiedLetter);
    WriteLine("Tracking Number:" + certifiedLetter.TrackingNumber);
   }
}
class Letter{
  public string Name {get; set;}
  public string Date {get; set;}
  override
  public string ToString(){
    return GetType()+ "\nRecipient Name:" + Name + "\nDate" + Date;
  }
}
class CertifiedLetter : Letter{
  public string TrackingNumber {get; set;}
}
