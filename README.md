# AutomationTest-Kumparan

Berikut adalah langkah-langkah untuk melakukan automation test pada command prompt :
1.	Pastikan sudah terpasang .NET Framework versi 4.7
2.	Lalu buka link https://www.nuget.org/packages/Microsoft.TestPlatform/15.9.0
3.	Download package (25.73 MB)
4.	File yang terdownload   extentionnya diubah ke dalam bentuk zip  
5.	Lalu extract folder zip tersebut 
6.	Pada windows buka Edit thesystem environment variable 
7.	Klik Environment Variables
8.	Double klik pada path 
9.	Klik New dan copy path Microsoft.testplatfrom tersimpan. Lalu klik Ok.
10.	Buka command prompt, ketikkan vsstest.console /?
11.	Lalu ketik path tersimpannya KumparanAutomation.dll, dengan command sebagai berikut:
a. Jika ingin menjalankan semua test case nya, maka ketik:
Vstest.console KumparanAutomation.dll
b. Jika ingin menjalankan salah satu test methodnya, maka ketik:
vstest.console KumparanAutomation.dll - -Tests:[TestMethodName]
Contoh :
vstest.console KumparanAutomation.dll - -Tests:ViewFromGaleriFoto
