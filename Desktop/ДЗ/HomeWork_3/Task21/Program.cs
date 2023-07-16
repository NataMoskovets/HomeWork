// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Length (int xA, int yA, int zA, int xB, int yB, int zB)
{
    double distance = Math.Sqrt (Math.Pow (xA - xB, 2) + Math.Pow (yB - yA, 2) + Math.Pow (zA - zB, 2));
    return distance;
}
int GetInfo (string message)

{
    Console.Write (message);
    int x = Convert.ToInt32 (Console.ReadLine ());
    return x;
} 

int coordinateA1 = GetInfo ("Введите координату x точки А: ");
int coordinateA2 = GetInfo ("Введите координату y точки А: ");
int coordinateA3 = GetInfo ("Введите координату z точки A: ");
int coordinateB1 = GetInfo ("Введите координату x точки B: ");
int coordinateB2 = GetInfo ("Введите координату y точки B: ");
int coordinateB3 = GetInfo ("Введите координату z точки B: ");

Console.Write ($"Расстояние между двумя точками на плоскости равно {Length (coordinateA1, coordinateA2, coordinateA3, coordinateB1, coordinateB2, coordinateB3)}");