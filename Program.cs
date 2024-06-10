// askar yoshini kiritib uni armiyaga bora oladimi yoki yoqmi aniqlaymiz
// 1. 17 < bolsa, bora olmaysiz.
// 2. 28 < bo'lsa bora olmaysiz. 
// 3. 17 yoki 28  bolsa balki bora olasiz.
// 4. boshqa barcha holatlarda bora olasiz.

using System;

int Army;
Console.Write("Enter Your age :");
string inputAge = Console.ReadLine();
Army = Convert.ToInt32(inputAge);
bool isMiner = Army < 17;
bool isTooOld = Army > 28;
bool isPossible = Army is 17 or 28;

if(isMiner)
{
    Console.WriteLine("Bora olmaysiz!");
}
else if(isTooOld)
{
    Console.WriteLine("Bora olmaysiz!");
} 
else if(isPossible)
{
    Console.WriteLine("Balki borarsiz");
}
else
{
    Console.WriteLine("Armiyaga borishingiz mumkin");
}