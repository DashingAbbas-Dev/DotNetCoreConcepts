using DotNetCoreConcepts;

#region Extension Method
//Extension method concept allows you to add new methods in the existing class or in the structure without modifying the source code of the original type
//It is introduced in C# 3.0.
ExtensionMethod extension = new ExtensionMethod();
extension.M1();
extension.M2();
extension.M3();
extension.M4();
extension.M5("Method Name: M5");
#endregion

#region Readonly Vs Const 
// Display the value of Constant fields
Console.WriteLine("The value of myvar: {0}", Const.myvar);
Console.WriteLine("The value of str: {0}", Const.str);

ReadOnly readOnly = new ReadOnly(100, 200);
#endregion

#region Ref and Out
OutKeyword @out = new OutKeyword();

int a = 10;
int b = 20;
int sum;
int product;

// Calling the CalculateSumAndProduct method with two out parameters
@out.CalculateSumAndProduct(a, b, out sum, out product);

Console.WriteLine($"Input values: a = {a}, b = {b}");
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Product: {product}");

RefKeyword @ref = new RefKeyword();
// Assign string value 
string str = "Geek";
// Pass as a reference parameter 
@ref.SetValue(ref str);
// Display the given string 
Console.WriteLine(str);
#endregion