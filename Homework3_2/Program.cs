// Задача 2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// Example1:  A (3,6,8); B (2,1,-7), -> 15.84
// Example2:  A (7,-5, 0); B (1,-1,9) -> 11.53

/* Distance in 3D:
// P1 = (x1,y1,z1) and P2 = (x2,y2,z2), the distance between P1 and P2 is given by d(P1,P2) = (x2-x1)2 + (y2-y1)2 + (z2-z1)2.
*/

int ReadInt(string message)
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

double Length(int x1, int y1, int z1, int x2, int y2, int z2)  //The Length takes paramethers of the first dot (x1,y1,z1) and the second dot (x2,y2,z2)
{
    double temp = Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2);
    return Math.Sqrt(temp);
}

int x1 = ReadInt("Enter the X coordinate of the first point: ");
int y1 = ReadInt("Enter the Y coordinate of the first point: ");
int z1 = ReadInt("Enter the Z coordinate of the first point: ");
int x2 = ReadInt("Enter the X coordinate of the second point: ");
int y2 = ReadInt("Enter the Y coordinate of the second point: ");
int z2 = ReadInt("Enter the Z coordinate of the second point: ");

double distance = Length(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"The distance between the two points in 3D space is: {distance}");



