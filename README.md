# sportRadarTest
Prueba Técnica para SportRadar

Para probar he tenido en cuenta los datos de ejemplo

Board b = new Board();
b.anadirPartido("Mexico", "Canada");
b.anadirPartido("Spain", "Brazil");
b.anadirPartido("Germany", "France");
b.anadirPartido("Uruguay", "Italy");
b.anadirPartido("Argentina", "Australia");

b.actualizarResultado("Mexico", "Canada", 0, 5);
b.actualizarResultado("Spain", "Brazil", 10, 2);
b.actualizarResultado("Germany", "France", 2, 2);
b.actualizarResultado("Uruguay", "Italy", 6, 6);
b.actualizarResultado("Argentina", "Australia", 3, 1);

Console.WriteLine(b.devuelteResultados());

b.finalizarPartido("Mexico", "Canada");

Console.WriteLine(b.devuelteResultados());
