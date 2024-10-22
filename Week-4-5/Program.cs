using Week_4_5;

BaseGeometricPatterns square = new Square(4);
BaseGeometricPatterns rectangle = new Rectangle(4, 8);
BaseGeometricPatterns rightTriangle = new RightTriangle(4, 8);

Console.WriteLine($"Karenin alanı: {square.AreaCalculator()}");
Console.WriteLine($"Dikdörtgenin alanı: {rectangle.AreaCalculator()}");
Console.WriteLine($"Dik üçgenin alanı: {rightTriangle.AreaCalculator()}");