// See https://aka.ms/new-console-template for more information
using SymmetricKeyHash;
///DEV
string key = "ITIzNDU2UXdlcnR5";
/// UAT
//string key = "VG9mZnNVQVQ4OCM=";
/// Production
//string key = "UFJEVG9mZnM4OCM=";
var isWorking = true;
while(isWorking)
{
    Console.WriteLine("Please enter a string for encryption");
    string str = Console.ReadLine();
    var encryptedString = AesOperation.EncryptString(key, str);
    Console.WriteLine($"encrypted string = {encryptedString}");

    var decryptedString = AesOperation.DecryptString(key, encryptedString);
    Console.WriteLine($"decrypted string = {decryptedString}");
    Console.WriteLine("Do u want to continue? y/n?");
    isWorking = Console.ReadLine() == "y";
}
Console.ReadKey();