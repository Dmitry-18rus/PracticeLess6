// // задача 40 - HARD необязательная. 
// На вход программы подаются три целых положительных числа. 
// Определить , является ли это сторонами треугольника. 
// Если да, то вывести всю информацию по нему - площадь, периметр, 
// значения углов треугольника в градусах, является ли он прямоугольным, 
// равнобедренным, равносторонним.

Console.WriteLine("Введите первое число ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число ");
int n3 = Convert.ToInt32(Console.ReadLine());
int [] arrayMinMax = new int [3];
double [] arrayParam = new double [6];

Check(n1,n2,n3);
Print (Check(n1,n2,n3));
FindMinMax (n1, n2, n3,Check(n1,n2,n3), arrayMinMax);
MetPrintMinMax(arrayMinMax);
FindSquare(arrayMinMax);
Perim(arrayMinMax);
Corners(arrayMinMax,arrayParam);
Ravnostoron(arrayParam);


bool Check (int n1, int n2, int n3)
{
    bool check = false;
    if (n1 <n2 + n3 && n2 <n1 + n3 && n3 <n1 + n2) {check = true;}
return check;
}

void Print (bool check)
{
    if (Check(n1,n2,n3) == true)
    {
        Console.WriteLine("Данные стороны являются сторонами треугольника");
    }
    else {Console.WriteLine("Данные стороны НЕ являются сторонами треугольника");}
}

void FindMinMax (int n1, int n2, int n3,bool check, int [] arrayMinMax)
{
    if (Check(n1, n2, n3) == true)
    {   
        int max1 = n1; int max2 = n2; int max3 = n3;
        if (n1 == n2)
        {
            if (n3>n1) {max1 = n3;max2 = n1;max3 = n2;}
        }
        else if (n1 == n3)
        {
            if (n2>n1) {max1 = n2;max2 = n1;}
        }
        else if (n3 == n2)
        {
            if (n3>n1) {max1 = n3;max3 = n1;}
        }
        else if (n2 > n1)
        {
            max1 = n2;
            if (n1 > n3) { max2 = n1;}
            else if (n1 < n3)
            {            
                if (n3 > n2) {max1 = n3;max2 = n2;max3 = n1;}
                else if (n2>n3){max2 = n3;max3 = n1;}
            }
        }
        else if(n2<n1)
        { 
            if (n3 > n2)
            {
                if (n3>n1){max1 = n3;max2 = n1;max3 = n2;}
                else if (n3<n1) {max2 = n3;max3 = n2;}
            }
        }
    arrayMinMax[0] = max1;
    arrayMinMax[1] = max2;
    arrayMinMax[2] = max3;
    }
}

void MetPrintMinMax ( int [] arrayMinMax)
{
    Console.Write("[");
    foreach (int el  in arrayMinMax)
        Console.Write($"{el} ");
    // Console.WriteLine();
    Console.WriteLine("]");
}

double FindSquare (int [] arrayMinMax)

{
    double max1 = Convert.ToDouble(arrayMinMax[0]);
    double max2 = Convert.ToDouble(arrayMinMax[1]);
    double max3 = Convert.ToDouble(arrayMinMax[2]);
    // Console.WriteLine("max1="+max1);
    // Console.WriteLine("max2="+max2);
    // Console.WriteLine("max3="+max3);
    
    double x = ( Math.Pow(max3,2)+Math.Pow(max1,2)-Math.Pow(max2,2))/(2*max1);
    Console.WriteLine("x= "+x);
    double h = Math.Sqrt((Math.Pow(max2,2)-Math.Pow((max1-x),2))); 
    // double h = Math.Sqrt ((Math.Pow(max3,2)-Math.Pow(x,2)),2);
    Console.WriteLine("h= "+Math.Round (h,3));
    double s = (h*max1/2);
    Console.WriteLine("s= "+Math.Round (s,3));
    arrayParam[0] = x;
    arrayParam[1] = h;
    arrayParam[2] = s;
    return s;
}

int Perim (int[] arrayMinMax )
{
    int p = arrayMinMax[0]+arrayMinMax[1]+arrayMinMax[2];
    Console.WriteLine("p= " +p);
    return p;
}

void Corners (int [] arrayMinMax, double [] arrayParam)
{
    double max1 = Convert.ToDouble(arrayMinMax[0]);
    double max2 = Convert.ToDouble(arrayMinMax[1]);
    double max3 = Convert.ToDouble(arrayMinMax[2]);
    double x = arrayParam[0];
    double h = arrayParam[1];
    double corner1 = Math.Round ((Math.Acos((max1-x)/max2))*180/Math.PI,3);
    Console.WriteLine("Угол 1= " +corner1);
    double corner2 = Math.Round (Math.Acos((x)/max3)*180/Math.PI,3);
    Console.WriteLine("Угол 2= " +corner2);
    double corner3 = Math.Round (180 - corner1 - corner2,3);
    Console.WriteLine("Угол 3= " +corner3);
    arrayParam[3] = corner1;
    arrayParam[4] = corner2;
    arrayParam[5] = corner3;

}

void Ravnostoron (double [] arrayParam)
{
    double cor1 = arrayParam[3];
    double cor2 = arrayParam[4];
    double cor3 = arrayParam[5];
    if (cor1 == cor2) 
    {
        if (cor2 == cor3)
            Console.WriteLine("Треугольник равносторонний");
        else
            Console.WriteLine("Треугольник равнобедренный");
    }
    else if (cor1 == cor3)
    {
        if (cor2 == cor3)
            Console.WriteLine("Треугольник равносторонний");
        else
            Console.WriteLine("Треугольник равнобедренный");
    }
    else if (cor2 == cor3)
    {
        if (cor3 == cor1)
            Console.WriteLine("Треугольник равносторонний");
        else
            Console.WriteLine("Треугольник равнобедренный");
    }
    else if (cor1 == 90 || cor2 ==90 || cor3 ==90)
        Console.WriteLine("Треугольник прямоугольный");
}