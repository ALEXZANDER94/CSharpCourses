byte b = 1;
int i = b;
Console.WriteLine(i);

int j = 1000;
byte c = (byte) i;
Console.WriteLine(c);

string number = "1234";
int k = Convert.ToInt32(number);
Console.WriteLine(k);

try
{
    byte l = Convert.ToByte(number);
    Console.WriteLine(l);
}
catch(OverflowException e) {
    Console.WriteLine(e.ToString());
}
catch(Exception ex)
{
    Console.WriteLine(ex.ToString());
}

try
{
    string str = "true";
    bool isTrue = Convert.ToBoolean(str);
    Console.WriteLine(isTrue);
}
catch(Exception ex)
{
    Console.WriteLine(ex.ToString());
}