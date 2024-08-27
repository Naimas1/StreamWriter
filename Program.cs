using System.IO;

class Program
{
    static void Main()
    {
        using (StreamWriter streamwriter = new StreamWriter(@"D:\index.html"))
        {
            // Початок HTML документа
            streamwriter.WriteLine("<html>");
            streamwriter.WriteLine("<head>");
            streamwriter.WriteLine("  <title>Таблиці</title>");
            streamwriter.WriteLine("  <meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />");
            streamwriter.WriteLine("  <style>");
            streamwriter.WriteLine("    table { width: 50%; border-collapse: collapse; margin: 20px auto; }");
            streamwriter.WriteLine("    th, td { border: 1px solid black; padding: 10px; text-align: center; }");
            streamwriter.WriteLine("    .grey { background-color: #f0f0f0; }");
            streamwriter.WriteLine("    .red { background-color: #ffcccc; }");
            streamwriter.WriteLine("    .green { background-color: #ccffcc; }");
            streamwriter.WriteLine("  </style>");
            streamwriter.WriteLine("</head>");
            streamwriter.WriteLine("<body>");

            // Перша таблиця (А, B, A+B, A*B, A^B)
            streamwriter.WriteLine("<h2>Таблиця арифметичних операцій</h2>");
            streamwriter.WriteLine("<table>");
            streamwriter.WriteLine("  <tr>");
            streamwriter.WriteLine("    <th>Число A</th>");
            streamwriter.WriteLine("    <th>Число B</th>");
            streamwriter.WriteLine("    <th>A + B</th>");
            streamwriter.WriteLine("    <th>A * B</th>");
            streamwriter.WriteLine("    <th>A ^ B</th>");
            streamwriter.WriteLine("  </tr>");

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    string rowClass = (a + b) % 2 == 0 ? "grey" : "white";
                    streamwriter.WriteLine($"  <tr class=\"{rowClass}\">");
                    streamwriter.WriteLine($"    <td>{a}</td>");
                    streamwriter.WriteLine($"    <td>{b}</td>");
                    streamwriter.WriteLine($"    <td>{a + b}</td>");
                    streamwriter.WriteLine($"    <td>{a * b}</td>");
                    streamwriter.WriteLine($"    <td>{Math.Pow(a, b)}</td>");
                    streamwriter.WriteLine("  </tr>");
                }
            }

            streamwriter.WriteLine("</table>");

            // Друга таблиця (Поле для гри в хрестики-нуліки)
            var arr = new[]
            {
                new[] { (string)null, "X", "O" },
                new[] { (string)null, "X", null },
                new[] { "O", "X", "O" }
            };

            streamwriter.WriteLine("<h2>Поле для гри в хрестики-нуліки</h2>");
            streamwriter.WriteLine("<table>");

            for (int rowNum = 0; rowNum < arr.Length; rowNum++)
            {
                streamwriter.WriteLine("  <tr>");
                for (int colNum = 0; colNum < arr[rowNum].Length; colNum++)
                {
                    string item = arr[rowNum][colNum];
                    string cellClass = item == "O" ? "red" : item == "X" ? "green" : "";
                    streamwriter.WriteLine($"    <td class=\"{cellClass}\">{item}</td>");
                }
                streamwriter.WriteLine("  </tr>");
            }

            streamwriter.WriteLine("</table>");

            // Закриття HTML документа
            streamwriter.WriteLine("</body>");
            streamwriter.WriteLine("</html>");
        }
    }
}

