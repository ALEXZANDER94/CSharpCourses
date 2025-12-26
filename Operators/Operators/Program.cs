//arithmetic
var a = 10;
var b = 3;
Console.WriteLine(a + b); // 13
Console.WriteLine((float) a / (float) b); // 3.3333~

a = 1;
b = 2;
var c = 3;
Console.WriteLine(a + b * c); // 7
Console.WriteLine(a > b); // false
Console.WriteLine(a == b); // false
Console.WriteLine(a != b); // true

Console.WriteLine(!(a != b)); // false

//logical
Console.WriteLine(c > b && c > a); // true
Console.WriteLine(c > b && c ==  a); // false
Console.WriteLine(c > b || c == a); // true
